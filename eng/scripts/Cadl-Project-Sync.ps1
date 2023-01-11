[CmdletBinding()]
param (
    [Parameter(Position=0)]
    [ValidateNotNullOrEmpty()]
    [string] $ProjectDirectory
)

$ErrorActionPreference = "Stop"
. $PSScriptRoot/../common/scripts/Helpers/PSModule-Helpers.ps1
Install-ModuleIfNotInstalled "powershell-yaml" "0.4.1" | Import-Module
$sparseCheckoutFile = ".git/info/sparse-checkout"

function AddSparseCheckoutPath([string]$subDirectory) {
    if (!(Test-Path $sparseCheckoutFile) -or !((Get-Content $sparseCheckoutFile).Contains($subDirectory))) {
        Write-Output $subDirectory >> .git/info/sparse-checkout
    }
}

function CopySpecToProjectIfNeeded([string]$source, [string]$dest) {
    Write-Host "Copying spec from $source"
    Copy-Item -Path $source -Destination $dest -Recurse -Force
}

function GetGitRemoteValue([string]$repo) {
    Push-Location $ProjectDirectory
    $result = ""
    try {
        $gitRemotes = (git remote -v)
        foreach ($remote in $gitRemotes)
        {
            if ($remote.StartsWith("origin")) {
                if ($remote -match 'https://github.com/\S+[\.git]') {
                    $result = "https://github.com/$repo.git"
                    break
                } elseif ($remote -match "git@github.com:\S+[\.git]"){
                    $result = "git@github.com:$repo.git"
                    break
                } else {
                    throw "Unknown git remote format found: $remote"
                }
            }
        }
    }
    finally {
        Pop-Location
    }

    return $result
}

function InitializeSparseGitClone([string]$repo) {
    git clone --no-checkout --filter=tree:0 $repo .
    if ($LASTEXITCODE) { exit $LASTEXITCODE }
    git sparse-checkout init
    if ($LASTEXITCODE) { exit $LASTEXITCODE }
    Remove-Item $sparseCheckoutFile -Force
}

function GetSpecCloneDir([string]$projectName) {
    Push-Location $ProjectDirectory
    try {
        $root = git rev-parse --show-toplevel
    }
    finally {
        Pop-Location
    }

    $sparseSpecCloneDir = "$root/../sparse-spec/$projectName"
    New-Item $sparseSpecCloneDir -Type Directory -Force | Out-Null
    $createResult = Resolve-Path $sparseSpecCloneDir
    return $createResult
}

$cadlConfigurationFile = Resolve-Path "$ProjectDirectory/src/cadl-location.yaml"
Write-Host "Reading configuration from $cadlConfigurationFile"
$configuration = Get-Content -Path $cadlConfigurationFile -Raw | ConvertFrom-Yaml

$pieces = $cadlConfigurationFile.Path.Replace("\","/").Split("/")
$projectName = $pieces[$pieces.Count - 3]

if ($configuration["directory"] -match "^[^/\\]+[\\/]+[^/\\]+")
{
    $specSubDirectory = $Matches[0]
}
else
{
    throw "The directory in $cadlConfigurationFile is not expected"
}

if ( $configuration["repo"] -and $configuration["commit"]) {
    $specCloneDir = GetSpecCloneDir $projectName
    $gitRemoteValue = GetGitRemoteValue $configuration["repo"]

    Write-Host "Setting up sparse clone for $projectName at $specCloneDir"

    Push-Location $specCloneDir.Path
    try {
        if (!(Test-Path ".git")) {
            InitializeSparseGitClone $gitRemoteValue
            AddSparseCheckoutPath $specSubDirectory
        }
        git checkout $configuration["commit"]
    }
    finally {
        Pop-Location
    }
} elseif ( $configuration["spec-root-dir"] ) {
    $specCloneDir = $configuration["spec-root-dir"]
}

$tempCadlDir = "$ProjectDirectory/TempCadlFiles"
New-Item $tempCadlDir -Type Directory -Force | Out-Null

Get-ChildItem –Path "$specCloneDir/$specSubDirectory" |
        Foreach-Object {
            if ($_.Name -ne "resource-manager" -and $_.Name -ne "data-plane" )
            {
                CopySpecToProjectIfNeeded -source $_.FullName -dest $tempCadlDir `
            }
        }
