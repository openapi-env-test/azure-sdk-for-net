// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class CommonEncryptionCenc : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnabledProtocols))
            {
                writer.WritePropertyName("enabledProtocols");
                writer.WriteObjectValue(EnabledProtocols);
            }
            if (Optional.IsCollectionDefined(ClearTracks))
            {
                writer.WritePropertyName("clearTracks");
                writer.WriteStartArray();
                foreach (var item in ClearTracks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContentKeys))
            {
                writer.WritePropertyName("contentKeys");
                writer.WriteObjectValue(ContentKeys);
            }
            if (Optional.IsDefined(Drm))
            {
                writer.WritePropertyName("drm");
                writer.WriteObjectValue(Drm);
            }
            writer.WriteEndObject();
        }

        internal static CommonEncryptionCenc DeserializeCommonEncryptionCenc(JsonElement element)
        {
            Optional<MediaEnabledProtocols> enabledProtocols = default;
            Optional<IList<MediaTrackSelection>> clearTracks = default;
            Optional<StreamingPolicyContentKeys> contentKeys = default;
            Optional<CencDrmConfiguration> drm = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabledProtocols"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabledProtocols = MediaEnabledProtocols.DeserializeMediaEnabledProtocols(property.Value);
                    continue;
                }
                if (property.NameEquals("clearTracks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MediaTrackSelection> array = new List<MediaTrackSelection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaTrackSelection.DeserializeMediaTrackSelection(item));
                    }
                    clearTracks = array;
                    continue;
                }
                if (property.NameEquals("contentKeys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    contentKeys = StreamingPolicyContentKeys.DeserializeStreamingPolicyContentKeys(property.Value);
                    continue;
                }
                if (property.NameEquals("drm"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    drm = CencDrmConfiguration.DeserializeCencDrmConfiguration(property.Value);
                    continue;
                }
            }
            return new CommonEncryptionCenc(enabledProtocols.Value, Optional.ToList(clearTracks), contentKeys.Value, drm.Value);
        }
    }
}
