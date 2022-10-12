// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterServerCertificateCommonNames : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CommonNames))
            {
                writer.WritePropertyName("commonNames");
                writer.WriteStartArray();
                foreach (var item in CommonNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(X509StoreName))
            {
                writer.WritePropertyName("x509StoreName");
                writer.WriteStringValue(X509StoreName.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ClusterServerCertificateCommonNames DeserializeClusterServerCertificateCommonNames(JsonElement element)
        {
            Optional<IList<ClusterServerCertificateCommonName>> commonNames = default;
            Optional<ClusterCertificateStoreName> x509StoreName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commonNames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ClusterServerCertificateCommonName> array = new List<ClusterServerCertificateCommonName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClusterServerCertificateCommonName.DeserializeClusterServerCertificateCommonName(item));
                    }
                    commonNames = array;
                    continue;
                }
                if (property.NameEquals("x509StoreName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    x509StoreName = new ClusterCertificateStoreName(property.Value.GetString());
                    continue;
                }
            }
            return new ClusterServerCertificateCommonNames(Optional.ToList(commonNames), Optional.ToNullable(x509StoreName));
        }
    }
}
