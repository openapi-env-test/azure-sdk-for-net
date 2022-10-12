// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SapTableLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(LinkedServiceType);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia");
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Server))
            {
                writer.WritePropertyName("server");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Server);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Server.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SystemNumber))
            {
                writer.WritePropertyName("systemNumber");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SystemNumber);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SystemNumber.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ClientId);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ClientId.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Language);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Language.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SystemId))
            {
                writer.WritePropertyName("systemId");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SystemId);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SystemId.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(UserName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(UserName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteObjectValue(Password);
            }
            if (Optional.IsDefined(MessageServer))
            {
                writer.WritePropertyName("messageServer");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MessageServer);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(MessageServer.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(MessageServerService))
            {
                writer.WritePropertyName("messageServerService");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MessageServerService);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(MessageServerService.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SncMode))
            {
                writer.WritePropertyName("sncMode");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SncMode);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SncMode.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SncMyName))
            {
                writer.WritePropertyName("sncMyName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SncMyName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SncMyName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SncPartnerName))
            {
                writer.WritePropertyName("sncPartnerName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SncPartnerName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SncPartnerName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SncLibraryPath))
            {
                writer.WritePropertyName("sncLibraryPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SncLibraryPath);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SncLibraryPath.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(SncQop))
            {
                writer.WritePropertyName("sncQop");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SncQop);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(SncQop.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(LogonGroup))
            {
                writer.WritePropertyName("logonGroup");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(LogonGroup);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(LogonGroup.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EncryptedCredential);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EncryptedCredential.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static SapTableLinkedService DeserializeSapTableLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<BinaryData> server = default;
            Optional<BinaryData> systemNumber = default;
            Optional<BinaryData> clientId = default;
            Optional<BinaryData> language = default;
            Optional<BinaryData> systemId = default;
            Optional<BinaryData> userName = default;
            Optional<FactorySecretBaseDefinition> password = default;
            Optional<BinaryData> messageServer = default;
            Optional<BinaryData> messageServerService = default;
            Optional<BinaryData> sncMode = default;
            Optional<BinaryData> sncMyName = default;
            Optional<BinaryData> sncPartnerName = default;
            Optional<BinaryData> sncLibraryPath = default;
            Optional<BinaryData> sncQop = default;
            Optional<BinaryData> logonGroup = default;
            Optional<BinaryData> encryptedCredential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryData.FromString(item.GetRawText()));
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("server"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            server = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("systemNumber"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            systemNumber = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clientId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clientId = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("language"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            language = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("systemId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            systemId = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("userName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            userName = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("password"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            password = FactorySecretBaseDefinition.DeserializeFactorySecretBaseDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("messageServer"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            messageServer = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("messageServerService"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            messageServerService = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sncMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sncMode = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sncMyName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sncMyName = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sncPartnerName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sncPartnerName = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sncLibraryPath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sncLibraryPath = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("sncQop"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sncQop = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("logonGroup"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            logonGroup = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptedCredential = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SapTableLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, server.Value, systemNumber.Value, clientId.Value, language.Value, systemId.Value, userName.Value, password.Value, messageServer.Value, messageServerService.Value, sncMode.Value, sncMyName.Value, sncPartnerName.Value, sncLibraryPath.Value, sncQop.Value, logonGroup.Value, encryptedCredential.Value);
        }
    }
}
