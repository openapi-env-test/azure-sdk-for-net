// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Contoso.Azure.Management.Cdn
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LogAnalyticsOperations.
    /// </summary>
    public static partial class LogAnalyticsOperationsExtensions
    {
            /// <summary>
            /// Get log report for AFD profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='metrics'>
            /// </param>
            /// <param name='dateTimeBegin'>
            /// </param>
            /// <param name='dateTimeEnd'>
            /// </param>
            /// <param name='granularity'>
            /// Possible values include: 'PT5M', 'PT1H', 'P1D'
            /// </param>
            /// <param name='groupBy'>
            /// </param>
            /// <param name='continents'>
            /// </param>
            /// <param name='countryOrRegions'>
            /// </param>
            /// <param name='customDomains'>
            /// </param>
            /// <param name='protocols'>
            /// </param>
            public static MetricsResponse GetLogAnalyticsMetrics(this ILogAnalyticsOperations operations, string resourceGroupName, string profileName, IList<string> metrics, System.DateTime dateTimeBegin, System.DateTime dateTimeEnd, string granularity, IList<string> groupBy = default(IList<string>), IList<string> continents = default(IList<string>), IList<string> countryOrRegions = default(IList<string>), IList<string> customDomains = default(IList<string>), IList<string> protocols = default(IList<string>))
            {
                return operations.GetLogAnalyticsMetricsAsync(resourceGroupName, profileName, metrics, dateTimeBegin, dateTimeEnd, granularity, groupBy, continents, countryOrRegions, customDomains, protocols).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get log report for AFD profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='metrics'>
            /// </param>
            /// <param name='dateTimeBegin'>
            /// </param>
            /// <param name='dateTimeEnd'>
            /// </param>
            /// <param name='granularity'>
            /// Possible values include: 'PT5M', 'PT1H', 'P1D'
            /// </param>
            /// <param name='groupBy'>
            /// </param>
            /// <param name='continents'>
            /// </param>
            /// <param name='countryOrRegions'>
            /// </param>
            /// <param name='customDomains'>
            /// </param>
            /// <param name='protocols'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MetricsResponse> GetLogAnalyticsMetricsAsync(this ILogAnalyticsOperations operations, string resourceGroupName, string profileName, IList<string> metrics, System.DateTime dateTimeBegin, System.DateTime dateTimeEnd, string granularity, IList<string> groupBy = default(IList<string>), IList<string> continents = default(IList<string>), IList<string> countryOrRegions = default(IList<string>), IList<string> customDomains = default(IList<string>), IList<string> protocols = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLogAnalyticsMetricsWithHttpMessagesAsync(resourceGroupName, profileName, metrics, dateTimeBegin, dateTimeEnd, granularity, groupBy, continents, countryOrRegions, customDomains, protocols, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get log analytics ranking report for AFD profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='rankings'>
            /// </param>
            /// <param name='metrics'>
            /// </param>
            /// <param name='maxRanking'>
            /// </param>
            /// <param name='dateTimeBegin'>
            /// </param>
            /// <param name='dateTimeEnd'>
            /// </param>
            /// <param name='customDomains'>
            /// </param>
            public static RankingsResponse GetLogAnalyticsRankings(this ILogAnalyticsOperations operations, string resourceGroupName, string profileName, IList<string> rankings, IList<string> metrics, double maxRanking, System.DateTime dateTimeBegin, System.DateTime dateTimeEnd, IList<string> customDomains = default(IList<string>))
            {
                return operations.GetLogAnalyticsRankingsAsync(resourceGroupName, profileName, rankings, metrics, maxRanking, dateTimeBegin, dateTimeEnd, customDomains).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get log analytics ranking report for AFD profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='rankings'>
            /// </param>
            /// <param name='metrics'>
            /// </param>
            /// <param name='maxRanking'>
            /// </param>
            /// <param name='dateTimeBegin'>
            /// </param>
            /// <param name='dateTimeEnd'>
            /// </param>
            /// <param name='customDomains'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RankingsResponse> GetLogAnalyticsRankingsAsync(this ILogAnalyticsOperations operations, string resourceGroupName, string profileName, IList<string> rankings, IList<string> metrics, double maxRanking, System.DateTime dateTimeBegin, System.DateTime dateTimeEnd, IList<string> customDomains = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLogAnalyticsRankingsWithHttpMessagesAsync(resourceGroupName, profileName, rankings, metrics, maxRanking, dateTimeBegin, dateTimeEnd, customDomains, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all available location names for AFD log analytics report.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            public static ContinentsResponse GetLogAnalyticsLocations(this ILogAnalyticsOperations operations, string resourceGroupName, string profileName)
            {
                return operations.GetLogAnalyticsLocationsAsync(resourceGroupName, profileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all available location names for AFD log analytics report.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContinentsResponse> GetLogAnalyticsLocationsAsync(this ILogAnalyticsOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLogAnalyticsLocationsWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all endpoints and custom domains available for AFD log report
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            public static ResourcesResponse GetLogAnalyticsResources(this ILogAnalyticsOperations operations, string resourceGroupName, string profileName)
            {
                return operations.GetLogAnalyticsResourcesAsync(resourceGroupName, profileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all endpoints and custom domains available for AFD log report
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourcesResponse> GetLogAnalyticsResourcesAsync(this ILogAnalyticsOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLogAnalyticsResourcesWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get Waf related log analytics report for AFD profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='metrics'>
            /// </param>
            /// <param name='dateTimeBegin'>
            /// </param>
            /// <param name='dateTimeEnd'>
            /// </param>
            /// <param name='granularity'>
            /// Possible values include: 'PT5M', 'PT1H', 'P1D'
            /// </param>
            /// <param name='actions'>
            /// </param>
            /// <param name='groupBy'>
            /// </param>
            /// <param name='ruleTypes'>
            /// </param>
            public static WafMetricsResponse GetWafLogAnalyticsMetrics(this ILogAnalyticsOperations operations, string resourceGroupName, string profileName, IList<string> metrics, System.DateTime dateTimeBegin, System.DateTime dateTimeEnd, string granularity, IList<string> actions = default(IList<string>), IList<string> groupBy = default(IList<string>), IList<string> ruleTypes = default(IList<string>))
            {
                return operations.GetWafLogAnalyticsMetricsAsync(resourceGroupName, profileName, metrics, dateTimeBegin, dateTimeEnd, granularity, actions, groupBy, ruleTypes).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Waf related log analytics report for AFD profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='metrics'>
            /// </param>
            /// <param name='dateTimeBegin'>
            /// </param>
            /// <param name='dateTimeEnd'>
            /// </param>
            /// <param name='granularity'>
            /// Possible values include: 'PT5M', 'PT1H', 'P1D'
            /// </param>
            /// <param name='actions'>
            /// </param>
            /// <param name='groupBy'>
            /// </param>
            /// <param name='ruleTypes'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WafMetricsResponse> GetWafLogAnalyticsMetricsAsync(this ILogAnalyticsOperations operations, string resourceGroupName, string profileName, IList<string> metrics, System.DateTime dateTimeBegin, System.DateTime dateTimeEnd, string granularity, IList<string> actions = default(IList<string>), IList<string> groupBy = default(IList<string>), IList<string> ruleTypes = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWafLogAnalyticsMetricsWithHttpMessagesAsync(resourceGroupName, profileName, metrics, dateTimeBegin, dateTimeEnd, granularity, actions, groupBy, ruleTypes, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get WAF log analytics charts for AFD profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='metrics'>
            /// </param>
            /// <param name='dateTimeBegin'>
            /// </param>
            /// <param name='dateTimeEnd'>
            /// </param>
            /// <param name='maxRanking'>
            /// </param>
            /// <param name='rankings'>
            /// </param>
            /// <param name='actions'>
            /// </param>
            /// <param name='ruleTypes'>
            /// </param>
            public static WafRankingsResponse GetWafLogAnalyticsRankings(this ILogAnalyticsOperations operations, string resourceGroupName, string profileName, IList<string> metrics, System.DateTime dateTimeBegin, System.DateTime dateTimeEnd, double maxRanking, IList<string> rankings, IList<string> actions = default(IList<string>), IList<string> ruleTypes = default(IList<string>))
            {
                return operations.GetWafLogAnalyticsRankingsAsync(resourceGroupName, profileName, metrics, dateTimeBegin, dateTimeEnd, maxRanking, rankings, actions, ruleTypes).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get WAF log analytics charts for AFD profile
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='metrics'>
            /// </param>
            /// <param name='dateTimeBegin'>
            /// </param>
            /// <param name='dateTimeEnd'>
            /// </param>
            /// <param name='maxRanking'>
            /// </param>
            /// <param name='rankings'>
            /// </param>
            /// <param name='actions'>
            /// </param>
            /// <param name='ruleTypes'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WafRankingsResponse> GetWafLogAnalyticsRankingsAsync(this ILogAnalyticsOperations operations, string resourceGroupName, string profileName, IList<string> metrics, System.DateTime dateTimeBegin, System.DateTime dateTimeEnd, double maxRanking, IList<string> rankings, IList<string> actions = default(IList<string>), IList<string> ruleTypes = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWafLogAnalyticsRankingsWithHttpMessagesAsync(resourceGroupName, profileName, metrics, dateTimeBegin, dateTimeEnd, maxRanking, rankings, actions, ruleTypes, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
