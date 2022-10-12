// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    internal partial class KeyVaultProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyIdentifier))
            {
                writer.WritePropertyName("keyIdentifier");
                writer.WriteStringValue(KeyIdentifier.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static KeyVaultProperties DeserializeKeyVaultProperties(JsonElement element)
        {
            Optional<Uri> keyIdentifier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyIdentifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyIdentifier = null;
                        continue;
                    }
                    keyIdentifier = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new KeyVaultProperties(keyIdentifier.Value);
        }
    }
}
