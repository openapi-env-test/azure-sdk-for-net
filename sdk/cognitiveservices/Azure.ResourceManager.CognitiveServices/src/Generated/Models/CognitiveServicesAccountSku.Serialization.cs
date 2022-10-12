// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesAccountSku
    {
        internal static CognitiveServicesAccountSku DeserializeCognitiveServicesAccountSku(JsonElement element)
        {
            Optional<ResourceType> resourceType = default;
            Optional<CognitiveServicesSku> sku = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = CognitiveServicesSku.DeserializeCognitiveServicesSku(property.Value);
                    continue;
                }
            }
            return new CognitiveServicesAccountSku(Optional.ToNullable(resourceType), sku.Value);
        }
    }
}
