// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The PolicyFragmentContentFormat. </summary>
    public readonly partial struct PolicyFragmentContentFormat : IEquatable<PolicyFragmentContentFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PolicyFragmentContentFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PolicyFragmentContentFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string XmlValue = "xml";
        private const string RawxmlValue = "rawxml";

        /// <summary> The contents are inline and Content type is an XML document. </summary>
        public static PolicyFragmentContentFormat Xml { get; } = new PolicyFragmentContentFormat(XmlValue);
        /// <summary> The contents are inline and Content type is a non XML encoded policy document. </summary>
        public static PolicyFragmentContentFormat Rawxml { get; } = new PolicyFragmentContentFormat(RawxmlValue);
        /// <summary> Determines if two <see cref="PolicyFragmentContentFormat"/> values are the same. </summary>
        public static bool operator ==(PolicyFragmentContentFormat left, PolicyFragmentContentFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolicyFragmentContentFormat"/> values are not the same. </summary>
        public static bool operator !=(PolicyFragmentContentFormat left, PolicyFragmentContentFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PolicyFragmentContentFormat"/>. </summary>
        public static implicit operator PolicyFragmentContentFormat(string value) => new PolicyFragmentContentFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolicyFragmentContentFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolicyFragmentContentFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
