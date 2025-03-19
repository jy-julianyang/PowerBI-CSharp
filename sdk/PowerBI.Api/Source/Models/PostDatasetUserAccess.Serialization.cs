// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class PostDatasetUserAccess : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("datasetUserAccessRight"u8);
            writer.WriteStringValue(DatasetUserAccessRight.ToSerialString());
            writer.WritePropertyName("identifier"u8);
            writer.WriteStringValue(Identifier);
            writer.WritePropertyName("principalType"u8);
            writer.WriteStringValue(PrincipalType.ToSerialString());
            writer.WriteEndObject();
        }

        internal static PostDatasetUserAccess DeserializePostDatasetUserAccess(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DatasetUserAccessRightEntry datasetUserAccessRight = default;
            string identifier = default;
            PrincipalType principalType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datasetUserAccessRight"u8))
                {
                    datasetUserAccessRight = property.Value.GetString().ToDatasetUserAccessRightEntry();
                    continue;
                }
                if (property.NameEquals("identifier"u8))
                {
                    identifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("principalType"u8))
                {
                    principalType = property.Value.GetString().ToPrincipalType();
                    continue;
                }
            }
            return new PostDatasetUserAccess(identifier, principalType, datasetUserAccessRight);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new PostDatasetUserAccess FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePostDatasetUserAccess(document.RootElement);
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
