using Azure.Core;
using Azure.Core.Pipeline;
using System;
using System.Threading.Tasks;
using System.Threading;

namespace Microsoft.PowerBI.Api
{
    /// <summary> The powerbi service client. </summary>
    public class PowerBIClient
    {
        private class PowerBiTokenCredential : TokenCredential
        {
            private readonly AccessToken accessToken;

            public PowerBiTokenCredential(AccessToken accessToken)
            {
                this.accessToken = accessToken;
            }

            public override AccessToken GetToken(TokenRequestContext requestContext, CancellationToken cancellationToken)
            {
                return accessToken;
            }

            public override ValueTask<AccessToken> GetTokenAsync(TokenRequestContext requestContext, CancellationToken cancellationToken)
            {
                return new ValueTask<AccessToken>(accessToken);
            }
        }

        private readonly ReportsClient _reportClient = null;
        private readonly ProfilesClient _profilesClient = null;
        private readonly DashboardsClient _dashboardsClient = null;
        private readonly TilesClient _tilesClient = null;
        private readonly DatasetsClient _datasetsClient = null;
        private readonly EmbedTokenClient _embedTokenClient = null;
        private readonly UsersClient _usersClient = null;
        private readonly ImportsClient _importsClient = null;
        private readonly AppsClient _appsClient = null;
        private readonly DataflowsClient _dataflowsClient = null;
        private readonly GatewaysClient _gatewaysClient = null;
        private readonly GroupsClient _groupsClient = null;
        private readonly CapacitiesClient _capacitiesClient = null;
        private readonly AvailableFeaturesClient _availableFeaturesClient = null;
        private readonly PipelinesClient _pipelinesClient = null;
        private readonly DataflowStorageAccountsClient _dataflowStorageAccountsClient = null;
        private readonly WorkspaceInfoClient _workspaceInfoClient = null;
        private readonly WidelySharedArtifactsClient _widelySharedArtifactsClient = null;
        private readonly AdminClient _adminClient = null;
        private readonly InformationProtectionClient _informationProtectionClient = null;
        private readonly ScorecardsClient _scorecardsClient = null;
        private readonly GoalsClient _goalsClient = null;
        private readonly GoalsStatusRulesClient _goalsStatusRulesClient = null;
        private readonly GoalValuesClient _goalValuesClient = null;
        private readonly GoalNotesClient _goalNotesClient = null;
        private readonly TemplateAppsClient _templateAppsClient = null;

        /// <summary> Initializes a new instance of PowerBIClient for mocking. </summary>
        protected PowerBIClient()
        {
        }

        /// <summary> Initializes a new instance of PowerBIClient. </summary>
        /// <param name="token"> An Azure AAD access token string. </param>
        /// <param name="baseUrl"> Overrides the baseUrl of the PowerBIClient. </param>
        /// <param name="servicePrincipalProfile">The Service Principal Profile ID</param>
        /// <param name="options">The options for configuring the client.</param>
        /// <exception cref="ArgumentException"> <paramref name="token" /> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="token" /> is null. </exception>
        public PowerBIClient(string token, Uri baseUrl = null, Guid? servicePrincipalProfile = null, PowerBIClientOptions options = null)
        {
            PowerBIClientUtils.AssertNotNull(token, nameof(token));
            PowerBIClientUtils.AssertValidUriScheme(baseUrl, nameof(baseUrl));

            if (servicePrincipalProfile != null)
            {
                options = options ?? new PowerBIClientOptions();
                HeaderPolicy headerPolicy = new HeaderPolicy("X-PowerBI-Profile-Id", servicePrincipalProfile.Value);
                options.AddPolicy(headerPolicy, HttpPipelinePosition.BeforeTransport);
            }

            var decodedToken = PowerBIClientUtils.DecodeTokenAndValidate(token);
            PowerBiTokenCredential powerBICredential = new PowerBiTokenCredential(new AccessToken(token, decodedToken.GetExpirationTime()));

            _reportClient = new ReportsClient(powerBICredential, baseUrl, options);
            _dashboardsClient = new DashboardsClient(powerBICredential, baseUrl, options);
            _tilesClient = new TilesClient(powerBICredential, baseUrl, options);
            _datasetsClient = new DatasetsClient(powerBICredential, baseUrl, options);
            _embedTokenClient = new EmbedTokenClient(powerBICredential, baseUrl, options);
            _usersClient = new UsersClient(powerBICredential, baseUrl, options);
            _importsClient = new ImportsClient(powerBICredential, baseUrl, options, this);
            _appsClient = new AppsClient(powerBICredential, baseUrl, options);
            _dataflowsClient = new DataflowsClient(powerBICredential, baseUrl, options);
            _gatewaysClient = new GatewaysClient(powerBICredential, baseUrl, options);
            _groupsClient = new GroupsClient(powerBICredential, baseUrl, options);
            _capacitiesClient = new CapacitiesClient(powerBICredential, baseUrl, options);
            _availableFeaturesClient = new AvailableFeaturesClient(powerBICredential, baseUrl, options);
            _pipelinesClient = new PipelinesClient(powerBICredential, baseUrl, options);
            _dataflowStorageAccountsClient = new DataflowStorageAccountsClient(powerBICredential, baseUrl, options);
            _workspaceInfoClient = new WorkspaceInfoClient(powerBICredential, baseUrl, options);
            _widelySharedArtifactsClient = new WidelySharedArtifactsClient(powerBICredential, baseUrl, options);
            _adminClient = new AdminClient(powerBICredential, baseUrl, options);
            _informationProtectionClient = new InformationProtectionClient(powerBICredential, baseUrl, options);
            _templateAppsClient = new TemplateAppsClient(powerBICredential, baseUrl, options);
            _profilesClient = new ProfilesClient(powerBICredential, baseUrl, options);
            _scorecardsClient = new ScorecardsClient(powerBICredential, baseUrl, options);
            _goalsClient = new GoalsClient(powerBICredential, baseUrl, options);
            _goalsStatusRulesClient = new GoalsStatusRulesClient(powerBICredential, baseUrl, options);
            _goalValuesClient = new GoalValuesClient(powerBICredential, baseUrl, options);
            _goalNotesClient = new GoalNotesClient(powerBICredential, baseUrl, options);
        }

