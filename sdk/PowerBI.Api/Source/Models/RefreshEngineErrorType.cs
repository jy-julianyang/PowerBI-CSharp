// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The type of the error. </summary>
    public readonly partial struct RefreshEngineErrorType : IEquatable<RefreshEngineErrorType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RefreshEngineErrorType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RefreshEngineErrorType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string WarningValue = "Warning";

        /// <summary> Error message. </summary>
        public static RefreshEngineErrorType Error { get; } = new RefreshEngineErrorType(ErrorValue);
        /// <summary> Warning message. </summary>
        public static RefreshEngineErrorType Warning { get; } = new RefreshEngineErrorType(WarningValue);
        /// <summary> Determines if two <see cref="RefreshEngineErrorType"/> values are the same. </summary>
        public static bool operator ==(RefreshEngineErrorType left, RefreshEngineErrorType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RefreshEngineErrorType"/> values are not the same. </summary>
        public static bool operator !=(RefreshEngineErrorType left, RefreshEngineErrorType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RefreshEngineErrorType"/>. </summary>
        public static implicit operator RefreshEngineErrorType(string value) => new RefreshEngineErrorType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RefreshEngineErrorType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RefreshEngineErrorType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
