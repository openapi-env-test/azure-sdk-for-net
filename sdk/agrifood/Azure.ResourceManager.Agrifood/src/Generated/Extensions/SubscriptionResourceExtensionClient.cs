// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Agrifood.Models;

namespace Azure.ResourceManager.Agrifood
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _farmBeatFarmBeatsModelsClientDiagnostics;
        private FarmBeatsModelsRestOperations _farmBeatFarmBeatsModelsRestClient;
        private ClientDiagnostics _locationsClientDiagnostics;
        private LocationsRestOperations _locationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics FarmBeatFarmBeatsModelsClientDiagnostics => _farmBeatFarmBeatsModelsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Agrifood", FarmBeatResource.ResourceType.Namespace, Diagnostics);
        private FarmBeatsModelsRestOperations FarmBeatFarmBeatsModelsRestClient => _farmBeatFarmBeatsModelsRestClient ??= new FarmBeatsModelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(FarmBeatResource.ResourceType));
        private ClientDiagnostics LocationsClientDiagnostics => _locationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Agrifood", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationsRestOperations LocationsRestClient => _locationsRestClient ??= new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists the FarmBeats instances for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AgFoodPlatform/farmBeats
        /// Operation Id: FarmBeatsModels_ListBySubscription
        /// </summary>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FarmBeatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FarmBeatResource> GetFarmBeatsAsync(int? maxPageSize = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<FarmBeatResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = FarmBeatFarmBeatsModelsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFarmBeats");
                scope.Start();
                try
                {
                    var response = await FarmBeatFarmBeatsModelsRestClient.ListBySubscriptionAsync(Id.SubscriptionId, pageSizeHint, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FarmBeatResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FarmBeatResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = FarmBeatFarmBeatsModelsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFarmBeats");
                scope.Start();
                try
                {
                    var response = await FarmBeatFarmBeatsModelsRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, pageSizeHint, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FarmBeatResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the FarmBeats instances for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AgFoodPlatform/farmBeats
        /// Operation Id: FarmBeatsModels_ListBySubscription
        /// </summary>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FarmBeatResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FarmBeatResource> GetFarmBeats(int? maxPageSize = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<FarmBeatResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = FarmBeatFarmBeatsModelsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFarmBeats");
                scope.Start();
                try
                {
                    var response = FarmBeatFarmBeatsModelsRestClient.ListBySubscription(Id.SubscriptionId, pageSizeHint, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FarmBeatResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FarmBeatResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = FarmBeatFarmBeatsModelsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetFarmBeats");
                scope.Start();
                try
                {
                    var response = FarmBeatFarmBeatsModelsRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, pageSizeHint, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FarmBeatResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks the name availability of the resource with requested resource name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AgFoodPlatform/checkNameAvailability
        /// Operation Id: Locations_CheckNameAvailability
        /// </summary>
        /// <param name="content"> NameAvailabilityRequest object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckNameAvailabilityResponse>> CheckNameAvailabilityLocationAsync(CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityLocation");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks the name availability of the resource with requested resource name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AgFoodPlatform/checkNameAvailability
        /// Operation Id: Locations_CheckNameAvailability
        /// </summary>
        /// <param name="content"> NameAvailabilityRequest object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameAvailabilityResponse> CheckNameAvailabilityLocation(CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityLocation");
            scope.Start();
            try
            {
                var response = LocationsRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
