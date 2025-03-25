// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI user access right entry for a report. </summary>
    public partial class DatamartUser : User
    {
        /// <summary> Initializes a new instance of <see cref="DatamartUser"/>. </summary>
        /// <param name="identifier"> Identifier of the principal. </param>
        /// <param name="principalType"> The principal type. </param>
        /// <param name="datamartUserAccessRight"> The access right that the user has for the datamart (permission level). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identifier"/> is null. </exception>
        public DatamartUser(string identifier, PrincipalType principalType, DatamartUserAccessRight datamartUserAccessRight) : base(identifier, principalType)
        {
            Argument.AssertNotNull(identifier, nameof(identifier));

            DatamartUserAccessRight = datamartUserAccessRight;
        }

        /// <summary> Initializes a new instance of <see cref="DatamartUser"/>. </summary>
        /// <param name="emailAddress"> Email address of the user. </param>
        /// <param name="displayName"> Display name of the principal. </param>
        /// <param name="identifier"> Identifier of the principal. </param>
        /// <param name="graphId"> Identifier of the principal in Microsoft Graph. Only available for admin APIs. </param>
        /// <param name="userType"> Type of the user. </param>
        /// <param name="principalType"> The principal type. </param>
        /// <param name="profile"> A Power BI service principal profile. Only relevant for [Power BI Embedded multi-tenancy solution](/power-bi/developer/embedded/embed-multi-tenancy). </param>
        /// <param name="datamartUserAccessRight"> The access right that the user has for the datamart (permission level). </param>
        internal DatamartUser(string emailAddress, string displayName, string identifier, string graphId, string userType, PrincipalType principalType, ServicePrincipalProfile profile, DatamartUserAccessRight datamartUserAccessRight) : base(emailAddress, displayName, identifier, graphId, userType, principalType, profile)
        {
            DatamartUserAccessRight = datamartUserAccessRight;
        }

        /// <summary> The access right that the user has for the datamart (permission level). </summary>
        public DatamartUserAccessRight DatamartUserAccessRight { get; set; }
    }
}
