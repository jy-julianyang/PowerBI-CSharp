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
    public partial class Group : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsReadOnly))
            {
                writer.WritePropertyName("isReadOnly"u8);
                writer.WriteBooleanValue(IsReadOnly.Value);
            }
            if (Optional.IsDefined(IsOnDedicatedCapacity))
            {
                writer.WritePropertyName("isOnDedicatedCapacity"u8);
                writer.WriteBooleanValue(IsOnDedicatedCapacity.Value);
            }
            if (Optional.IsDefined(CapacityId))
            {
                writer.WritePropertyName("capacityId"u8);
                writer.WriteStringValue(CapacityId.Value);
            }
            if (Optional.IsDefined(DataflowStorageId))
            {
                writer.WritePropertyName("dataflowStorageId"u8);
                writer.WriteStringValue(DataflowStorageId.Value);
            }
            if (Optional.IsDefined(DefaultDatasetStorageFormat))
            {
                writer.WritePropertyName("defaultDatasetStorageFormat"u8);
                writer.WriteStringValue(DefaultDatasetStorageFormat.Value.ToString());
            }
            if (Optional.IsDefined(LogAnalyticsWorkspace))
            {
                writer.WritePropertyName("logAnalyticsWorkspace"u8);
                writer.WriteObjectValue(LogAnalyticsWorkspace);
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WriteEndObject();
        }

        internal static Group DeserializeGroup(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? isReadOnly = default;
            bool? isOnDedicatedCapacity = default;
            Guid? capacityId = default;
            Guid? dataflowStorageId = default;
            DefaultDatasetStorageFormat? defaultDatasetStorageFormat = default;
            AzureResource logAnalyticsWorkspace = default;
            Guid id = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isReadOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isOnDedicatedCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOnDedicatedCapacity = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("capacityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("dataflowStorageId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataflowStorageId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("defaultDatasetStorageFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultDatasetStorageFormat = new DefaultDatasetStorageFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logAnalyticsWorkspace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logAnalyticsWorkspace = AzureResource.DeserializeAzureResource(property.Value);
                    continue;
                }
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
            }
            return new Group(
                id,
                name,
                isReadOnly,
                isOnDedicatedCapacity,
                capacityId,
                dataflowStorageId,
                defaultDatasetStorageFormat,
                logAnalyticsWorkspace);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new Group FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGroup(document.RootElement);
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
