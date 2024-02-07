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
    /// A class representing a collection of <see cref="ServiceWorkspaceApiReleaseResource"/> and their operations.
    /// Each <see cref="ServiceWorkspaceApiReleaseResource"/> in the collection will belong to the same instance of <see cref="ServiceWorkspaceApiResource"/>.
    /// To get a <see cref="ServiceWorkspaceApiReleaseCollection"/> instance call the GetServiceWorkspaceApiReleases method from an instance of <see cref="ServiceWorkspaceApiResource"/>.
    /// </summary>
    public partial class ServiceWorkspaceApiReleaseCollection : ArmCollection, IEnumerable<ServiceWorkspaceApiReleaseResource>, IAsyncEnumerable<ServiceWorkspaceApiReleaseResource>
    {
        private readonly ClientDiagnostics _serviceWorkspaceApiReleaseWorkspaceApiReleaseClientDiagnostics;
        private readonly WorkspaceApiReleaseRestOperations _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceApiReleaseCollection"/> class for mocking. </summary>
        protected ServiceWorkspaceApiReleaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceApiReleaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceWorkspaceApiReleaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceWorkspaceApiReleaseWorkspaceApiReleaseClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceWorkspaceApiReleaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceWorkspaceApiReleaseResource.ResourceType, out string serviceWorkspaceApiReleaseWorkspaceApiReleaseApiVersion);
            _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient = new WorkspaceApiReleaseRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceWorkspaceApiReleaseWorkspaceApiReleaseApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceWorkspaceApiResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceWorkspaceApiResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new Release for the API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/releases/{releaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiRelease_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="releaseId"> Release identifier within an API. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="releaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="releaseId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceWorkspaceApiReleaseResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string releaseId, ApiReleaseData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(releaseId, nameof(releaseId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspaceApiReleaseWorkspaceApiReleaseClientDiagnostics.CreateScope("ServiceWorkspaceApiReleaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, releaseId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ServiceWorkspaceApiReleaseResource>(Response.FromValue(new ServiceWorkspaceApiReleaseResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new Release for the API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/releases/{releaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiRelease_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="releaseId"> Release identifier within an API. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="releaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="releaseId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceWorkspaceApiReleaseResource> CreateOrUpdate(WaitUntil waitUntil, string releaseId, ApiReleaseData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(releaseId, nameof(releaseId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspaceApiReleaseWorkspaceApiReleaseClientDiagnostics.CreateScope("ServiceWorkspaceApiReleaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, releaseId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ServiceWorkspaceApiReleaseResource>(Response.FromValue(new ServiceWorkspaceApiReleaseResource(Client, response), response.GetRawResponse()));
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
        /// Returns the details of an API release.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/releases/{releaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiRelease_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="releaseId"> Release identifier within an API. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="releaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="releaseId"/> is null. </exception>
        public virtual async Task<Response<ServiceWorkspaceApiReleaseResource>> GetAsync(string releaseId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(releaseId, nameof(releaseId));

            using var scope = _serviceWorkspaceApiReleaseWorkspaceApiReleaseClientDiagnostics.CreateScope("ServiceWorkspaceApiReleaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, releaseId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceApiReleaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the details of an API release.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/releases/{releaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiRelease_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="releaseId"> Release identifier within an API. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="releaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="releaseId"/> is null. </exception>
        public virtual Response<ServiceWorkspaceApiReleaseResource> Get(string releaseId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(releaseId, nameof(releaseId));

            using var scope = _serviceWorkspaceApiReleaseWorkspaceApiReleaseClientDiagnostics.CreateScope("ServiceWorkspaceApiReleaseCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, releaseId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceApiReleaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all releases of an API. An API release is created when making an API Revision current. Releases are also used to rollback to previous revisions. Results will be paged and can be constrained by the $top and $skip parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/releases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiRelease_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| notes | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceWorkspaceApiReleaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceWorkspaceApiReleaseResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspaceApiReleaseResource(Client, ApiReleaseData.DeserializeApiReleaseData(e)), _serviceWorkspaceApiReleaseWorkspaceApiReleaseClientDiagnostics, Pipeline, "ServiceWorkspaceApiReleaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all releases of an API. An API release is created when making an API Revision current. Releases are also used to rollback to previous revisions. Results will be paged and can be constrained by the $top and $skip parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/releases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiRelease_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| notes | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceWorkspaceApiReleaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceWorkspaceApiReleaseResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspaceApiReleaseResource(Client, ApiReleaseData.DeserializeApiReleaseData(e)), _serviceWorkspaceApiReleaseWorkspaceApiReleaseClientDiagnostics, Pipeline, "ServiceWorkspaceApiReleaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/releases/{releaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiRelease_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="releaseId"> Release identifier within an API. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="releaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="releaseId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string releaseId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(releaseId, nameof(releaseId));

            using var scope = _serviceWorkspaceApiReleaseWorkspaceApiReleaseClientDiagnostics.CreateScope("ServiceWorkspaceApiReleaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, releaseId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/releases/{releaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiRelease_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="releaseId"> Release identifier within an API. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="releaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="releaseId"/> is null. </exception>
        public virtual Response<bool> Exists(string releaseId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(releaseId, nameof(releaseId));

            using var scope = _serviceWorkspaceApiReleaseWorkspaceApiReleaseClientDiagnostics.CreateScope("ServiceWorkspaceApiReleaseCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, releaseId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/releases/{releaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiRelease_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="releaseId"> Release identifier within an API. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="releaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="releaseId"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceWorkspaceApiReleaseResource>> GetIfExistsAsync(string releaseId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(releaseId, nameof(releaseId));

            using var scope = _serviceWorkspaceApiReleaseWorkspaceApiReleaseClientDiagnostics.CreateScope("ServiceWorkspaceApiReleaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, releaseId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspaceApiReleaseResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceApiReleaseResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/releases/{releaseId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiRelease_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="releaseId"> Release identifier within an API. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="releaseId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="releaseId"/> is null. </exception>
        public virtual NullableResponse<ServiceWorkspaceApiReleaseResource> GetIfExists(string releaseId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(releaseId, nameof(releaseId));

            using var scope = _serviceWorkspaceApiReleaseWorkspaceApiReleaseClientDiagnostics.CreateScope("ServiceWorkspaceApiReleaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceApiReleaseWorkspaceApiReleaseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, releaseId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspaceApiReleaseResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceApiReleaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceWorkspaceApiReleaseResource> IEnumerable<ServiceWorkspaceApiReleaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceWorkspaceApiReleaseResource> IAsyncEnumerable<ServiceWorkspaceApiReleaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
