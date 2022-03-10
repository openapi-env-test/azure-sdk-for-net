# Azure.IoT.DeviceUpdate

Run `generate.ps1` or `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
public-clients: true
title: DeviceUpdate
require:
- https://github.com/openapi-env-test/azure-rest-api-specs/blob/5807ac5a08d6ae8fe5493916308f034a8d64247c/specification/deviceupdate/data-plane/readme.md
- https://github.com/openapi-env-test/azure-rest-api-specs/blob/5807ac5a08d6ae8fe5493916308f034a8d64247c/specification/deviceupdate/data-plane/readme.csharp.md
csharp: true
namespace: Azure.IoT.DeviceUpdate
data-plane: true
security: AADToken
security-scopes:  https://api.adu.microsoft.com/.default
```
