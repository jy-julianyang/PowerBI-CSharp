// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatamartUser : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("datamartUserAccessRight"u8);
            writer.WriteStringValue(DatamartUserAccessRight.ToSerialString());
            if (Optional.IsDefined(EmailAddress))
            {
                writer.WritePropertyName("emailAddress"u8);
                writer.WriteStringValue(EmailAddress);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WritePropertyName("identifier"u8);
            writer.WriteStringValue(Identifier);
            if (Optional.IsDefined(GraphId))
            {
                writer.WritePropertyName("graphId"u8);
                writer.WriteStringValue(GraphId);
            }
            if (Optional.IsDefined(UserType))
            {
                writer.WritePropertyName("userType"u8);
                writer.WriteStringValue(UserType);
            }
            writer.WritePropertyName("principalType"u8);
            writer.WriteStringValue(PrincipalType.ToSerialString());
            if (Optional.IsDefined(Profile))
            {
                writer.WritePropertyName("profile"u8);
                writer.WriteObjectValue(Profile);
            }
            writer.WriteEndObject();
        }

        internal static DatamartUser DeserializeDatamartUser(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DatamartUserAccessRight datamartUserAccessRight = default;
            string emailAddress = default;
            string displayName = default;
            string identifier = default;
            string graphId = default;
            string userType = default;
            PrincipalType principalType = default;
            ServicePrincipalProfile profile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datamartUserAccessRight"u8))
                {
                    datamartUserAccessRight = property.Value.GetString().ToDatamartUserAccessRight();
                    continue;
                }
                if (property.NameEquals("emailAddress"u8))
                {
                    emailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identifier"u8))
                {
                    identifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("graphId"u8))
                {
                    graphId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userType"u8))
                {
                    userType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("principalType"u8))
                {
                    principalType = property.Value.GetString().ToPrincipalType();
                    continue;
                }
                if (property.NameEquals("profile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    profile = ServicePrincipalProfile.DeserializeServicePrincipalProfile(property.Value);
                    continue;
                }
            }
            return new DatamartUser(
                emailAddress,
                displayName,
                identifier,
                graphId,
                userType,
                principalType,
                profile,
                datamartUserAccessRight);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new DatamartUser FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDatamartUser(document.RootElement);
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
