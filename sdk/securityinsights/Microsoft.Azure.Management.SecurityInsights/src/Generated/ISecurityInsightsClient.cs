// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Contoso.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// API spec for Microsoft.SecurityInsights (Azure Security Insights)
    /// resource provider
    /// </summary>
    public partial interface ISecurityInsightsClient : System.IDisposable
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
        /// API version for the operation
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Azure subscription ID
        /// </summary>
        string SubscriptionId { get; set; }

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
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IAlertRulesOperations.
        /// </summary>
        IAlertRulesOperations AlertRules { get; }

        /// <summary>
        /// Gets the IActionsOperations.
        /// </summary>
        IActionsOperations Actions { get; }

        /// <summary>
        /// Gets the IAlertRuleTemplatesOperations.
        /// </summary>
        IAlertRuleTemplatesOperations AlertRuleTemplates { get; }

        /// <summary>
        /// Gets the ICasesOperations.
        /// </summary>
        ICasesOperations Cases { get; }

        /// <summary>
        /// Gets the ICommentsOperations.
        /// </summary>
        ICommentsOperations Comments { get; }

        /// <summary>
        /// Gets the ICaseCommentsOperations.
        /// </summary>
        ICaseCommentsOperations CaseComments { get; }

        /// <summary>
        /// Gets the IBookmarksOperations.
        /// </summary>
        IBookmarksOperations Bookmarks { get; }

        /// <summary>
        /// Gets the ICaseRelationsOperations.
        /// </summary>
        ICaseRelationsOperations CaseRelations { get; }

        /// <summary>
        /// Gets the IBookmarkRelationsOperations.
        /// </summary>
        IBookmarkRelationsOperations BookmarkRelations { get; }

        /// <summary>
        /// Gets the IBookmarkOperations.
        /// </summary>
        IBookmarkOperations Bookmark { get; }

        /// <summary>
        /// Gets the IDataConnectorsOperations.
        /// </summary>
        IDataConnectorsOperations DataConnectors { get; }

        /// <summary>
        /// Gets the IDataConnectorsCheckRequirementsOperations.
        /// </summary>
        IDataConnectorsCheckRequirementsOperations DataConnectorsCheckRequirements { get; }

        /// <summary>
        /// Gets the IEntitiesOperations.
        /// </summary>
        IEntitiesOperations Entities { get; }

        /// <summary>
        /// Gets the IEntitiesGetTimelineOperations.
        /// </summary>
        IEntitiesGetTimelineOperations EntitiesGetTimeline { get; }

        /// <summary>
        /// Gets the IEntitiesRelationsOperations.
        /// </summary>
        IEntitiesRelationsOperations EntitiesRelations { get; }

        /// <summary>
        /// Gets the IEntityRelationsOperations.
        /// </summary>
        IEntityRelationsOperations EntityRelations { get; }

        /// <summary>
        /// Gets the IOfficeConsentsOperations.
        /// </summary>
        IOfficeConsentsOperations OfficeConsents { get; }

        /// <summary>
        /// Gets the IProductSettingsOperations.
        /// </summary>
        IProductSettingsOperations ProductSettings { get; }

        /// <summary>
        /// Gets the ICasesAggregationsOperations.
        /// </summary>
        ICasesAggregationsOperations CasesAggregations { get; }

        /// <summary>
        /// Gets the IEntityQueriesOperations.
        /// </summary>
        IEntityQueriesOperations EntityQueries { get; }

        /// <summary>
        /// Gets the IIncidentsOperations.
        /// </summary>
        IIncidentsOperations Incidents { get; }

        /// <summary>
        /// Gets the IIncidentCommentsOperations.
        /// </summary>
        IIncidentCommentsOperations IncidentComments { get; }

        /// <summary>
        /// Gets the IIncidentRelationsOperations.
        /// </summary>
        IIncidentRelationsOperations IncidentRelations { get; }

        /// <summary>
        /// Gets the IWatchlistsOperations.
        /// </summary>
        IWatchlistsOperations Watchlists { get; }

        /// <summary>
        /// Gets the IWatchlistItemOperations.
        /// </summary>
        IWatchlistItemOperations WatchlistItem { get; }

        /// <summary>
        /// Gets the IThreatIntelligenceIndicatorOperations.
        /// </summary>
        IThreatIntelligenceIndicatorOperations ThreatIntelligenceIndicator { get; }

        /// <summary>
        /// Gets the IThreatIntelligenceIndicatorsOperations.
        /// </summary>
        IThreatIntelligenceIndicatorsOperations ThreatIntelligenceIndicators { get; }

        /// <summary>
        /// Gets the IThreatIntelligenceIndicatorMetricsOperations.
        /// </summary>
        IThreatIntelligenceIndicatorMetricsOperations ThreatIntelligenceIndicatorMetrics { get; }

    }
}
