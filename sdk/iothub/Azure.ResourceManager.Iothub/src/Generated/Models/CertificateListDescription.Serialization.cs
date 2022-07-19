// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Iothub;

namespace Azure.ResourceManager.Iothub.Models
{
    internal partial class CertificateListDescription
    {
        internal static CertificateListDescription DeserializeCertificateListDescription(JsonElement element)
        {
            Optional<IReadOnlyList<CertificateDescriptionData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CertificateDescriptionData> array = new List<CertificateDescriptionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CertificateDescriptionData.DeserializeCertificateDescriptionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CertificateListDescription(Optional.ToList(value));
        }
    }
}
