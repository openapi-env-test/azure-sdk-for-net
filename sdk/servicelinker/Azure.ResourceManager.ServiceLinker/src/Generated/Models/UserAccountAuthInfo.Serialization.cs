// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class UserAccountAuthInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId"u8);
                writer.WriteStringValue(PrincipalId.Value);
            }
            if (Optional.IsDefined(DeleteOrUpdateBehavior))
            {
                writer.WritePropertyName("deleteOrUpdateBehavior"u8);
                writer.WriteStringValue(DeleteOrUpdateBehavior.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Roles))
            {
                writer.WritePropertyName("roles"u8);
                writer.WriteStartArray();
                foreach (var item in Roles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UserName))
            {
                if (UserName != null)
                {
                    writer.WritePropertyName("userName"u8);
                    writer.WriteStringValue(UserName);
                }
                else
                {
                    writer.WriteNull("userName");
                }
            }
            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType.ToString());
            if (Optional.IsDefined(AuthMode))
            {
                writer.WritePropertyName("authMode"u8);
                writer.WriteStringValue(AuthMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static UserAccountAuthInfo DeserializeUserAccountAuthInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> principalId = default;
            Optional<DeleteOrUpdateBehavior> deleteOrUpdateBehavior = default;
            Optional<IList<string>> roles = default;
            Optional<string> userName = default;
            LinkerAuthType authType = default;
            Optional<AuthMode> authMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("deleteOrUpdateBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deleteOrUpdateBehavior = new DeleteOrUpdateBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    roles = array;
                    continue;
                }
                if (property.NameEquals("userName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userName = null;
                        continue;
                    }
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authType"u8))
                {
                    authType = new LinkerAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authMode = new AuthMode(property.Value.GetString());
                    continue;
                }
            }
            return new UserAccountAuthInfo(authType, Optional.ToNullable(authMode), Optional.ToNullable(principalId), Optional.ToNullable(deleteOrUpdateBehavior), Optional.ToList(roles), userName.Value);
        }
    }
}
