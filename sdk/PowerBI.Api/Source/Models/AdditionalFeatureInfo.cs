// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> Additional feature information. </summary>
    public partial class AdditionalFeatureInfo
    {
        /// <summary> Initializes a new instance of <see cref="AdditionalFeatureInfo"/>. </summary>
        internal AdditionalFeatureInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AdditionalFeatureInfo"/>. </summary>
        /// <param name="usage"> Workspaces that aren't assigned to a capacity get a limited amount of [embed tokens](/power-bi/developer/embedded/embed-tokens#embed-token), to allow experimenting with the APIs. The `Usage` value represents the percentage of embed tokens that have been consumed. The `Usage` value only applies to the **embed trial** feature. For more information, see [Development testing](/power-bi/developer/embedded/move-to-production#development-testing). </param>
        internal AdditionalFeatureInfo(int? usage)
        {
            Usage = usage;
        }

        /// <summary> Workspaces that aren't assigned to a capacity get a limited amount of [embed tokens](/power-bi/developer/embedded/embed-tokens#embed-token), to allow experimenting with the APIs. The `Usage` value represents the percentage of embed tokens that have been consumed. The `Usage` value only applies to the **embed trial** feature. For more information, see [Development testing](/power-bi/developer/embedded/move-to-production#development-testing). </summary>
        public int? Usage { get; }
    }
}
