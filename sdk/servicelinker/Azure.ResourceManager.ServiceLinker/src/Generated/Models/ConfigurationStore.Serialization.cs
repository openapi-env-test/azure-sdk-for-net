// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    internal partial class ConfigurationStore : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AppConfigurationId))
            {
                if (AppConfigurationId != null)
                {
                    writer.WritePropertyName("appConfigurationId"u8);
                    writer.WriteStringValue(AppConfigurationId);
                }
                else
                {
                    writer.WriteNull("appConfigurationId");
                }
            }
            writer.WriteEndObject();
        }

        internal static ConfigurationStore DeserializeConfigurationStore(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> appConfigurationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appConfigurationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        appConfigurationId = null;
                        continue;
                    }
                    appConfigurationId = property.Value.GetString();
                    continue;
                }
            }
            return new ConfigurationStore(appConfigurationId.Value);
        }
    }
}
