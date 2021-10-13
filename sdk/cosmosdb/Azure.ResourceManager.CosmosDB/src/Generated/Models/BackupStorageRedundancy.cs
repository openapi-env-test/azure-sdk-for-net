// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Enum to indicate type of backup storage redundancy. </summary>
    public readonly partial struct BackupStorageRedundancy : IEquatable<BackupStorageRedundancy>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="BackupStorageRedundancy"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupStorageRedundancy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GeoValue = "Geo";
        private const string LocalValue = "Local";
        private const string ZoneValue = "Zone";

        /// <summary> Geo. </summary>
        public static BackupStorageRedundancy Geo { get; } = new BackupStorageRedundancy(GeoValue);
        /// <summary> Local. </summary>
        public static BackupStorageRedundancy Local { get; } = new BackupStorageRedundancy(LocalValue);
        /// <summary> Zone. </summary>
        public static BackupStorageRedundancy Zone { get; } = new BackupStorageRedundancy(ZoneValue);
        /// <summary> Determines if two <see cref="BackupStorageRedundancy"/> values are the same. </summary>
        public static bool operator ==(BackupStorageRedundancy left, BackupStorageRedundancy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupStorageRedundancy"/> values are not the same. </summary>
        public static bool operator !=(BackupStorageRedundancy left, BackupStorageRedundancy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BackupStorageRedundancy"/>. </summary>
        public static implicit operator BackupStorageRedundancy(string value) => new BackupStorageRedundancy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupStorageRedundancy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupStorageRedundancy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
