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
    public partial class GoalNote : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id.Value);
            }
            if (Optional.IsDefined(ValueTimestamp))
            {
                writer.WritePropertyName("valueTimestamp"u8);
                writer.WriteStringValue(ValueTimestamp.Value, "O");
            }
            if (Optional.IsDefined(GoalId))
            {
                writer.WritePropertyName("goalId"u8);
                writer.WriteStringValue(GoalId.Value);
            }
            if (Optional.IsDefined(ScorecardId))
            {
                writer.WritePropertyName("scorecardId"u8);
                writer.WriteStringValue(ScorecardId.Value);
            }
            if (Optional.IsDefined(LastModifiedTime))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedTime.Value, "O");
            }
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStringValue(Content);
            }
            if (Optional.IsDefined(CreatedTime))
            {
                writer.WritePropertyName("createdTime"u8);
                writer.WriteStringValue(CreatedTime.Value, "O");
            }
            if (Optional.IsDefined(Body))
            {
                writer.WritePropertyName("body"u8);
                writer.WriteStringValue(Body);
            }
            writer.WriteEndObject();
        }

        internal static GoalNote DeserializeGoalNote(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? id = default;
            DateTimeOffset? valueTimestamp = default;
            Guid? goalId = default;
            Guid? scorecardId = default;
            DateTimeOffset? lastModifiedTime = default;
            string content = default;
            DateTimeOffset? createdTime = default;
            string body = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("valueTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("goalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    goalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("scorecardId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scorecardId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("body"u8))
                {
                    body = property.Value.GetString();
                    continue;
                }
            }
            return new GoalNote(
                id,
                valueTimestamp,
                goalId,
                scorecardId,
                lastModifiedTime,
                content,
                createdTime,
                body);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GoalNote FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGoalNote(document.RootElement);
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
