// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExpressRouteCircuitPeeringsOperations.
    /// </summary>
    public static partial class ExpressRouteCircuitPeeringsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified peering from the specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            public static void Delete(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName)
            {
                operations.DeleteAsync(resourceGroupName, circuitName, peeringName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified peering from the specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified authorization from the specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            public static ExpressRouteCircuitPeering Get(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName)
            {
                return operations.GetAsync(resourceGroupName, circuitName, peeringName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified authorization from the specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitPeering> GetAsync(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a peering in the specified express route circuits.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='peeringParameters'>
            /// Parameters supplied to the create or update express route circuit peering
            /// operation.
            /// </param>
            public static ExpressRouteCircuitPeering CreateOrUpdate(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, ExpressRouteCircuitPeering peeringParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, circuitName, peeringName, peeringParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a peering in the specified express route circuits.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='peeringParameters'>
            /// Parameters supplied to the create or update express route circuit peering
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitPeering> CreateOrUpdateAsync(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, ExpressRouteCircuitPeering peeringParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, peeringParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all peerings in a specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            public static IPage<ExpressRouteCircuitPeering> List(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName)
            {
                return operations.ListAsync(resourceGroupName, circuitName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all peerings in a specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExpressRouteCircuitPeering>> ListAsync(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, circuitName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified peering from the specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            public static void BeginDelete(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName)
            {
                operations.BeginDeleteAsync(resourceGroupName, circuitName, peeringName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified peering from the specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a peering in the specified express route circuits.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='peeringParameters'>
            /// Parameters supplied to the create or update express route circuit peering
            /// operation.
            /// </param>
            public static ExpressRouteCircuitPeering BeginCreateOrUpdate(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, ExpressRouteCircuitPeering peeringParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, circuitName, peeringName, peeringParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a peering in the specified express route circuits.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='peeringParameters'>
            /// Parameters supplied to the create or update express route circuit peering
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitPeering> BeginCreateOrUpdateAsync(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, ExpressRouteCircuitPeering peeringParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, peeringParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all peerings in a specified express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ExpressRouteCircuitPeering> ListNext(this IExpressRouteCircuitPeeringsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all peerings in a specified express route circuit.
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
            public static async Task<IPage<ExpressRouteCircuitPeering>> ListNextAsync(this IExpressRouteCircuitPeeringsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
