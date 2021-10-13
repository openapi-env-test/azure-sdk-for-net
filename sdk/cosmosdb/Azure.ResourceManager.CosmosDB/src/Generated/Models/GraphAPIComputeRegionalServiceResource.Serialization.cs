// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class GraphAPIComputeRegionalServiceResource
    {
        internal static GraphAPIComputeRegionalServiceResource DeserializeGraphAPIComputeRegionalServiceResource(JsonElement element)
        {
            Optional<string> graphApiComputeEndpoint = default;
            Optional<string> name = default;
            Optional<string> location = default;
            Optional<ServiceStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("graphApiComputeEndpoint"))
                {
                    graphApiComputeEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new ServiceStatus(property.Value.GetString());
                    continue;
                }
            }
            return new GraphAPIComputeRegionalServiceResource(name.Value, location.Value, Optional.ToNullable(status), graphApiComputeEndpoint.Value);
        }
    }
}
