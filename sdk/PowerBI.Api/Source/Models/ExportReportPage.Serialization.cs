// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class ExportReportPage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("pageName"u8);
            writer.WriteStringValue(PageName);
            if (Optional.IsDefined(VisualName))
            {
                writer.WritePropertyName("visualName"u8);
                writer.WriteStringValue(VisualName);
            }
            if (Optional.IsDefined(Bookmark))
            {
                writer.WritePropertyName("bookmark"u8);
                writer.WriteObjectValue(Bookmark);
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
