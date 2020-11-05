param($GenerateInput, $GenerateOutput)

# Get the list of changed swaggers
$input = Get-Content $GenerateInput | ConvertFrom-Json
$inputFiles = $input.changedFiles;
$inputFiles += $input.relatedReadmeMdFiles;
Write-Output "List Of changed swagger files and related readmes" $inputFiles "`n"
$headSha = $input.headSha

Write-Output "Find new project"
$rpIndex = @()
$rpMapping = Get-Content -Path './eng/scripts/RPMapping.json' | ConvertFrom-Json
$input.changedFiles | ForEach-Object {
  if ($_ -Match 'resource-manager') {
    $rpName = $_.Substring(14)
    $rpName = $rpName.Substring(0, $rpName.IndexOf('/'));
    $rpName = $rpMapping."$rpName"
    If ($rpIndex -notcontains $rpName) {
      $rpIndex += $rpName
    }
  }
}
$rpIndex | ForEach-Object {
  $path = './sdk/' + $_.PSObject.Properties.Name + '/Azure.ResourceManager.' + $_.PSObject.Properties.Value
  $folderName = $_.PSObject.Properties.Name
  $rpName = $_.PSObject.Properties.Value
  if (-not (Test-Path $path)) {
    dotnet new -i ./eng/templates/Azure.ResourceManager.Template
    New-Item -Path ('./sdk/' + $folderName) -Name ('Azure.ResourceManager.' + $rpName) -ItemType "directory"
    Set-Location -Path ('./sdk/' + $folderName + '/Azure.ResourceManager.' + $rpName)
    dotnet new azuremgmt --provider $rpName
    Set-Location -Path '../../../'
  }
}

$autorestFilesPath = Get-ChildItem -Path "sdk"  -Filter autorest.md -Recurse | Resolve-Path -Relative

Write-Host "Updating autorest.md for the changed swaggers..."
$sdkPaths = @()
foreach ($inputFile in $inputFiles) {
  foreach ($path in $autorestFilesPath) {
    $fileContent = Get-Content -Raw $path
    $containsUrl = $fileContent -Match "[\/][0-9a-f]{4,40}[\/]$inputFile"
    if ($containsUrl -contains $true) {
      Write-Host "Updating " $path
      $fileContent -replace "[\/][0-9a-f]{4,40}[\/]$inputFile", "/$headSha/$inputFile" | `
        Set-Content $path -NoNewline

      $sdkPath = (get-item $path).Directory.Parent.FullName | Resolve-Path -Relative
      $packageName = Split-Path $sdkPath -Leaf
      Write-Host "Generating code for " $packageName
      $srcPath = Join-Path $sdkPath 'src'
      dotnet msbuild /restore /t:GenerateCode $srcPath
      Write-Host "Generated code for " $packageName

      If ($sdkPaths -notcontains $sdkPath) {
        $sdkPaths += $sdkPath
      }
    }
  }
}

$packages = @()
foreach ($sdkPath in $sdkPaths) {
  $srcPath = Join-Path $sdkPath 'src'
  $csprojPath = Get-ChildItem $srcPath -Filter *.csproj -Recurse
  $artifactsPath = "artifacts/packages"
  # $artifactsPath = Join-Path $sdkPath 'packages'
  If (!(test-path $artifactsPath)) {
    New-Item -ItemType Directory -Force -Path $artifactsPath
  }
  Write-Host "Testing artifacts package folder path:" $artifactsPath
  dotnet pack $csprojPath --output $artifactsPath

  $artifacts = @()
  $path = @()
  $readmeMd = @()
  $packageName = Split-Path $sdkPath -Leaf
  $path += $sdkPath
  $readmeMd += Join-Path $sdkPath 'readme.md'
  $artifacts += Get-ChildItem $artifactsPath -Filter *$packageName* -Recurse | Select-Object -ExpandProperty FullName | Resolve-Path -Relative
  foreach ($artipath in $artifacts) {
    Write-Host "Testing artifacts path:" $artipath
  }
  $packageInfo = [PSCustomObject]@{
    packageName = $packageName
    path        = $path
    readmeMd    = $readmeMd
    artifacts   = $artifacts
  }

  $packages += $packageInfo
}

if ($GenerateOutput) {
  Write-Host "Generating output JSON..."
  ConvertTo-Json @{
    packages = $packages
  } -depth 5 | Out-File -FilePath $GenerateOutput
}
