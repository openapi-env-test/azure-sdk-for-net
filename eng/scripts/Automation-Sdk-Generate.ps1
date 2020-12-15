[CmdletBinding()]
param(
  [Parameter()]
  [ValidateNotNullOrEmpty()]
  [string] $InputJsonPath,

  [Parameter()]
  [string] $OutputJsonPath,

  [Parameter()]
  [string] $RepoRoot = "${PSScriptRoot}/../.."
)

function Find-Mapping([string]$path) {
  $fileContent = Get-Content $path
  $name = ''
  $proName = ''
  foreach ($item in $fileContent) {
    if (($item -match '\$\(csharp-sdks-folder\)')) {
      $matchResult = $item -match "\/([^/]+)\/"
      $name = $matches[0].Substring(1, $matches[0].Length - 2)
      if (($name -ne '') -and ($name -notmatch "\$")) {
        $matchResult = $item -match "Microsoft.Azure.Management.[^/]+"
        if ($matchResult) {
          $proName = $matches[0].Substring(27)
          if ($proName -ne '') {
            break
          } 
        }
      }
    }
  }
  return @{ $name = "$proName" }
}

$inputFileContent = Get-Content $InputJsonPath | ConvertFrom-Json
[string[]] $inputFilePaths = $inputFileContent.changedFiles;
$inputFilePaths += $inputFileContent.relatedReadmeMdFiles;
$inputFilePaths = $inputFilePaths | Select-Object -Unique

$changedFilePaths = $inputFilePaths -join "`n";
Write-Host "List of changed swagger files and related readmes:`n$changedFilePaths`n"

Write-Output "Find RP which need to create new project"
# Get RP Mapping
$RPMapping = [ordered]@{ }
$readmePath = ''
git clone https://github.com/Azure/azure-rest-api-specs.git ../azure-rest-api-specs
$folderNames = Get-ChildItem ../azure-rest-api-specs/specification
$folderNames | ForEach-Object {
  $folderName = @{'' = "" }
  $readmePath = "../azure-rest-api-specs/specification/$($_.Name)/resource-manager/readme.csharp.md"
  if (Test-Path $readmePath) {
    $folderName = Find-Mapping $readmePath
  }
  if (([string]$folderName.Keys[0] -eq "") -or ([string]$folderName.Keys[0] -match "\$")) {
    $readmePath = "../azure-rest-api-specs/specification/$($_.Name)/resource-manager/readme.md"
    if (Test-Path $readmePath) {
      $folderName = Find-Mapping $readmePath
    }
  }
  if (([string]$folderName.Keys[0] -notmatch "\$") -and (!$RPMapping.Contains($_.Name)) -and ([string]$folderName.Keys[0] -ne "")) {
    $RPMapping += @{ $_.Name = $folderName }
  }
}
$rpIndex = [ordered]@{ }
$inputFilePaths | ForEach-Object {
  if ($_ -Match 'resource-manager') {
    $rpName = $_.Substring(14)
    $rpName = $rpName.Substring(0, $rpName.IndexOf('/'));
    $rpName = $RPMapping."$rpName"
    If (!$rpIndex.Contains([string]$rpName.Keys[0])) {
      $rpIndex += $rpName
    }
  }
}
$rpIndex | ForEach-Object {
  $folderName = [string]$_.Keys[0]
  $rpName = [string]$_.Values[0]
  $folderPath = "$RepoRoot/sdk/$folderName/Azure.ResourceManager.$rpName"
  if (-not (Test-Path $folderPath)) {
    dotnet new -i $RepoRoot/eng/templates/Azure.ResourceManager.Template
    New-Item -Path $RepoRoot/sdk/$folderName -Name Azure.ResourceManager.$rpName -ItemType directory
    Set-Location -Path $folderPath
    dotnet new azuremgmt --provider $rpName
    Set-Location -Path $RepoRoot
  }
}

$autorestFilesPath = Get-ChildItem -Path "$RepoRoot/sdk"  -Filter autorest.md -Recurse | Resolve-Path -Relative

