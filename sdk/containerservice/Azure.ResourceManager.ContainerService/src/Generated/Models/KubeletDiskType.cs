// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> KubeletDiskType determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral storage. Currently allows one value, OS, resulting in Kubelet using the OS disk for data. </summary>
    public readonly partial struct KubeletDiskType : IEquatable<KubeletDiskType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="KubeletDiskType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KubeletDiskType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OSValue = "OS";

        /// <summary> OS. </summary>
        public static KubeletDiskType OS { get; } = new KubeletDiskType(OSValue);
        /// <summary> Determines if two <see cref="KubeletDiskType"/> values are the same. </summary>
        public static bool operator ==(KubeletDiskType left, KubeletDiskType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KubeletDiskType"/> values are not the same. </summary>
        public static bool operator !=(KubeletDiskType left, KubeletDiskType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KubeletDiskType"/>. </summary>
        public static implicit operator KubeletDiskType(string value) => new KubeletDiskType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KubeletDiskType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KubeletDiskType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
