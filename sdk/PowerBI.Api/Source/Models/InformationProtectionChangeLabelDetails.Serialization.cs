// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class InformationProtectionChangeLabelDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("artifacts"u8);
            writer.WriteObjectValue(Artifacts);
            writer.WritePropertyName("labelId"u8);
            writer.WriteStringValue(LabelId);
            if (Optional.IsDefined(DelegatedUser))
            {
                writer.WritePropertyName("delegatedUser"u8);
                writer.WriteObjectValue(DelegatedUser);
            }
            if (Optional.IsDefined(AssignmentMethod))
            {
                writer.WritePropertyName("assignmentMethod"u8);
                writer.WriteStringValue(AssignmentMethod.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
