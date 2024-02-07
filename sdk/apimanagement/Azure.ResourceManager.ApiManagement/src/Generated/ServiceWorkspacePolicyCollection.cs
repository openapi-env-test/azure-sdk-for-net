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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceWorkspacePolicyResource"/> and their operations.
    /// Each <see cref="ServiceWorkspacePolicyResource"/> in the collection will belong to the same instance of <see cref="WorkspaceContractResource"/>.
    /// To get a <see cref="ServiceWorkspacePolicyCollection"/> instance call the GetServiceWorkspacePolicies method from an instance of <see cref="WorkspaceContractResource"/>.
    /// </summary>
    public partial class ServiceWorkspacePolicyCollection : ArmCollection, IEnumerable<ServiceWorkspacePolicyResource>, IAsyncEnumerable<ServiceWorkspacePolicyResource>
    {
        private readonly ClientDiagnostics _serviceWorkspacePolicyWorkspacePolicyClientDiagnostics;
        private readonly WorkspacePolicyRestOperations _serviceWorkspacePolicyWorkspacePolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspacePolicyCollection"/> class for mocking. </summary>
        protected ServiceWorkspacePolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspacePolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceWorkspacePolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceWorkspacePolicyWorkspacePolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceWorkspacePolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceWorkspacePolicyResource.ResourceType, out string serviceWorkspacePolicyWorkspacePolicyApiVersion);
            _serviceWorkspacePolicyWorkspacePolicyRestClient = new WorkspacePolicyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceWorkspacePolicyWorkspacePolicyApiVersion);
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
        /// Creates or updates policy configuration for the workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicy_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="data"> The policy contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceWorkspacePolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, PolicyName policyId, PolicyContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspacePolicyWorkspacePolicyClientDiagnostics.CreateScope("ServiceWorkspacePolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceWorkspacePolicyWorkspacePolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ServiceWorkspacePolicyResource>(Response.FromValue(new ServiceWorkspacePolicyResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates policy configuration for the workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicy_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="data"> The policy contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceWorkspacePolicyResource> CreateOrUpdate(WaitUntil waitUntil, PolicyName policyId, PolicyContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspacePolicyWorkspacePolicyClientDiagnostics.CreateScope("ServiceWorkspacePolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceWorkspacePolicyWorkspacePolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ServiceWorkspacePolicyResource>(Response.FromValue(new ServiceWorkspacePolicyResource(Client, response), response.GetRawResponse()));
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
        /// Get the policy configuration at the API level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceWorkspacePolicyResource>> GetAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspacePolicyWorkspacePolicyClientDiagnostics.CreateScope("ServiceWorkspacePolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceWorkspacePolicyWorkspacePolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, format, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspacePolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the policy configuration at the API level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceWorkspacePolicyResource> Get(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspacePolicyWorkspacePolicyClientDiagnostics.CreateScope("ServiceWorkspacePolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceWorkspacePolicyWorkspacePolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, format, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspacePolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the policy configuration at the workspace level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicy_ListByApi</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceWorkspacePolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceWorkspacePolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspacePolicyWorkspacePolicyRestClient.CreateListByApiRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspacePolicyWorkspacePolicyRestClient.CreateListByApiNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspacePolicyResource(Client, PolicyContractData.DeserializePolicyContractData(e)), _serviceWorkspacePolicyWorkspacePolicyClientDiagnostics, Pipeline, "ServiceWorkspacePolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the policy configuration at the workspace level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicy_ListByApi</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceWorkspacePolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceWorkspacePolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspacePolicyWorkspacePolicyRestClient.CreateListByApiRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspacePolicyWorkspacePolicyRestClient.CreateListByApiNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspacePolicyResource(Client, PolicyContractData.DeserializePolicyContractData(e)), _serviceWorkspacePolicyWorkspacePolicyClientDiagnostics, Pipeline, "ServiceWorkspacePolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspacePolicyWorkspacePolicyClientDiagnostics.CreateScope("ServiceWorkspacePolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspacePolicyWorkspacePolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspacePolicyWorkspacePolicyClientDiagnostics.CreateScope("ServiceWorkspacePolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceWorkspacePolicyWorkspacePolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<ServiceWorkspacePolicyResource>> GetIfExistsAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspacePolicyWorkspacePolicyClientDiagnostics.CreateScope("ServiceWorkspacePolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspacePolicyWorkspacePolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspacePolicyResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspacePolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspacePolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<ServiceWorkspacePolicyResource> GetIfExists(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspacePolicyWorkspacePolicyClientDiagnostics.CreateScope("ServiceWorkspacePolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceWorkspacePolicyWorkspacePolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspacePolicyResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspacePolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceWorkspacePolicyResource> IEnumerable<ServiceWorkspacePolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceWorkspacePolicyResource> IAsyncEnumerable<ServiceWorkspacePolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
