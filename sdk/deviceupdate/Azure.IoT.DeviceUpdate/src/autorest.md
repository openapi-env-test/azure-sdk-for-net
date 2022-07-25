# Azure.IoT.DeviceUpdate

Run `generate.ps1` or `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
- /mnt/vss/_work/1/s/azure-rest-api-specs/specification/deviceupdate/data-plane/readme.md
csharp: true
public-clients: true
title: DeviceUpdate
namespace: Azure.IoT.DeviceUpdate
security: AADToken
security-scopes:  https://api.adu.microsoft.com/.default
```
