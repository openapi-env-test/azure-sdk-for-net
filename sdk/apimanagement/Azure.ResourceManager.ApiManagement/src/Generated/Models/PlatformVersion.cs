// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Compute Platform Version running the service. </summary>
    public readonly partial struct PlatformVersion : IEquatable<PlatformVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PlatformVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PlatformVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UndeterminedValue = "undetermined";
        private const string Stv1Value = "stv1";
        private const string Stv2Value = "stv2";
        private const string Mtv1Value = "mtv1";
        private const string Stv21Value = "stv2.1";

        /// <summary> Platform version cannot be determined, as compute platform is not deployed. </summary>
        public static PlatformVersion Undetermined { get; } = new PlatformVersion(UndeterminedValue);
        /// <summary> Platform running the service on Single Tenant V1 platform. </summary>
        public static PlatformVersion Stv1 { get; } = new PlatformVersion(Stv1Value);
        /// <summary> Platform running the service on Single Tenant V2 platform. </summary>
        public static PlatformVersion Stv2 { get; } = new PlatformVersion(Stv2Value);
        /// <summary> Platform running the service on Multi Tenant V1 platform. </summary>
        public static PlatformVersion Mtv1 { get; } = new PlatformVersion(Mtv1Value);
        /// <summary> Platform running the service on Single Tenant V2 platform on newer Hardware. </summary>
        public static PlatformVersion Stv21 { get; } = new PlatformVersion(Stv21Value);
        /// <summary> Determines if two <see cref="PlatformVersion"/> values are the same. </summary>
        public static bool operator ==(PlatformVersion left, PlatformVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PlatformVersion"/> values are not the same. </summary>
        public static bool operator !=(PlatformVersion left, PlatformVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PlatformVersion"/>. </summary>
        public static implicit operator PlatformVersion(string value) => new PlatformVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PlatformVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PlatformVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
