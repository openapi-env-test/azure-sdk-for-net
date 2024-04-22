// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The value indicating whether the metadata is required or not. </summary>
    public readonly partial struct DaprMetadataRequired : IEquatable<DaprMetadataRequired>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DaprMetadataRequired"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DaprMetadataRequired(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "true";
        private const string FalseValue = "false";

        /// <summary> true. </summary>
        public static DaprMetadataRequired True { get; } = new DaprMetadataRequired(TrueValue);
        /// <summary> false. </summary>
        public static DaprMetadataRequired False { get; } = new DaprMetadataRequired(FalseValue);
        /// <summary> Determines if two <see cref="DaprMetadataRequired"/> values are the same. </summary>
        public static bool operator ==(DaprMetadataRequired left, DaprMetadataRequired right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DaprMetadataRequired"/> values are not the same. </summary>
        public static bool operator !=(DaprMetadataRequired left, DaprMetadataRequired right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DaprMetadataRequired"/>. </summary>
        public static implicit operator DaprMetadataRequired(string value) => new DaprMetadataRequired(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DaprMetadataRequired other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DaprMetadataRequired other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
