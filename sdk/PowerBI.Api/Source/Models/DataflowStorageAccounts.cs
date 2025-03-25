// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> OData response wrapper for Power BI dataflow storage account list. </summary>
    public partial class DataflowStorageAccounts
    {
        /// <summary> Initializes a new instance of <see cref="DataflowStorageAccounts"/>. </summary>
        internal DataflowStorageAccounts()
        {
            Value = new ChangeTrackingList<DataflowStorageAccount>();
        }

        /// <summary> Initializes a new instance of <see cref="DataflowStorageAccounts"/>. </summary>
        /// <param name="odataContext"></param>
        /// <param name="value"> The Power BI dataflow storage account list. </param>
        internal DataflowStorageAccounts(string odataContext, IReadOnlyList<DataflowStorageAccount> value)
        {
            OdataContext = odataContext;
            Value = value;
        }

        /// <summary> Gets the odata context. </summary>
        public string OdataContext { get; }
        /// <summary> The Power BI dataflow storage account list. </summary>
        public IReadOnlyList<DataflowStorageAccount> Value { get; }
    }
}
