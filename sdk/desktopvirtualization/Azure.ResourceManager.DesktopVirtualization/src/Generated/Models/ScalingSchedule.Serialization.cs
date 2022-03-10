// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class ScalingSchedule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(DaysOfWeek))
            {
                writer.WritePropertyName("daysOfWeek");
                writer.WriteStartArray();
                foreach (var item in DaysOfWeek)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RampUpStartTime))
            {
                writer.WritePropertyName("rampUpStartTime");
                writer.WriteStringValue(RampUpStartTime.Value, "O");
            }
            if (Optional.IsDefined(RampUpLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("rampUpLoadBalancingAlgorithm");
                writer.WriteStringValue(RampUpLoadBalancingAlgorithm.Value.ToString());
            }
            if (Optional.IsDefined(RampUpMinimumHostsPct))
            {
                writer.WritePropertyName("rampUpMinimumHostsPct");
                writer.WriteNumberValue(RampUpMinimumHostsPct.Value);
            }
            if (Optional.IsDefined(RampUpCapacityThresholdPct))
            {
                writer.WritePropertyName("rampUpCapacityThresholdPct");
                writer.WriteNumberValue(RampUpCapacityThresholdPct.Value);
            }
            if (Optional.IsDefined(PeakStartTime))
            {
                writer.WritePropertyName("peakStartTime");
                writer.WriteStringValue(PeakStartTime.Value, "O");
            }
            if (Optional.IsDefined(PeakLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("peakLoadBalancingAlgorithm");
                writer.WriteStringValue(PeakLoadBalancingAlgorithm.Value.ToString());
            }
            if (Optional.IsDefined(RampDownStartTime))
            {
                writer.WritePropertyName("rampDownStartTime");
                writer.WriteStringValue(RampDownStartTime.Value, "O");
            }
            if (Optional.IsDefined(RampDownLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("rampDownLoadBalancingAlgorithm");
                writer.WriteStringValue(RampDownLoadBalancingAlgorithm.Value.ToString());
            }
            if (Optional.IsDefined(RampDownMinimumHostsPct))
            {
                writer.WritePropertyName("rampDownMinimumHostsPct");
                writer.WriteNumberValue(RampDownMinimumHostsPct.Value);
            }
            if (Optional.IsDefined(RampDownCapacityThresholdPct))
            {
                writer.WritePropertyName("rampDownCapacityThresholdPct");
                writer.WriteNumberValue(RampDownCapacityThresholdPct.Value);
            }
            if (Optional.IsDefined(RampDownForceLogoffUsers))
            {
                writer.WritePropertyName("rampDownForceLogoffUsers");
                writer.WriteBooleanValue(RampDownForceLogoffUsers.Value);
            }
            if (Optional.IsDefined(RampDownStopHostsWhen))
            {
                writer.WritePropertyName("rampDownStopHostsWhen");
                writer.WriteStringValue(RampDownStopHostsWhen.Value.ToString());
            }
            if (Optional.IsDefined(RampDownWaitTimeMinutes))
            {
                writer.WritePropertyName("rampDownWaitTimeMinutes");
                writer.WriteNumberValue(RampDownWaitTimeMinutes.Value);
            }
            if (Optional.IsDefined(RampDownNotificationMessage))
            {
                writer.WritePropertyName("rampDownNotificationMessage");
                writer.WriteStringValue(RampDownNotificationMessage);
            }
            if (Optional.IsDefined(OffPeakStartTime))
            {
                writer.WritePropertyName("offPeakStartTime");
                writer.WriteStringValue(OffPeakStartTime.Value, "O");
            }
            if (Optional.IsDefined(OffPeakLoadBalancingAlgorithm))
            {
                writer.WritePropertyName("offPeakLoadBalancingAlgorithm");
                writer.WriteStringValue(OffPeakLoadBalancingAlgorithm.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ScalingSchedule DeserializeScalingSchedule(JsonElement element)
        {
            Optional<string> name = default;
            Optional<IList<ScalingScheduleDaysOfWeekItem>> daysOfWeek = default;
            Optional<DateTimeOffset> rampUpStartTime = default;
            Optional<SessionHostLoadBalancingAlgorithm> rampUpLoadBalancingAlgorithm = default;
            Optional<int> rampUpMinimumHostsPct = default;
            Optional<int> rampUpCapacityThresholdPct = default;
            Optional<DateTimeOffset> peakStartTime = default;
            Optional<SessionHostLoadBalancingAlgorithm> peakLoadBalancingAlgorithm = default;
            Optional<DateTimeOffset> rampDownStartTime = default;
            Optional<SessionHostLoadBalancingAlgorithm> rampDownLoadBalancingAlgorithm = default;
            Optional<int> rampDownMinimumHostsPct = default;
            Optional<int> rampDownCapacityThresholdPct = default;
            Optional<bool> rampDownForceLogoffUsers = default;
            Optional<StopHostsWhen> rampDownStopHostsWhen = default;
            Optional<int> rampDownWaitTimeMinutes = default;
            Optional<string> rampDownNotificationMessage = default;
            Optional<DateTimeOffset> offPeakStartTime = default;
            Optional<SessionHostLoadBalancingAlgorithm> offPeakLoadBalancingAlgorithm = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("daysOfWeek"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ScalingScheduleDaysOfWeekItem> array = new List<ScalingScheduleDaysOfWeekItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ScalingScheduleDaysOfWeekItem(item.GetString()));
                    }
                    daysOfWeek = array;
                    continue;
                }
                if (property.NameEquals("rampUpStartTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rampUpStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("rampUpLoadBalancingAlgorithm"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rampUpLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rampUpMinimumHostsPct"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rampUpMinimumHostsPct = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rampUpCapacityThresholdPct"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rampUpCapacityThresholdPct = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("peakStartTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    peakStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("peakLoadBalancingAlgorithm"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    peakLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rampDownStartTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rampDownStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("rampDownLoadBalancingAlgorithm"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rampDownLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rampDownMinimumHostsPct"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rampDownMinimumHostsPct = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rampDownCapacityThresholdPct"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rampDownCapacityThresholdPct = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rampDownForceLogoffUsers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rampDownForceLogoffUsers = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rampDownStopHostsWhen"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rampDownStopHostsWhen = new StopHostsWhen(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rampDownWaitTimeMinutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rampDownWaitTimeMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rampDownNotificationMessage"))
                {
                    rampDownNotificationMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offPeakStartTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    offPeakStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("offPeakLoadBalancingAlgorithm"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    offPeakLoadBalancingAlgorithm = new SessionHostLoadBalancingAlgorithm(property.Value.GetString());
                    continue;
                }
            }
            return new ScalingSchedule(name.Value, Optional.ToList(daysOfWeek), Optional.ToNullable(rampUpStartTime), Optional.ToNullable(rampUpLoadBalancingAlgorithm), Optional.ToNullable(rampUpMinimumHostsPct), Optional.ToNullable(rampUpCapacityThresholdPct), Optional.ToNullable(peakStartTime), Optional.ToNullable(peakLoadBalancingAlgorithm), Optional.ToNullable(rampDownStartTime), Optional.ToNullable(rampDownLoadBalancingAlgorithm), Optional.ToNullable(rampDownMinimumHostsPct), Optional.ToNullable(rampDownCapacityThresholdPct), Optional.ToNullable(rampDownForceLogoffUsers), Optional.ToNullable(rampDownStopHostsWhen), Optional.ToNullable(rampDownWaitTimeMinutes), rampDownNotificationMessage.Value, Optional.ToNullable(offPeakStartTime), Optional.ToNullable(offPeakLoadBalancingAlgorithm));
        }
    }
}
