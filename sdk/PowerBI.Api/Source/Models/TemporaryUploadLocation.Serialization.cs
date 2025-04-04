// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class TemporaryUploadLocation
    {
        internal static TemporaryUploadLocation DeserializeTemporaryUploadLocation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string url = default;
            DateTimeOffset expirationTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationTime"u8))
                {
                    expirationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new TemporaryUploadLocation(url, expirationTime);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TemporaryUploadLocation FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTemporaryUploadLocation(document.RootElement);
        }
    }
}
