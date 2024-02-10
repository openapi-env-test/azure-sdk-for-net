// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class PatientRecord : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteObjectValue(Details);
            }
            if (Optional.IsCollectionDefined(Encounters))
            {
                writer.WritePropertyName("encounters"u8);
                writer.WriteStartArray();
                foreach (var item in Encounters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PatientDocuments))
            {
                writer.WritePropertyName("patientDocuments"u8);
                writer.WriteStartArray();
                foreach (var item in PatientDocuments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static PatientRecord DeserializePatientRecord(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            Optional<PatientDetails> details = default;
            Optional<IList<PatientEncounter>> encounters = default;
            Optional<IList<PatientDocument>> patientDocuments = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    details = PatientDetails.DeserializePatientDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("encounters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PatientEncounter> array = new List<PatientEncounter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PatientEncounter.DeserializePatientEncounter(item));
                    }
                    encounters = array;
                    continue;
                }
                if (property.NameEquals("patientDocuments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PatientDocument> array = new List<PatientDocument>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PatientDocument.DeserializePatientDocument(item));
                    }
                    patientDocuments = array;
                    continue;
                }
            }
            return new PatientRecord(id, details.Value, Optional.ToList(encounters), Optional.ToList(patientDocuments));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PatientRecord FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePatientRecord(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
