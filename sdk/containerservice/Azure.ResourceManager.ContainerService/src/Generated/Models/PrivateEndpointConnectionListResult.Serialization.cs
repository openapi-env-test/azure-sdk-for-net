// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class PrivateEndpointConnectionListResult
    {
        internal static PrivateEndpointConnectionListResult DeserializePrivateEndpointConnectionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PrivateEndpointConnection>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PrivateEndpointConnection> array = new List<PrivateEndpointConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateEndpointConnection.DeserializePrivateEndpointConnection(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PrivateEndpointConnectionListResult(Optional.ToList(value));
        }
    }
}
