# Azure.IoT.DeviceUpdate

Run `generate.ps1` or `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
public-clients: true
title: DeviceUpdate
require:
- https://github.com/openapi-env-test/azure-rest-api-specs/blob/26fbe918f2c3683cdcb7ec6f0c75fb03aab274c1/specification/deviceupdate/data-plane/readme.md
- https://github.com/openapi-env-test/azure-rest-api-specs/blob/26fbe918f2c3683cdcb7ec6f0c75fb03aab274c1/specification/deviceupdate/data-plane/readme.csharp.md
csharp: true
namespace: Azure.IoT.DeviceUpdate
data-plane: true
security: AADToken
security-scopes:  https://api.adu.microsoft.com/.default
```
