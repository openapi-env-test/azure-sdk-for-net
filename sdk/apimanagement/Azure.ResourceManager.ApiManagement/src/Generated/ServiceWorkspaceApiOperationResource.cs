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
    /// A Class representing a ServiceWorkspaceApiOperation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ServiceWorkspaceApiOperationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetServiceWorkspaceApiOperationResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServiceWorkspaceApiResource"/> using the GetServiceWorkspaceApiOperation method.
    /// </summary>
    public partial class ServiceWorkspaceApiOperationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceWorkspaceApiOperationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="workspaceId"> The workspaceId. </param>
        /// <param name="apiId"> The apiId. </param>
        /// <param name="operationId"> The operationId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string workspaceId, string apiId, string operationId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/operations/{operationId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serviceWorkspaceApiOperationWorkspaceApiOperationClientDiagnostics;
        private readonly WorkspaceApiOperationRestOperations _serviceWorkspaceApiOperationWorkspaceApiOperationRestClient;
        private readonly ApiOperationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/workspaces/apis/operations";

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceApiOperationResource"/> class for mocking. </summary>
        protected ServiceWorkspaceApiOperationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceApiOperationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceWorkspaceApiOperationResource(ArmClient client, ApiOperationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceApiOperationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceWorkspaceApiOperationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceWorkspaceApiOperationWorkspaceApiOperationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serviceWorkspaceApiOperationWorkspaceApiOperationApiVersion);
            _serviceWorkspaceApiOperationWorkspaceApiOperationRestClient = new WorkspaceApiOperationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceWorkspaceApiOperationWorkspaceApiOperationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ApiOperationData Data
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

        /// <summary> Gets a collection of ServiceWorkspaceApiOperationPolicyResources in the ServiceWorkspaceApiOperation. </summary>
        /// <returns> An object representing collection of ServiceWorkspaceApiOperationPolicyResources and their operations over a ServiceWorkspaceApiOperationPolicyResource. </returns>
        public virtual ServiceWorkspaceApiOperationPolicyCollection GetServiceWorkspaceApiOperationPolicies()
        {
            return GetCachedClient(client => new ServiceWorkspaceApiOperationPolicyCollection(client, Id));
        }

        /// <summary>
        /// Get the policy configuration at the API Operation level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/operations/{operationId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiOperationPolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServiceWorkspaceApiOperationPolicyResource>> GetServiceWorkspaceApiOperationPolicyAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            return await GetServiceWorkspaceApiOperationPolicies().GetAsync(policyId, format, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the policy configuration at the API Operation level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/operations/{operationId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiOperationPolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ServiceWorkspaceApiOperationPolicyResource> GetServiceWorkspaceApiOperationPolicy(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            return GetServiceWorkspaceApiOperationPolicies().Get(policyId, format, cancellationToken);
        }

        /// <summary>
        /// Gets the details of the API Operation specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/operations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiOperation_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceWorkspaceApiOperationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceApiOperationWorkspaceApiOperationClientDiagnostics.CreateScope("ServiceWorkspaceApiOperationResource.Get");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceApiOperationWorkspaceApiOperationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceApiOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the API Operation specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/operations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiOperation_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceWorkspaceApiOperationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceApiOperationWorkspaceApiOperationClientDiagnostics.CreateScope("ServiceWorkspaceApiOperationResource.Get");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceApiOperationWorkspaceApiOperationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceApiOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified operation in the API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/operations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiOperation_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceApiOperationWorkspaceApiOperationClientDiagnostics.CreateScope("ServiceWorkspaceApiOperationResource.Delete");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceApiOperationWorkspaceApiOperationRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
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
        /// Deletes the specified operation in the API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/operations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiOperation_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceApiOperationWorkspaceApiOperationClientDiagnostics.CreateScope("ServiceWorkspaceApiOperationResource.Delete");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceApiOperationWorkspaceApiOperationRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
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
        /// Updates the details of the operation in the API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/operations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiOperation_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="operationUpdateContract"> API Operation Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationUpdateContract"/> is null. </exception>
        public virtual async Task<Response<ServiceWorkspaceApiOperationResource>> UpdateAsync(ETag ifMatch, OperationUpdateContract operationUpdateContract, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(operationUpdateContract, nameof(operationUpdateContract));

            using var scope = _serviceWorkspaceApiOperationWorkspaceApiOperationClientDiagnostics.CreateScope("ServiceWorkspaceApiOperationResource.Update");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceApiOperationWorkspaceApiOperationRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, operationUpdateContract, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ServiceWorkspaceApiOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the details of the operation in the API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/operations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiOperation_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="operationUpdateContract"> API Operation Update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationUpdateContract"/> is null. </exception>
        public virtual Response<ServiceWorkspaceApiOperationResource> Update(ETag ifMatch, OperationUpdateContract operationUpdateContract, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(operationUpdateContract, nameof(operationUpdateContract));

            using var scope = _serviceWorkspaceApiOperationWorkspaceApiOperationClientDiagnostics.CreateScope("ServiceWorkspaceApiOperationResource.Update");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceApiOperationWorkspaceApiOperationRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, operationUpdateContract, cancellationToken);
                return Response.FromValue(new ServiceWorkspaceApiOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the API operation specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/operations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiOperation_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceApiOperationWorkspaceApiOperationClientDiagnostics.CreateScope("ServiceWorkspaceApiOperationResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceApiOperationWorkspaceApiOperationRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the API operation specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/apis/{apiId}/operations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceApiOperation_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceApiOperationWorkspaceApiOperationClientDiagnostics.CreateScope("ServiceWorkspaceApiOperationResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceApiOperationWorkspaceApiOperationRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
