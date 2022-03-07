#Requires -Version 7.0
param (
  [string]$inputJsonFile="eng\scripts\generateInput.json",
  [string]$outputJsonFile="output.json"
)

. (Join-Path $PSScriptRoot automation GenerateAndBuildLib.ps1)

$inputJson = Get-Content $inputJsonFile | Out-String | ConvertFrom-Json
$swaggerDir = $inputJson.specFolder
$swaggerDir = $swaggerDir -replace "\\", "/"
$readmeFiles = $inputJson.relatedReadmeMdFiles
$commitid = $inputJson.headSha
$serviceType = $inputJson.serviceType

$generatedSDKPackages = @()

foreach ( $readmeFile in $readmeFiles ) {
    $readmeFile = $readmeFile -replace "\\", "/"
    $service = Get-ResourceProviderFromReadme $readmeFile
    $readmeFile = Join-Path $swaggerDir $readmeFile
    Write-Host "swaggerDir:$swaggerDir, readmeFile:$readmeFile"

    if (Test-Path -Path $readmeFile) {
        Write-Host "readme file exists."
        Get-Content -Path $readmeFile
    } else {
        Write-Host "readme file does not exist."
    }
    
    $sdkPath =  (Join-Path $PSScriptRoot .. ..)
    $sdkPath = Resolve-Path $sdkPath
    $sdkPath = $sdkPath -replace "\\", "/"

    
    $packagesToGen = @()
    $newpackageoutput = "newPackageOutput.json"
    if ( $serviceType -eq "resource-manager" ) {
        Write-Host "Generate resource-manager SDK client library."
        New-MgmtPackageFolder -service $service -packageName $service -sdkPath $sdkPath -commitid $commitid -readme $readmeFile -outputJsonFile $newpackageoutput
        $newpackageoutputJson = Get-Content $newpackageoutput | Out-String | ConvertFrom-Json
        $packagesToGen = $packagesToGen + @($newpackageoutputJson)
        Remove-Item $newpackageoutput
    } else {
        Write-Host "Generate data-plane SDK client library."
        npx autorest --csharp $readmeFile --csharp-sdks-folder=$sdkPath --skip-csproj --clear-output-folder=true
        $serviceSDKDirectory = (Join-Path $sdkPath sdk $service)
        $folders = Get-ChildItem $serviceSDKDirectory -Directory -exclude *.*Management*,Azure.ResourceManager*
        $folders |ForEach-Object {
            $folder=$_.Name
            New-DataPlanePackageFolder -service $service -namespace $folder -sdkPath $sdkPath -readme $readmeFile -outputJsonFile $newpackageoutput
            $newpackageoutputJson = Get-Content $newpackageoutput | Out-String | ConvertFrom-Json
            $packagesToGen = $packagesToGen + @($newpackageoutputJson)
            Remove-Item $newpackageoutput
        }
    }
    if ( $? -ne $True) {
        Write-Error "Failed to create sdk project folder. exit code: $?"
        exit 1
    }

    foreach ( $package in $packagesToGen )
    {
        $projectFolder = $newpackageoutputJson.projectFolder
        $path = $newpackageoutputJson.path
        $service = $newpackageoutputJson.service
        Write-Host "projectFolder:$projectFolder"

        Invoke-Generate -sdkfolder $projectFolder
        if ( $? -ne $True) {
            Write-Error "Failed to generate sdk. exit code: $?"
            exit 1
        }
        # Generate APIs
        $repoRoot = (Join-Path $PSScriptRoot .. ..)
        $repoRoot = Resolve-Path $repoRoot
        Set-Location $repoRoot
        pwsh eng/scripts/Export-API.ps1 $service

        $generatedSDKPackages = $generatedSDKPackages + @([pscustomobject]@{packageName="$service"; result='succeeded'; path=@("$path");packageFolder="$projectFolder"})
    }
}

$outputJson = [PSCustomObject]@{
    packages = $generatedSDKPackages
}
$outputJson | ConvertTo-Json -depth 100 | Out-File $outputJsonFile