// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing a ServiceWorkspaceProduct along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ServiceWorkspaceProductResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetServiceWorkspaceProductResource method.
    /// Otherwise you can get one from its parent resource <see cref="WorkspaceContractResource"/> using the GetServiceWorkspaceProduct method.
    /// </summary>
    public partial class ServiceWorkspaceProductResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceWorkspaceProductResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="workspaceId"> The workspaceId. </param>
        /// <param name="productId"> The productId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string workspaceId, string productId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serviceWorkspaceProductWorkspaceProductClientDiagnostics;
        private readonly WorkspaceProductRestOperations _serviceWorkspaceProductWorkspaceProductRestClient;
        private readonly ApiManagementProductData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/workspaces/products";

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceProductResource"/> class for mocking. </summary>
        protected ServiceWorkspaceProductResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceProductResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceWorkspaceProductResource(ArmClient client, ApiManagementProductData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceProductResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceWorkspaceProductResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceWorkspaceProductWorkspaceProductClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serviceWorkspaceProductWorkspaceProductApiVersion);
            _serviceWorkspaceProductWorkspaceProductRestClient = new WorkspaceProductRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceWorkspaceProductWorkspaceProductApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ApiManagementProductData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ServiceWorkspaceProductPolicyResources in the ServiceWorkspaceProduct. </summary>
        /// <returns> An object representing collection of ServiceWorkspaceProductPolicyResources and their operations over a ServiceWorkspaceProductPolicyResource. </returns>
        public virtual ServiceWorkspaceProductPolicyCollection GetServiceWorkspaceProductPolicies()
        {
            return GetCachedClient(client => new ServiceWorkspaceProductPolicyCollection(client, Id));
        }

        /// <summary>
        /// Get the policy configuration at the Product level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductPolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServiceWorkspaceProductPolicyResource>> GetServiceWorkspaceProductPolicyAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            return await GetServiceWorkspaceProductPolicies().GetAsync(policyId, format, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the policy configuration at the Product level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductPolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ServiceWorkspaceProductPolicyResource> GetServiceWorkspaceProductPolicy(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            return GetServiceWorkspaceProductPolicies().Get(policyId, format, cancellationToken);
        }

        /// <summary> Gets a collection of ServiceWorkspaceProductApiLinkResources in the ServiceWorkspaceProduct. </summary>
        /// <returns> An object representing collection of ServiceWorkspaceProductApiLinkResources and their operations over a ServiceWorkspaceProductApiLinkResource. </returns>
        public virtual ServiceWorkspaceProductApiLinkCollection GetServiceWorkspaceProductApiLinks()
        {
            return GetCachedClient(client => new ServiceWorkspaceProductApiLinkCollection(client, Id));
        }

        /// <summary>
        /// Gets the API link for the product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/apiLinks/{apiLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductApiLink_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiLinkId"> Product-API link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiLinkId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="apiLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServiceWorkspaceProductApiLinkResource>> GetServiceWorkspaceProductApiLinkAsync(string apiLinkId, CancellationToken cancellationToken = default)
        {
            return await GetServiceWorkspaceProductApiLinks().GetAsync(apiLinkId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the API link for the product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/apiLinks/{apiLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductApiLink_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiLinkId"> Product-API link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiLinkId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="apiLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ServiceWorkspaceProductApiLinkResource> GetServiceWorkspaceProductApiLink(string apiLinkId, CancellationToken cancellationToken = default)
        {
            return GetServiceWorkspaceProductApiLinks().Get(apiLinkId, cancellationToken);
        }

        /// <summary> Gets a collection of ServiceWorkspaceProductGroupLinkResources in the ServiceWorkspaceProduct. </summary>
        /// <returns> An object representing collection of ServiceWorkspaceProductGroupLinkResources and their operations over a ServiceWorkspaceProductGroupLinkResource. </returns>
        public virtual ServiceWorkspaceProductGroupLinkCollection GetServiceWorkspaceProductGroupLinks()
        {
            return GetCachedClient(client => new ServiceWorkspaceProductGroupLinkCollection(client, Id));
        }

        /// <summary>
        /// Gets the group link for the product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/groupLinks/{groupLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductGroupLink_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupLinkId"> Product-Group link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupLinkId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServiceWorkspaceProductGroupLinkResource>> GetServiceWorkspaceProductGroupLinkAsync(string groupLinkId, CancellationToken cancellationToken = default)
        {
            return await GetServiceWorkspaceProductGroupLinks().GetAsync(groupLinkId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the group link for the product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/groupLinks/{groupLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductGroupLink_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupLinkId"> Product-Group link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupLinkId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="groupLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ServiceWorkspaceProductGroupLinkResource> GetServiceWorkspaceProductGroupLink(string groupLinkId, CancellationToken cancellationToken = default)
        {
            return GetServiceWorkspaceProductGroupLinks().Get(groupLinkId, cancellationToken);
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceWorkspaceProductResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductResource.Get");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceProductWorkspaceProductRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceWorkspaceProductResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductResource.Get");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceProductWorkspaceProductRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Delete product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="deleteSubscriptions"> Delete existing subscriptions associated with the product or not. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, ETag ifMatch, bool? deleteSubscriptions = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductResource.Delete");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceProductWorkspaceProductRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, deleteSubscriptions, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="deleteSubscriptions"> Delete existing subscriptions associated with the product or not. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, ETag ifMatch, bool? deleteSubscriptions = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductResource.Delete");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceProductWorkspaceProductRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, deleteSubscriptions, cancellationToken);
                var operation = new ApiManagementArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update existing product details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="productUpdateParameters"> Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="productUpdateParameters"/> is null. </exception>
        public virtual async Task<Response<ServiceWorkspaceProductResource>> UpdateAsync(ETag ifMatch, ProductUpdateParameters productUpdateParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(productUpdateParameters, nameof(productUpdateParameters));

            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductResource.Update");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceProductWorkspaceProductRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, productUpdateParameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ServiceWorkspaceProductResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update existing product details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="productUpdateParameters"> Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="productUpdateParameters"/> is null. </exception>
        public virtual Response<ServiceWorkspaceProductResource> Update(ETag ifMatch, ProductUpdateParameters productUpdateParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(productUpdateParameters, nameof(productUpdateParameters));

            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductResource.Update");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceProductWorkspaceProductRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, productUpdateParameters, cancellationToken);
                return Response.FromValue(new ServiceWorkspaceProductResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the product specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceProductWorkspaceProductRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the product specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProduct_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceProductWorkspaceProductClientDiagnostics.CreateScope("ServiceWorkspaceProductResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceProductWorkspaceProductRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
