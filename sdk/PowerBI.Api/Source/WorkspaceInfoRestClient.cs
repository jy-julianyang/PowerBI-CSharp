// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.PowerBI.Api.Models;

namespace Microsoft.PowerBI.Api
{
    internal partial class WorkspaceInfoRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of WorkspaceInfoRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public WorkspaceInfoRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://api.powerbi.com");
        }

        internal HttpMessage CreatePostWorkspaceInfoRequest(RequiredWorkspaces requiredWorkspaces, bool? lineage, bool? datasourceDetails, bool? datasetSchema, bool? datasetExpressions, bool? getArtifactUsers)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/admin/workspaces/getInfo", false);
            if (lineage != null)
            {
                uri.AppendQuery("lineage", lineage.Value, true);
            }
            if (datasourceDetails != null)
            {
                uri.AppendQuery("datasourceDetails", datasourceDetails.Value, true);
            }
            if (datasetSchema != null)
            {
                uri.AppendQuery("datasetSchema", datasetSchema.Value, true);
            }
            if (datasetExpressions != null)
            {
                uri.AppendQuery("datasetExpressions", datasetExpressions.Value, true);
            }
            if (getArtifactUsers != null)
            {
                uri.AppendQuery("getArtifactUsers", getArtifactUsers.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(requiredWorkspaces);
            request.Content = content;
            return message;
        }

        /// <summary> Initiates a call to receive metadata for the requested list of workspaces. </summary>
        /// <param name="requiredWorkspaces"> Required workspace IDs to get info for. </param>
        /// <param name="lineage"> Whether to return lineage info (upstream dataflows, tiles, data source IDs). </param>
        /// <param name="datasourceDetails"> Whether to return data source details. </param>
        /// <param name="datasetSchema"> Whether to return dataset schema (tables, columns and measures). If you set this parameter to `true`, you must fully enable metadata scanning in order for data to be returned. For more information, see [Enable tenant settings for metadata scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning). </param>
        /// <param name="datasetExpressions"> Whether to return dataset expressions (DAX and Mashup queries). If you set this parameter to `true`, you must fully enable metadata scanning in order for data to be returned. For more information, see [Enable tenant settings for metadata scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning). </param>
        /// <param name="getArtifactUsers"> Whether to return user details for a Power BI item (such as a report or a dashboard). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredWorkspaces"/> is null. </exception>
        /// <remarks>
        /// &gt; [!IMPORTANT]
        /// &gt; If you set the `datasetSchema` or `datasetExpressions` parameters to `true`, you must fully enable metadata scanning in order for data to be returned. For more information, see [Enable tenant settings for metadata scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning).
        ///
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// - Maximum 500 requests per hour.
        /// - Maximum 16 simultaneous requests.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public async Task<Response<ScanRequest>> PostWorkspaceInfoAsync(RequiredWorkspaces requiredWorkspaces, bool? lineage = null, bool? datasourceDetails = null, bool? datasetSchema = null, bool? datasetExpressions = null, bool? getArtifactUsers = null, CancellationToken cancellationToken = default)
        {
            if (requiredWorkspaces == null)
            {
                throw new ArgumentNullException(nameof(requiredWorkspaces));
            }

            using var message = CreatePostWorkspaceInfoRequest(requiredWorkspaces, lineage, datasourceDetails, datasetSchema, datasetExpressions, getArtifactUsers);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        ScanRequest value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ScanRequest.DeserializeScanRequest(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Initiates a call to receive metadata for the requested list of workspaces. </summary>
        /// <param name="requiredWorkspaces"> Required workspace IDs to get info for. </param>
        /// <param name="lineage"> Whether to return lineage info (upstream dataflows, tiles, data source IDs). </param>
        /// <param name="datasourceDetails"> Whether to return data source details. </param>
        /// <param name="datasetSchema"> Whether to return dataset schema (tables, columns and measures). If you set this parameter to `true`, you must fully enable metadata scanning in order for data to be returned. For more information, see [Enable tenant settings for metadata scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning). </param>
        /// <param name="datasetExpressions"> Whether to return dataset expressions (DAX and Mashup queries). If you set this parameter to `true`, you must fully enable metadata scanning in order for data to be returned. For more information, see [Enable tenant settings for metadata scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning). </param>
        /// <param name="getArtifactUsers"> Whether to return user details for a Power BI item (such as a report or a dashboard). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredWorkspaces"/> is null. </exception>
        /// <remarks>
        /// &gt; [!IMPORTANT]
        /// &gt; If you set the `datasetSchema` or `datasetExpressions` parameters to `true`, you must fully enable metadata scanning in order for data to be returned. For more information, see [Enable tenant settings for metadata scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning).
        ///
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// - Maximum 500 requests per hour.
        /// - Maximum 16 simultaneous requests.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public Response<ScanRequest> PostWorkspaceInfo(RequiredWorkspaces requiredWorkspaces, bool? lineage = null, bool? datasourceDetails = null, bool? datasetSchema = null, bool? datasetExpressions = null, bool? getArtifactUsers = null, CancellationToken cancellationToken = default)
        {
            if (requiredWorkspaces == null)
            {
                throw new ArgumentNullException(nameof(requiredWorkspaces));
            }

            using var message = CreatePostWorkspaceInfoRequest(requiredWorkspaces, lineage, datasourceDetails, datasetSchema, datasetExpressions, getArtifactUsers);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        ScanRequest value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ScanRequest.DeserializeScanRequest(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetScanStatusRequest(Guid scanId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/admin/workspaces/scanStatus/", false);
            uri.AppendPath(scanId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the scan status for the specified scan. </summary>
        /// <param name="scanId"> The scan ID, which is included in the response from the workspaces or the [Admin - WorkspaceInfo PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call that triggered the scan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// Maximum 10,000 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public async Task<Response<ScanRequest>> GetScanStatusAsync(Guid scanId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetScanStatusRequest(scanId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScanRequest value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ScanRequest.DeserializeScanRequest(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the scan status for the specified scan. </summary>
        /// <param name="scanId"> The scan ID, which is included in the response from the workspaces or the [Admin - WorkspaceInfo PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call that triggered the scan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// Maximum 10,000 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public Response<ScanRequest> GetScanStatus(Guid scanId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetScanStatusRequest(scanId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScanRequest value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ScanRequest.DeserializeScanRequest(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetScanResultRequest(Guid scanId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/admin/workspaces/scanResult/", false);
            uri.AppendPath(scanId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the scan result for the specified scan. </summary>
        /// <param name="scanId"> The scan ID, which is included in the response from the workspaces or the [Admin - WorkspaceInfo PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call that triggered the scan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Only make this API call after a successful [GetScanStatus](/rest/api/power-bi/admin/workspace-info-get-scan-status) API call. The scan result will remain available for 24 hours.
        ///
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// Maximum 500 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public async Task<Response<WorkspaceInfoResponse>> GetScanResultAsync(Guid scanId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetScanResultRequest(scanId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkspaceInfoResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WorkspaceInfoResponse.DeserializeWorkspaceInfoResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the scan result for the specified scan. </summary>
        /// <param name="scanId"> The scan ID, which is included in the response from the workspaces or the [Admin - WorkspaceInfo PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call that triggered the scan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Only make this API call after a successful [GetScanStatus](/rest/api/power-bi/admin/workspace-info-get-scan-status) API call. The scan result will remain available for 24 hours.
        ///
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// Maximum 500 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public Response<WorkspaceInfoResponse> GetScanResult(Guid scanId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetScanResultRequest(scanId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkspaceInfoResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WorkspaceInfoResponse.DeserializeWorkspaceInfoResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetModifiedWorkspacesRequest(DateTimeOffset? modifiedSince, bool? excludePersonalWorkspaces, bool? excludeInActiveWorkspaces)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/admin/workspaces/modified", false);
            if (modifiedSince != null)
            {
                uri.AppendQuery("modifiedSince", modifiedSince.Value, "O", true);
            }
            if (excludePersonalWorkspaces != null)
            {
                uri.AppendQuery("excludePersonalWorkspaces", excludePersonalWorkspaces.Value, true);
            }
            if (excludeInActiveWorkspaces != null)
            {
                uri.AppendQuery("excludeInActiveWorkspaces", excludeInActiveWorkspaces.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a list of workspace IDs in the organization. </summary>
        /// <param name="modifiedSince"> Last modified date (must be in ISO 8601 compliant UTC format). </param>
        /// <param name="excludePersonalWorkspaces"> Whether to exclude personal workspaces. </param>
        /// <param name="excludeInActiveWorkspaces"> Whether to exclude inactive workspaces. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// If the optional `modifiedSince` parameter is set to a date-time, only the IDs of workspaces that changed after that date-time are returned. If the `modifiedSince` parameter isn't used, the IDs of all workspaces in the organization are returned. The date-time specified by the `modifiedSince` parameter must be in the range of 30 minutes (to allow workspace changes to take effect) to 30 days prior to the current time.
        ///
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// Maximum 30 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public async Task<Response<IReadOnlyList<ModifiedWorkspace>>> GetModifiedWorkspacesAsync(DateTimeOffset? modifiedSince = null, bool? excludePersonalWorkspaces = null, bool? excludeInActiveWorkspaces = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetModifiedWorkspacesRequest(modifiedSince, excludePersonalWorkspaces, excludeInActiveWorkspaces);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<ModifiedWorkspace> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<ModifiedWorkspace> array = new List<ModifiedWorkspace>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(ModifiedWorkspace.DeserializeModifiedWorkspace(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of workspace IDs in the organization. </summary>
        /// <param name="modifiedSince"> Last modified date (must be in ISO 8601 compliant UTC format). </param>
        /// <param name="excludePersonalWorkspaces"> Whether to exclude personal workspaces. </param>
        /// <param name="excludeInActiveWorkspaces"> Whether to exclude inactive workspaces. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// If the optional `modifiedSince` parameter is set to a date-time, only the IDs of workspaces that changed after that date-time are returned. If the `modifiedSince` parameter isn't used, the IDs of all workspaces in the organization are returned. The date-time specified by the `modifiedSince` parameter must be in the range of 30 minutes (to allow workspace changes to take effect) to 30 days prior to the current time.
        ///
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// Maximum 30 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public Response<IReadOnlyList<ModifiedWorkspace>> GetModifiedWorkspaces(DateTimeOffset? modifiedSince = null, bool? excludePersonalWorkspaces = null, bool? excludeInActiveWorkspaces = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetModifiedWorkspacesRequest(modifiedSince, excludePersonalWorkspaces, excludeInActiveWorkspaces);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<ModifiedWorkspace> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<ModifiedWorkspace> array = new List<ModifiedWorkspace>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(ModifiedWorkspace.DeserializeModifiedWorkspace(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
