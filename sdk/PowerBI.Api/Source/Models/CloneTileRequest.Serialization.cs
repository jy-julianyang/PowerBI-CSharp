// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class CloneTileRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetDashboardId"u8);
            writer.WriteStringValue(TargetDashboardId);
            if (Optional.IsDefined(TargetWorkspaceId))
            {
                writer.WritePropertyName("targetWorkspaceId"u8);
                writer.WriteStringValue(TargetWorkspaceId.Value);
            }
            if (Optional.IsDefined(TargetReportId))
            {
                writer.WritePropertyName("targetReportId"u8);
                writer.WriteStringValue(TargetReportId.Value);
            }
            if (Optional.IsDefined(TargetModelId))
            {
                writer.WritePropertyName("targetModelId"u8);
                writer.WriteStringValue(TargetModelId);
            }
            if (Optional.IsDefined(PositionConflictAction))
            {
                writer.WritePropertyName("positionConflictAction"u8);
                writer.WriteStringValue(PositionConflictAction.Value.ToSerialString());
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
