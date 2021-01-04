// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceSshPublicKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyData");
            writer.WriteStringValue(KeyData);
            writer.WriteEndObject();
        }

        internal static ContainerServiceSshPublicKey DeserializeContainerServiceSshPublicKey(JsonElement element)
        {
            string keyData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyData"))
                {
                    keyData = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerServiceSshPublicKey(keyData);
        }
    }
}
