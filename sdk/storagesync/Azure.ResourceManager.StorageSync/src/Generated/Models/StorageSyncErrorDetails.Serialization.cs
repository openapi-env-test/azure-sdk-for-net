// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class StorageSyncErrorDetails
    {
        internal static StorageSyncErrorDetails DeserializeStorageSyncErrorDetails(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<string> target = default;
            Optional<Uri> requestUri = default;
            Optional<string> exceptionType = default;
            Optional<string> httpMethod = default;
            Optional<string> hashedMessage = default;
            Optional<string> httpErrorCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        requestUri = null;
                        continue;
                    }
                    requestUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exceptionType"))
                {
                    exceptionType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpMethod"))
                {
                    httpMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hashedMessage"))
                {
                    hashedMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpErrorCode"))
                {
                    httpErrorCode = property.Value.GetString();
                    continue;
                }
            }
            return new StorageSyncErrorDetails(code.Value, message.Value, target.Value, requestUri.Value, exceptionType.Value, httpMethod.Value, hashedMessage.Value, httpErrorCode.Value);
        }
    }
}
