// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.PowerBI.Api.Models;

namespace Microsoft.PowerBI.Api
{
    /// <summary> The GoalsStatusRules service client. </summary>
    public partial class GoalsStatusRulesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal GoalsStatusRulesRestClient RestClient { get; }

        /// <summary> Initializes a new instance of GoalsStatusRulesClient for mocking. </summary>
        protected GoalsStatusRulesClient()
        {
        }

        /// <summary> Initializes a new instance of GoalsStatusRulesClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public GoalsStatusRulesClient(TokenCredential credential, Uri endpoint = null, PowerBIClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("https://api.powerbi.com");

            options ??= new PowerBIClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://analysis.windows.net/powerbi/api/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new GoalsStatusRulesRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of GoalsStatusRulesClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal GoalsStatusRulesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new GoalsStatusRulesRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Returns status rules of a goal. </summary>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.Read.All or Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<GoalsRulesGoalStatusRules>> PreviewGetAsync(Guid groupId, Guid scorecardId, Guid goalId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsStatusRulesClient.PreviewGet");
            scope.Start();
            try
            {
                return await RestClient.PreviewGetAsync(groupId, scorecardId, goalId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns status rules of a goal. </summary>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.Read.All or Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<GoalsRulesGoalStatusRules> PreviewGet(Guid groupId, Guid scorecardId, Guid goalId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsStatusRulesClient.PreviewGet");
            scope.Start();
            try
            {
                return RestClient.PreviewGet(groupId, scorecardId, goalId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates status rules of a goal. </summary>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="statusRulesUpdateRequest"> The status rules definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<GoalsRulesGoalStatusRules>> PreviewPostAsync(Guid groupId, Guid scorecardId, Guid goalId, GoalsRulesGoalStatusRulesUpdateRequest statusRulesUpdateRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsStatusRulesClient.PreviewPost");
            scope.Start();
            try
            {
                return await RestClient.PreviewPostAsync(groupId, scorecardId, goalId, statusRulesUpdateRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates status rules of a goal. </summary>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="statusRulesUpdateRequest"> The status rules definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<GoalsRulesGoalStatusRules> PreviewPost(Guid groupId, Guid scorecardId, Guid goalId, GoalsRulesGoalStatusRulesUpdateRequest statusRulesUpdateRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsStatusRulesClient.PreviewPost");
            scope.Start();
            try
            {
                return RestClient.PreviewPost(groupId, scorecardId, goalId, statusRulesUpdateRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes status rule definitions from a goal. </summary>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response> PreviewDeleteAsync(Guid groupId, Guid scorecardId, Guid goalId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsStatusRulesClient.PreviewDelete");
            scope.Start();
            try
            {
                return await RestClient.PreviewDeleteAsync(groupId, scorecardId, goalId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes status rule definitions from a goal. </summary>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response PreviewDelete(Guid groupId, Guid scorecardId, Guid goalId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsStatusRulesClient.PreviewDelete");
            scope.Start();
            try
            {
                return RestClient.PreviewDelete(groupId, scorecardId, goalId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
