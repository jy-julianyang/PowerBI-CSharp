// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatasetUsersAccess
    {
        internal static DatasetUsersAccess DeserializeDatasetUsersAccess(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataContext = default;
            IReadOnlyList<DatasetUserAccess> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatasetUserAccess> array = new List<DatasetUserAccess>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetUserAccess.DeserializeDatasetUserAccess(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DatasetUsersAccess(odataContext, value ?? new ChangeTrackingList<DatasetUserAccess>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DatasetUsersAccess FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDatasetUsersAccess(document.RootElement);
        }
    }
}
