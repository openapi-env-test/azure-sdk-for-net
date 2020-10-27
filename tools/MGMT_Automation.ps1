function Get-RPs {
    param (
        [string[]]$changedFiles
    )
    $output = @()
    $rpMapping = Get-Content -Path './tools/RPMapping.json' | ConvertFrom-Json
    
    $changedFiles | ForEach-Object { 
        $rpName = $_.Substring(14)
        $rpName = $rpName.Substring(0, $rpName.IndexOf('/'));
        $rpName = $rpMapping."$rpName"
        If ($output -notcontains $rpName){
            $output += $rpName
        }
    }
    Write-Output $output
}

function Error-Report {
    param (
        [string]$result
    )

    if($result.Contains('Error')){
        $stderr =+ $result
    }
}

function New-Project {
    param (
        [string]$path, 
        [string]$rpName
    )
    
    # Only need to to once, consider to move to initScript
    $newCommand = 'dotnet new -i ./eng/templates/Azure.ResourceManager.Template'
    $result = Invoke-Expression $newCommand
    Error-Report -result $result

    New-Item -Path $path -Name ('Azure.ResourceManager.'+$rpName) -ItemType "directory"

    Set-Location -Path ($path+'/Azure.ResourceManager.'+$rpName)
    $createCommand = 'dotnet new azuremgmt --provider '+ $rpName
    $result = Invoke-Expression $createCommand
    Error-Report -result $result
    Set-Location -Path '../../../'
}

function GenerateCode-WithBuild {
    param (
        [string]$path, 
        [string]$commit
    )
    $autorestFile = $path + '/src/autorest.md'
    $content = Get-Content -Path $autorestFile | ForEach-Object {
        $_ -replace 'azure-rest-api-specs/[\S]*/specification',('azure-rest-api-specs/'+$commit+'/specification')
    } 
    Set-Content -Path $autorestFile -Value $content

    Set-Location -Path $path
    $generateCommand = 'dotnet build /t:GenerateCode'
    Invoke-Expression $generateCommand
    $buildCommand = 'dotnet build'
    Invoke-Expression $buildCommand
}

function Generate-Output {
    param (
        [string]$rpName
    )
    $package = @"
    {
        "packageName": "Azure.ResourceManager.$rpName",
        "path": [
            "sdk/$rpName"
        ],
        "readmeMd": [
            "specification/$rpName/resource-manager/readme.md"
        ],
        "changelog": {
            "content": "Feature: something \n Breaking Changes: something\n",
            "hasBreakingChange": "true"
        },
        "artifacts": [
            "sdk/cdn/cdn.nuget",
            "sdk/cdn/cdn.snuget"
        ],
        "installInstructions": {
            "full": "To install something...",
            "lite": "dotnet something"
        },
        "result": "success"
    }
"@
    Write-Output $package
}

$inputConfig = Get-Content -Path './tools/generateInput.json' | ConvertFrom-Json
$outputConfig = @{
    packages = @()
}

$inputConfig.changedFiles = @($inputConfig.changedFiles) -match 'resource-manager'

$rpIndex = Get-RPs($inputConfig.changedFiles)

$rpIndex | ForEach-Object {
    $path = './sdk/'+$_.PSObject.Properties.Name+'/Azure.ResourceManager.'+$_.PSObject.Properties.Value
    $rpName = $_.PSObject.Properties.Value
    if (-not (Test-Path $path)) {
        New-Project -path ('./sdk/'+$_.PSObject.Properties.Name) -rpName $rpName
    }
    GenerateCode-WithBuild -path $path -commit $inputConfig.headSha
    $outputPackage = Generate-Output -rpName $rpName | ConvertFrom-Json
    $outputConfig.packages += ($outputPackage)
}

Set-Location -Path '../../../'
Set-Content -Path './tools/generateOutput.json' -Value ($outputConfig | ConvertTo-Json)