        /// <summary> Initializes a new instance of PowerBIClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="baseUrl"> Overrides the baseUrl of the PowerBIClient. </param>
        /// <param name="servicePrincipalProfile">The Service Principal Profile ID</param>
        /// <param name="options">The options for configuring the client.</param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential" /> is null. </exception>
        public PowerBIClient(TokenCredential credential, Uri baseUrl = null, Guid? servicePrincipalProfile = null, PowerBIClientOptions options = null)
        {
            PowerBIClientUtils.AssertNotNull(credential, nameof(credential));

            if (servicePrincipalProfile != null)
            {
                options = options ?? new PowerBIClientOptions();
                HeaderPolicy headerPolicy = new HeaderPolicy("X-PowerBI-Profile-Id", servicePrincipalProfile.Value);
                options.AddPolicy(headerPolicy, HttpPipelinePosition.BeforeTransport);
            }

            _reportClient = new ReportsClient(credential, baseUrl, options);
            _dashboardsClient = new DashboardsClient(credential, baseUrl, options);
            _tilesClient = new TilesClient(credential, baseUrl, options);
            _datasetsClient = new DatasetsClient(credential, baseUrl, options);
            _embedTokenClient = new EmbedTokenClient(credential, baseUrl, options);
            _usersClient = new UsersClient(credential, baseUrl, options);
            _importsClient = new ImportsClient(credential, baseUrl, options, this);
            _appsClient = new AppsClient(credential, baseUrl, options);
            _dataflowsClient = new DataflowsClient(credential, baseUrl, options);
            _gatewaysClient = new GatewaysClient(credential, baseUrl, options);
            _groupsClient = new GroupsClient(credential, baseUrl, options);
            _capacitiesClient = new CapacitiesClient(credential, baseUrl, options);
            _availableFeaturesClient = new AvailableFeaturesClient(credential, baseUrl, options);
            _pipelinesClient = new PipelinesClient(credential, baseUrl, options);
            _dataflowStorageAccountsClient = new DataflowStorageAccountsClient(credential, baseUrl, options);
            _workspaceInfoClient = new WorkspaceInfoClient(credential, baseUrl, options);
            _widelySharedArtifactsClient = new WidelySharedArtifactsClient(credential, baseUrl, options);
            _adminClient = new AdminClient(credential, baseUrl, options);
            _informationProtectionClient = new InformationProtectionClient(credential, baseUrl, options);
            _templateAppsClient = new TemplateAppsClient(credential, baseUrl, options);
            _profilesClient = new ProfilesClient(credential, baseUrl, options);
            _scorecardsClient = new ScorecardsClient(credential, baseUrl, options);
            _goalsClient = new GoalsClient(credential, baseUrl, options);
            _goalsStatusRulesClient = new GoalsStatusRulesClient(credential, baseUrl, options);
            _goalValuesClient = new GoalValuesClient(credential, baseUrl, options);
            _goalNotesClient = new GoalNotesClient(credential, baseUrl, options);
        }

        /// <summary> Gets the reports client. </summary>
        public virtual ReportsClient Reports
        {
            get
            {
                return _reportClient;
            }
        }

        /// <summary> Gets the profiles client. </summary>
        public virtual ProfilesClient Profiles
        {
            get
            {
                return _profilesClient;
            }
        }

