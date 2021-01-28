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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// WatchlistItemOperations operations.
    /// </summary>
    public partial interface IWatchlistItemOperations
    {
        /// <summary>
        /// Delete a watchlist item.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='operationalInsightsResourceProvider'>
        /// The namespace of workspaces resource provider-
        /// Microsoft.OperationalInsights.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='watchlistAlias'>
        /// Watchlist Alias
        /// </param>
        /// <param name='watchlistItemId'>
        /// Watchlist Item Id (GUID)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string watchlistAlias, string watchlistItemId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a watchlist item.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='operationalInsightsResourceProvider'>
        /// The namespace of workspaces resource provider-
        /// Microsoft.OperationalInsights.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='watchlistAlias'>
        /// Watchlist Alias
        /// </param>
        /// <param name='watchlistItemId'>
        /// Watchlist Item Id (GUID)
        /// </param>
        /// <param name='watchlistItem'>
        /// The watchlist item
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<WatchlistItem>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string watchlistAlias, string watchlistItemId, WatchlistItem watchlistItem, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
