// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class GroupTypeExtensions
    {
        public static string ToSerialString(this GroupType value) => value switch
        {
            GroupType.AdminWorkspace => "AdminWorkspace",
            GroupType.PersonalGroup => "PersonalGroup",
            GroupType.Personal => "Personal",
            GroupType.Workspace => "Workspace",
            GroupType.Group => "Group",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown GroupType value.")
        };

        public static GroupType ToGroupType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AdminWorkspace")) return GroupType.AdminWorkspace;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PersonalGroup")) return GroupType.PersonalGroup;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Personal")) return GroupType.Personal;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Workspace")) return GroupType.Workspace;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Group")) return GroupType.Group;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown GroupType value.");
        }
    }
}
