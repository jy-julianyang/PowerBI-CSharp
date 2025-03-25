// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class DatasetModeExtensions
    {
        public static string ToSerialString(this DatasetMode value) => value switch
        {
            DatasetMode.AsAzure => "AsAzure",
            DatasetMode.AsOnPrem => "AsOnPrem",
            DatasetMode.Push => "Push",
            DatasetMode.Streaming => "Streaming",
            DatasetMode.PushStreaming => "PushStreaming",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DatasetMode value.")
        };

        public static DatasetMode ToDatasetMode(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AsAzure")) return DatasetMode.AsAzure;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AsOnPrem")) return DatasetMode.AsOnPrem;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Push")) return DatasetMode.Push;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Streaming")) return DatasetMode.Streaming;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PushStreaming")) return DatasetMode.PushStreaming;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DatasetMode value.");
        }
    }
}
