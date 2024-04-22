// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class ConfigurationInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DeleteOrUpdateBehavior))
            {
                writer.WritePropertyName("deleteOrUpdateBehavior"u8);
                writer.WriteStringValue(DeleteOrUpdateBehavior.Value.ToString());
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
            if (Optional.IsCollectionDefined(CustomizedKeys))
            {
                writer.WritePropertyName("customizedKeys"u8);
                writer.WriteStartObject();
                foreach (var item in CustomizedKeys)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(DaprProperties))
            {
                writer.WritePropertyName("daprProperties"u8);
                writer.WriteObjectValue(DaprProperties);
            }
            if (Optional.IsCollectionDefined(AdditionalConfigurations))
            {
                writer.WritePropertyName("additionalConfigurations"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalConfigurations)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(AdditionalConnectionStringProperties))
            {
                writer.WritePropertyName("additionalConnectionStringProperties"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalConnectionStringProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ConfigurationStore))
            {
                if (ConfigurationStore != null)
                {
                    writer.WritePropertyName("configurationStore"u8);
                    writer.WriteObjectValue(ConfigurationStore);
                }
                else
                {
                    writer.WriteNull("configurationStore");
                }
            }
            writer.WriteEndObject();
        }

        internal static ConfigurationInfo DeserializeConfigurationInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DeleteOrUpdateBehavior> deleteOrUpdateBehavior = default;
            Optional<ActionType> action = default;
            Optional<IDictionary<string, string>> customizedKeys = default;
            Optional<DaprProperties> daprProperties = default;
            Optional<IDictionary<string, string>> additionalConfigurations = default;
            Optional<IDictionary<string, string>> additionalConnectionStringProperties = default;
            Optional<ConfigurationStore> configurationStore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deleteOrUpdateBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deleteOrUpdateBehavior = new DeleteOrUpdateBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new ActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customizedKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    customizedKeys = dictionary;
                    continue;
                }
                if (property.NameEquals("daprProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    daprProperties = DaprProperties.DeserializeDaprProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("additionalConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    additionalConfigurations = dictionary;
                    continue;
                }
                if (property.NameEquals("additionalConnectionStringProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    additionalConnectionStringProperties = dictionary;
                    continue;
                }
                if (property.NameEquals("configurationStore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        configurationStore = null;
                        continue;
                    }
                    configurationStore = ConfigurationStore.DeserializeConfigurationStore(property.Value);
                    continue;
                }
            }
            return new ConfigurationInfo(Optional.ToNullable(deleteOrUpdateBehavior), Optional.ToNullable(action), Optional.ToDictionary(customizedKeys), daprProperties.Value, Optional.ToDictionary(additionalConfigurations), Optional.ToDictionary(additionalConnectionStringProperties), configurationStore.Value);
        }
    }
}
