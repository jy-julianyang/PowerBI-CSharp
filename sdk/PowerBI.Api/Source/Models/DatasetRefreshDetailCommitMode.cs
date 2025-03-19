// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> Determines if objects will be committed in batches or only when complete. </summary>
    public readonly partial struct DatasetRefreshDetailCommitMode : IEquatable<DatasetRefreshDetailCommitMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DatasetRefreshDetailCommitMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatasetRefreshDetailCommitMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TransactionalValue = "Transactional";
        private const string PartialBatchValue = "PartialBatch";

        /// <summary> Commit the whole refresh operation as a transaction. </summary>
        public static DatasetRefreshDetailCommitMode Transactional { get; } = new DatasetRefreshDetailCommitMode(TransactionalValue);
        /// <summary> Commit the refresh operation in batches. </summary>
        public static DatasetRefreshDetailCommitMode PartialBatch { get; } = new DatasetRefreshDetailCommitMode(PartialBatchValue);
        /// <summary> Determines if two <see cref="DatasetRefreshDetailCommitMode"/> values are the same. </summary>
        public static bool operator ==(DatasetRefreshDetailCommitMode left, DatasetRefreshDetailCommitMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatasetRefreshDetailCommitMode"/> values are not the same. </summary>
        public static bool operator !=(DatasetRefreshDetailCommitMode left, DatasetRefreshDetailCommitMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DatasetRefreshDetailCommitMode"/>. </summary>
        public static implicit operator DatasetRefreshDetailCommitMode(string value) => new DatasetRefreshDetailCommitMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatasetRefreshDetailCommitMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatasetRefreshDetailCommitMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
