$RepoRoot = ${PSScriptRoot}
Write-Host "Testing init script path $RepoRoot"

Get-Help ./dotnet-install.ps1
& "$PSScriptRoot/dotnet-install.ps1" -Version 5.0.100
