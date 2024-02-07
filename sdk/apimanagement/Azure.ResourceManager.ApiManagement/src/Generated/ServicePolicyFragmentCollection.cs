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
    /// A class representing a collection of <see cref="ServicePolicyFragmentResource"/> and their operations.
    /// Each <see cref="ServicePolicyFragmentResource"/> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource"/>.
    /// To get a <see cref="ServicePolicyFragmentCollection"/> instance call the GetServicePolicyFragments method from an instance of <see cref="ApiManagementServiceResource"/>.
    /// </summary>
    public partial class ServicePolicyFragmentCollection : ArmCollection, IEnumerable<ServicePolicyFragmentResource>, IAsyncEnumerable<ServicePolicyFragmentResource>
    {
        private readonly ClientDiagnostics _servicePolicyFragmentPolicyFragmentClientDiagnostics;
        private readonly PolicyFragmentRestOperations _servicePolicyFragmentPolicyFragmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServicePolicyFragmentCollection"/> class for mocking. </summary>
        protected ServicePolicyFragmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServicePolicyFragmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServicePolicyFragmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _servicePolicyFragmentPolicyFragmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServicePolicyFragmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServicePolicyFragmentResource.ResourceType, out string servicePolicyFragmentPolicyFragmentApiVersion);
            _servicePolicyFragmentPolicyFragmentRestClient = new PolicyFragmentRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, servicePolicyFragmentPolicyFragmentApiVersion);
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
        /// Creates or updates a policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyFragment_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> A resource identifier. </param>
        /// <param name="data"> The policy fragment contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServicePolicyFragmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string id, PolicyFragmentContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _servicePolicyFragmentPolicyFragmentClientDiagnostics.CreateScope("ServicePolicyFragmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _servicePolicyFragmentPolicyFragmentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ServicePolicyFragmentResource>(new ServicePolicyFragmentOperationSource(Client), _servicePolicyFragmentPolicyFragmentClientDiagnostics, Pipeline, _servicePolicyFragmentPolicyFragmentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, ifMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyFragment_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> A resource identifier. </param>
        /// <param name="data"> The policy fragment contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServicePolicyFragmentResource> CreateOrUpdate(WaitUntil waitUntil, string id, PolicyFragmentContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _servicePolicyFragmentPolicyFragmentClientDiagnostics.CreateScope("ServicePolicyFragmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _servicePolicyFragmentPolicyFragmentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ServicePolicyFragmentResource>(new ServicePolicyFragmentOperationSource(Client), _servicePolicyFragmentPolicyFragmentClientDiagnostics, Pipeline, _servicePolicyFragmentPolicyFragmentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, ifMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyFragment_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> A resource identifier. </param>
        /// <param name="format"> Policy fragment content format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<ServicePolicyFragmentResource>> GetAsync(string id, PolicyFragmentContentFormat? format = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _servicePolicyFragmentPolicyFragmentClientDiagnostics.CreateScope("ServicePolicyFragmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _servicePolicyFragmentPolicyFragmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, format, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServicePolicyFragmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a policy fragment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyFragment_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> A resource identifier. </param>
        /// <param name="format"> Policy fragment content format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<ServicePolicyFragmentResource> Get(string id, PolicyFragmentContentFormat? format = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _servicePolicyFragmentPolicyFragmentClientDiagnostics.CreateScope("ServicePolicyFragmentCollection.Get");
            scope.Start();
            try
            {
                var response = _servicePolicyFragmentPolicyFragmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, format, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServicePolicyFragmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all policy fragments.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyFragments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyFragment_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter, orderBy | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| value | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="orderBy"> OData order by query option. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServicePolicyFragmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServicePolicyFragmentResource> GetAllAsync(string filter = null, string orderBy = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _servicePolicyFragmentPolicyFragmentRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, orderBy, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _servicePolicyFragmentPolicyFragmentRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, orderBy, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServicePolicyFragmentResource(Client, PolicyFragmentContractData.DeserializePolicyFragmentContractData(e)), _servicePolicyFragmentPolicyFragmentClientDiagnostics, Pipeline, "ServicePolicyFragmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all policy fragments.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyFragments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyFragment_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter, orderBy | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| value | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="orderBy"> OData order by query option. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServicePolicyFragmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServicePolicyFragmentResource> GetAll(string filter = null, string orderBy = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _servicePolicyFragmentPolicyFragmentRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, orderBy, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _servicePolicyFragmentPolicyFragmentRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, orderBy, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServicePolicyFragmentResource(Client, PolicyFragmentContractData.DeserializePolicyFragmentContractData(e)), _servicePolicyFragmentPolicyFragmentClientDiagnostics, Pipeline, "ServicePolicyFragmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyFragment_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> A resource identifier. </param>
        /// <param name="format"> Policy fragment content format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string id, PolicyFragmentContentFormat? format = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _servicePolicyFragmentPolicyFragmentClientDiagnostics.CreateScope("ServicePolicyFragmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _servicePolicyFragmentPolicyFragmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, format, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyFragment_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> A resource identifier. </param>
        /// <param name="format"> Policy fragment content format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> Exists(string id, PolicyFragmentContentFormat? format = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _servicePolicyFragmentPolicyFragmentClientDiagnostics.CreateScope("ServicePolicyFragmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _servicePolicyFragmentPolicyFragmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, format, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyFragment_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> A resource identifier. </param>
        /// <param name="format"> Policy fragment content format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<NullableResponse<ServicePolicyFragmentResource>> GetIfExistsAsync(string id, PolicyFragmentContentFormat? format = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _servicePolicyFragmentPolicyFragmentClientDiagnostics.CreateScope("ServicePolicyFragmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _servicePolicyFragmentPolicyFragmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, format, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServicePolicyFragmentResource>(response.GetRawResponse());
                return Response.FromValue(new ServicePolicyFragmentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/policyFragments/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyFragment_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> A resource identifier. </param>
        /// <param name="format"> Policy fragment content format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual NullableResponse<ServicePolicyFragmentResource> GetIfExists(string id, PolicyFragmentContentFormat? format = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _servicePolicyFragmentPolicyFragmentClientDiagnostics.CreateScope("ServicePolicyFragmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _servicePolicyFragmentPolicyFragmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, format, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServicePolicyFragmentResource>(response.GetRawResponse());
                return Response.FromValue(new ServicePolicyFragmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServicePolicyFragmentResource> IEnumerable<ServicePolicyFragmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServicePolicyFragmentResource> IAsyncEnumerable<ServicePolicyFragmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
