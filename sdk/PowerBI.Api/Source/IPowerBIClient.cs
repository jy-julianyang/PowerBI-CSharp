// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public partial interface IPowerBIClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// The unique identifier of the scorecard
        /// </summary>
        System.Guid ScorecardId { get; set; }

        /// <summary>
        /// The unique identifier of the goal
        /// </summary>
        System.Guid GoalId { get; set; }

        /// <summary>
        /// The unique identifier of the workspace
        /// </summary>
        System.Guid GroupId { get; set; }

        /// <summary>
        /// The timestamp for the value of the goal
        /// </summary>
        System.DateTime Timestamp { get; set; }

        /// <summary>
        /// The unique identifier of the goal check-in note
        /// </summary>
        System.Guid NoteId { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IDatasetsOperations.
        /// </summary>
        IDatasetsOperations Datasets { get; }

        /// <summary>
        /// Gets the IUsers.
        /// </summary>
        IUsers Users { get; }

        /// <summary>
        /// Gets the IImportsOperations.
        /// </summary>
        IImportsOperations Imports { get; }

        /// <summary>
        /// Gets the IReportsOperations.
        /// </summary>
        IReportsOperations Reports { get; }

        /// <summary>
        /// Gets the IDashboardsOperations.
        /// </summary>
        IDashboardsOperations Dashboards { get; }

        /// <summary>
        /// Gets the ITilesOperations.
        /// </summary>
        ITilesOperations Tiles { get; }

        /// <summary>
        /// Gets the IAppsOperations.
        /// </summary>
        IAppsOperations Apps { get; }

        /// <summary>
        /// Gets the IDataflowsOperations.
        /// </summary>
        IDataflowsOperations Dataflows { get; }

        /// <summary>
        /// Gets the IGatewaysOperations.
        /// </summary>
        IGatewaysOperations Gateways { get; }

        /// <summary>
        /// Gets the IGroupsOperations.
        /// </summary>
        IGroupsOperations Groups { get; }

        /// <summary>
        /// Gets the ICapacitiesOperations.
        /// </summary>
        ICapacitiesOperations Capacities { get; }

        /// <summary>
        /// Gets the IAvailableFeaturesOperations.
        /// </summary>
        IAvailableFeaturesOperations AvailableFeatures { get; }

        /// <summary>
        /// Gets the IPipelinesOperations.
        /// </summary>
        IPipelinesOperations Pipelines { get; }

        /// <summary>
        /// Gets the IDataflowStorageAccountsOperations.
        /// </summary>
        IDataflowStorageAccountsOperations DataflowStorageAccounts { get; }

        /// <summary>
        /// Gets the IWorkspaceInfoOperations.
        /// </summary>
        IWorkspaceInfoOperations WorkspaceInfo { get; }

        /// <summary>
        /// Gets the IWidelySharedArtifacts.
        /// </summary>
        IWidelySharedArtifacts WidelySharedArtifacts { get; }

        /// <summary>
        /// Gets the IAdmin.
        /// </summary>
        IAdmin Admin { get; }

        /// <summary>
        /// Gets the IEmbedTokenOperations.
        /// </summary>
        IEmbedTokenOperations EmbedToken { get; }

        /// <summary>
        /// Gets the IInformationProtection.
        /// </summary>
        IInformationProtection InformationProtection { get; }

        /// <summary>
        /// Gets the IProfiles.
        /// </summary>
        IProfiles Profiles { get; }

        /// <summary>
        /// Gets the ITemplateApps.
        /// </summary>
        ITemplateApps TemplateApps { get; }

        /// <summary>
        /// Gets the IScorecardsOperations.
        /// </summary>
        IScorecardsOperations Scorecards { get; }

        /// <summary>
        /// Gets the IGoalsOperations.
        /// </summary>
        IGoalsOperations Goals { get; }

        /// <summary>
        /// Gets the IGoalsStatusRules.
        /// </summary>
        IGoalsStatusRules GoalsStatusRules { get; }

        /// <summary>
        /// Gets the IGoalValuesOperations.
        /// </summary>
        IGoalValuesOperations GoalValues { get; }

        /// <summary>
        /// Gets the IGoalNotesOperations.
        /// </summary>
        IGoalNotesOperations GoalNotes { get; }

    }
}
