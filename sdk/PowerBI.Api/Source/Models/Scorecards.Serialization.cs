// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class Scorecards
    {
        internal static Scorecards DeserializeScorecards(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataContext = default;
            int? odataCount = default;
            string odataNextLink = default;
            IReadOnlyList<Scorecard> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"u8))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Scorecard> array = new List<Scorecard>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Scorecard.DeserializeScorecard(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new Scorecards(odataContext, odataCount, odataNextLink, value ?? new ChangeTrackingList<Scorecard>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Scorecards FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeScorecards(document.RootElement);
        }
    }
}
