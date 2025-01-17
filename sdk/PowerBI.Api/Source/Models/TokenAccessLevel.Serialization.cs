// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class TokenAccessLevelExtensions
    {
        public static string ToSerialString(this TokenAccessLevel value) => value switch
        {
            TokenAccessLevel.View => "View",
            TokenAccessLevel.Edit => "Edit",
            TokenAccessLevel.Create => "Create",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TokenAccessLevel value.")
        };

        public static TokenAccessLevel ToTokenAccessLevel(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "View")) return TokenAccessLevel.View;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Edit")) return TokenAccessLevel.Edit;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Create")) return TokenAccessLevel.Create;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TokenAccessLevel value.");
        }
    }
}
