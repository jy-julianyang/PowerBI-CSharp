// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DeploymentSourceAndTarget
    {
        internal static DeploymentSourceAndTarget DeserializeDeploymentSourceAndTarget(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid source = default;
            string sourceDisplayName = default;
            Guid? target = default;
            string targetDisplayName = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("sourceDisplayName"u8))
                {
                    sourceDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("targetDisplayName"u8))
                {
                    targetDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new DeploymentSourceAndTarget(source, sourceDisplayName, target, targetDisplayName, type);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DeploymentSourceAndTarget FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDeploymentSourceAndTarget(document.RootElement);
        }
    }
}
