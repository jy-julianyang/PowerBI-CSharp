// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PipelinesOperations operations.
    /// </summary>
    public partial interface IPipelinesOperations
    {
        /// <summary>
        /// Returns a list of deployment pipelines that the user has access to.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Pipeline.Read.All or Pipeline.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Pipelines>> GetPipelinesWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Pipeline.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='createPipelineRequest'>
        /// The create pipeline request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Pipeline>> CreatePipelineWithHttpMessagesAsync(CreatePipelineRequest createPipelineRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Pipeline.ReadWrite.All or Pipeline.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='expand'>
        /// Accepts a comma-separated list of data types, which will be
        /// expanded inline in the response. Supports `stages`.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Pipeline>> GetPipelineWithHttpMessagesAsync(System.Guid pipelineId, string expand = "stages", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Pipeline.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='updatePipelineRequest'>
        /// The update pipeline request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Pipeline>> UpdatePipelineWithHttpMessagesAsync(System.Guid pipelineId, UpdatePipelineRequest updatePipelineRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Pipeline.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// This operation will fail if there's an active deployment operation.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> DeletePipelineWithHttpMessagesAsync(System.Guid pipelineId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of users that have access to the specified
        /// deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Pipeline.ReadWrite.All or Pipeline.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<PipelineUsers>> GetPipelineUsersWithHttpMessagesAsync(System.Guid pipelineId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Grants user permissions to the specified deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Pipeline.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='userDetails'>
        /// Details of user access right
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdatePipelineUserWithHttpMessagesAsync(System.Guid pipelineId, PipelineUser userDetails, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes user permissions from the specified deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Pipeline.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='identifier'>
        /// To delete user pipeline permissions, provide the user principal
        /// name (UPN) of the user. To delete a service principal or a security
        /// group's pipeline permissions, provide the Object ID of the service
        /// principal or security group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeletePipelineUserWithHttpMessagesAsync(System.Guid pipelineId, string identifier, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the stages of the specified deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Pipeline.ReadWrite.All or Pipeline.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<PipelineStages>> GetPipelineStagesWithHttpMessagesAsync(System.Guid pipelineId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Assigns the specified workspace to the specified deployment
        /// pipeline stage.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Pipeline.ReadWrite.All and Workspace.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// - The specified deployment pipeline stage isn't already assigned.
        /// - You must be an admin of the specified workspace.
        /// - The specified workspace isn't assigned to any other deployment
        /// pipeline.
        /// - This operation will fail if there's an active deployment
        /// operation.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='stageOrder'>
        /// The deployment pipeline stage order. Development (0), Test (1),
        /// Production (2).
        /// </param>
        /// <param name='assignWorkspaceRequest'>
        /// The assign workspace request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AssignWorkspaceWithHttpMessagesAsync(System.Guid pipelineId, int stageOrder, AssignWorkspaceRequest assignWorkspaceRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Unassigns the workspace from the specified stage in the specified
        /// deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Pipeline.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// This operation will fail if there's an active deployment operation.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='stageOrder'>
        /// The deployment pipeline stage order. Development (0), Test (1),
        /// Production (2).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> UnassignWorkspaceWithHttpMessagesAsync(System.Guid pipelineId, int stageOrder, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the supported items from the workspace assigned to the
        /// specified stage of the specified deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// To learn about items that aren't supported in deployment pipelines,
        /// see [Unsupported
        /// items](/power-bi/create-reports/deployment-pipelines-process#unsupported-items).
        ///
        /// ## Permissions
        ///
        /// The user must at least be a contributor on the workspace assigned
        /// to the specified stage. For more information, see
        /// [Permissions](/power-bi/create-reports/deployment-pipelines-process#permissions).
        ///
        /// ## Required Scope
        ///
        /// Pipeline.ReadWrite.All or Pipeline.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='stageOrder'>
        /// The deployment pipeline stage order. Development (0), Test (1),
        /// Production (2).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<PipelineStageArtifacts>> GetPipelineStageArtifactsWithHttpMessagesAsync(System.Guid pipelineId, int stageOrder, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of the up-to-20 most recent deploy operations
        /// performed on the specified deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Pipeline.ReadWrite.All or Pipeline.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<PipelineOperations>> GetPipelineOperationsWithHttpMessagesAsync(System.Guid pipelineId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the details of the specified deploy operation performed on
        /// the specified deployment pipeline, including the deployment
        /// execution plan.
        /// </summary>
        /// <remarks>
        ///
        /// Use to track the status of a deploy operation.
        ///
        /// ## Required Scope
        ///
        /// Pipeline.ReadWrite.All or Pipeline.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='operationId'>
        /// The operation ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<PipelineOperation>> GetPipelineOperationWithHttpMessagesAsync(System.Guid pipelineId, System.Guid operationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deploys all supported items from the source stage of the specified
        /// deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// To learn about items that aren't supported in deployment pipelines,
        /// see [Unsupported
        /// items](/power-bi/create-reports/deployment-pipelines-process#unsupported-items).
        ///
        /// ## Permissions
        ///
        /// The user must at least be a contributor on both source and target
        /// deployment workspaces. For more information, see
        /// [Permissions](/power-bi/create-reports/deployment-pipelines-process#permissions).
        ///
        /// ## Required Scope
        ///
        /// Pipeline.Deploy
        ///
        /// ## Limitations
        ///
        /// Maximum 300 deployed items per request.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='deployRequest'>
        /// The deploy request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PipelineOperation>> DeployAllWithHttpMessagesAsync(System.Guid pipelineId, DeployAllRequest deployRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deploys the specified items from the source stage of the specified
        /// deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must at least be a contributor on both source and target
        /// deployment workspaces. For more information, see
        /// [Permissions](/power-bi/create-reports/deployment-pipelines-process#permissions).
        ///
        /// ## Required Scope
        ///
        /// Pipeline.Deploy
        ///
        /// ## Limitations
        ///
        /// Maximum 300 deployed items per request.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='deployRequest'>
        /// The selective deploy request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PipelineOperation>> SelectiveDeployWithHttpMessagesAsync(System.Guid pipelineId, SelectiveDeployRequest deployRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of deployment pipelines for the organization.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights or authenticate using a
        /// service principal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='expand'>
        /// Accepts a comma-separated list of data types, which will be
        /// expanded inline in the response. Supports `users` and `stages`.
        /// </param>
        /// <param name='filter'>
        /// Filters the results based on a boolean condition. This API only
        /// supports filtering for [orphaned deployment
        /// pipelines](#get-orphaned-deployment-pipelines-example). Unsupported
        /// filters will return unfiltered results.
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results. This parameter must be in the
        /// range of 1-5000.
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results. Use with top to fetch results beyond the
        /// first 5000.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<AdminPipelines>> GetPipelinesAsAdminWithHttpMessagesAsync(string expand = default(string), string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of users that have access to a specified deployment
        /// pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights or authenticate using a
        /// service principal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<PipelineUsers>> GetPipelineUsersAsAdminWithHttpMessagesAsync(System.Guid pipelineId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Grants user permissions to a specified deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights.
        ///
        /// ## Required Scope
        ///
        /// Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='userDetails'>
        /// Details of user access right
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdateUserAsAdminWithHttpMessagesAsync(System.Guid pipelineId, PipelineUser userDetails, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes user permissions from a specified deployment pipeline.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights.
        ///
        /// ## Required Scope
        ///
        /// Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='pipelineId'>
        /// The deployment pipeline ID
        /// </param>
        /// <param name='identifier'>
        /// For the principal type `User`, provide the user principal name
        /// (UPN). Otherwise, provide the [Object
        /// ID](/power-bi/developer/embedded/embedded-troubleshoot#what-is-the-difference-between-application-object-id-and-principal-object-id)
        /// of the principal.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteUserAsAdminWithHttpMessagesAsync(System.Guid pipelineId, string identifier, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
