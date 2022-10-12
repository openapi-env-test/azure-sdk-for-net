// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class DicomServiceAuthenticationConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static DicomServiceAuthenticationConfiguration DeserializeDicomServiceAuthenticationConfiguration(JsonElement element)
        {
            Optional<string> authority = default;
            Optional<IReadOnlyList<string>> audiences = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authority"))
                {
                    authority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("audiences"))
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
                    audiences = array;
                    continue;
                }
            }
            return new DicomServiceAuthenticationConfiguration(authority.Value, Optional.ToList(audiences));
        }
    }
}
