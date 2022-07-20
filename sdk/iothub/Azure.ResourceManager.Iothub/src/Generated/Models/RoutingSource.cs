// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Iothub.Models
{
    /// <summary> The source that the routing rule is to be applied to, such as DeviceMessages. </summary>
    public readonly partial struct RoutingSource : IEquatable<RoutingSource>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoutingSource"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoutingSource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string DeviceMessagesValue = "DeviceMessages";
        private const string TwinChangeEventsValue = "TwinChangeEvents";
        private const string DeviceLifecycleEventsValue = "DeviceLifecycleEvents";
        private const string DeviceJobLifecycleEventsValue = "DeviceJobLifecycleEvents";
        private const string DigitalTwinChangeEventsValue = "DigitalTwinChangeEvents";
        private const string DeviceConnectionStateEventsValue = "DeviceConnectionStateEvents";
        private const string MqttBrokerMessagesValue = "MqttBrokerMessages";

        /// <summary> Invalid. </summary>
        public static RoutingSource Invalid { get; } = new RoutingSource(InvalidValue);
        /// <summary> DeviceMessages. </summary>
        public static RoutingSource DeviceMessages { get; } = new RoutingSource(DeviceMessagesValue);
        /// <summary> TwinChangeEvents. </summary>
        public static RoutingSource TwinChangeEvents { get; } = new RoutingSource(TwinChangeEventsValue);
        /// <summary> DeviceLifecycleEvents. </summary>
        public static RoutingSource DeviceLifecycleEvents { get; } = new RoutingSource(DeviceLifecycleEventsValue);
        /// <summary> DeviceJobLifecycleEvents. </summary>
        public static RoutingSource DeviceJobLifecycleEvents { get; } = new RoutingSource(DeviceJobLifecycleEventsValue);
        /// <summary> DigitalTwinChangeEvents. </summary>
        public static RoutingSource DigitalTwinChangeEvents { get; } = new RoutingSource(DigitalTwinChangeEventsValue);
        /// <summary> DeviceConnectionStateEvents. </summary>
        public static RoutingSource DeviceConnectionStateEvents { get; } = new RoutingSource(DeviceConnectionStateEventsValue);
        /// <summary> MqttBrokerMessages. </summary>
        public static RoutingSource MqttBrokerMessages { get; } = new RoutingSource(MqttBrokerMessagesValue);
        /// <summary> Determines if two <see cref="RoutingSource"/> values are the same. </summary>
        public static bool operator ==(RoutingSource left, RoutingSource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoutingSource"/> values are not the same. </summary>
        public static bool operator !=(RoutingSource left, RoutingSource right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RoutingSource"/>. </summary>
        public static implicit operator RoutingSource(string value) => new RoutingSource(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoutingSource other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoutingSource other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
