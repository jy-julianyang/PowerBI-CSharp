// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> OData response wrapper for audit activity events list. </summary>
    public partial class ActivityEventResponse
    {
        /// <summary> Initializes a new instance of <see cref="ActivityEventResponse"/>. </summary>
        internal ActivityEventResponse()
        {
            ActivityEventEntities = new ChangeTrackingList<object>();
        }

        /// <summary> Initializes a new instance of <see cref="ActivityEventResponse"/>. </summary>
        /// <param name="activityEventEntities"> An array of activity event objects. To learn more about an activity event (which is a collection of event properties) refer to [Microsoft 365 Management Activity schema](https://learn.microsoft.com/en-us/office/office-365-management-api/office-365-management-activity-api-schema#power-bi-schema). </param>
        /// <param name="continuationUri"> The URI for the next chunk in the result set. </param>
        /// <param name="continuationToken"> Token to get the next chunk of the result set. </param>
        internal ActivityEventResponse(IReadOnlyList<object> activityEventEntities, string continuationUri, string continuationToken)
        {
            ActivityEventEntities = activityEventEntities;
            ContinuationUri = continuationUri;
            ContinuationToken = continuationToken;
        }

        /// <summary> An array of activity event objects. To learn more about an activity event (which is a collection of event properties) refer to [Microsoft 365 Management Activity schema](https://learn.microsoft.com/en-us/office/office-365-management-api/office-365-management-activity-api-schema#power-bi-schema). </summary>
        public IReadOnlyList<object> ActivityEventEntities { get; }
        /// <summary> The URI for the next chunk in the result set. </summary>
        public string ContinuationUri { get; }
        /// <summary> Token to get the next chunk of the result set. </summary>
        public string ContinuationToken { get; }
    }
}
