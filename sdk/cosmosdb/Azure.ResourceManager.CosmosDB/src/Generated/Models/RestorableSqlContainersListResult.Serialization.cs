// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class RestorableSqlContainersListResult
    {
        internal static RestorableSqlContainersListResult DeserializeRestorableSqlContainersListResult(JsonElement element)
        {
            Optional<IReadOnlyList<RestorableSqlContainerGetResult>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RestorableSqlContainerGetResult> array = new List<RestorableSqlContainerGetResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorableSqlContainerGetResult.DeserializeRestorableSqlContainerGetResult(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new RestorableSqlContainersListResult(Optional.ToList(value));
        }
    }
}
