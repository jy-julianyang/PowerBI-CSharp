// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI request to restore a deleted group. </summary>
    public partial class GroupRestoreRequest
    {
        /// <summary> Initializes a new instance of <see cref="GroupRestoreRequest"/>. </summary>
        /// <param name="emailAddress"> The email address of the owner of the group to be restored. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="emailAddress"/> is null. </exception>
        public GroupRestoreRequest(string emailAddress)
        {
            Argument.AssertNotNull(emailAddress, nameof(emailAddress));

            EmailAddress = emailAddress;
        }

        /// <summary> Initializes a new instance of <see cref="GroupRestoreRequest"/>. </summary>
        /// <param name="name"> The name of the group to be restored. </param>
        /// <param name="emailAddress"> The email address of the owner of the group to be restored. </param>
        internal GroupRestoreRequest(string name, string emailAddress)
        {
            Name = name;
            EmailAddress = emailAddress;
        }

        /// <summary> The name of the group to be restored. </summary>
        public string Name { get; set; }
        /// <summary> The email address of the owner of the group to be restored. </summary>
        public string EmailAddress { get; }
    }
}
