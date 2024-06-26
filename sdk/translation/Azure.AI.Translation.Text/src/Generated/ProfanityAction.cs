// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Translation.Text
{
    /// <summary> Translator profanity actions. </summary>
    public readonly partial struct ProfanityAction : IEquatable<ProfanityAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProfanityAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProfanityAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoActionValue = "NoAction";
        private const string MarkedValue = "Marked";
        private const string DeletedValue = "Deleted";

        /// <summary> NoAction. </summary>
        public static ProfanityAction NoAction { get; } = new ProfanityAction(NoActionValue);
        /// <summary> Marked. </summary>
        public static ProfanityAction Marked { get; } = new ProfanityAction(MarkedValue);
        /// <summary> Deleted. </summary>
        public static ProfanityAction Deleted { get; } = new ProfanityAction(DeletedValue);
        /// <summary> Determines if two <see cref="ProfanityAction"/> values are the same. </summary>
        public static bool operator ==(ProfanityAction left, ProfanityAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProfanityAction"/> values are not the same. </summary>
        public static bool operator !=(ProfanityAction left, ProfanityAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProfanityAction"/>. </summary>
        public static implicit operator ProfanityAction(string value) => new ProfanityAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProfanityAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProfanityAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
