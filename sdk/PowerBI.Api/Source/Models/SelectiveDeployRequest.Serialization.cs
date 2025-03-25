// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class SelectiveDeployRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Datasets))
            {
                writer.WritePropertyName("datasets"u8);
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Reports))
            {
                writer.WritePropertyName("reports"u8);
                writer.WriteStartArray();
                foreach (var item in Reports)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Dashboards))
            {
                writer.WritePropertyName("dashboards"u8);
                writer.WriteStartArray();
                foreach (var item in Dashboards)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Dataflows))
            {
                writer.WritePropertyName("dataflows"u8);
                writer.WriteStartArray();
                foreach (var item in Dataflows)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Datamarts))
            {
                writer.WritePropertyName("datamarts"u8);
                writer.WriteStartArray();
                foreach (var item in Datamarts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("sourceStageOrder"u8);
            writer.WriteNumberValue(SourceStageOrder);
            if (Optional.IsDefined(IsBackwardDeployment))
            {
                writer.WritePropertyName("isBackwardDeployment"u8);
                writer.WriteBooleanValue(IsBackwardDeployment.Value);
            }
            if (Optional.IsDefined(NewWorkspace))
            {
                writer.WritePropertyName("newWorkspace"u8);
                writer.WriteObjectValue(NewWorkspace);
            }
            if (Optional.IsDefined(UpdateAppSettings))
            {
                writer.WritePropertyName("updateAppSettings"u8);
                writer.WriteObjectValue(UpdateAppSettings);
            }
            if (Optional.IsDefined(Options))
            {
                writer.WritePropertyName("options"u8);
                writer.WriteObjectValue(Options);
            }
            if (Optional.IsDefined(Note))
            {
                writer.WritePropertyName("note"u8);
                writer.WriteStringValue(Note);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
