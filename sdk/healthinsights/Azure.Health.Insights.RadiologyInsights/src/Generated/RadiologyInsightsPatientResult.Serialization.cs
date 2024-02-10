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
    public partial class RadiologyInsightsPatientResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("patientId"u8);
            writer.WriteStringValue(PatientId);
            writer.WritePropertyName("inferences"u8);
            writer.WriteStartArray();
            foreach (var item in Inferences)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static RadiologyInsightsPatientResult DeserializeRadiologyInsightsPatientResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string patientId = default;
            IList<FhirR4Extendible> inferences = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patientId"u8))
                {
                    patientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inferences"u8))
                {
                    List<FhirR4Extendible> array = new List<FhirR4Extendible>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Extendible.DeserializeFhirR4Extendible(item));
                    }
                    inferences = array;
                    continue;
                }
            }
            return new RadiologyInsightsPatientResult(patientId, inferences);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RadiologyInsightsPatientResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRadiologyInsightsPatientResult(document.RootElement);
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
