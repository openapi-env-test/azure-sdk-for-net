function Get-RPs {
    param (
        [string[]]$changedFiles
    )
    $output = {@()}.Invoke()
    $rpMapping = Get-Content -Path './tools/RPMapping.json' | ConvertFrom-Json
    $rpName = $rpMapping."$rpName"
    $changedFiles | ForEach-Object { 
        $rpName = $_.Substring(14)
        $rpName = $rpName.Substring(0, $rpName.IndexOf('/'));
        $rpName = $rpMapping."$rpName"
        If ($output -notcontains $rpName){
            $output.Add($rpName)
        }
    }
    Write-Output $output
}

function Create-Project {
    param (
        $path, $rpName
    )
    
    $newCommand = 'dotnet new -i ./eng/templates/Azure.ResourceManager.Template'
    Invoke-Expression $newCommand
    New-Item -Path $path -Name ('Azure.ResourceManager.'+$rpName) -ItemType "directory"
    Start-Process 'dotnet' ['new', 'azuremgmt', '--provider', $rpName] -WorkingDirectory $path+'/Azure.ResourceManager.'+$rpName
}

$input = Get-Content -Path './tools/generateInput.json' | ConvertFrom-Json

$input.changedFiles = @($input.changedFiles) -match 'resource-manager'

Write-Output $input.changedFiles

$rpIndex = Get-RPs($input.changedFiles)
$rpIndex.GetEnumerator() | ForEach-Object {
    # Path not working
    $path = '../sdk/'+$_.Key+'/Azure.ResourceManager.'+$_.Value
    $rpName = $_.value
    if (-not (Test-Path $path)) {
        Create-Project('../sdk/'+$_.key, $rpName)
    }
}

Write-Output $rpIndex



