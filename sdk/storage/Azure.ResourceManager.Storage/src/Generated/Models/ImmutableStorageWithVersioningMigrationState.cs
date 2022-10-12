// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> This property denotes the container level immutability to object level immutability migration state. </summary>
    public readonly partial struct ImmutableStorageWithVersioningMigrationState : IEquatable<ImmutableStorageWithVersioningMigrationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImmutableStorageWithVersioningMigrationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImmutableStorageWithVersioningMigrationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string CompletedValue = "Completed";

        /// <summary> InProgress. </summary>
        public static ImmutableStorageWithVersioningMigrationState InProgress { get; } = new ImmutableStorageWithVersioningMigrationState(InProgressValue);
        /// <summary> Completed. </summary>
        public static ImmutableStorageWithVersioningMigrationState Completed { get; } = new ImmutableStorageWithVersioningMigrationState(CompletedValue);
        /// <summary> Determines if two <see cref="ImmutableStorageWithVersioningMigrationState"/> values are the same. </summary>
        public static bool operator ==(ImmutableStorageWithVersioningMigrationState left, ImmutableStorageWithVersioningMigrationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImmutableStorageWithVersioningMigrationState"/> values are not the same. </summary>
        public static bool operator !=(ImmutableStorageWithVersioningMigrationState left, ImmutableStorageWithVersioningMigrationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ImmutableStorageWithVersioningMigrationState"/>. </summary>
        public static implicit operator ImmutableStorageWithVersioningMigrationState(string value) => new ImmutableStorageWithVersioningMigrationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImmutableStorageWithVersioningMigrationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImmutableStorageWithVersioningMigrationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
