// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class ExportReportRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("format"u8);
            writer.WriteStringValue(Format.ToSerialString());
            if (Optional.IsDefined(PowerBIReportConfiguration))
            {
                writer.WritePropertyName("powerBIReportConfiguration"u8);
                writer.WriteObjectValue(PowerBIReportConfiguration);
            }
            if (Optional.IsDefined(PaginatedReportConfiguration))
            {
                writer.WritePropertyName("paginatedReportConfiguration"u8);
                writer.WriteObjectValue(PaginatedReportConfiguration);
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
