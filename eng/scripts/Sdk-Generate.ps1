param($GenerateInput, $GenerateOutput)

# Get the list of changed swaggers
$input = Get-Content $GenerateInput | ConvertFrom-Json
$inputFiles = $input.changedFiles;
$inputFiles += $input.relatedReadmeMdFiles;
Write-Output "List Of changed swagger files and related readmes" $inputFiles "`n"
$headSha = $input.headSha

$autorestFilesPath = Get-ChildItem -Path "./sdk"  -Filter autorest.md -Recurse

Write-Host "Updating autorest.md for the changed swaggers..."
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

       $sdkPaths += (get-item $path).Directory.Parent.FullName
     }
    }
}
Write-Host "autorest.md files are updated. `n"

dotnet msbuild /restore /t:GenerateCode "./eng/service.proj"

$packages = @()
foreach ($sdkPath in $sdkPaths)
{
    $srcPath = Join-Path $sdkPath 'src'
    $csprojPath = Get-ChildItem $srcPath -Filter *.csproj -Recurse
    $artifactsPath = "./artifacts/packages"
    If(!(test-path $artifactsPath))
    {
      New-Item -ItemType Directory -Force -Path $artifactsPath
    }
    dotnet pack $csprojPath --output $artifactsPath

    $packageName = Split-Path $sdkPath -Leaf
    $readmePath = Join-Path $sdkPath 'readme.md'
    $artifacts = @()
    $artifacts +=  Get-ChildItem $artifactsPath -Filter *$packageName* -Recurse | Select-Object -ExpandProperty FullName
    $packageInfo = [PSCustomObject]@{
        packageName = $packageName
        path = $sdkPath
        readmeMd = $readmePath
        artifacts = $artifacts
    }

    $packages += $packageInfo
}

if ($GenerateOutput) {
    Write-Host "Generating output JSON..."
    ConvertTo-Json @{
      packages         = $packages
    } -depth 5 | Out-File -FilePath $GenerateOutput
}
