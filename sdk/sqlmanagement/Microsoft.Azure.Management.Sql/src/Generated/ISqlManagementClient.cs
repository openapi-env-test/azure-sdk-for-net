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
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// The Azure SQL Database management API provides a RESTful set of web
    /// services that interact with Azure SQL Database services to manage your
    /// databases. The API enables you to create, retrieve, update, and delete
    /// databases.
    /// </summary>
    public partial interface ISqlManagementClient : System.IDisposable
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
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The subscription ID that identifies an Azure subscription.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The API version to use for the request.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IExtendedDatabaseBlobAuditingPoliciesOperations.
        /// </summary>
        IExtendedDatabaseBlobAuditingPoliciesOperations ExtendedDatabaseBlobAuditingPolicies { get; }

        /// <summary>
        /// Gets the IExtendedServerBlobAuditingPoliciesOperations.
        /// </summary>
        IExtendedServerBlobAuditingPoliciesOperations ExtendedServerBlobAuditingPolicies { get; }

        /// <summary>
        /// Gets the IServerBlobAuditingPoliciesOperations.
        /// </summary>
        IServerBlobAuditingPoliciesOperations ServerBlobAuditingPolicies { get; }

        /// <summary>
        /// Gets the IDatabaseBlobAuditingPoliciesOperations.
        /// </summary>
        IDatabaseBlobAuditingPoliciesOperations DatabaseBlobAuditingPolicies { get; }

        /// <summary>
        /// Gets the IDatabaseOperations.
        /// </summary>
        IDatabaseOperations DatabaseOperations { get; }

        /// <summary>
        /// Gets the IDatabasesOperations.
        /// </summary>
        IDatabasesOperations Databases { get; }

        /// <summary>
        /// Gets the IDatabaseVulnerabilityAssessmentRuleBaselinesOperations.
        /// </summary>
        IDatabaseVulnerabilityAssessmentRuleBaselinesOperations DatabaseVulnerabilityAssessmentRuleBaselines { get; }

        /// <summary>
        /// Gets the IDatabaseVulnerabilityAssessmentsOperations.
        /// </summary>
        IDatabaseVulnerabilityAssessmentsOperations DatabaseVulnerabilityAssessments { get; }

        /// <summary>
        /// Gets the IDataWarehouseUserActivitiesOperations.
        /// </summary>
        IDataWarehouseUserActivitiesOperations DataWarehouseUserActivities { get; }

        /// <summary>
        /// Gets the IJobAgentsOperations.
        /// </summary>
        IJobAgentsOperations JobAgents { get; }

        /// <summary>
        /// Gets the IJobCredentialsOperations.
        /// </summary>
        IJobCredentialsOperations JobCredentials { get; }

        /// <summary>
        /// Gets the IJobExecutionsOperations.
        /// </summary>
        IJobExecutionsOperations JobExecutions { get; }

        /// <summary>
        /// Gets the IJobsOperations.
        /// </summary>
        IJobsOperations Jobs { get; }

        /// <summary>
        /// Gets the IJobStepExecutionsOperations.
        /// </summary>
        IJobStepExecutionsOperations JobStepExecutions { get; }

        /// <summary>
        /// Gets the IJobStepsOperations.
        /// </summary>
        IJobStepsOperations JobSteps { get; }

        /// <summary>
        /// Gets the IJobTargetExecutionsOperations.
        /// </summary>
        IJobTargetExecutionsOperations JobTargetExecutions { get; }

        /// <summary>
        /// Gets the IJobTargetGroupsOperations.
        /// </summary>
        IJobTargetGroupsOperations JobTargetGroups { get; }

        /// <summary>
        /// Gets the IJobVersionsOperations.
        /// </summary>
        IJobVersionsOperations JobVersions { get; }

        /// <summary>
        /// Gets the ILongTermRetentionBackupsOperations.
        /// </summary>
        ILongTermRetentionBackupsOperations LongTermRetentionBackups { get; }

        /// <summary>
        /// Gets the IBackupLongTermRetentionPoliciesOperations.
        /// </summary>
        IBackupLongTermRetentionPoliciesOperations BackupLongTermRetentionPolicies { get; }

        /// <summary>
        /// Gets the IManagedBackupShortTermRetentionPoliciesOperations.
        /// </summary>
        IManagedBackupShortTermRetentionPoliciesOperations ManagedBackupShortTermRetentionPolicies { get; }

        /// <summary>
        /// Gets the IManagedDatabasesOperations.
        /// </summary>
        IManagedDatabasesOperations ManagedDatabases { get; }

        /// <summary>
        /// Gets the IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations.
        /// </summary>
        IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies { get; }

        /// <summary>
        /// Gets the IRestorableDroppedManagedDatabasesOperations.
        /// </summary>
        IRestorableDroppedManagedDatabasesOperations RestorableDroppedManagedDatabases { get; }

        /// <summary>
        /// Gets the IRestorePointsOperations.
        /// </summary>
        IRestorePointsOperations RestorePoints { get; }

        /// <summary>
        /// Gets the IServerAutomaticTuningOperations.
        /// </summary>
        IServerAutomaticTuningOperations ServerAutomaticTuning { get; }

        /// <summary>
        /// Gets the IServerDnsAliasesOperations.
        /// </summary>
        IServerDnsAliasesOperations ServerDnsAliases { get; }

        /// <summary>
        /// Gets the IServerSecurityAlertPoliciesOperations.
        /// </summary>
        IServerSecurityAlertPoliciesOperations ServerSecurityAlertPolicies { get; }

        /// <summary>
        /// Gets the IManagedDatabaseSecurityAlertPoliciesOperations.
        /// </summary>
        IManagedDatabaseSecurityAlertPoliciesOperations ManagedDatabaseSecurityAlertPolicies { get; }

        /// <summary>
        /// Gets the IManagedServerSecurityAlertPoliciesOperations.
        /// </summary>
        IManagedServerSecurityAlertPoliciesOperations ManagedServerSecurityAlertPolicies { get; }

        /// <summary>
        /// Gets the ISensitivityLabelsOperations.
        /// </summary>
        ISensitivityLabelsOperations SensitivityLabels { get; }

        /// <summary>
        /// Gets the IManagedInstanceAdministratorsOperations.
        /// </summary>
        IManagedInstanceAdministratorsOperations ManagedInstanceAdministrators { get; }

    }
}
