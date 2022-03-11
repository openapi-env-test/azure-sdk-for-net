// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class FirewallPolicyFilterRuleCollectionAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyFilterRuleCollectionAction DeserializeFirewallPolicyFilterRuleCollectionAction(JsonElement element)
        {
            Optional<FirewallPolicyFilterRuleCollectionActionType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new FirewallPolicyFilterRuleCollectionActionType(property.Value.GetString());
                    continue;
                }
            }
            return new FirewallPolicyFilterRuleCollectionAction(Optional.ToNullable(type));
        }
    }
}
