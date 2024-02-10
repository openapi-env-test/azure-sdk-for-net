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
    public partial class RadiologyInsightsData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("patients"u8);
            writer.WriteStartArray();
            foreach (var item in Patients)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration);
            }
            writer.WriteEndObject();
        }

        internal static RadiologyInsightsData DeserializeRadiologyInsightsData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<PatientRecord> patients = default;
            Optional<RadiologyInsightsModelConfiguration> configuration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patients"u8))
                {
                    List<PatientRecord> array = new List<PatientRecord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PatientRecord.DeserializePatientRecord(item));
                    }
                    patients = array;
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = RadiologyInsightsModelConfiguration.DeserializeRadiologyInsightsModelConfiguration(property.Value);
                    continue;
                }
            }
            return new RadiologyInsightsData(patients, configuration.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RadiologyInsightsData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRadiologyInsightsData(document.RootElement);
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
