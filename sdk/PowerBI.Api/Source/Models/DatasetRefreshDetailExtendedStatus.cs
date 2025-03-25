// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> Dataset operation detailed status. </summary>
    public readonly partial struct DatasetRefreshDetailExtendedStatus : IEquatable<DatasetRefreshDetailExtendedStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DatasetRefreshDetailExtendedStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatasetRefreshDetailExtendedStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string NotStartedValue = "NotStarted";
        private const string InProgressValue = "InProgress";
        private const string CompletedValue = "Completed";
        private const string TimedOutValue = "TimedOut";
        private const string FailedValue = "Failed";
        private const string DisabledValue = "Disabled";
        private const string CancelledValue = "Cancelled";

        /// <summary> The completion state is unknown. </summary>
        public static DatasetRefreshDetailExtendedStatus Unknown { get; } = new DatasetRefreshDetailExtendedStatus(UnknownValue);
        /// <summary> The refresh operation isn't started. </summary>
        public static DatasetRefreshDetailExtendedStatus NotStarted { get; } = new DatasetRefreshDetailExtendedStatus(NotStartedValue);
        /// <summary> The refresh operation is in progress. </summary>
        public static DatasetRefreshDetailExtendedStatus InProgress { get; } = new DatasetRefreshDetailExtendedStatus(InProgressValue);
        /// <summary> The refresh operation is successfully completed. </summary>
        public static DatasetRefreshDetailExtendedStatus Completed { get; } = new DatasetRefreshDetailExtendedStatus(CompletedValue);
        /// <summary> The refresh operation is timed out. </summary>
        public static DatasetRefreshDetailExtendedStatus TimedOut { get; } = new DatasetRefreshDetailExtendedStatus(TimedOutValue);
        /// <summary> The refresh operation is unsuccessful. </summary>
        public static DatasetRefreshDetailExtendedStatus Failed { get; } = new DatasetRefreshDetailExtendedStatus(FailedValue);
        /// <summary> The refresh operation is disabled by a selective refresh. </summary>
        public static DatasetRefreshDetailExtendedStatus Disabled { get; } = new DatasetRefreshDetailExtendedStatus(DisabledValue);
        /// <summary> The refresh operation has been cancelled by customer. </summary>
        public static DatasetRefreshDetailExtendedStatus Cancelled { get; } = new DatasetRefreshDetailExtendedStatus(CancelledValue);
        /// <summary> Determines if two <see cref="DatasetRefreshDetailExtendedStatus"/> values are the same. </summary>
        public static bool operator ==(DatasetRefreshDetailExtendedStatus left, DatasetRefreshDetailExtendedStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatasetRefreshDetailExtendedStatus"/> values are not the same. </summary>
        public static bool operator !=(DatasetRefreshDetailExtendedStatus left, DatasetRefreshDetailExtendedStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DatasetRefreshDetailExtendedStatus"/>. </summary>
        public static implicit operator DatasetRefreshDetailExtendedStatus(string value) => new DatasetRefreshDetailExtendedStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatasetRefreshDetailExtendedStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatasetRefreshDetailExtendedStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
