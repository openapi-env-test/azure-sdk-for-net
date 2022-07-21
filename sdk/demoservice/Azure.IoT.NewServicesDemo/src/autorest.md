# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
- /spec-repo/specification/demoservice/data-plane/readme.md
csharp: true
namespace: Azure.IoT.NewServicesDemo

 
 
```
