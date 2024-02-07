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
    /// A class representing a collection of <see cref="ServiceWorkspaceGroupResource"/> and their operations.
    /// Each <see cref="ServiceWorkspaceGroupResource"/> in the collection will belong to the same instance of <see cref="WorkspaceContractResource"/>.
    /// To get a <see cref="ServiceWorkspaceGroupCollection"/> instance call the GetServiceWorkspaceGroups method from an instance of <see cref="WorkspaceContractResource"/>.
    /// </summary>
    public partial class ServiceWorkspaceGroupCollection : ArmCollection, IEnumerable<ServiceWorkspaceGroupResource>, IAsyncEnumerable<ServiceWorkspaceGroupResource>
    {
        private readonly ClientDiagnostics _serviceWorkspaceGroupWorkspaceGroupClientDiagnostics;
        private readonly WorkspaceGroupRestOperations _serviceWorkspaceGroupWorkspaceGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceGroupCollection"/> class for mocking. </summary>
        protected ServiceWorkspaceGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceWorkspaceGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceWorkspaceGroupWorkspaceGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceWorkspaceGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceWorkspaceGroupResource.ResourceType, out string serviceWorkspaceGroupWorkspaceGroupApiVersion);
            _serviceWorkspaceGroupWorkspaceGroupRestClient = new WorkspaceGroupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceWorkspaceGroupWorkspaceGroupApiVersion);
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
        /// Creates or Updates a group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceGroup_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="groupId"> Group identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="groupCreateParameters"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> or <paramref name="groupCreateParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceWorkspaceGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string groupId, GroupCreateParameters groupCreateParameters, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));
            Argument.AssertNotNull(groupCreateParameters, nameof(groupCreateParameters));

            using var scope = _serviceWorkspaceGroupWorkspaceGroupClientDiagnostics.CreateScope("ServiceWorkspaceGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceGroupWorkspaceGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupId, groupCreateParameters, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ServiceWorkspaceGroupResource>(Response.FromValue(new ServiceWorkspaceGroupResource(Client, response), response.GetRawResponse()));
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
        /// Creates or Updates a group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceGroup_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="groupId"> Group identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="groupCreateParameters"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> or <paramref name="groupCreateParameters"/> is null. </exception>
        public virtual ArmOperation<ServiceWorkspaceGroupResource> CreateOrUpdate(WaitUntil waitUntil, string groupId, GroupCreateParameters groupCreateParameters, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));
            Argument.AssertNotNull(groupCreateParameters, nameof(groupCreateParameters));

            using var scope = _serviceWorkspaceGroupWorkspaceGroupClientDiagnostics.CreateScope("ServiceWorkspaceGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceGroupWorkspaceGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupId, groupCreateParameters, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ServiceWorkspaceGroupResource>(Response.FromValue(new ServiceWorkspaceGroupResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the group specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceGroup_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> Group identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual async Task<Response<ServiceWorkspaceGroupResource>> GetAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _serviceWorkspaceGroupWorkspaceGroupClientDiagnostics.CreateScope("ServiceWorkspaceGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceGroupWorkspaceGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the group specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceGroup_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> Group identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual Response<ServiceWorkspaceGroupResource> Get(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _serviceWorkspaceGroupWorkspaceGroupClientDiagnostics.CreateScope("ServiceWorkspaceGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceGroupWorkspaceGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of groups defined within a workspace in a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/groups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceGroup_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| externalId | filter | eq |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceWorkspaceGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceWorkspaceGroupResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceGroupWorkspaceGroupRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspaceGroupWorkspaceGroupRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspaceGroupResource(Client, ApiManagementGroupData.DeserializeApiManagementGroupData(e)), _serviceWorkspaceGroupWorkspaceGroupClientDiagnostics, Pipeline, "ServiceWorkspaceGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of groups defined within a workspace in a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/groups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceGroup_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| externalId | filter | eq |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceWorkspaceGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceWorkspaceGroupResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceGroupWorkspaceGroupRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspaceGroupWorkspaceGroupRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspaceGroupResource(Client, ApiManagementGroupData.DeserializeApiManagementGroupData(e)), _serviceWorkspaceGroupWorkspaceGroupClientDiagnostics, Pipeline, "ServiceWorkspaceGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceGroup_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> Group identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _serviceWorkspaceGroupWorkspaceGroupClientDiagnostics.CreateScope("ServiceWorkspaceGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceGroupWorkspaceGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceGroup_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> Group identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual Response<bool> Exists(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _serviceWorkspaceGroupWorkspaceGroupClientDiagnostics.CreateScope("ServiceWorkspaceGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceGroupWorkspaceGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceGroup_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> Group identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceWorkspaceGroupResource>> GetIfExistsAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _serviceWorkspaceGroupWorkspaceGroupClientDiagnostics.CreateScope("ServiceWorkspaceGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceGroupWorkspaceGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspaceGroupResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/groups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceGroup_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupId"> Group identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupId"/> is null. </exception>
        public virtual NullableResponse<ServiceWorkspaceGroupResource> GetIfExists(string groupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupId, nameof(groupId));

            using var scope = _serviceWorkspaceGroupWorkspaceGroupClientDiagnostics.CreateScope("ServiceWorkspaceGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceGroupWorkspaceGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, groupId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspaceGroupResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceWorkspaceGroupResource> IEnumerable<ServiceWorkspaceGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceWorkspaceGroupResource> IAsyncEnumerable<ServiceWorkspaceGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
