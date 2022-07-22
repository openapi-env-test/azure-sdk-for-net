# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
- /mnt/vss/_work/1/s/azure-rest-api-specs/specification/purview/data-plane/readme.md
csharp: true
namespace: Azure.Analytics.Purview.Shared

 
 
```
