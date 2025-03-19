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
    /// <summary> The GoalNotes service client. </summary>
    public partial class GoalNotesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal GoalNotesRestClient RestClient { get; }

        /// <summary> Initializes a new instance of GoalNotesClient for mocking. </summary>
        protected GoalNotesClient()
        {
        }

        /// <summary> Initializes a new instance of GoalNotesClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public GoalNotesClient(TokenCredential credential, Uri endpoint = null, PowerBIClientOptions options = null)
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
            RestClient = new GoalNotesRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of GoalNotesClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal GoalNotesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new GoalNotesRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Adds a new note to a goal value check-in. </summary>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="timestamp"> The timestamp for the value of the goal. </param>
        /// <param name="goalNote"> The goal check-in note. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<GoalNote>> PreviewPostAsync(Guid groupId, Guid scorecardId, Guid goalId, DateTimeOffset timestamp, GoalNoteRequest goalNote, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalNotesClient.PreviewPost");
            scope.Start();
            try
            {
                return await RestClient.PreviewPostAsync(groupId, scorecardId, goalId, timestamp, goalNote, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Adds a new note to a goal value check-in. </summary>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="timestamp"> The timestamp for the value of the goal. </param>
        /// <param name="goalNote"> The goal check-in note. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<GoalNote> PreviewPost(Guid groupId, Guid scorecardId, Guid goalId, DateTimeOffset timestamp, GoalNoteRequest goalNote, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalNotesClient.PreviewPost");
            scope.Start();
            try
            {
                return RestClient.PreviewPost(groupId, scorecardId, goalId, timestamp, goalNote, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a goal value check-in note by ID. </summary>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="timestamp"> The timestamp for the value of the goal. </param>
        /// <param name="noteId"> The unique identifier of the goal check-in note. </param>
        /// <param name="goalNote"> The note content to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<GoalNote>> PreviewPatchByIDAsync(Guid groupId, Guid scorecardId, Guid goalId, DateTimeOffset timestamp, Guid noteId, GoalNoteRequest goalNote, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalNotesClient.PreviewPatchByID");
            scope.Start();
            try
            {
                return await RestClient.PreviewPatchByIDAsync(groupId, scorecardId, goalId, timestamp, noteId, goalNote, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a goal value check-in note by ID. </summary>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="timestamp"> The timestamp for the value of the goal. </param>
        /// <param name="noteId"> The unique identifier of the goal check-in note. </param>
        /// <param name="goalNote"> The note content to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<GoalNote> PreviewPatchByID(Guid groupId, Guid scorecardId, Guid goalId, DateTimeOffset timestamp, Guid noteId, GoalNoteRequest goalNote, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalNotesClient.PreviewPatchByID");
            scope.Start();
            try
            {
                return RestClient.PreviewPatchByID(groupId, scorecardId, goalId, timestamp, noteId, goalNote, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a goal value check-in note by ID. </summary>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="timestamp"> The timestamp for the value of the goal. </param>
        /// <param name="noteId"> The unique identifier of the goal check-in note. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response> PreviewDeleteByIDAsync(Guid groupId, Guid scorecardId, Guid goalId, DateTimeOffset timestamp, Guid noteId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalNotesClient.PreviewDeleteByID");
            scope.Start();
            try
            {
                return await RestClient.PreviewDeleteByIDAsync(groupId, scorecardId, goalId, timestamp, noteId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a goal value check-in note by ID. </summary>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="timestamp"> The timestamp for the value of the goal. </param>
        /// <param name="noteId"> The unique identifier of the goal check-in note. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response PreviewDeleteByID(Guid groupId, Guid scorecardId, Guid goalId, DateTimeOffset timestamp, Guid noteId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalNotesClient.PreviewDeleteByID");
            scope.Start();
            try
            {
                return RestClient.PreviewDeleteByID(groupId, scorecardId, goalId, timestamp, noteId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