        /// <summary> Gets the dashboards client. </summary>
        public virtual DashboardsClient Dashboards
        {
            get
            {
                return _dashboardsClient;
            }
        }

        /// <summary> Gets the tiles client. </summary>
        public virtual TilesClient Tiles
        {
            get
            {
                return _tilesClient;
            }
        }

        /// <summary> Gets the datasets client. </summary>
        public virtual DatasetsClient Datasets
        {
            get
            {
                return _datasetsClient;
            }
        }

        /// <summary> Gets the embed token client. </summary>
        public virtual EmbedTokenClient EmbedToken
        {
            get
            {
                return _embedTokenClient;
            }
        }

        /// <summary> Gets the users client. </summary>
        public virtual UsersClient Users
        {
            get
            {
                return _usersClient;
            }
        }

        /// <summary> Gets the imports client. </summary>
        public virtual ImportsClient Imports
        {
            get
            {
                return _importsClient;
            }
        }

        /// <summary> Gets the apps client. </summary>
        public virtual AppsClient Apps
        {
            get
            {
                return _appsClient;
            }
        }

        /// <summary> Get the DataFlows client. </summary>
        public virtual DataflowsClient Dataflows
        {
            get
            {
                return _dataflowsClient;
            }
        }

        /// <summary> Get the Gateways client. </summary>
        public virtual GatewaysClient Gateways
        {
            get
            {
                return _gatewaysClient;
            }
        }

        /// <summary> Get the Groups client. </summary>
        public virtual GroupsClient Groups
        {
            get
            {
                return _groupsClient;
            }
        }

        /// <summary> Get the Capacities client. </summary>
        public virtual CapacitiesClient Capacities
        {
            get
            {
                return _capacitiesClient;
            }
        }

        /// <summary> Get the AvailableFeatures client. </summary>
        public virtual AvailableFeaturesClient AvailableFeatures
        {
            get
            {
                return _availableFeaturesClient;
            }
        }

        /// <summary> Get the Pipelines client. </summary>
        public virtual PipelinesClient Pipelines
        {
            get
            {
                return _pipelinesClient;
            }
        }

        /// <summary> Get the DataflowStorageAccounts client. </summary>

        public virtual DataflowStorageAccountsClient DataflowStorageAccounts
        {
            get
            {
                return _dataflowStorageAccountsClient;
            }
        }

        /// <summary> Get the WorkspaceInfo client. </summary>
        public virtual WorkspaceInfoClient WorkspaceInfo
        {
            get
            {
                return _workspaceInfoClient;
            }
        }

        /// <summary> Get the WidelySharedArtifacts client. </summary>
        public virtual WidelySharedArtifactsClient WidelySharedArtifacts
        {
            get
            {
                return _widelySharedArtifactsClient;
            }
        }

        /// <summary> Get the Admin client. </summary>
        public virtual AdminClient Admin
        {
            get
            {
                return _adminClient;
            }
        }

        /// <summary> Get the InformationProtection client. </summary>
        public virtual InformationProtectionClient InformationProtection
        {
            get
            {
                return _informationProtectionClient;
            }
        }

        /// <summary> Get the Scorecards client. </summary>
        public virtual ScorecardsClient Scorecards
        {
            get
            {
                return _scorecardsClient;
            }
        }

        /// <summary> Get the Goals client. </summary>
        public virtual GoalsClient Goals
        {
            get
            {
                return _goalsClient;
            }
        }

        /// <summary> Get the GoalsStatusRules client. </summary>
        public virtual GoalsStatusRulesClient GoalsStatusRules
        {
            get
            {
                return _goalsStatusRulesClient;
            }
        }

        /// <summary> Get the GoalValues client. </summary>
        public virtual GoalValuesClient GoalValues
        {
            get
            {
                return _goalValuesClient;
            }
        }

        /// <summary> Get the GoalNotes client. </summary>
        public virtual GoalNotesClient GoalNotes
        {
            get
            {
                return _goalNotesClient;
            }
        }

        /// <summary> Get the TemplateApps client. </summary>
        public virtual TemplateAppsClient TemplateApps
        {
            get
            {
                return _templateAppsClient;
            }
        }
    }
    internal class HeaderPolicy : HttpPipelinePolicy
    {
        private string _headerName { get; }
        private Guid _headerValue { get; }

        internal HeaderPolicy(string headerName, Guid headerValue)
        {
            _headerName = headerName;
            _headerValue = headerValue;
        }

        public override async ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            message.Request.Headers.Add(_headerName, _headerValue.ToString());
            await ProcessNextAsync(message, pipeline);
        }

        public override void Process(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            message.Request.Headers.Add(_headerName, _headerValue.ToString());
            ProcessNext(message, pipeline);
        }
    }
}
