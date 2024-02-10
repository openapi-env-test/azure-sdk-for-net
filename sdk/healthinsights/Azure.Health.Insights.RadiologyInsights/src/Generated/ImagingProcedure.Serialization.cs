// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    internal partial class ImagingProcedure : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("modality"u8);
            writer.WriteObjectValue(Modality);
            writer.WritePropertyName("anatomy"u8);
            writer.WriteObjectValue(Anatomy);
            if (Optional.IsDefined(Laterality))
            {
                writer.WritePropertyName("laterality"u8);
                writer.WriteObjectValue(Laterality);
            }
            if (Optional.IsDefined(Contrast))
            {
                writer.WritePropertyName("contrast"u8);
                writer.WriteObjectValue(Contrast);
            }
            if (Optional.IsDefined(View))
            {
                writer.WritePropertyName("view"u8);
                writer.WriteObjectValue(View);
            }
            writer.WriteEndObject();
        }

        internal static ImagingProcedure DeserializeImagingProcedure(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FhirR4CodeableConcept modality = default;
            FhirR4CodeableConcept anatomy = default;
            Optional<FhirR4CodeableConcept> laterality = default;
            Optional<RadiologyCodeWithTypes> contrast = default;
            Optional<RadiologyCodeWithTypes> view = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modality"u8))
                {
                    modality = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value);
                    continue;
                }
                if (property.NameEquals("anatomy"u8))
                {
                    anatomy = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value);
                    continue;
                }
                if (property.NameEquals("laterality"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    laterality = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value);
                    continue;
                }
                if (property.NameEquals("contrast"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contrast = RadiologyCodeWithTypes.DeserializeRadiologyCodeWithTypes(property.Value);
                    continue;
                }
                if (property.NameEquals("view"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    view = RadiologyCodeWithTypes.DeserializeRadiologyCodeWithTypes(property.Value);
                    continue;
                }
            }
            return new ImagingProcedure(modality, anatomy, laterality.Value, contrast.Value, view.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ImagingProcedure FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeImagingProcedure(document.RootElement);
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
