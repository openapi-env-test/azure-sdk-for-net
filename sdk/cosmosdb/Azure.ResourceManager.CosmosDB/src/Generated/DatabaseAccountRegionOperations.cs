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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> The DatabaseAccountRegion service client. </summary>
    public partial class DatabaseAccountRegionOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DatabaseAccountRegionRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of DatabaseAccountRegionOperations for mocking. </summary>
        protected DatabaseAccountRegionOperations()
        {
        }

        /// <summary> Initializes a new instance of DatabaseAccountRegionOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal DatabaseAccountRegionOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-07-01-preview")
        {
            RestClient = new DatabaseAccountRegionRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieves the metrics determined by the given filter for the given database account and region. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="region"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of metrics to return. The parameters that can be filtered are name.value (name of the metric, can have an or of multiple names), startTime, endTime, and timeGrain. The supported operator is eq. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="region"/>, or <paramref name="filter"/> is null. </exception>
        public virtual AsyncPageable<Metric> ListMetricsAsync(string resourceGroupName, string accountName, string region, string filter, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (region == null)
            {
                throw new ArgumentNullException(nameof(region));
            }
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            async Task<Page<Metric>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DatabaseAccountRegionOperations.ListMetrics");
                scope.Start();
                try
                {
                    var response = await RestClient.ListMetricsAsync(resourceGroupName, accountName, region, filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Retrieves the metrics determined by the given filter for the given database account and region. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="region"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="filter"> An OData filter expression that describes a subset of metrics to return. The parameters that can be filtered are name.value (name of the metric, can have an or of multiple names), startTime, endTime, and timeGrain. The supported operator is eq. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="region"/>, or <paramref name="filter"/> is null. </exception>
        public virtual Pageable<Metric> ListMetrics(string resourceGroupName, string accountName, string region, string filter, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (region == null)
            {
                throw new ArgumentNullException(nameof(region));
            }
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            Page<Metric> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DatabaseAccountRegionOperations.ListMetrics");
                scope.Start();
                try
                {
                    var response = RestClient.ListMetrics(resourceGroupName, accountName, region, filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
