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
    internal partial class ProfilesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of ProfilesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public ProfilesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://api.powerbi.com");
        }

        internal HttpMessage CreateGetProfilesAsAdminRequest(string filter, int? top, int? skip)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/admin/profiles", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (skip != null)
            {
                uri.AppendQuery("$skip", skip.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Returns a list of service principal profiles for the organization. </summary>
        /// <param name="filter"> Filters the results based on a boolean condition, using 'id', 'displayName', or 'servicePrincipalId'. Supports only 'eq' operator. </param>
        /// <param name="top"> Returns only the first n results. This parameter must be in the range of 1-5000. </param>
        /// <param name="skip"> Skips the first n results. Use with top to fetch results beyond the first 5000. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator or authenticate using a service principal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// </remarks>
        public async Task<Response<AdminServicePrincipalProfiles>> GetProfilesAsAdminAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetProfilesAsAdminRequest(filter, top, skip);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdminServicePrincipalProfiles value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AdminServicePrincipalProfiles.DeserializeAdminServicePrincipalProfiles(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns a list of service principal profiles for the organization. </summary>
        /// <param name="filter"> Filters the results based on a boolean condition, using 'id', 'displayName', or 'servicePrincipalId'. Supports only 'eq' operator. </param>
        /// <param name="top"> Returns only the first n results. This parameter must be in the range of 1-5000. </param>
        /// <param name="skip"> Skips the first n results. Use with top to fetch results beyond the first 5000. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator or authenticate using a service principal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// </remarks>
        public Response<AdminServicePrincipalProfiles> GetProfilesAsAdmin(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetProfilesAsAdminRequest(filter, top, skip);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AdminServicePrincipalProfiles value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AdminServicePrincipalProfiles.DeserializeAdminServicePrincipalProfiles(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteProfileAsAdminRequest(Guid profileId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/admin/profiles/", false);
            uri.AppendPath(profileId, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes the specified service principal profile. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator.
        ///
        /// ## Required Scope
        ///
        /// Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// </remarks>
        public async Task<Response> DeleteProfileAsAdminAsync(Guid profileId, CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteProfileAsAdminRequest(profileId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes the specified service principal profile. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator.
        ///
        /// ## Required Scope
        ///
        /// Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// </remarks>
        public Response DeleteProfileAsAdmin(Guid profileId, CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteProfileAsAdminRequest(profileId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetProfilesRequest(int? top, int? skip, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/profiles", false);
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (skip != null)
            {
                uri.AppendQuery("$skip", skip.Value, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Returns a list of service principal profiles. </summary>
        /// <param name="top"> Returns only the first n results. </param>
        /// <param name="skip"> Skips the first n results. </param>
        /// <param name="filter"> Get a profile by DisplayName. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Returns a list of profiles that belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public async Task<Response<ServicePrincipalProfiles>> GetProfilesAsync(int? top = null, int? skip = null, string filter = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetProfilesRequest(top, skip, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServicePrincipalProfiles value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServicePrincipalProfiles.DeserializeServicePrincipalProfiles(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns a list of service principal profiles. </summary>
        /// <param name="top"> Returns only the first n results. </param>
        /// <param name="skip"> Skips the first n results. </param>
        /// <param name="filter"> Get a profile by DisplayName. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Returns a list of profiles that belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public Response<ServicePrincipalProfiles> GetProfiles(int? top = null, int? skip = null, string filter = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetProfilesRequest(top, skip, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServicePrincipalProfiles value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServicePrincipalProfiles.DeserializeServicePrincipalProfiles(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateProfileRequest(CreateOrUpdateProfileRequest createOrUpdateProfileRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/profiles", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createOrUpdateProfileRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new service principal profile. </summary>
        /// <param name="createOrUpdateProfileRequest"> The create profile request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createOrUpdateProfileRequest"/> is null. </exception>
        /// <remarks>
        /// &lt;br/&gt;Creates a new profile that belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal. The maximum number of profiles a single service principal can have, is 100,000.
        /// </remarks>
        public async Task<Response<ServicePrincipalProfile>> CreateProfileAsync(CreateOrUpdateProfileRequest createOrUpdateProfileRequest, CancellationToken cancellationToken = default)
        {
            if (createOrUpdateProfileRequest == null)
            {
                throw new ArgumentNullException(nameof(createOrUpdateProfileRequest));
            }

            using var message = CreateCreateProfileRequest(createOrUpdateProfileRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServicePrincipalProfile value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServicePrincipalProfile.DeserializeServicePrincipalProfile(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new service principal profile. </summary>
        /// <param name="createOrUpdateProfileRequest"> The create profile request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createOrUpdateProfileRequest"/> is null. </exception>
        /// <remarks>
        /// &lt;br/&gt;Creates a new profile that belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal. The maximum number of profiles a single service principal can have, is 100,000.
        /// </remarks>
        public Response<ServicePrincipalProfile> CreateProfile(CreateOrUpdateProfileRequest createOrUpdateProfileRequest, CancellationToken cancellationToken = default)
        {
            if (createOrUpdateProfileRequest == null)
            {
                throw new ArgumentNullException(nameof(createOrUpdateProfileRequest));
            }

            using var message = CreateCreateProfileRequest(createOrUpdateProfileRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServicePrincipalProfile value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServicePrincipalProfile.DeserializeServicePrincipalProfile(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetProfileRequest(Guid profileId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/profiles/", false);
            uri.AppendPath(profileId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Returns the specified service principal profile. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Returns the specified profile if it exists and belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public async Task<Response<ServicePrincipalProfile>> GetProfileAsync(Guid profileId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetProfileRequest(profileId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServicePrincipalProfile value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServicePrincipalProfile.DeserializeServicePrincipalProfile(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns the specified service principal profile. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Returns the specified profile if it exists and belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public Response<ServicePrincipalProfile> GetProfile(Guid profileId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetProfileRequest(profileId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServicePrincipalProfile value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServicePrincipalProfile.DeserializeServicePrincipalProfile(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateProfileRequest(Guid profileId, CreateOrUpdateProfileRequest createOrUpdateProfileRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/profiles/", false);
            uri.AppendPath(profileId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createOrUpdateProfileRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Updates the specified service principal profile name. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="createOrUpdateProfileRequest"> The update profile request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createOrUpdateProfileRequest"/> is null. </exception>
        /// <remarks>
        /// &lt;br/&gt;Updates the specified profile name if it exists and belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public async Task<Response<ServicePrincipalProfile>> UpdateProfileAsync(Guid profileId, CreateOrUpdateProfileRequest createOrUpdateProfileRequest, CancellationToken cancellationToken = default)
        {
            if (createOrUpdateProfileRequest == null)
            {
                throw new ArgumentNullException(nameof(createOrUpdateProfileRequest));
            }

            using var message = CreateUpdateProfileRequest(profileId, createOrUpdateProfileRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServicePrincipalProfile value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServicePrincipalProfile.DeserializeServicePrincipalProfile(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates the specified service principal profile name. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="createOrUpdateProfileRequest"> The update profile request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createOrUpdateProfileRequest"/> is null. </exception>
        /// <remarks>
        /// &lt;br/&gt;Updates the specified profile name if it exists and belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public Response<ServicePrincipalProfile> UpdateProfile(Guid profileId, CreateOrUpdateProfileRequest createOrUpdateProfileRequest, CancellationToken cancellationToken = default)
        {
            if (createOrUpdateProfileRequest == null)
            {
                throw new ArgumentNullException(nameof(createOrUpdateProfileRequest));
            }

            using var message = CreateUpdateProfileRequest(profileId, createOrUpdateProfileRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServicePrincipalProfile value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServicePrincipalProfile.DeserializeServicePrincipalProfile(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteProfileRequest(Guid profileId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/profiles/", false);
            uri.AppendPath(profileId, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes the specified service principal profile. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Deletes the specified profile if it exists and belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public async Task<Response> DeleteProfileAsync(Guid profileId, CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteProfileRequest(profileId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes the specified service principal profile. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Deletes the specified profile if it exists and belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public Response DeleteProfile(Guid profileId, CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteProfileRequest(profileId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
