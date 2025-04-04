// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class AvailableFeatures
    {
        internal static AvailableFeatures DeserializeAvailableFeatures(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataContext = default;
            IReadOnlyList<AvailableFeature> features = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("features"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailableFeature> array = new List<AvailableFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableFeature.DeserializeAvailableFeature(item));
                    }
                    features = array;
                    continue;
                }
            }
            return new AvailableFeatures(odataContext, features ?? new ChangeTrackingList<AvailableFeature>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AvailableFeatures FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAvailableFeatures(document.RootElement);
        }
    }
}
