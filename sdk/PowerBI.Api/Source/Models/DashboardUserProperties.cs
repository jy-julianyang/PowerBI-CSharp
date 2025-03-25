// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The DashboardUserProperties. </summary>
    public partial class DashboardUserProperties
    {
        /// <summary> Initializes a new instance of <see cref="DashboardUserProperties"/>. </summary>
        public DashboardUserProperties()
        {
            Users = new ChangeTrackingList<DashboardUser>();
        }

        /// <summary> Initializes a new instance of <see cref="DashboardUserProperties"/>. </summary>
        /// <param name="users"> (Empty value) The dashboard user access details. This property will be removed from the payload response in an upcoming release. You can retrieve user information on a Power BI dashboard by using the [Get Dashboard Users as Admin](/rest/api/power-bi/admin/dashboards-get-dashboard-users-as-admin) API call, or the [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call with the `getArtifactUsers` parameter. </param>
        internal DashboardUserProperties(IList<DashboardUser> users)
        {
            Users = users;
        }

        /// <summary> (Empty value) The dashboard user access details. This property will be removed from the payload response in an upcoming release. You can retrieve user information on a Power BI dashboard by using the [Get Dashboard Users as Admin](/rest/api/power-bi/admin/dashboards-get-dashboard-users-as-admin) API call, or the [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call with the `getArtifactUsers` parameter. </summary>
        public IList<DashboardUser> Users { get; }
    }
}
