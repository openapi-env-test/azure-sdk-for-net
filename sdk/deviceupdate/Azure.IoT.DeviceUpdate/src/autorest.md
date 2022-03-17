# Azure.IoT.DeviceUpdate

Run `generate.ps1` or `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
public-clients: true
title: DeviceUpdate
require:
- https://github.com/openapi-env-test/azure-rest-api-specs/blob/98f3d9363fca1f7426c27a270248e5a039bb8f95/specification/deviceupdate/data-plane/readme.md
- https://github.com/openapi-env-test/azure-rest-api-specs/blob/98f3d9363fca1f7426c27a270248e5a039bb8f95/specification/deviceupdate/data-plane/readme.csharp.md
csharp: true
namespace: Azure.IoT.DeviceUpdate
data-plane: true
security: AADToken
security-scopes:  https://api.adu.microsoft.com/.default
```
