// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebPubSub
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WebPubSubOperations.
    /// </summary>
    public static partial class WebPubSubOperationsExtensions
    {
            /// <summary>
            /// Checks that the resource name is valid and is not already in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// the region
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            public static NameAvailability CheckNameAvailability(this IWebPubSubOperations operations, string location, NameAvailabilityParameters parameters)
            {
                return operations.CheckNameAvailabilityAsync(location, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks that the resource name is valid and is not already in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// the region
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NameAvailability> CheckNameAvailabilityAsync(this IWebPubSubOperations operations, string location, NameAvailabilityParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(location, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Handles requests to list all resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<WebPubSubResource> ListBySubscription(this IWebPubSubOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WebPubSubResource>> ListBySubscriptionAsync(this IWebPubSubOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Handles requests to list all resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            public static IPage<WebPubSubResource> ListByResourceGroup(this IWebPubSubOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WebPubSubResource>> ListByResourceGroupAsync(this IWebPubSubOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the resource and its properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            public static WebPubSubResource Get(this IWebPubSubOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.GetAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the resource and its properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebPubSubResource> GetAsync(this IWebPubSubOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            public static WebPubSubResource CreateOrUpdate(this IWebPubSubOperations operations, WebPubSubResource parameters, string resourceGroupName, string resourceName)
            {
                return operations.CreateOrUpdateAsync(parameters, resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebPubSubResource> CreateOrUpdateAsync(this IWebPubSubOperations operations, WebPubSubResource parameters, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(parameters, resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Operation to delete a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            public static void Delete(this IWebPubSubOperations operations, string resourceGroupName, string resourceName)
            {
                operations.DeleteAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to delete a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IWebPubSubOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Operation to update an exiting resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the update operation
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            public static WebPubSubResource Update(this IWebPubSubOperations operations, WebPubSubResource parameters, string resourceGroupName, string resourceName)
            {
                return operations.UpdateAsync(parameters, resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to update an exiting resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the update operation
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebPubSubResource> UpdateAsync(this IWebPubSubOperations operations, WebPubSubResource parameters, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(parameters, resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the access keys of the resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            public static WebPubSubKeys ListKeys(this IWebPubSubOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.ListKeysAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the access keys of the resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebPubSubKeys> ListKeysAsync(this IWebPubSubOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerate the access key for the resource. PrimaryKey and SecondaryKey
            /// cannot be regenerated at the same time.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameter that describes the Regenerate Key Operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            public static WebPubSubKeys RegenerateKey(this IWebPubSubOperations operations, RegenerateKeyParameters parameters, string resourceGroupName, string resourceName)
            {
                return operations.RegenerateKeyAsync(parameters, resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerate the access key for the resource. PrimaryKey and SecondaryKey
            /// cannot be regenerated at the same time.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameter that describes the Regenerate Key Operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebPubSubKeys> RegenerateKeyAsync(this IWebPubSubOperations operations, RegenerateKeyParameters parameters, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeyWithHttpMessagesAsync(parameters, resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Operation to restart a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            public static void Restart(this IWebPubSubOperations operations, string resourceGroupName, string resourceName)
            {
                operations.RestartAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to restart a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RestartAsync(this IWebPubSubOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RestartWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or update a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            public static WebPubSubResource BeginCreateOrUpdate(this IWebPubSubOperations operations, WebPubSubResource parameters, string resourceGroupName, string resourceName)
            {
                return operations.BeginCreateOrUpdateAsync(parameters, resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebPubSubResource> BeginCreateOrUpdateAsync(this IWebPubSubOperations operations, WebPubSubResource parameters, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(parameters, resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Operation to delete a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            public static void BeginDelete(this IWebPubSubOperations operations, string resourceGroupName, string resourceName)
            {
                operations.BeginDeleteAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to delete a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IWebPubSubOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Operation to update an exiting resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the update operation
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            public static WebPubSubResource BeginUpdate(this IWebPubSubOperations operations, WebPubSubResource parameters, string resourceGroupName, string resourceName)
            {
                return operations.BeginUpdateAsync(parameters, resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to update an exiting resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the update operation
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebPubSubResource> BeginUpdateAsync(this IWebPubSubOperations operations, WebPubSubResource parameters, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(parameters, resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerate the access key for the resource. PrimaryKey and SecondaryKey
            /// cannot be regenerated at the same time.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameter that describes the Regenerate Key Operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            public static WebPubSubKeys BeginRegenerateKey(this IWebPubSubOperations operations, RegenerateKeyParameters parameters, string resourceGroupName, string resourceName)
            {
                return operations.BeginRegenerateKeyAsync(parameters, resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerate the access key for the resource. PrimaryKey and SecondaryKey
            /// cannot be regenerated at the same time.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameter that describes the Regenerate Key Operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebPubSubKeys> BeginRegenerateKeyAsync(this IWebPubSubOperations operations, RegenerateKeyParameters parameters, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRegenerateKeyWithHttpMessagesAsync(parameters, resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Operation to restart a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            public static void BeginRestart(this IWebPubSubOperations operations, string resourceGroupName, string resourceName)
            {
                operations.BeginRestartAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to restart a resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRestartAsync(this IWebPubSubOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRestartWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Handles requests to list all resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WebPubSubResource> ListBySubscriptionNext(this IWebPubSubOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WebPubSubResource>> ListBySubscriptionNextAsync(this IWebPubSubOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Handles requests to list all resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WebPubSubResource> ListByResourceGroupNext(this IWebPubSubOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WebPubSubResource>> ListByResourceGroupNextAsync(this IWebPubSubOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
