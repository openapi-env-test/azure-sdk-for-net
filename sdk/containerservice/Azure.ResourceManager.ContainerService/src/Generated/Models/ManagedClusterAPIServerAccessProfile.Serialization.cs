// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterAPIServerAccessProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AuthorizedIPRanges))
            {
                writer.WritePropertyName("authorizedIPRanges");
                writer.WriteStartArray();
                foreach (var item in AuthorizedIPRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnablePrivateCluster))
            {
                writer.WritePropertyName("enablePrivateCluster");
                writer.WriteBooleanValue(EnablePrivateCluster.Value);
            }
            if (Optional.IsDefined(PrivateDNSZone))
            {
                writer.WritePropertyName("privateDNSZone");
                writer.WriteStringValue(PrivateDNSZone);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterAPIServerAccessProfile DeserializeManagedClusterAPIServerAccessProfile(JsonElement element)
        {
            Optional<IList<string>> authorizedIPRanges = default;
            Optional<bool> enablePrivateCluster = default;
            Optional<string> privateDNSZone = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizedIPRanges"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    authorizedIPRanges = array;
                    continue;
                }
                if (property.NameEquals("enablePrivateCluster"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enablePrivateCluster = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("privateDNSZone"))
                {
                    privateDNSZone = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedClusterAPIServerAccessProfile(Optional.ToList(authorizedIPRanges), Optional.ToNullable(enablePrivateCluster), privateDNSZone.Value);
        }
    }
}
