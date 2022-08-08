# Azure.IoT.DeviceUpdate

Run `generate.ps1` or `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
public-clients: true
title: DeviceUpdateClient
require:
- /spec-repo/specification/deviceupdate/data-plane/readme.md

namespace: Azure.IoT.DeviceUpdate
security: AADToken
security-scopes:  https://api.adu.microsoft.com/.default
```

