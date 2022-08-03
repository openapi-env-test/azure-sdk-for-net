# Azure.IoT.DeviceUpdate

Run `generate.ps1` or `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
public-clients: true
title: DeviceUpdateClient
require:
- https://github.com/Azure/azure-rest-api-specs/blob/9cc462faa3e6c45bcba36ef95b8f8fca1247966f/deviceupdate/data-plane/readme.md

namespace: Azure.IoT.DeviceUpdate
security: AADToken
security-scopes:  https://api.adu.microsoft.com/.default
```

