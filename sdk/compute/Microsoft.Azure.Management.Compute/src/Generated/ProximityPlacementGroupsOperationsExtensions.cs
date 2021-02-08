// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProximityPlacementGroupsOperations.
    /// </summary>
    public static partial class ProximityPlacementGroupsOperationsExtensions
    {
            /// <summary>
            /// Create or update a proximity placement group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='proximityPlacementGroupName'>
            /// The name of the proximity placement group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Proximity Placement Group operation.
            /// </param>
            public static ProximityPlacementGroup CreateOrUpdate(this IProximityPlacementGroupsOperations operations, string resourceGroupName, string proximityPlacementGroupName, ProximityPlacementGroup parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, proximityPlacementGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a proximity placement group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='proximityPlacementGroupName'>
            /// The name of the proximity placement group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Proximity Placement Group operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProximityPlacementGroup> CreateOrUpdateAsync(this IProximityPlacementGroupsOperations operations, string resourceGroupName, string proximityPlacementGroupName, ProximityPlacementGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, proximityPlacementGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a proximity placement group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='proximityPlacementGroupName'>
            /// The name of the proximity placement group.
            /// </param>
            /// <param name='tags'>
            /// Resource tags
            /// </param>
            public static ProximityPlacementGroup Update(this IProximityPlacementGroupsOperations operations, string resourceGroupName, string proximityPlacementGroupName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.UpdateAsync(resourceGroupName, proximityPlacementGroupName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a proximity placement group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='proximityPlacementGroupName'>
            /// The name of the proximity placement group.
            /// </param>
            /// <param name='tags'>
            /// Resource tags
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProximityPlacementGroup> UpdateAsync(this IProximityPlacementGroupsOperations operations, string resourceGroupName, string proximityPlacementGroupName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, proximityPlacementGroupName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a proximity placement group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='proximityPlacementGroupName'>
            /// The name of the proximity placement group.
            /// </param>
            public static void Delete(this IProximityPlacementGroupsOperations operations, string resourceGroupName, string proximityPlacementGroupName)
            {
                operations.DeleteAsync(resourceGroupName, proximityPlacementGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a proximity placement group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='proximityPlacementGroupName'>
            /// The name of the proximity placement group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IProximityPlacementGroupsOperations operations, string resourceGroupName, string proximityPlacementGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, proximityPlacementGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves information about a proximity placement group .
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='proximityPlacementGroupName'>
            /// The name of the proximity placement group.
            /// </param>
            public static ProximityPlacementGroup Get(this IProximityPlacementGroupsOperations operations, string resourceGroupName, string proximityPlacementGroupName)
            {
                return operations.GetAsync(resourceGroupName, proximityPlacementGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves information about a proximity placement group .
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='proximityPlacementGroupName'>
            /// The name of the proximity placement group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProximityPlacementGroup> GetAsync(this IProximityPlacementGroupsOperations operations, string resourceGroupName, string proximityPlacementGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, proximityPlacementGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all proximity placement groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ProximityPlacementGroup> ListBySubscription(this IProximityPlacementGroupsOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all proximity placement groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProximityPlacementGroup>> ListBySubscriptionAsync(this IProximityPlacementGroupsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all proximity placement groups in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<ProximityPlacementGroup> ListByResourceGroup(this IProximityPlacementGroupsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all proximity placement groups in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProximityPlacementGroup>> ListByResourceGroupAsync(this IProximityPlacementGroupsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all proximity placement groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ProximityPlacementGroup> ListBySubscriptionNext(this IProximityPlacementGroupsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all proximity placement groups in a subscription.
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
            public static async Task<IPage<ProximityPlacementGroup>> ListBySubscriptionNextAsync(this IProximityPlacementGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all proximity placement groups in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ProximityPlacementGroup> ListByResourceGroupNext(this IProximityPlacementGroupsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all proximity placement groups in a resource group.
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
            public static async Task<IPage<ProximityPlacementGroup>> ListByResourceGroupNextAsync(this IProximityPlacementGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
