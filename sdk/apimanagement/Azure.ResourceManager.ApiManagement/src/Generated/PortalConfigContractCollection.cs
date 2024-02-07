// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="PortalConfigContractResource"/> and their operations.
    /// Each <see cref="PortalConfigContractResource"/> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource"/>.
    /// To get a <see cref="PortalConfigContractCollection"/> instance call the GetPortalConfigContracts method from an instance of <see cref="ApiManagementServiceResource"/>.
    /// </summary>
    public partial class PortalConfigContractCollection : ArmCollection, IEnumerable<PortalConfigContractResource>, IAsyncEnumerable<PortalConfigContractResource>
    {
        private readonly ClientDiagnostics _portalConfigContractPortalConfigClientDiagnostics;
        private readonly PortalConfigRestOperations _portalConfigContractPortalConfigRestClient;

        /// <summary> Initializes a new instance of the <see cref="PortalConfigContractCollection"/> class for mocking. </summary>
        protected PortalConfigContractCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PortalConfigContractCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PortalConfigContractCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _portalConfigContractPortalConfigClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", PortalConfigContractResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PortalConfigContractResource.ResourceType, out string portalConfigContractPortalConfigApiVersion);
            _portalConfigContractPortalConfigRestClient = new PortalConfigRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, portalConfigContractPortalConfigApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update the developer portal configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="portalConfigId"> Portal configuration identifier. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="data"> Update the developer portal configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalConfigId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PortalConfigContractResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string portalConfigId, ETag ifMatch, PortalConfigContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalConfigId, nameof(portalConfigId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _portalConfigContractPortalConfigRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalConfigId, ifMatch, data, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<PortalConfigContractResource>(Response.FromValue(new PortalConfigContractResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update the developer portal configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="portalConfigId"> Portal configuration identifier. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="data"> Update the developer portal configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalConfigId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PortalConfigContractResource> CreateOrUpdate(WaitUntil waitUntil, string portalConfigId, ETag ifMatch, PortalConfigContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalConfigId, nameof(portalConfigId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _portalConfigContractPortalConfigRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalConfigId, ifMatch, data, cancellationToken);
                var operation = new ApiManagementArmOperation<PortalConfigContractResource>(Response.FromValue(new PortalConfigContractResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the developer portal configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portalConfigId"> Portal configuration identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalConfigId"/> is null. </exception>
        public virtual async Task<Response<PortalConfigContractResource>> GetAsync(string portalConfigId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalConfigId, nameof(portalConfigId));

            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractCollection.Get");
            scope.Start();
            try
            {
                var response = await _portalConfigContractPortalConfigRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalConfigId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PortalConfigContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the developer portal configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portalConfigId"> Portal configuration identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalConfigId"/> is null. </exception>
        public virtual Response<PortalConfigContractResource> Get(string portalConfigId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalConfigId, nameof(portalConfigId));

            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractCollection.Get");
            scope.Start();
            try
            {
                var response = _portalConfigContractPortalConfigRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalConfigId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PortalConfigContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the developer portal configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PortalConfigContractResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PortalConfigContractResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _portalConfigContractPortalConfigRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _portalConfigContractPortalConfigRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PortalConfigContractResource(Client, PortalConfigContractData.DeserializePortalConfigContractData(e)), _portalConfigContractPortalConfigClientDiagnostics, Pipeline, "PortalConfigContractCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the developer portal configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PortalConfigContractResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PortalConfigContractResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _portalConfigContractPortalConfigRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _portalConfigContractPortalConfigRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PortalConfigContractResource(Client, PortalConfigContractData.DeserializePortalConfigContractData(e)), _portalConfigContractPortalConfigClientDiagnostics, Pipeline, "PortalConfigContractCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portalConfigId"> Portal configuration identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalConfigId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string portalConfigId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalConfigId, nameof(portalConfigId));

            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractCollection.Exists");
            scope.Start();
            try
            {
                var response = await _portalConfigContractPortalConfigRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalConfigId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portalConfigId"> Portal configuration identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalConfigId"/> is null. </exception>
        public virtual Response<bool> Exists(string portalConfigId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalConfigId, nameof(portalConfigId));

            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractCollection.Exists");
            scope.Start();
            try
            {
                var response = _portalConfigContractPortalConfigRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalConfigId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portalConfigId"> Portal configuration identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalConfigId"/> is null. </exception>
        public virtual async Task<NullableResponse<PortalConfigContractResource>> GetIfExistsAsync(string portalConfigId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalConfigId, nameof(portalConfigId));

            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _portalConfigContractPortalConfigRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalConfigId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PortalConfigContractResource>(response.GetRawResponse());
                return Response.FromValue(new PortalConfigContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/portalconfigs/{portalConfigId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PortalConfig_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="portalConfigId"> Portal configuration identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="portalConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="portalConfigId"/> is null. </exception>
        public virtual NullableResponse<PortalConfigContractResource> GetIfExists(string portalConfigId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(portalConfigId, nameof(portalConfigId));

            using var scope = _portalConfigContractPortalConfigClientDiagnostics.CreateScope("PortalConfigContractCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _portalConfigContractPortalConfigRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, portalConfigId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PortalConfigContractResource>(response.GetRawResponse());
                return Response.FromValue(new PortalConfigContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PortalConfigContractResource> IEnumerable<PortalConfigContractResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PortalConfigContractResource> IAsyncEnumerable<PortalConfigContractResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
