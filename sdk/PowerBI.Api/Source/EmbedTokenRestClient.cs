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
    internal partial class EmbedTokenRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of EmbedTokenRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public EmbedTokenRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://api.powerbi.com");
        }

        internal HttpMessage CreateGenerateTokenRequest(GenerateTokenRequestV2 requestParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/GenerateToken", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(requestParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Generates an embed token for multiple reports, datasets, and target workspaces. </summary>
        /// <param name="requestParameters"> Generate token parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestParameters"/> is null. </exception>
        /// <remarks>
        /// - Reports and datasets don't have to be related.
        /// - You can bind a report to a dataset during embedding.
        /// - You can only create a report in workspaces specified by the `targetWorkspaces` parameter.
        ///
        /// &gt; [!IMPORTANT]
        /// &gt; This API call is only relevant to the [embed for your customers](/power-bi/developer/embed-sample-for-customers) scenario. To learn more about using this API, see [Considerations when generating an embed token](/power-bi/developer/embedded/generate-embed-token).
        ///
        /// ## Permissions
        ///
        /// - When using a service principal for authentication, refer to [Embed Power BI content with service principal](/power-bi/developer/embed-service-principal) and [Considerations and limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
        /// - For Power BI reports with a paginated visual, include the paginated report ID in the API call. For more information, see [example](/rest/api/power-bi/embed-token/generate-token#examples).
        /// - This API call can be called by a service principal profile. For more information see: [Service principal profiles in Power BI Embedded](/power-bi/developer/embedded/embed-multi-tenancy).
        ///
        /// ## Required Scope
        ///
        /// All of the following, unless a requirement doesn't apply:
        ///
        /// - Content.Create, required if a target workspace is specified in [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2).
        /// - Report.ReadWrite.All or Report.Read.All, required if a report is specified in [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2).
        /// - Report.ReadWrite.All, required if the `allowEdit` flag is specified for at least one report in [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2).
        /// - Dataset.ReadWrite.All or Dataset.Read.All
        ///
        /// ## Limitations
        ///
        /// - You can only create a report in workspaces specified by the `targetWorkspaces` parameter.
        /// - All reports and datasets must reside in a **V2** workspace.
        /// - All target workspaces must be **V2** workspaces.
        /// - Maximum 50 reports.
        /// - Maximum 50 datasets.
        /// - Maximum 50 target workspaces.
        /// - For Azure Analysis Services or Analysis Services on-premises live connection reports, generating an embed token with row-level security (RLS) might not work for several minutes after a [rebind](/rest/api/power-bi/reports/rebind-report).
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public async Task<Response<EmbedToken>> GenerateTokenAsync(GenerateTokenRequestV2 requestParameters, CancellationToken cancellationToken = default)
        {
            if (requestParameters == null)
            {
                throw new ArgumentNullException(nameof(requestParameters));
            }

            using var message = CreateGenerateTokenRequest(requestParameters);
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

        /// <summary> Generates an embed token for multiple reports, datasets, and target workspaces. </summary>
        /// <param name="requestParameters"> Generate token parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestParameters"/> is null. </exception>
        /// <remarks>
        /// - Reports and datasets don't have to be related.
        /// - You can bind a report to a dataset during embedding.
        /// - You can only create a report in workspaces specified by the `targetWorkspaces` parameter.
        ///
        /// &gt; [!IMPORTANT]
        /// &gt; This API call is only relevant to the [embed for your customers](/power-bi/developer/embed-sample-for-customers) scenario. To learn more about using this API, see [Considerations when generating an embed token](/power-bi/developer/embedded/generate-embed-token).
        ///
        /// ## Permissions
        ///
        /// - When using a service principal for authentication, refer to [Embed Power BI content with service principal](/power-bi/developer/embed-service-principal) and [Considerations and limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
        /// - For Power BI reports with a paginated visual, include the paginated report ID in the API call. For more information, see [example](/rest/api/power-bi/embed-token/generate-token#examples).
        /// - This API call can be called by a service principal profile. For more information see: [Service principal profiles in Power BI Embedded](/power-bi/developer/embedded/embed-multi-tenancy).
        ///
        /// ## Required Scope
        ///
        /// All of the following, unless a requirement doesn't apply:
        ///
        /// - Content.Create, required if a target workspace is specified in [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2).
        /// - Report.ReadWrite.All or Report.Read.All, required if a report is specified in [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2).
        /// - Report.ReadWrite.All, required if the `allowEdit` flag is specified for at least one report in [GenerateTokenRequestV2](/rest/api/power-bi/embed-token/generate-token#generatetokenrequestv2).
        /// - Dataset.ReadWrite.All or Dataset.Read.All
        ///
        /// ## Limitations
        ///
        /// - You can only create a report in workspaces specified by the `targetWorkspaces` parameter.
        /// - All reports and datasets must reside in a **V2** workspace.
        /// - All target workspaces must be **V2** workspaces.
        /// - Maximum 50 reports.
        /// - Maximum 50 datasets.
        /// - Maximum 50 target workspaces.
        /// - For Azure Analysis Services or Analysis Services on-premises live connection reports, generating an embed token with row-level security (RLS) might not work for several minutes after a [rebind](/rest/api/power-bi/reports/rebind-report).
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public Response<EmbedToken> GenerateToken(GenerateTokenRequestV2 requestParameters, CancellationToken cancellationToken = default)
        {
            if (requestParameters == null)
            {
                throw new ArgumentNullException(nameof(requestParameters));
            }

            using var message = CreateGenerateTokenRequest(requestParameters);
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
