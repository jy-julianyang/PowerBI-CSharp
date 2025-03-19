// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The WorkspaceInfoDataflowProperties. </summary>
    public partial class WorkspaceInfoDataflowProperties
    {
        /// <summary> Initializes a new instance of <see cref="WorkspaceInfoDataflowProperties"/>. </summary>
        public WorkspaceInfoDataflowProperties()
        {
            DatasourceUsages = new ChangeTrackingList<DatasourceUsage>();
            MisconfiguredDatasourceUsages = new ChangeTrackingList<DatasourceUsage>();
            UpstreamDataflows = new ChangeTrackingList<DependentDataflow>();
            UpstreamDatamarts = new ChangeTrackingList<DependentDatamart>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceInfoDataflowProperties"/>. </summary>
        /// <param name="datasourceUsages"> The data source usages. </param>
        /// <param name="misconfiguredDatasourceUsages"> The data source misconfigured usages. </param>
        /// <param name="upstreamDataflows"> The list of all the dataflows this item depends on. </param>
        /// <param name="upstreamDatamarts"> The list of all the datamarts this item depends on. </param>
        internal WorkspaceInfoDataflowProperties(IList<DatasourceUsage> datasourceUsages, IList<DatasourceUsage> misconfiguredDatasourceUsages, IList<DependentDataflow> upstreamDataflows, IList<DependentDatamart> upstreamDatamarts)
        {
            DatasourceUsages = datasourceUsages;
            MisconfiguredDatasourceUsages = misconfiguredDatasourceUsages;
            UpstreamDataflows = upstreamDataflows;
            UpstreamDatamarts = upstreamDatamarts;
        }

        /// <summary> The data source usages. </summary>
        public IList<DatasourceUsage> DatasourceUsages { get; }
        /// <summary> The data source misconfigured usages. </summary>
        public IList<DatasourceUsage> MisconfiguredDatasourceUsages { get; }
        /// <summary> The list of all the dataflows this item depends on. </summary>
        public IList<DependentDataflow> UpstreamDataflows { get; }
        /// <summary> The list of all the datamarts this item depends on. </summary>
        public IList<DependentDatamart> UpstreamDatamarts { get; }
    }
}
