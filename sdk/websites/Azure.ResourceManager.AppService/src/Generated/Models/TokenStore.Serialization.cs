// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class TokenStore : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(TokenRefreshExtensionHours))
            {
                writer.WritePropertyName("tokenRefreshExtensionHours");
                writer.WriteNumberValue(TokenRefreshExtensionHours.Value);
            }
            if (Optional.IsDefined(FileSystem))
            {
                writer.WritePropertyName("fileSystem");
                writer.WriteObjectValue(FileSystem);
            }
            if (Optional.IsDefined(AzureBlobStorage))
            {
                writer.WritePropertyName("azureBlobStorage");
                writer.WriteObjectValue(AzureBlobStorage);
            }
            writer.WriteEndObject();
        }

        internal static TokenStore DeserializeTokenStore(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<double> tokenRefreshExtensionHours = default;
            Optional<FileSystemTokenStore> fileSystem = default;
            Optional<BlobStorageTokenStore> azureBlobStorage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tokenRefreshExtensionHours"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tokenRefreshExtensionHours = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("fileSystem"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileSystem = FileSystemTokenStore.DeserializeFileSystemTokenStore(property.Value);
                    continue;
                }
                if (property.NameEquals("azureBlobStorage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureBlobStorage = BlobStorageTokenStore.DeserializeBlobStorageTokenStore(property.Value);
                    continue;
                }
            }
            return new TokenStore(Optional.ToNullable(enabled), Optional.ToNullable(tokenRefreshExtensionHours), fileSystem.Value, azureBlobStorage.Value);
        }
    }
}
