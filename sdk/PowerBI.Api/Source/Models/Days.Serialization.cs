// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class DaysExtensions
    {
        public static string ToSerialString(this Days value) => value switch
        {
            Days.Monday => "Monday",
            Days.Tuesday => "Tuesday",
            Days.Wednesday => "Wednesday",
            Days.Thursday => "Thursday",
            Days.Friday => "Friday",
            Days.Saturday => "Saturday",
            Days.Sunday => "Sunday",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Days value.")
        };

        public static Days ToDays(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Monday")) return Days.Monday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Tuesday")) return Days.Tuesday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Wednesday")) return Days.Wednesday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Thursday")) return Days.Thursday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Friday")) return Days.Friday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Saturday")) return Days.Saturday;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Sunday")) return Days.Sunday;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Days value.");
        }
    }
}
