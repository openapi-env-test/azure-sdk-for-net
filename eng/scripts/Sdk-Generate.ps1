param($GenerateInput)

# Get the list of changed swaggers
$input = Get-Content $GenerateInput | ConvertFrom-Json
$inputFiles = $input.changedFiles;
$inputFiles += $input.relatedReadmeMdFiles;
Write-Output "List Of changed swagger files and related readmes" $inputFiles
$headSha = $input.headSha
Write-Host

$autorestFilesPath = Get-ChildItem -Path "./sdk"  -Filter autorest.md -Recurse

Write-Host "Updating autorest.md for the changed swaggers..."
foreach ($inputFile in $inputFiles)
{
    foreach ($path in $autorestFilesPath)
    {
        (Get-Content -Raw $path) -replace "[\/][0-9a-f]{4,40}[\/]$inputFile", "/$headSha/$inputFile" | `
         Set-Content $path -NoNewline
    }
}
Write-Host "autorest.md files updated"

dotnet msbuild /restore /t:GenerateCode "./eng/service.proj"

