// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> Source and target items. </summary>
    public partial class DeploymentSourceAndTarget
    {
        /// <summary> Initializes a new instance of <see cref="DeploymentSourceAndTarget"/>. </summary>
        /// <param name="source"> The ID of the Power BI item that's deployed from the source stage. </param>
        internal DeploymentSourceAndTarget(Guid source)
        {
            Source = source;
        }

        /// <summary> Initializes a new instance of <see cref="DeploymentSourceAndTarget"/>. </summary>
        /// <param name="source"> The ID of the Power BI item that's deployed from the source stage. </param>
        /// <param name="sourceDisplayName"> The display name of the Power BI item that's deployed from the source stage. </param>
        /// <param name="target"> The ID of the Power BI item that will be overwritten in the target stage. Only applies when overwriting a Power BI item. </param>
        /// <param name="targetDisplayName"> The name of the Power BI item that will be overwritten in the target stage. Only applies when overwriting a Power BI item. </param>
        /// <param name="type"> The type of the Power BI item that will be overwritten in the target stage. Only applies when overwriting a Power BI item. </param>
        internal DeploymentSourceAndTarget(Guid source, string sourceDisplayName, Guid? target, string targetDisplayName, string type)
        {
            Source = source;
            SourceDisplayName = sourceDisplayName;
            Target = target;
            TargetDisplayName = targetDisplayName;
            Type = type;
        }

        /// <summary> The ID of the Power BI item that's deployed from the source stage. </summary>
        public Guid Source { get; }
        /// <summary> The display name of the Power BI item that's deployed from the source stage. </summary>
        public string SourceDisplayName { get; }
        /// <summary> The ID of the Power BI item that will be overwritten in the target stage. Only applies when overwriting a Power BI item. </summary>
        public Guid? Target { get; }
        /// <summary> The name of the Power BI item that will be overwritten in the target stage. Only applies when overwriting a Power BI item. </summary>
        public string TargetDisplayName { get; }
        /// <summary> The type of the Power BI item that will be overwritten in the target stage. Only applies when overwriting a Power BI item. </summary>
        public string Type { get; }
    }
}
