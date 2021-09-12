// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    public partial class PowerBIClient : ServiceClient<PowerBIClient>, IPowerBIClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client subscription.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Gets the IDatasetsOperations.
        /// </summary>
        public virtual IDatasetsOperations Datasets { get; private set; }

        /// <summary>
        /// Gets the IUsers.
        /// </summary>
        public virtual IUsers Users { get; private set; }

        /// <summary>
        /// Gets the IImportsOperations.
        /// </summary>
        public virtual IImportsOperations Imports { get; private set; }

        /// <summary>
        /// Gets the IReportsOperations.
        /// </summary>
        public virtual IReportsOperations Reports { get; private set; }

        /// <summary>
        /// Gets the IDashboardsOperations.
        /// </summary>
        public virtual IDashboardsOperations Dashboards { get; private set; }

        /// <summary>
        /// Gets the ITilesOperations.
        /// </summary>
        public virtual ITilesOperations Tiles { get; private set; }

        /// <summary>
        /// Gets the IAppsOperations.
        /// </summary>
        public virtual IAppsOperations Apps { get; private set; }

        /// <summary>
        /// Gets the IDataflowsOperations.
        /// </summary>
        public virtual IDataflowsOperations Dataflows { get; private set; }

        /// <summary>
        /// Gets the IGatewaysOperations.
        /// </summary>
        public virtual IGatewaysOperations Gateways { get; private set; }

        /// <summary>
        /// Gets the IGroupsOperations.
        /// </summary>
        public virtual IGroupsOperations Groups { get; private set; }

        /// <summary>
        /// Gets the ICapacitiesOperations.
        /// </summary>
        public virtual ICapacitiesOperations Capacities { get; private set; }

        /// <summary>
        /// Gets the IAvailableFeaturesOperations.
        /// </summary>
        public virtual IAvailableFeaturesOperations AvailableFeatures { get; private set; }

        /// <summary>
        /// Gets the IPipelinesOperations.
        /// </summary>
        public virtual IPipelinesOperations Pipelines { get; private set; }

        /// <summary>
        /// Gets the IDataflowStorageAccountsOperations.
        /// </summary>
        public virtual IDataflowStorageAccountsOperations DataflowStorageAccounts { get; private set; }

        /// <summary>
        /// Gets the IWorkspaceInfoOperations.
        /// </summary>
        public virtual IWorkspaceInfoOperations WorkspaceInfo { get; private set; }

        /// <summary>
        /// Gets the IAdmin.
        /// </summary>
        public virtual IAdmin Admin { get; private set; }

        /// <summary>
        /// Gets the IEmbedTokenOperations.
        /// </summary>
        public virtual IEmbedTokenOperations EmbedToken { get; private set; }

        /// <summary>
        /// Gets the IInformationProtection.
        /// </summary>
        public virtual IInformationProtection InformationProtection { get; private set; }

        /// <summary>
        /// Gets the ITemplateApps.
        /// </summary>
        public virtual ITemplateApps TemplateApps { get; private set; }

        /// <summary>
        /// Initializes a new instance of the PowerBIClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected PowerBIClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the PowerBIClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected PowerBIClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the PowerBIClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected PowerBIClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the PowerBIClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected PowerBIClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the PowerBIClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public PowerBIClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the PowerBIClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public PowerBIClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the PowerBIClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public PowerBIClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the PowerBIClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public PowerBIClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Datasets = new DatasetsOperations(this);
            Users = new Users(this);
            Imports = new ImportsOperations(this);
            Reports = new ReportsOperations(this);
            Dashboards = new DashboardsOperations(this);
            Tiles = new TilesOperations(this);
            Apps = new AppsOperations(this);
            Dataflows = new DataflowsOperations(this);
            Gateways = new GatewaysOperations(this);
            Groups = new GroupsOperations(this);
            Capacities = new CapacitiesOperations(this);
            AvailableFeatures = new AvailableFeaturesOperations(this);
            Pipelines = new PipelinesOperations(this);
            DataflowStorageAccounts = new DataflowStorageAccountsOperations(this);
            WorkspaceInfo = new WorkspaceInfoOperations(this);
            Admin = new Admin(this);
            EmbedToken = new EmbedTokenOperations(this);
            InformationProtection = new InformationProtection(this);
            TemplateApps = new TemplateApps(this);
            BaseUri = new System.Uri("https://api.powerbi.com/v1.0/myorg");
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
    }
}
