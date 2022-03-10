# Azure.IoT.DeviceUpdate

Run `generate.ps1` or `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
public-clients: true
title: DeviceUpdate
require:
- https://github.com/openapi-env-test/azure-rest-api-specs/blob/9286892da180b4368cbb5d2e78a19afcdc0a9b15/specification/deviceupdate/data-plane/readme.md
- https://github.com/openapi-env-test/azure-rest-api-specs/blob/9286892da180b4368cbb5d2e78a19afcdc0a9b15/specification/deviceupdate/data-plane/readme.csharp.md
csharp: true
namespace: Azure.IoT.DeviceUpdate
data-plane: true
security: AADToken
security-scopes:  https://api.adu.microsoft.com/.default
```
