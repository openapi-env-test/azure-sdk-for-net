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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary> A Class representing a VirtualApplication along with the instance operations that can be performed on it. </summary>
    public partial class VirtualApplication : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VirtualApplication"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string applicationGroupName, string applicationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _virtualApplicationApplicationsClientDiagnostics;
        private readonly ApplicationsRestOperations _virtualApplicationApplicationsRestClient;
        private readonly VirtualApplicationData _data;

        /// <summary> Initializes a new instance of the <see cref="VirtualApplication"/> class for mocking. </summary>
        protected VirtualApplication()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VirtualApplication"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VirtualApplication(ArmClient client, VirtualApplicationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualApplication"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VirtualApplication(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualApplicationApplicationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string virtualApplicationApplicationsApiVersion);
            _virtualApplicationApplicationsRestClient = new ApplicationsRestOperations(_virtualApplicationApplicationsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualApplicationApplicationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DesktopVirtualization/applicationGroups/applications";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VirtualApplicationData Data
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

        /// <summary>
        /// Get an application.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}
        /// Operation Id: Applications_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VirtualApplication>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplication.Get");
            scope.Start();
            try
            {
                var response = await _virtualApplicationApplicationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _virtualApplicationApplicationsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualApplication(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an application.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}
        /// Operation Id: Applications_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualApplication> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplication.Get");
            scope.Start();
            try
            {
                var response = _virtualApplicationApplicationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _virtualApplicationApplicationsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualApplication(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove an application.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}
        /// Operation Id: Applications_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplication.Delete");
            scope.Start();
            try
            {
                var response = await _virtualApplicationApplicationsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DesktopVirtualizationArmOperation(response);
                if (waitForCompletion)
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
        /// Remove an application.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}
        /// Operation Id: Applications_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplication.Delete");
            scope.Start();
            try
            {
                var response = _virtualApplicationApplicationsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DesktopVirtualizationArmOperation(response);
                if (waitForCompletion)
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
        /// Update an application.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}
        /// Operation Id: Applications_Update
        /// </summary>
        /// <param name="data"> Object containing Application definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public async virtual Task<Response<VirtualApplication>> UpdateAsync(PatchableVirtualApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplication.Update");
            scope.Start();
            try
            {
                var response = await _virtualApplicationApplicationsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualApplication(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update an application.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/applications/{applicationName}
        /// Operation Id: Applications_Update
        /// </summary>
        /// <param name="data"> Object containing Application definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<VirtualApplication> Update(PatchableVirtualApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualApplicationApplicationsClientDiagnostics.CreateScope("VirtualApplication.Update");
            scope.Start();
            try
            {
                var response = _virtualApplicationApplicationsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new VirtualApplication(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
