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
    /// <summary> The RestorableSqlContainers service client. </summary>
    public partial class RestorableSqlContainersOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal RestorableSqlContainersRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of RestorableSqlContainersOperations for mocking. </summary>
        protected RestorableSqlContainersOperations()
        {
        }

        /// <summary> Initializes a new instance of RestorableSqlContainersOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal RestorableSqlContainersOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-07-01-preview")
        {
            RestClient = new RestorableSqlContainersRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB SQL containers under a specific database.  This helps in scenario where container was accidentally deleted.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="restorableSqlDatabaseRid"> The resource ID of the SQL database. </param>
        /// <param name="startTime"> The snapshot create timestamp after which snapshots need to be listed. </param>
        /// <param name="endTime"> The snapshot create timestamp before which snapshots need to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="instanceId"/> is null. </exception>
        public virtual AsyncPageable<RestorableSqlContainerGetResult> ListAsync(string location, string instanceId, string restorableSqlDatabaseRid = null, string startTime = null, string endTime = null, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            async Task<Page<RestorableSqlContainerGetResult>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorableSqlContainersOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(location, instanceId, restorableSqlDatabaseRid, startTime, endTime, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB SQL containers under a specific database.  This helps in scenario where container was accidentally deleted.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="restorableSqlDatabaseRid"> The resource ID of the SQL database. </param>
        /// <param name="startTime"> The snapshot create timestamp after which snapshots need to be listed. </param>
        /// <param name="endTime"> The snapshot create timestamp before which snapshots need to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="instanceId"/> is null. </exception>
        public virtual Pageable<RestorableSqlContainerGetResult> List(string location, string instanceId, string restorableSqlDatabaseRid = null, string startTime = null, string endTime = null, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            Page<RestorableSqlContainerGetResult> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorableSqlContainersOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(location, instanceId, restorableSqlDatabaseRid, startTime, endTime, cancellationToken);
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
