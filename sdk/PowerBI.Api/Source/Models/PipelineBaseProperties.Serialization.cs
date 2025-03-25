// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class PipelineBaseProperties
    {
        internal static PipelineBaseProperties DeserializePipelineBaseProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid id = default;
            string displayName = default;
            string description = default;
            IReadOnlyList<PipelineStage> stages = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineStage> array = new List<PipelineStage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineStage.DeserializePipelineStage(item));
                    }
                    stages = array;
                    continue;
                }
            }
            return new PipelineBaseProperties(id, displayName, description, stages ?? new ChangeTrackingList<PipelineStage>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PipelineBaseProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePipelineBaseProperties(document.RootElement);
        }
    }
}