Write-Host "Updating autorest.md files for all the changed swaggers."
$sdksInfo = @{}
$headSha = $inputFileContent.headSha
$repoHttpsUrl = $inputFileContent.repoHttpsUrl
foreach ($path in $autorestFilesPath) {
  $fileContent = Get-Content $path
  foreach ($inputFilePath in $inputFilePaths) {
    $isUpdatedLines = $false
    $escapedInputFilePath = [System.Text.RegularExpressions.Regex]::Escape($inputFilePath)
    $regexForMatchingShaAndPath = "https:\/\/[^`"]*[\/][0-9a-f]{4,40}[\/]$escapedInputFilePath"
    $updatedLines = foreach ($line in $fileContent) {
      if ($line -match $regexForMatchingShaAndPath) {
        $line -replace $regexForMatchingShaAndPath, "$repoHttpsUrl/blob/$headSha/$inputFilePath"

        $isUpdatedLines = $true
        $sdkpath = (get-item $path).Directory.Parent.FullName | Resolve-Path -Relative
        if (!$sdksInfo.ContainsKey($sdkpath)) {
          $specReadmePath = $inputFileContent.relatedReadmeMdFiles -match $inputFilePath
          $sdksInfo.Add($sdkpath, $specReadmePath)
        }
      }
      else {
        $line
      }
    }
    if ($isUpdatedLines) {
      $updatedLines | Out-File -FilePath $path
    }
  }
}

Write-Host "Updated autorest.md files for all the changed swaggers. `n"

$packages = @()
$dotnet = Join-Path $RepoRoot ".dotnet"
$env:PATH = "$dotnet`:" + $env:PATH
foreach ($sdkPath in $sdksInfo.Keys) {
  $packageName = Split-Path $sdkPath -Leaf
  Write-Host "Generating code for " $packageName
  $artifacts = @()
  $hasBreakingChange = $null
  $content = $null
  $srcPath = Join-Path $sdkPath 'src'
  dotnet msbuild /restore /t:GenerateCode $srcPath
  if (!$LASTEXITCODE) {
    $result = "succeeded"
    Write-Host "Successfully generated code for" $packageName "`n"
    
    dotnet pack $srcPath /p:RunApiCompat=$false
    if (!$LASTEXITCODE) {
      $result = "succeeded"
      $artifactsPath = "$RepoRoot/artifacts/packages/Debug/$packageName"
      $artifacts += Get-ChildItem $artifactsPath -Filter *.nupkg -Recurse | Select-Object -ExpandProperty FullName | Resolve-Path -Relative
      
      $logFilePath = Join-Path "$srcPath" 'log.txt'
      if (!(Test-Path $logFilePath)) {
        New-Item $logFilePath
      }
      dotnet build $srcPath /t:RunApiCompat /p:TargetFramework=netstandard2.0 /flp:v=m`;LogFile=$logFilePath
      if (!$LASTEXITCODE) {
        $hasBreakingChange = $false
      }
      else {
        $logFile = Get-Content -Path $logFilePath | select-object -skip 2
        $breakingChanges = $logFile -join ",`n"
        $content = "Breaking Changes: $breakingChanges"
        $hasBreakingChange = $true
      }

      if (Test-Path $logFilePath) {
        Remove-Item $logFilePath
      }
    }
    else {
      $result = "failed"
      Write-Error "Error occurred while generating artifacts for $packageName `n"
    }
  } 
  else {
    $result = "failed"
    Write-Error "Error occurred while generating code for $packageName `n"
  }

  $path = , $sdkPath

  $readmeMd = $sdksInfo[$sdkPath]

  $changelog = [PSCustomObject]@{
    content           = $content
    hasBreakingChange = $hasBreakingChange
  }

  $downloadUrlPrefix = $inputFileContent.installInstructionInput.downloadUrlPrefix
  $full = $null
  if ($artifacts.count -gt 0) {
    $fileName = Split-Path $artifacts[0] -Leaf
    $full = "Download the $packageName package from [here]($downloadUrlPrefix/$fileName)"
  }
  $installInstructions = [PSCustomObject]@{
    full = $full
    lite = $full
  }

  $packageInfo = [PSCustomObject]@{
    packageName         = $packageName
    path                = $path
    readmeMd            = $readmeMd
    changelog           = $changelog
    artifacts           = $artifacts
    installInstructions = $installInstructions
    result              = $result
  }
  $packages += $packageInfo
}

if ($OutputJsonPath) {
  Write-Host "`nGenerating output JSON..."
  ConvertTo-Json @{
    packages = $packages
  } -depth 5 | Out-File -FilePath $OutputJsonPath
}
