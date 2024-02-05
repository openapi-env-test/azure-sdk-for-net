// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class UefiKeySignatures : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Pk))
            {
                writer.WritePropertyName("pk"u8);
                writer.WriteObjectValue(Pk);
            }
            if (Optional.IsCollectionDefined(Kek))
            {
                writer.WritePropertyName("kek"u8);
                writer.WriteStartArray();
                foreach (var item in Kek)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Db))
            {
                writer.WritePropertyName("db"u8);
                writer.WriteStartArray();
                foreach (var item in Db)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Dbx))
            {
                writer.WritePropertyName("dbx"u8);
                writer.WriteStartArray();
                foreach (var item in Dbx)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static UefiKeySignatures DeserializeUefiKeySignatures(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<UefiKey> pk = default;
            Optional<IList<UefiKey>> kek = default;
            Optional<IList<UefiKey>> db = default;
            Optional<IList<UefiKey>> dbx = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pk = UefiKey.DeserializeUefiKey(property.Value);
                    continue;
                }
                if (property.NameEquals("kek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UefiKey> array = new List<UefiKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UefiKey.DeserializeUefiKey(item));
                    }
                    kek = array;
                    continue;
                }
                if (property.NameEquals("db"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UefiKey> array = new List<UefiKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UefiKey.DeserializeUefiKey(item));
                    }
                    db = array;
                    continue;
                }
                if (property.NameEquals("dbx"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UefiKey> array = new List<UefiKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UefiKey.DeserializeUefiKey(item));
                    }
                    dbx = array;
                    continue;
                }
            }
            return new UefiKeySignatures(pk.Value, Optional.ToList(kek), Optional.ToList(db), Optional.ToList(dbx));
        }
    }
}
