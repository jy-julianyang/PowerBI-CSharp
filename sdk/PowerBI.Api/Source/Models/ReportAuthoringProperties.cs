// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The ReportAuthoringProperties. </summary>
    public partial class ReportAuthoringProperties
    {
        /// <summary> Initializes a new instance of <see cref="ReportAuthoringProperties"/>. </summary>
        public ReportAuthoringProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReportAuthoringProperties"/>. </summary>
        /// <param name="createdBy"> The report owner. Available only for reports created after June 2019. </param>
        /// <param name="modifiedBy"> The last user that modified the report. </param>
        /// <param name="createdDateTime"> The report creation date and time. </param>
        /// <param name="modifiedDateTime"> The date and time that the report was last modified. </param>
        internal ReportAuthoringProperties(string createdBy, string modifiedBy, DateTimeOffset? createdDateTime, DateTimeOffset? modifiedDateTime)
        {
            CreatedBy = createdBy;
            ModifiedBy = modifiedBy;
            CreatedDateTime = createdDateTime;
            ModifiedDateTime = modifiedDateTime;
        }

        /// <summary> The report owner. Available only for reports created after June 2019. </summary>
        public string CreatedBy { get; set; }
        /// <summary> The last user that modified the report. </summary>
        public string ModifiedBy { get; set; }
        /// <summary> The report creation date and time. </summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary> The date and time that the report was last modified. </summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
    }
}
