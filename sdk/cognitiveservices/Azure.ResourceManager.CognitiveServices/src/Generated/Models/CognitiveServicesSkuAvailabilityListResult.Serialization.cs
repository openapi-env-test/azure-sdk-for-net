// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    internal partial class CognitiveServicesSkuAvailabilityListResult
    {
        internal static CognitiveServicesSkuAvailabilityListResult DeserializeCognitiveServicesSkuAvailabilityListResult(JsonElement element)
        {
            Optional<IReadOnlyList<CognitiveServicesSkuAvailabilityList>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CognitiveServicesSkuAvailabilityList> array = new List<CognitiveServicesSkuAvailabilityList>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CognitiveServicesSkuAvailabilityList.DeserializeCognitiveServicesSkuAvailabilityList(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CognitiveServicesSkuAvailabilityListResult(Optional.ToList(value));
        }
    }
}
