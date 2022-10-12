// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class KubernetesRoleStorage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints");
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static KubernetesRoleStorage DeserializeKubernetesRoleStorage(JsonElement element)
        {
            Optional<IReadOnlyList<KubernetesRoleStorageClassInfo>> storageClasses = default;
            Optional<IList<DataBoxEdgeMountPointMap>> endpoints = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageClasses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KubernetesRoleStorageClassInfo> array = new List<KubernetesRoleStorageClassInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KubernetesRoleStorageClassInfo.DeserializeKubernetesRoleStorageClassInfo(item));
                    }
                    storageClasses = array;
                    continue;
                }
                if (property.NameEquals("endpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataBoxEdgeMountPointMap> array = new List<DataBoxEdgeMountPointMap>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxEdgeMountPointMap.DeserializeDataBoxEdgeMountPointMap(item));
                    }
                    endpoints = array;
                    continue;
                }
            }
            return new KubernetesRoleStorage(Optional.ToList(storageClasses), Optional.ToList(endpoints));
        }
    }
}
