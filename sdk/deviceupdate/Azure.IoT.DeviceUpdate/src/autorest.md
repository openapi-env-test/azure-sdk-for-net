# Azure.IoT.DeviceUpdate

Run `generate.ps1` or `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
public-clients: true
title: DeviceUpdate
require:
  - https://github.com/Azure/azure-rest-api-specs/blob/9e30496a8803beb5a84909997e5cd7ea0f242fd8/specification/deviceupdate/data-plane/readme.md
namespace: Azure.IoT.DeviceUpdate
security: AADToken
security-scopes:  https://api.adu.microsoft.com/.default
```
