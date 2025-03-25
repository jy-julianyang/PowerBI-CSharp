// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The details of an error, if present. </summary>
    public partial class DatasetExecuteQueriesError
    {
        /// <summary> Initializes a new instance of <see cref="DatasetExecuteQueriesError"/>. </summary>
        internal DatasetExecuteQueriesError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatasetExecuteQueriesError"/>. </summary>
        /// <param name="code"> The code associated with the error. </param>
        /// <param name="message"> The message of the error. If not present here, this information my also be found in details object nested under the error object. </param>
        internal DatasetExecuteQueriesError(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> The code associated with the error. </summary>
        public string Code { get; }
        /// <summary> The message of the error. If not present here, this information my also be found in details object nested under the error object. </summary>
        public string Message { get; }
    }
}
