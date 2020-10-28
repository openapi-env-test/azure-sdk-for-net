param($GenerateInput)

# input: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2016-10-01/keyvault.json
function Get-RPs($changedFiles) {
    $swaggerDefinitions = @{};
    $rpMapping = Get-Content -Path './../RPMapping.json' | ConvertFrom-Json
    foreach($changedFile in $changedFiles)
    {
        $rpNameArr = $changedFile.Split("/")
        $rpName = $rpNameArr[1]
        if (isCognitiveService($rpName) -eq $true)
        {
         $rpName = $rpNameArr[3]
        }
        # keyvault
        $rpName = $rpMapping.$rpName.psobject.properties
        $rpName = $rpName.Name
        if (!$swaggerDefinitions.ContainsKey($rpName)) 
        {
            $swaggerDefinitions.$rpName = @()
        }
        $swaggerDefinitions.$rpName += "$changedFile"
    }
    Write-Output $swaggerDefinitions
}

function isCognitiveService ($value)
{
	$isCognitiveService = $false
	if($value -match "cognitiveservices"){
		$isCognitiveService = $true
	}
	return $isCognitiveService
}

# Get the list of changed swaggers
# Output: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2016-10-01/keyvault.json
$input = Get-Content $GenerateInput | ConvertFrom-Json
Write-Output "List Of changed swaggers" $input.changedFiles
$headSha = $input.headSha
Write-Host

# Get the list of sdk folder names with swagger urls
# sdk: keyvault url: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2016-10-01/keyvault.json
$rpCollection = Get-RPs $input.changedFiles
foreach ($key in $rpCollection.Keys) 
{ 
    # Write-Host "sdk: $key    url: $($rpCollection[$key])" 
    Write-Host "sdk: $key" 
    $num = 1
    foreach ($value in $rpCollection[$key]) 
    { 
    Write-Host "ulr-$num" $value
    $num++ 
    }
}

Write-Host

foreach ($key in $rpCollection.Keys)
{
    $sdkPath = Get-ChildItem -Path "../../sdk" | Where-Object {$_.Name -match $key}
    $track2SdksPath = Get-ChildItem $sdkPath -Recurse | Where-Object { $_.PSIsContainer -and $_.Name.StartsWith("Azure.")}
    $autorestFilePath = Get-Childitem $track2SdksPath -include *autorest.md -depth 2
    foreach ($path in $autorestFilePath)
    {
        # printing all the autorest mds
        Write-Host "autorest path" $path
    }

    foreach ($swaggerUrl in $rpCollection[$key])
    {
        foreach ($path in $autorestFilePath)
        {
        # Write-Host "autorest path" $path
        (Get-Content -Raw $path) -replace "[\/][0-9a-f]{4,40}[\/]$swaggerUrl", "/$headSha/$swaggerUrl" | `
         Set-Content $path -NoNewline
        }
    }
     Write-Host
}

dotnet msbuild /restore /t:GenerateCode "../service.proj"