// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerResourceLimits : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MemoryInGB))
            {
                writer.WritePropertyName("memoryInGB");
                writer.WriteNumberValue(MemoryInGB.Value);
            }
            if (Optional.IsDefined(Cpu))
            {
                writer.WritePropertyName("cpu");
                writer.WriteNumberValue(Cpu.Value);
            }
            if (Optional.IsDefined(Gpu))
            {
                writer.WritePropertyName("gpu");
                writer.WriteObjectValue(Gpu);
            }
            writer.WriteEndObject();
        }

        internal static ContainerResourceLimits DeserializeContainerResourceLimits(JsonElement element)
        {
            Optional<double> memoryInGB = default;
            Optional<double> cpu = default;
            Optional<ContainerGpuResourceInfo> gpu = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("memoryInGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    memoryInGB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("cpu"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cpu = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("gpu"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    gpu = ContainerGpuResourceInfo.DeserializeContainerGpuResourceInfo(property.Value);
                    continue;
                }
            }
            return new ContainerResourceLimits(Optional.ToNullable(memoryInGB), Optional.ToNullable(cpu), gpu.Value);
        }
    }
}
