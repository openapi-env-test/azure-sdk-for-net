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
    /// A class representing a collection of <see cref="ServiceWorkspaceProductResource"/> and their operations.
    /// Each <see cref="ServiceWorkspaceProductResource"/> in the collection will belong to the same instance of <see cref="WorkspaceContractResource"/>.
    /// To get a <see cref="ServiceWorkspaceProductCollection"/> instance call the GetServiceWorkspaceProducts method from an instance of <see cref="WorkspaceContractResource"/>.
    /// </summary>
    public partial class ServiceWorkspaceProductCollection : ArmCollection, IEnumerable<ServiceWorkspaceProductResource>, IAsyncEnumerable<ServiceWorkspaceProductResource>
    {
        private readonly ClientDiagnostics _serviceWorkspaceProductWorkspaceProductClientDiagnostics;
        private readonly WorkspaceProductRestOperations _serviceWorkspaceProductWorkspaceProductRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceProductCollection"/> class for mocking. </summary>
        protected ServiceWorkspaceProductCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceProductCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceWorkspaceProductCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceWorkspaceProductWorkspaceProductClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceWorkspaceProductResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceWorkspaceProductResource.ResourceType, out string serviceWorkspaceProductWorkspaceProductApiVersion);
            _serviceWorkspaceProductWorkspaceProductRestClient = new WorkspaceProductRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceWorkspaceProductWorkspaceProductApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WorkspaceContractResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WorkspaceContractResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or Updates a product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceWorkspaceProductResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string productId, ApiManagementProductData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceProductWorkspaceProductRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, productId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ServiceWorkspaceProductResource>(Response.FromValue(new ServiceWorkspaceProductResource(Client, response), response.GetRawResponse()));
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
        /// Creates or Updates a product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceWorkspaceProductResource> CreateOrUpdate(WaitUntil waitUntil, string productId, ApiManagementProductData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceProductWorkspaceProductRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, productId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ServiceWorkspaceProductResource>(Response.FromValue(new ServiceWorkspaceProductResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the product specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> is null. </exception>
        public virtual async Task<Response<ServiceWorkspaceProductResource>> GetAsync(string productId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));

            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceProductWorkspaceProductRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, productId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceProductResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the product specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> is null. </exception>
        public virtual Response<ServiceWorkspaceProductResource> Get(string productId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));

            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceProductWorkspaceProductRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, productId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceProductResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of products in the specified workspace in a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| terms | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;| groups | expand |     |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="expandGroups"> When set to true, the response contains an array of groups that have visibility to the product. The default is false. </param>
        /// <param name="tags"> Products which are part of a specific tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceWorkspaceProductResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceWorkspaceProductResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, bool? expandGroups = null, string tags = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceProductWorkspaceProductRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, expandGroups, tags);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspaceProductWorkspaceProductRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, expandGroups, tags);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspaceProductResource(Client, ApiManagementProductData.DeserializeApiManagementProductData(e)), _serviceWorkspaceProductWorkspaceProductClientDiagnostics, Pipeline, "ServiceWorkspaceProductCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of products in the specified workspace in a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| terms | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;| groups | expand |     |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="expandGroups"> When set to true, the response contains an array of groups that have visibility to the product. The default is false. </param>
        /// <param name="tags"> Products which are part of a specific tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceWorkspaceProductResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceWorkspaceProductResource> GetAll(string filter = null, int? top = null, int? skip = null, bool? expandGroups = null, string tags = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceProductWorkspaceProductRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, expandGroups, tags);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspaceProductWorkspaceProductRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, expandGroups, tags);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspaceProductResource(Client, ApiManagementProductData.DeserializeApiManagementProductData(e)), _serviceWorkspaceProductWorkspaceProductClientDiagnostics, Pipeline, "ServiceWorkspaceProductCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string productId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));

            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceProductWorkspaceProductRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, productId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> is null. </exception>
        public virtual Response<bool> Exists(string productId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));

            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceProductWorkspaceProductRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, productId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceWorkspaceProductResource>> GetIfExistsAsync(string productId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));

            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceProductWorkspaceProductRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, productId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspaceProductResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceProductResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="productId"> Product identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="productId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="productId"/> is null. </exception>
        public virtual NullableResponse<ServiceWorkspaceProductResource> GetIfExists(string productId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(productId, nameof(productId));

            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceProductWorkspaceProductRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, productId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspaceProductResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceProductResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceWorkspaceProductResource> IEnumerable<ServiceWorkspaceProductResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceWorkspaceProductResource> IAsyncEnumerable<ServiceWorkspaceProductResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
