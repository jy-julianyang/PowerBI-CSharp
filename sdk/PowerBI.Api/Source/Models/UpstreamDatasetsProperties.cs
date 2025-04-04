// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The UpstreamDatasetsProperties. </summary>
    public partial class UpstreamDatasetsProperties
    {
        /// <summary> Initializes a new instance of <see cref="UpstreamDatasetsProperties"/>. </summary>
        public UpstreamDatasetsProperties()
        {
            UpstreamDatasets = new ChangeTrackingList<DependentDataset>();
        }

        /// <summary> Initializes a new instance of <see cref="UpstreamDatasetsProperties"/>. </summary>
        /// <param name="upstreamDatasets"> The upstream datasets. </param>
        internal UpstreamDatasetsProperties(IList<DependentDataset> upstreamDatasets)
        {
            UpstreamDatasets = upstreamDatasets;
        }

        /// <summary> The upstream datasets. </summary>
        public IList<DependentDataset> UpstreamDatasets { get; }
    }
}
