// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> Power BI report common properties. The API returns a subset of the following list of report properties. The subset depends on the API called, caller permissions, and the availability of data in the Power BI database. </summary>
    public partial class ReportBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="ReportBaseProperties"/>. </summary>
        /// <param name="id"> The report ID. </param>
        public ReportBaseProperties(Guid id)
        {
            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="ReportBaseProperties"/>. </summary>
        /// <param name="id"> The report ID. </param>
        /// <param name="name"> The name of the report. App reports has prefix [App]. </param>
        /// <param name="datasetId"> The dataset ID of the report. </param>
        /// <param name="appId"> The app ID, returned only if the report belongs to an app. </param>
        /// <param name="description"> The report description. </param>
        /// <param name="reportType"> The report type. </param>
        /// <param name="originalReportId"> The actual report ID when the workspace is published as an app. </param>
        /// <param name="isOwnedByMe"> Indicates whether the current user has the ability to either modify or create a copy of the report. </param>
        internal ReportBaseProperties(Guid id, string name, string datasetId, string appId, string description, ReportBasePropertiesReportType? reportType, Guid? originalReportId, bool? isOwnedByMe)
        {
            Id = id;
            Name = name;
            DatasetId = datasetId;
            AppId = appId;
            Description = description;
            ReportType = reportType;
            OriginalReportId = originalReportId;
            IsOwnedByMe = isOwnedByMe;
        }

        /// <summary> The report ID. </summary>
        public Guid Id { get; set; }
        /// <summary> The name of the report. App reports has prefix [App]. </summary>
        public string Name { get; set; }
        /// <summary> The dataset ID of the report. </summary>
        public string DatasetId { get; set; }
        /// <summary> The app ID, returned only if the report belongs to an app. </summary>
        public string AppId { get; set; }
        /// <summary> The report description. </summary>
        public string Description { get; set; }
        /// <summary> The report type. </summary>
        public ReportBasePropertiesReportType? ReportType { get; set; }
        /// <summary> The actual report ID when the workspace is published as an app. </summary>
        public Guid? OriginalReportId { get; set; }
        /// <summary> Indicates whether the current user has the ability to either modify or create a copy of the report. </summary>
        public bool? IsOwnedByMe { get; set; }
    }
}
