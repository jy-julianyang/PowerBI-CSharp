// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.PowerBI.Api.Models;

namespace Microsoft.PowerBI.Api
{
    internal partial class TilesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of TilesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public TilesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://api.powerbi.com");
        }

        internal HttpMessage CreateGenerateTokenInGroupRequest(Guid groupId, Guid dashboardId, Guid tileId, GenerateTokenRequest requestParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/groups/", false);
            uri.AppendPath(groupId, true);
            uri.AppendPath("/dashboards/", false);
            uri.AppendPath(dashboardId, true);
            uri.AppendPath("/tiles/", false);
            uri.AppendPath(tileId, true);
            uri.AppendPath("/GenerateToken", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(requestParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Generates an embed token to view the specified tile from the specified workspace. </summary>
        /// <param name="groupId"> The workspace ID. </param>
        /// <param name="dashboardId"> The dashboard ID. </param>
        /// <param name="tileId"> The tile ID. </param>
        /// <param name="requestParameters"> Generate token parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestParameters"/> is null. </exception>
        /// <remarks>
        /// &gt; [!IMPORTANT]
        /// &gt; This API call is only relevant to the [embed for your customers](/power-bi/developer/embed-sample-for-customers) scenario. To learn more about using this API, see [Considerations when generating an embed token](/power-bi/developer/embedded/generate-embed-token).
        ///
        /// ## Permissions
        ///
        /// - When using a service principal for authentication, refer to [Embed Power BI content with service principal](/power-bi/developer/embed-service-principal) and [Considerations and limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
        /// - This API call can be called by a service principal profile. For more information see: [Service principal profiles in Power BI Embedded](/power-bi/developer/embedded/embed-multi-tenancy).
        ///
        /// ## Required Scope
        ///
        /// All of the following:
        ///
        /// - Dashboard.ReadWrite.All or Dashboard.Read.All
        /// - Report.ReadWrite.All or Report.Read.All
        /// - Dataset.ReadWrite.All or Dataset.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public async Task<Response<EmbedToken>> GenerateTokenInGroupAsync(Guid groupId, Guid dashboardId, Guid tileId, GenerateTokenRequest requestParameters, CancellationToken cancellationToken = default)
        {
            if (requestParameters == null)
            {
                throw new ArgumentNullException(nameof(requestParameters));
            }

            using var message = CreateGenerateTokenInGroupRequest(groupId, dashboardId, tileId, requestParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EmbedToken value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EmbedToken.DeserializeEmbedToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Generates an embed token to view the specified tile from the specified workspace. </summary>
        /// <param name="groupId"> The workspace ID. </param>
        /// <param name="dashboardId"> The dashboard ID. </param>
        /// <param name="tileId"> The tile ID. </param>
        /// <param name="requestParameters"> Generate token parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestParameters"/> is null. </exception>
        /// <remarks>
        /// &gt; [!IMPORTANT]
        /// &gt; This API call is only relevant to the [embed for your customers](/power-bi/developer/embed-sample-for-customers) scenario. To learn more about using this API, see [Considerations when generating an embed token](/power-bi/developer/embedded/generate-embed-token).
        ///
        /// ## Permissions
        ///
        /// - When using a service principal for authentication, refer to [Embed Power BI content with service principal](/power-bi/developer/embed-service-principal) and [Considerations and limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
        /// - This API call can be called by a service principal profile. For more information see: [Service principal profiles in Power BI Embedded](/power-bi/developer/embedded/embed-multi-tenancy).
        ///
        /// ## Required Scope
        ///
        /// All of the following:
        ///
        /// - Dashboard.ReadWrite.All or Dashboard.Read.All
        /// - Report.ReadWrite.All or Report.Read.All
        /// - Dataset.ReadWrite.All or Dataset.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public Response<EmbedToken> GenerateTokenInGroup(Guid groupId, Guid dashboardId, Guid tileId, GenerateTokenRequest requestParameters, CancellationToken cancellationToken = default)
        {
            if (requestParameters == null)
            {
                throw new ArgumentNullException(nameof(requestParameters));
            }

            using var message = CreateGenerateTokenInGroupRequest(groupId, dashboardId, tileId, requestParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EmbedToken value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EmbedToken.DeserializeEmbedToken(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
