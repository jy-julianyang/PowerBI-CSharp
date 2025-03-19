// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI refreshable is a dataset that's been refreshed at least once, or for which a valid refresh schedule exists. If a dataset doesn't meet either of these conditions, then it won't show up in the API response. Power BI retains a seven-day refresh history for each dataset, up to a maximum of sixty refreshes. </summary>
    public partial class Refreshable
    {
        /// <summary> Initializes a new instance of <see cref="Refreshable"/>. </summary>
        internal Refreshable()
        {
            ConfiguredBy = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="Refreshable"/>. </summary>
        /// <param name="id"> The object ID of the refreshable. </param>
        /// <param name="name"> The display name of the refreshable. </param>
        /// <param name="kind"> The refreshable kind. </param>
        /// <param name="startTime"> The start time of the window for which refresh data exists in UTC format. </param>
        /// <param name="endTime"> The end time of the window for which refresh data exists in UTC format. </param>
        /// <param name="refreshCount"> The number of refreshes within the time window for which refresh data exists. </param>
        /// <param name="refreshFailures"> The number of refresh failures within the time window for which refresh data exists. </param>
        /// <param name="averageDuration"> The average duration in seconds of a refresh during the time window for which refresh data exists. </param>
        /// <param name="medianDuration"> The median duration in seconds of a refresh within the time window for which refresh data exists. </param>
        /// <param name="refreshesPerDay"> The number of refreshes per day (scheduled and on-demand) within the time window for which refresh data exists. </param>
        /// <param name="lastRefresh"> The last Power BI refresh history entry for the refreshable item. </param>
        /// <param name="refreshSchedule"> The refresh schedule for the refreshable item. </param>
        /// <param name="configuredBy"> The refreshable owners. </param>
        /// <param name="capacity"> The capacity for the refreshable item. </param>
        /// <param name="group"> The associated group for the refreshable item. </param>
        internal Refreshable(string id, string name, RefreshableKind? kind, DateTimeOffset? startTime, DateTimeOffset? endTime, int? refreshCount, int? refreshFailures, float? averageDuration, float? medianDuration, int? refreshesPerDay, Refresh lastRefresh, RefreshSchedule refreshSchedule, IReadOnlyList<string> configuredBy, Capacity capacity, RefreshableGroup group)
        {
            Id = id;
            Name = name;
            Kind = kind;
            StartTime = startTime;
            EndTime = endTime;
            RefreshCount = refreshCount;
            RefreshFailures = refreshFailures;
            AverageDuration = averageDuration;
            MedianDuration = medianDuration;
            RefreshesPerDay = refreshesPerDay;
            LastRefresh = lastRefresh;
            RefreshSchedule = refreshSchedule;
            ConfiguredBy = configuredBy;
            Capacity = capacity;
            Group = group;
        }

        /// <summary> The object ID of the refreshable. </summary>
        public string Id { get; }
        /// <summary> The display name of the refreshable. </summary>
        public string Name { get; }
        /// <summary> The refreshable kind. </summary>
        public RefreshableKind? Kind { get; }
        /// <summary> The start time of the window for which refresh data exists in UTC format. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The end time of the window for which refresh data exists in UTC format. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> The number of refreshes within the time window for which refresh data exists. </summary>
        public int? RefreshCount { get; }
        /// <summary> The number of refresh failures within the time window for which refresh data exists. </summary>
        public int? RefreshFailures { get; }
        /// <summary> The average duration in seconds of a refresh during the time window for which refresh data exists. </summary>
        public float? AverageDuration { get; }
        /// <summary> The median duration in seconds of a refresh within the time window for which refresh data exists. </summary>
        public float? MedianDuration { get; }
        /// <summary> The number of refreshes per day (scheduled and on-demand) within the time window for which refresh data exists. </summary>
        public int? RefreshesPerDay { get; }
        /// <summary> The last Power BI refresh history entry for the refreshable item. </summary>
        public Refresh LastRefresh { get; }
        /// <summary> The refresh schedule for the refreshable item. </summary>
        public RefreshSchedule RefreshSchedule { get; }
        /// <summary> The refreshable owners. </summary>
        public IReadOnlyList<string> ConfiguredBy { get; }
        /// <summary> The capacity for the refreshable item. </summary>
        public Capacity Capacity { get; }
        /// <summary> The associated group for the refreshable item. </summary>
        public RefreshableGroup Group { get; }
    }
}
