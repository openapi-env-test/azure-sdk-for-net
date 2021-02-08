// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// The Azure SQL Database management API provides a RESTful set of web
    /// services that interact with Azure SQL Database services to manage your
    /// databases. The API enables you to create, retrieve, update, and delete
    /// databases.
    /// </summary>
    public partial class SqlManagementClient : ServiceClient<SqlManagementClient>, ISqlManagementClient, IAzureClient
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
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The subscription ID that identifies an Azure subscription.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The API version to use for the request.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IExtendedDatabaseBlobAuditingPoliciesOperations.
        /// </summary>
        public virtual IExtendedDatabaseBlobAuditingPoliciesOperations ExtendedDatabaseBlobAuditingPolicies { get; private set; }

        /// <summary>
        /// Gets the IExtendedServerBlobAuditingPoliciesOperations.
        /// </summary>
        public virtual IExtendedServerBlobAuditingPoliciesOperations ExtendedServerBlobAuditingPolicies { get; private set; }

        /// <summary>
        /// Gets the IServerBlobAuditingPoliciesOperations.
        /// </summary>
        public virtual IServerBlobAuditingPoliciesOperations ServerBlobAuditingPolicies { get; private set; }

        /// <summary>
        /// Gets the IDatabaseBlobAuditingPoliciesOperations.
        /// </summary>
        public virtual IDatabaseBlobAuditingPoliciesOperations DatabaseBlobAuditingPolicies { get; private set; }

        /// <summary>
        /// Gets the IDatabaseOperations.
        /// </summary>
        public virtual IDatabaseOperations DatabaseOperations { get; private set; }

        /// <summary>
        /// Gets the IDatabasesOperations.
        /// </summary>
        public virtual IDatabasesOperations Databases { get; private set; }

        /// <summary>
        /// Gets the IDatabaseVulnerabilityAssessmentRuleBaselinesOperations.
        /// </summary>
        public virtual IDatabaseVulnerabilityAssessmentRuleBaselinesOperations DatabaseVulnerabilityAssessmentRuleBaselines { get; private set; }

        /// <summary>
        /// Gets the IDatabaseVulnerabilityAssessmentsOperations.
        /// </summary>
        public virtual IDatabaseVulnerabilityAssessmentsOperations DatabaseVulnerabilityAssessments { get; private set; }

        /// <summary>
        /// Gets the IDataWarehouseUserActivitiesOperations.
        /// </summary>
        public virtual IDataWarehouseUserActivitiesOperations DataWarehouseUserActivities { get; private set; }

        /// <summary>
        /// Gets the IJobAgentsOperations.
        /// </summary>
        public virtual IJobAgentsOperations JobAgents { get; private set; }

        /// <summary>
        /// Gets the IJobCredentialsOperations.
        /// </summary>
        public virtual IJobCredentialsOperations JobCredentials { get; private set; }

        /// <summary>
        /// Gets the IJobExecutionsOperations.
        /// </summary>
        public virtual IJobExecutionsOperations JobExecutions { get; private set; }

        /// <summary>
        /// Gets the IJobsOperations.
        /// </summary>
        public virtual IJobsOperations Jobs { get; private set; }

        /// <summary>
        /// Gets the IJobStepExecutionsOperations.
        /// </summary>
        public virtual IJobStepExecutionsOperations JobStepExecutions { get; private set; }

        /// <summary>
        /// Gets the IJobStepsOperations.
        /// </summary>
        public virtual IJobStepsOperations JobSteps { get; private set; }

        /// <summary>
        /// Gets the IJobTargetExecutionsOperations.
        /// </summary>
        public virtual IJobTargetExecutionsOperations JobTargetExecutions { get; private set; }

        /// <summary>
        /// Gets the IJobTargetGroupsOperations.
        /// </summary>
        public virtual IJobTargetGroupsOperations JobTargetGroups { get; private set; }

        /// <summary>
        /// Gets the IJobVersionsOperations.
        /// </summary>
        public virtual IJobVersionsOperations JobVersions { get; private set; }

        /// <summary>
        /// Gets the ILongTermRetentionBackupsOperations.
        /// </summary>
        public virtual ILongTermRetentionBackupsOperations LongTermRetentionBackups { get; private set; }

        /// <summary>
        /// Gets the IBackupLongTermRetentionPoliciesOperations.
        /// </summary>
        public virtual IBackupLongTermRetentionPoliciesOperations BackupLongTermRetentionPolicies { get; private set; }

        /// <summary>
        /// Gets the IManagedBackupShortTermRetentionPoliciesOperations.
        /// </summary>
        public virtual IManagedBackupShortTermRetentionPoliciesOperations ManagedBackupShortTermRetentionPolicies { get; private set; }

        /// <summary>
        /// Gets the IManagedDatabasesOperations.
        /// </summary>
        public virtual IManagedDatabasesOperations ManagedDatabases { get; private set; }

        /// <summary>
        /// Gets the IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations.
        /// </summary>
        public virtual IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies { get; private set; }

        /// <summary>
        /// Gets the IRestorableDroppedManagedDatabasesOperations.
        /// </summary>
        public virtual IRestorableDroppedManagedDatabasesOperations RestorableDroppedManagedDatabases { get; private set; }

        /// <summary>
        /// Gets the IRestorePointsOperations.
        /// </summary>
        public virtual IRestorePointsOperations RestorePoints { get; private set; }

        /// <summary>
        /// Gets the IServerAutomaticTuningOperations.
        /// </summary>
        public virtual IServerAutomaticTuningOperations ServerAutomaticTuning { get; private set; }

        /// <summary>
        /// Gets the IServerDnsAliasesOperations.
        /// </summary>
        public virtual IServerDnsAliasesOperations ServerDnsAliases { get; private set; }

        /// <summary>
        /// Gets the IServerSecurityAlertPoliciesOperations.
        /// </summary>
        public virtual IServerSecurityAlertPoliciesOperations ServerSecurityAlertPolicies { get; private set; }

        /// <summary>
        /// Gets the IManagedDatabaseSecurityAlertPoliciesOperations.
        /// </summary>
        public virtual IManagedDatabaseSecurityAlertPoliciesOperations ManagedDatabaseSecurityAlertPolicies { get; private set; }

        /// <summary>
        /// Gets the IManagedServerSecurityAlertPoliciesOperations.
        /// </summary>
        public virtual IManagedServerSecurityAlertPoliciesOperations ManagedServerSecurityAlertPolicies { get; private set; }

        /// <summary>
        /// Gets the ISensitivityLabelsOperations.
        /// </summary>
        public virtual ISensitivityLabelsOperations SensitivityLabels { get; private set; }

        /// <summary>
        /// Gets the IManagedInstanceAdministratorsOperations.
        /// </summary>
        public virtual IManagedInstanceAdministratorsOperations ManagedInstanceAdministrators { get; private set; }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling SqlManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        protected SqlManagementClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected SqlManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected SqlManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
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
        protected SqlManagementClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
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
        protected SqlManagementClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SqlManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
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
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling SqlManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SqlManagementClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
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
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
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
        public SqlManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
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
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SqlManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
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
        /// Initializes a new instance of the SqlManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
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
        public SqlManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
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
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            ExtendedDatabaseBlobAuditingPolicies = new ExtendedDatabaseBlobAuditingPoliciesOperations(this);
            ExtendedServerBlobAuditingPolicies = new ExtendedServerBlobAuditingPoliciesOperations(this);
            ServerBlobAuditingPolicies = new ServerBlobAuditingPoliciesOperations(this);
            DatabaseBlobAuditingPolicies = new DatabaseBlobAuditingPoliciesOperations(this);
            DatabaseOperations = new DatabaseOperations(this);
            Databases = new DatabasesOperations(this);
            DatabaseVulnerabilityAssessmentRuleBaselines = new DatabaseVulnerabilityAssessmentRuleBaselinesOperations(this);
            DatabaseVulnerabilityAssessments = new DatabaseVulnerabilityAssessmentsOperations(this);
            DataWarehouseUserActivities = new DataWarehouseUserActivitiesOperations(this);
            JobAgents = new JobAgentsOperations(this);
            JobCredentials = new JobCredentialsOperations(this);
            JobExecutions = new JobExecutionsOperations(this);
            Jobs = new JobsOperations(this);
            JobStepExecutions = new JobStepExecutionsOperations(this);
            JobSteps = new JobStepsOperations(this);
            JobTargetExecutions = new JobTargetExecutionsOperations(this);
            JobTargetGroups = new JobTargetGroupsOperations(this);
            JobVersions = new JobVersionsOperations(this);
            LongTermRetentionBackups = new LongTermRetentionBackupsOperations(this);
            BackupLongTermRetentionPolicies = new BackupLongTermRetentionPoliciesOperations(this);
            ManagedBackupShortTermRetentionPolicies = new ManagedBackupShortTermRetentionPoliciesOperations(this);
            ManagedDatabases = new ManagedDatabasesOperations(this);
            ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies = new ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations(this);
            RestorableDroppedManagedDatabases = new RestorableDroppedManagedDatabasesOperations(this);
            RestorePoints = new RestorePointsOperations(this);
            ServerAutomaticTuning = new ServerAutomaticTuningOperations(this);
            ServerDnsAliases = new ServerDnsAliasesOperations(this);
            ServerSecurityAlertPolicies = new ServerSecurityAlertPoliciesOperations(this);
            ManagedDatabaseSecurityAlertPolicies = new ManagedDatabaseSecurityAlertPoliciesOperations(this);
            ManagedServerSecurityAlertPolicies = new ManagedServerSecurityAlertPoliciesOperations(this);
            SensitivityLabels = new SensitivityLabelsOperations(this);
            ManagedInstanceAdministrators = new ManagedInstanceAdministratorsOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2017-03-01-preview";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
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
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
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
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
