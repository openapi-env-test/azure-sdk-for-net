# Azure.IoT.DeviceUpdate

Run `generate.ps1` or `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
public-clients: true
title: DeviceUpdateClient
require:
- https://github.com/test-repo-billy/azure-rest-api-specs/blob/7c254880f3eca18527c8a0ade9b9470033ca2941/deviceupdate/data-plane/readme.md

namespace: Azure.IoT.DeviceUpdate
security: AADToken
security-scopes:  https://api.adu.microsoft.com/.default
```

