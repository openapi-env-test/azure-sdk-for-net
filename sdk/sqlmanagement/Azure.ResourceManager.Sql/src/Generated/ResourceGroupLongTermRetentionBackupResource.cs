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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ResourceGroupLongTermRetentionBackup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ResourceGroupLongTermRetentionBackupResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetResourceGroupLongTermRetentionBackupResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetResourceGroupLongTermRetentionBackup method.
    /// </summary>
    public partial class ResourceGroupLongTermRetentionBackupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceGroupLongTermRetentionBackupResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="locationName"> The locationName. </param>
        /// <param name="longTermRetentionServerName"> The longTermRetentionServerName. </param>
        /// <param name="longTermRetentionDatabaseName"> The longTermRetentionDatabaseName. </param>
        /// <param name="backupName"> The backupName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, AzureLocation locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, string backupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics;
        private readonly LongTermRetentionBackupsRestOperations _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient;
        private readonly LongTermRetentionBackupData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/locations/longTermRetentionServers/longTermRetentionDatabases/longTermRetentionBackups";

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionBackupResource"/> class for mocking. </summary>
        protected ResourceGroupLongTermRetentionBackupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionBackupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceGroupLongTermRetentionBackupResource(ArmClient client, LongTermRetentionBackupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupLongTermRetentionBackupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupLongTermRetentionBackupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceGroupLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
            _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient = new LongTermRetentionBackupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGroupLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LongTermRetentionBackupData Data
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
        /// Gets a long term retention backup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_GetByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceGroupLongTermRetentionBackupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.Get");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a long term retention backup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_GetByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGroupLongTermRetentionBackupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.Get");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupLongTermRetentionBackupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a long term retention backup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_DeleteByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.Delete");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.DeleteByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateDeleteByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes a long term retention backup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_DeleteByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.Delete");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.DeleteByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateDeleteByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Change a long term retention backup access tier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/changeAccessTier</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_ChangeAccessTierByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="changeLongTermRetentionBackupAccessTierParameters"> The <see cref="ChangeLongTermRetentionBackupAccessTierParameters"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="changeLongTermRetentionBackupAccessTierParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ResourceGroupLongTermRetentionBackupResource>> ChangeAccessTierByResourceGroupAsync(WaitUntil waitUntil, ChangeLongTermRetentionBackupAccessTierParameters changeLongTermRetentionBackupAccessTierParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(changeLongTermRetentionBackupAccessTierParameters, nameof(changeLongTermRetentionBackupAccessTierParameters));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.ChangeAccessTierByResourceGroup");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.ChangeAccessTierByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, changeLongTermRetentionBackupAccessTierParameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ResourceGroupLongTermRetentionBackupResource>(new ResourceGroupLongTermRetentionBackupOperationSource(Client), _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateChangeAccessTierByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, changeLongTermRetentionBackupAccessTierParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Change a long term retention backup access tier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/changeAccessTier</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_ChangeAccessTierByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="changeLongTermRetentionBackupAccessTierParameters"> The <see cref="ChangeLongTermRetentionBackupAccessTierParameters"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="changeLongTermRetentionBackupAccessTierParameters"/> is null. </exception>
        public virtual ArmOperation<ResourceGroupLongTermRetentionBackupResource> ChangeAccessTierByResourceGroup(WaitUntil waitUntil, ChangeLongTermRetentionBackupAccessTierParameters changeLongTermRetentionBackupAccessTierParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(changeLongTermRetentionBackupAccessTierParameters, nameof(changeLongTermRetentionBackupAccessTierParameters));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.ChangeAccessTierByResourceGroup");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.ChangeAccessTierByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, changeLongTermRetentionBackupAccessTierParameters, cancellationToken);
                var operation = new SqlArmOperation<ResourceGroupLongTermRetentionBackupResource>(new ResourceGroupLongTermRetentionBackupOperationSource(Client), _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateChangeAccessTierByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, changeLongTermRetentionBackupAccessTierParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Copy an existing long term retention backup to a different server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/copy</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_CopyByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The parameters needed for long term retention copy request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<LongTermRetentionBackupOperationResult>> CopyByResourceGroupAsync(WaitUntil waitUntil, CopyLongTermRetentionBackupContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.CopyByResourceGroup");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CopyByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<LongTermRetentionBackupOperationResult>(new LongTermRetentionBackupOperationResultOperationSource(), _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateCopyByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// Copy an existing long term retention backup to a different server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/copy</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_CopyByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The parameters needed for long term retention copy request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<LongTermRetentionBackupOperationResult> CopyByResourceGroup(WaitUntil waitUntil, CopyLongTermRetentionBackupContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.CopyByResourceGroup");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CopyByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new SqlArmOperation<LongTermRetentionBackupOperationResult>(new LongTermRetentionBackupOperationResultOperationSource(), _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateCopyByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// Updates an existing long term retention backup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/update</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_UpdateByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The requested backup resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<LongTermRetentionBackupOperationResult>> UpdateByResourceGroupAsync(WaitUntil waitUntil, UpdateLongTermRetentionBackupContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.UpdateByResourceGroup");
            scope.Start();
            try
            {
                var response = await _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.UpdateByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<LongTermRetentionBackupOperationResult>(new LongTermRetentionBackupOperationResultOperationSource(), _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateUpdateByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// Updates an existing long term retention backup.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}/update</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LongTermRetentionBackups_UpdateByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The requested backup resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<LongTermRetentionBackupOperationResult> UpdateByResourceGroup(WaitUntil waitUntil, UpdateLongTermRetentionBackupContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("ResourceGroupLongTermRetentionBackupResource.UpdateByResourceGroup");
            scope.Start();
            try
            {
                var response = _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.UpdateByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new SqlArmOperation<LongTermRetentionBackupOperationResult>(new LongTermRetentionBackupOperationResultOperationSource(), _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, _resourceGroupLongTermRetentionBackupLongTermRetentionBackupsRestClient.CreateUpdateByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Parent.Parent.Name), Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
    }
}
