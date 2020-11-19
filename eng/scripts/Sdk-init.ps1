$RepoRoot = ${PSScriptRoot}
Write-Host "Testing path $RepoRoot"

Get-Help .\dotnet-install.ps1
./dotnet-install.ps1 -Version 5.0.100
