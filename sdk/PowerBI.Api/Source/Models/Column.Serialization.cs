// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class Column : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("dataType"u8);
            writer.WriteStringValue(DataType);
            if (Optional.IsDefined(FormatString))
            {
                writer.WritePropertyName("formatString"u8);
                writer.WriteStringValue(FormatString);
            }
            if (Optional.IsDefined(SortByColumn))
            {
                writer.WritePropertyName("sortByColumn"u8);
                writer.WriteStringValue(SortByColumn);
            }
            if (Optional.IsDefined(DataCategory))
            {
                writer.WritePropertyName("dataCategory"u8);
                writer.WriteStringValue(DataCategory);
            }
            if (Optional.IsDefined(IsHidden))
            {
                writer.WritePropertyName("isHidden"u8);
                writer.WriteBooleanValue(IsHidden.Value);
            }
            if (Optional.IsDefined(SummarizeBy))
            {
                writer.WritePropertyName("summarizeBy"u8);
                writer.WriteStringValue(SummarizeBy);
            }
            writer.WriteEndObject();
        }

        internal static Column DeserializeColumn(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string dataType = default;
            string formatString = default;
            string sortByColumn = default;
            string dataCategory = default;
            bool? isHidden = default;
            string summarizeBy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataType"u8))
                {
                    dataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("formatString"u8))
                {
                    formatString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sortByColumn"u8))
                {
                    sortByColumn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataCategory"u8))
                {
                    dataCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isHidden"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("summarizeBy"u8))
                {
                    summarizeBy = property.Value.GetString();
                    continue;
                }
            }
            return new Column(
                name,
                dataType,
                formatString,
                sortByColumn,
                dataCategory,
                isHidden,
                summarizeBy);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Column FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeColumn(document.RootElement);
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
