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
    public partial class RelatedDatasetProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DatasetWorkspaceId))
            {
                writer.WritePropertyName("datasetWorkspaceId"u8);
                writer.WriteStringValue(DatasetWorkspaceId.Value);
            }
            writer.WriteEndObject();
        }

        internal static RelatedDatasetProperties DeserializeRelatedDatasetProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? datasetWorkspaceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datasetWorkspaceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    datasetWorkspaceId = property.Value.GetGuid();
                    continue;
                }
            }
            return new RelatedDatasetProperties(datasetWorkspaceId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RelatedDatasetProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRelatedDatasetProperties(document.RootElement);
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
