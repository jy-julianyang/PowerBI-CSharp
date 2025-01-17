// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A request to update dataflow information. </summary>
    public partial class DataflowUpdateRequestMessage
    {
        /// <summary> Initializes a new instance of <see cref="DataflowUpdateRequestMessage"/>. </summary>
        public DataflowUpdateRequestMessage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataflowUpdateRequestMessage"/>. </summary>
        /// <param name="name"> The new name for the dataflow. </param>
        /// <param name="description"> The new description for the dataflow. </param>
        /// <param name="allowNativeQueries"> Whether to allow native queries. </param>
        /// <param name="computeEngineBehavior"> The behavior of the compute engine. </param>
        internal DataflowUpdateRequestMessage(string name, string description, bool? allowNativeQueries, DataflowUpdateRequestMessageComputeEngineBehavior? computeEngineBehavior)
        {
            Name = name;
            Description = description;
            AllowNativeQueries = allowNativeQueries;
            ComputeEngineBehavior = computeEngineBehavior;
        }

        /// <summary> The new name for the dataflow. </summary>
        public string Name { get; set; }
        /// <summary> The new description for the dataflow. </summary>
        public string Description { get; set; }
        /// <summary> Whether to allow native queries. </summary>
        public bool? AllowNativeQueries { get; set; }
        /// <summary> The behavior of the compute engine. </summary>
        public DataflowUpdateRequestMessageComputeEngineBehavior? ComputeEngineBehavior { get; set; }
    }
}
