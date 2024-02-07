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
    /// A class representing a collection of <see cref="ServiceProductGroupLinkResource"/> and their operations.
    /// Each <see cref="ServiceProductGroupLinkResource"/> in the collection will belong to the same instance of <see cref="ServiceProductResource"/>.
    /// To get a <see cref="ServiceProductGroupLinkCollection"/> instance call the GetServiceProductGroupLinks method from an instance of <see cref="ServiceProductResource"/>.
    /// </summary>
    public partial class ServiceProductGroupLinkCollection : ArmCollection, IEnumerable<ServiceProductGroupLinkResource>, IAsyncEnumerable<ServiceProductGroupLinkResource>
    {
        private readonly ClientDiagnostics _serviceProductGroupLinkProductGroupLinkClientDiagnostics;
        private readonly ProductGroupLinkRestOperations _serviceProductGroupLinkProductGroupLinkRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceProductGroupLinkCollection"/> class for mocking. </summary>
        protected ServiceProductGroupLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceProductGroupLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceProductGroupLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceProductGroupLinkProductGroupLinkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceProductGroupLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceProductGroupLinkResource.ResourceType, out string serviceProductGroupLinkProductGroupLinkApiVersion);
            _serviceProductGroupLinkProductGroupLinkRestClient = new ProductGroupLinkRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceProductGroupLinkProductGroupLinkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceProductResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceProductResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Adds a group to the specified product via link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/groupLinks/{groupLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductGroupLink_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="groupLinkId"> Product-Group link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupLinkId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceProductGroupLinkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string groupLinkId, ProductGroupLinkContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupLinkId, nameof(groupLinkId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceProductGroupLinkProductGroupLinkClientDiagnostics.CreateScope("ServiceProductGroupLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceProductGroupLinkProductGroupLinkRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupLinkId, data, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ServiceProductGroupLinkResource>(Response.FromValue(new ServiceProductGroupLinkResource(Client, response), response.GetRawResponse()));
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
        /// Adds a group to the specified product via link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/groupLinks/{groupLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductGroupLink_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="groupLinkId"> Product-Group link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupLinkId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceProductGroupLinkResource> CreateOrUpdate(WaitUntil waitUntil, string groupLinkId, ProductGroupLinkContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupLinkId, nameof(groupLinkId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceProductGroupLinkProductGroupLinkClientDiagnostics.CreateScope("ServiceProductGroupLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceProductGroupLinkProductGroupLinkRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupLinkId, data, cancellationToken);
                var operation = new ApiManagementArmOperation<ServiceProductGroupLinkResource>(Response.FromValue(new ServiceProductGroupLinkResource(Client, response), response.GetRawResponse()));
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
        /// Gets the group link for the product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/groupLinks/{groupLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductGroupLink_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupLinkId"> Product-Group link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupLinkId"/> is null. </exception>
        public virtual async Task<Response<ServiceProductGroupLinkResource>> GetAsync(string groupLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupLinkId, nameof(groupLinkId));

            using var scope = _serviceProductGroupLinkProductGroupLinkClientDiagnostics.CreateScope("ServiceProductGroupLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceProductGroupLinkProductGroupLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupLinkId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceProductGroupLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the group link for the product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/groupLinks/{groupLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductGroupLink_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupLinkId"> Product-Group link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupLinkId"/> is null. </exception>
        public virtual Response<ServiceProductGroupLinkResource> Get(string groupLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupLinkId, nameof(groupLinkId));

            using var scope = _serviceProductGroupLinkProductGroupLinkClientDiagnostics.CreateScope("ServiceProductGroupLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceProductGroupLinkProductGroupLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupLinkId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceProductGroupLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of the group links associated with a product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/groupLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductGroupLink_ListByProduct</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| groupId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceProductGroupLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceProductGroupLinkResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceProductGroupLinkProductGroupLinkRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceProductGroupLinkProductGroupLinkRestClient.CreateListByProductNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceProductGroupLinkResource(Client, ProductGroupLinkContractData.DeserializeProductGroupLinkContractData(e)), _serviceProductGroupLinkProductGroupLinkClientDiagnostics, Pipeline, "ServiceProductGroupLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of the group links associated with a product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/groupLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductGroupLink_ListByProduct</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| groupId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceProductGroupLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceProductGroupLinkResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceProductGroupLinkProductGroupLinkRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceProductGroupLinkProductGroupLinkRestClient.CreateListByProductNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceProductGroupLinkResource(Client, ProductGroupLinkContractData.DeserializeProductGroupLinkContractData(e)), _serviceProductGroupLinkProductGroupLinkClientDiagnostics, Pipeline, "ServiceProductGroupLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/groupLinks/{groupLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductGroupLink_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupLinkId"> Product-Group link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupLinkId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupLinkId, nameof(groupLinkId));

            using var scope = _serviceProductGroupLinkProductGroupLinkClientDiagnostics.CreateScope("ServiceProductGroupLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceProductGroupLinkProductGroupLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupLinkId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/groupLinks/{groupLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductGroupLink_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupLinkId"> Product-Group link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupLinkId"/> is null. </exception>
        public virtual Response<bool> Exists(string groupLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupLinkId, nameof(groupLinkId));

            using var scope = _serviceProductGroupLinkProductGroupLinkClientDiagnostics.CreateScope("ServiceProductGroupLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceProductGroupLinkProductGroupLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupLinkId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/groupLinks/{groupLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductGroupLink_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupLinkId"> Product-Group link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupLinkId"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceProductGroupLinkResource>> GetIfExistsAsync(string groupLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupLinkId, nameof(groupLinkId));

            using var scope = _serviceProductGroupLinkProductGroupLinkClientDiagnostics.CreateScope("ServiceProductGroupLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceProductGroupLinkProductGroupLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupLinkId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceProductGroupLinkResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceProductGroupLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/products/{productId}/groupLinks/{groupLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProductGroupLink_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupLinkId"> Product-Group link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupLinkId"/> is null. </exception>
        public virtual NullableResponse<ServiceProductGroupLinkResource> GetIfExists(string groupLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupLinkId, nameof(groupLinkId));

            using var scope = _serviceProductGroupLinkProductGroupLinkClientDiagnostics.CreateScope("ServiceProductGroupLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceProductGroupLinkProductGroupLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupLinkId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceProductGroupLinkResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceProductGroupLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceProductGroupLinkResource> IEnumerable<ServiceProductGroupLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceProductGroupLinkResource> IAsyncEnumerable<ServiceProductGroupLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
