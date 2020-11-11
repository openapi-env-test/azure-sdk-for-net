param(
$GenerateInput, 
$GenerateOutput,
$RepoRoot = "${PSScriptRoot}"
)

$input = Get-Content $GenerateInput | ConvertFrom-Json
$inputFiles = $input.changedFiles;
$inputFiles += $input.relatedReadmeMdFiles;
Write-Output "List Of changed swagger files and related readmes" $inputFiles "`n"
$headSha = $input.headSha

$autorestFilesPath = Get-ChildItem -Path "$RepoRoot/sdk"  -Filter autorest.md -Recurse | Resolve-Path -Relative

Write-Host "Updating autorest.md files for all the changed swaggers..."
$sdkPaths = @()
foreach ($inputFile in $inputFiles)
{
    foreach ($path in $autorestFilesPath)
    {
     $fileContent = Get-Content -Raw $path
     $containsUrl = $fileContent | %{$_ -match "[\/][0-9a-f]{4,40}[\/]$inputFile"}
     if ($containsUrl -contains $true)
     {
       Write-Host "Updating " $path
       $fileContent -replace "[\/][0-9a-f]{4,40}[\/]$inputFile", "/$headSha/$inputFile" | `
         Set-Content $path -NoNewline

       $sdkPaths += (get-item $path).Directory.Parent.FullName | Resolve-Path -Relative
     }
    }
}
Write-Host "Updated autorest.md files for all the changed swaggers. `n"

$packages = @()
$artifactsPath = "$RepoRoot/artifacts/packages"
if(!(Test-Path $artifactsPath))
{
  New-Item -ItemType Directory -Force -Path $artifactsPath
}
foreach ($sdkPath in $sdkPaths)
{
    $packageName = Split-Path $sdkPath -Leaf
    $path = @()
    $path += $sdkPath
    $readmeMd = @()
    $artifacts = @()
    $changelog = $null
    $result = $null

   $packageNameArr = $packageName.Split(".")
   $name = $input.relatedReadmeMdFiles -match $packageNameArr[2]
   if($packageName -match "Azure.ResourceManager")
   {
    $readmeMd += $name -match "resource-plane"
   }
   elseif($packageName -match "Azure.")
   {
    $readmeMd += $name -match "data-plane"
   }

    $srcPath = Join-Path $sdkPath 'src'
    Write-Host "Generating code for " $packageName
    dotnet msbuild /restore /t:GenerateCode $srcPath

    if($LASTEXITCODE -eq 0)
    {
      Write-Host "Successfully generated code for" $packageName "`n"
      $result = "succeeded"

      $csprojPath = Get-ChildItem $srcPath -Filter *.csproj -Recurse
      dotnet pack $csprojPath --output $artifactsPath /p:RunApiCompat=$false

      $artifacts +=  Get-ChildItem $artifactsPath -Filter *$packageName* -Recurse | Select-Object -ExpandProperty FullName | Resolve-Path -Relative

      $logFilePath = Join-Path "$srcPath" 'log.txt'
      if(!(Test-Path $logFilePath))
      {
        New-Item $logFilePath
      }

      # run this only if previous step passed and check with digital twin data plane sdk if it is creating PR then do this otherwise talk to wes
      dotnet build $csprojPath /t:RunApiCompat /p:TargetFramework=netstandard2.0 /flp:v=m`;LogFile=$logFilePath
      
      $hasBreakingChange = $null
      $content = $null
      if($LASTEXITCODE -eq 0)
      {
        $content = ""
        $hasBreakingChange = $false
      }
      else
      {
        $logFile = Get-Content -Path $logFilePath | select-object -skip 2
        $collate = foreach($Obj in $logFile) 
        {       
          $begin = ""
          $end = ",`n"
          $begin + $Obj + $end
          }
        $content = "Breaking Changes: $collate"
        $hasBreakingChange = $true
      }

      $changelog = [PSCustomObject]@{
        content = $content
        hasBreakingChange = $hasBreakingChange
      }

      if (Test-Path $logFilePath) 
      {
        Remove-Item $logFilePath
      }

      $installInstructions = [PSCustomObject]@{
        full = "To install something..."
        lite = "dotnet something"
      }
    } 
    else 
    {
      Write-Host "Error occurred while generating code for" $packageName "`n"
      $result = "failed"
    }

   # check exit code if success then only write content otherwise empty
    $packageInfo = [PSCustomObject]@{
        packageName = $packageName
        path = $path
        readmeMd = $readmeMd
        changelog = $changelog
        artifacts = $artifacts
        installInstructions = $installInstructions
        result = $result
    }

    $packages += $packageInfo
}

if ($GenerateOutput) {
    Write-Host "`nGenerating output JSON..."
    ConvertTo-Json @{
      packages         = $packages
    } -depth 5 | Out-File -FilePath $GenerateOutput
}
