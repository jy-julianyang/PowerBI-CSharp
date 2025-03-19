// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class ReportBaseProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DatasetId))
            {
                writer.WritePropertyName("datasetId"u8);
                writer.WriteStringValue(DatasetId);
            }
            if (Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId"u8);
                writer.WriteStringValue(AppId);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ReportType))
            {
                writer.WritePropertyName("reportType"u8);
                writer.WriteStringValue(ReportType.Value.ToString());
            }
            if (Optional.IsDefined(OriginalReportId))
            {
                writer.WritePropertyName("originalReportId"u8);
                writer.WriteStringValue(OriginalReportId.Value);
            }
            if (Optional.IsDefined(IsOwnedByMe))
            {
                writer.WritePropertyName("isOwnedByMe"u8);
                writer.WriteBooleanValue(IsOwnedByMe.Value);
            }
            writer.WriteEndObject();
        }

        internal static ReportBaseProperties DeserializeReportBaseProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid id = default;
            string name = default;
            string datasetId = default;
            string appId = default;
            string description = default;
            ReportBasePropertiesReportType? reportType = default;
            Guid? originalReportId = default;
            bool? isOwnedByMe = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datasetId"u8))
                {
                    datasetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reportType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportType = new ReportBasePropertiesReportType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("originalReportId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    originalReportId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("isOwnedByMe"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOwnedByMe = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ReportBaseProperties(
                id,
                name,
                datasetId,
                appId,
                description,
                reportType,
                originalReportId,
                isOwnedByMe);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ReportBaseProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeReportBaseProperties(document.RootElement);
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
