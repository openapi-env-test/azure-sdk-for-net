# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

```yaml
title: PurviewAdministration
require:
  - https://github.com/Azure/azure-rest-api-specs/blob/9e30496a8803beb5a84909997e5cd7ea0f242fd8/specification/purview/data-plane/readme.md
namespace: Azure.Analytics.Purview.Administration
modelerfour:
    lenient-model-deduplication: true
security: AADToken
security-scopes:  https://purview.azure.net/.default
```

# Model endpoint parameter as a url, not a string.

```yaml
directive:
  - from: swagger-document
    where: $.parameters.endpoint
    transform: >
      if ($.format === undefined) {
        $.format = "url";
      }
  - from: swagger-document
    where: $.parameters.Endpoint
    transform: >
      if ($.format === undefined) {
        $.format = "url";
      }
```

# Promote collectionName to be a client parameter.

```yaml
directive:
  - from: swagger-document
    where: $.parameters
    transform: >
      $["collectionName"] = {
        "in": "path",
        "name": "collectionName",
        "required": true,
        "type": "string",
        "x-ms-parameter-location": "client"
      };

  - from: swagger-document
    where: $.paths..parameters[?(@.name=='collectionName')]
    transform: >
      $ = { "$ref": "#/parameters/collectionName" };
```

# Rename or reorganize methods

```yaml
directive:
  - from: swagger-document
    where: $..[?(@.operationId !== undefined)]
    transform: >
      const mappingTable = {
        "Collections_ListCollections": "Accounts_GetCollections",
        "ResourceSetRules_ListResourceSetRules": "Accounts_GetResourceSetRules",
        "MetadataRoles_List": "MetadataRoles_GetMetadataRoles",
        "MetadataPolicy_ListAll": "MetadataPolicy_GetMetadataPolicies",
        "MetadataPolicy_Get": "MetadataPolicy_GetMetadataPolicy",
        "MetadataPolicy_Update": "MetadataPolicy_UpdateMetadataPolicy",
      };

      $.operationId = (mappingTable[$.operationId] ?? $.operationId);
```

# Add `Purview` To Metadata Clients

```yaml
directive:
  - from: swagger-document
    where: $..[?(@.operationId !== undefined)]
    transform: >
      if ($.operationId.startsWith("Metadata")) {
          $.operationId = "Purview" + $.operationId;
      }
```
