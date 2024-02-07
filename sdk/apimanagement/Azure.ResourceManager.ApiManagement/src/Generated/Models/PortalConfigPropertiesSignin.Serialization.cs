// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class PortalConfigPropertiesSignin : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Require))
            {
                writer.WritePropertyName("require"u8);
                writer.WriteBooleanValue(Require.Value);
            }
            writer.WriteEndObject();
        }

        internal static PortalConfigPropertiesSignin DeserializePortalConfigPropertiesSignin(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> require = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("require"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    require = property.Value.GetBoolean();
                    continue;
                }
            }
            return new PortalConfigPropertiesSignin(Optional.ToNullable(require));
        }
    }
}
