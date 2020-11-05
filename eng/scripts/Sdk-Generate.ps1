param($GenerateInput, $GenerateOutput)

$input = Get-Content $GenerateInput | ConvertFrom-Json
$inputFiles = $input.changedFiles;
$inputFiles += $input.relatedReadmeMdFiles;
Write-Output "List Of changed swagger files and related readmes" $inputFiles "`n"
$headSha = $input.headSha

$autorestFilesPath = Get-ChildItem -Path "sdk"  -Filter autorest.md -Recurse | Resolve-Path -Relative

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
$artifactsPath = "artifacts/packages"
If(!(test-path $artifactsPath))
{
  New-Item -ItemType Directory -Force -Path $artifactsPath
}
foreach ($sdkPath in $sdkPaths)
{
    $packageName = Split-Path $sdkPath -Leaf
    $srcPath = Join-Path $sdkPath 'src'

    Write-Host "Generating code for " $packageName
    dotnet msbuild /restore /t:GenerateCode $srcPath

    $result = $null
    if($LASTEXITCODE -eq 0)
    {
      Write-Host "Successfully generated code for" $packageName "`n"
      $result = "success"
    } 
    else 
    {
      Write-Host "Error occurred while generating code for" $packageName "`n"
      $result = "error"
    }

    $csprojPath = Get-ChildItem $srcPath -Filter *.csproj -Recurse
    dotnet pack $csprojPath --output $artifactsPath

    $path = @()
    $path += $sdkPath
    $readmeMd = @()
    $readmeMd += Join-Path $sdkPath 'readme.md'
    $artifacts = @()
    $artifacts +=  Get-ChildItem $artifactsPath -Filter *$packageName* -Recurse | Select-Object -ExpandProperty FullName | Resolve-Path -Relative
    
    $packageInfo = [PSCustomObject]@{
        packageName = $packageName
        path = $path
        readmeMd = $readmeMd
        artifacts = $artifacts
        result = $result
    }

    $packages += $packageInfo
}

if ($GenerateOutput) {
    Write-Host "Generating output JSON..."
    ConvertTo-Json @{
      packages         = $packages
    } -depth 5 | Out-File -FilePath $GenerateOutput
}
