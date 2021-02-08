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
    /// Extension methods for VirtualNetworkGatewaysOperations.
    /// </summary>
    public static partial class VirtualNetworkGatewaysOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update virtual network gateway operation.
            /// </param>
            public static VirtualNetworkGateway CreateOrUpdate(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGateway parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, virtualNetworkGatewayName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update virtual network gateway operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGateway> CreateOrUpdateAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified virtual network gateway by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            public static VirtualNetworkGateway Get(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
            {
                return operations.GetAsync(resourceGroupName, virtualNetworkGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified virtual network gateway by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGateway> GetAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified virtual network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            public static void Delete(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
            {
                operations.DeleteAsync(resourceGroupName, virtualNetworkGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified virtual network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all virtual network gateways by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<VirtualNetworkGateway> List(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all virtual network gateways by resource group.
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
            public static async Task<IPage<VirtualNetworkGateway>> ListAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Resets the primary of the virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='gatewayVip'>
            /// Virtual network gateway vip address supplied to the begin reset of the
            /// active-active feature enabled gateway.
            /// </param>
            public static VirtualNetworkGateway Reset(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string gatewayVip = default(string))
            {
                return operations.ResetAsync(resourceGroupName, virtualNetworkGatewayName, gatewayVip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resets the primary of the virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='gatewayVip'>
            /// Virtual network gateway vip address supplied to the begin reset of the
            /// active-active feature enabled gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGateway> ResetAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string gatewayVip = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ResetWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, gatewayVip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Generates VPN client package for P2S client of the virtual network gateway
            /// in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the generate virtual network gateway VPN client
            /// package operation.
            /// </param>
            public static string Generatevpnclientpackage(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VpnClientParameters parameters)
            {
                return operations.GeneratevpnclientpackageAsync(resourceGroupName, virtualNetworkGatewayName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates VPN client package for P2S client of the virtual network gateway
            /// in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the generate virtual network gateway VPN client
            /// package operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GeneratevpnclientpackageAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VpnClientParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GeneratevpnclientpackageWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The GetBgpPeerStatus operation retrieves the status of all BGP peers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='peer'>
            /// The IP address of the peer to retrieve the status of.
            /// </param>
            public static BgpPeerStatusListResult GetBgpPeerStatus(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string peer = default(string))
            {
                return operations.GetBgpPeerStatusAsync(resourceGroupName, virtualNetworkGatewayName, peer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The GetBgpPeerStatus operation retrieves the status of all BGP peers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='peer'>
            /// The IP address of the peer to retrieve the status of.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BgpPeerStatusListResult> GetBgpPeerStatusAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string peer = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBgpPeerStatusWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, peer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation retrieves a list of routes the virtual network gateway has
            /// learned, including routes learned from BGP peers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            public static GatewayRouteListResult GetLearnedRoutes(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
            {
                return operations.GetLearnedRoutesAsync(resourceGroupName, virtualNetworkGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation retrieves a list of routes the virtual network gateway has
            /// learned, including routes learned from BGP peers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayRouteListResult> GetLearnedRoutesAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLearnedRoutesWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation retrieves a list of routes the virtual network gateway is
            /// advertising to the specified peer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='peer'>
            /// The IP address of the peer
            /// </param>
            public static GatewayRouteListResult GetAdvertisedRoutes(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string peer)
            {
                return operations.GetAdvertisedRoutesAsync(resourceGroupName, virtualNetworkGatewayName, peer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation retrieves a list of routes the virtual network gateway is
            /// advertising to the specified peer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='peer'>
            /// The IP address of the peer
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayRouteListResult> GetAdvertisedRoutesAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string peer, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAdvertisedRoutesWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, peer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update virtual network gateway operation.
            /// </param>
            public static VirtualNetworkGateway BeginCreateOrUpdate(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGateway parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, virtualNetworkGatewayName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update virtual network gateway operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGateway> BeginCreateOrUpdateAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VirtualNetworkGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified virtual network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            public static void BeginDelete(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
            {
                operations.BeginDeleteAsync(resourceGroupName, virtualNetworkGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified virtual network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Resets the primary of the virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='gatewayVip'>
            /// Virtual network gateway vip address supplied to the begin reset of the
            /// active-active feature enabled gateway.
            /// </param>
            public static VirtualNetworkGateway BeginReset(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string gatewayVip = default(string))
            {
                return operations.BeginResetAsync(resourceGroupName, virtualNetworkGatewayName, gatewayVip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resets the primary of the virtual network gateway in the specified resource
            /// group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='gatewayVip'>
            /// Virtual network gateway vip address supplied to the begin reset of the
            /// active-active feature enabled gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkGateway> BeginResetAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string gatewayVip = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginResetWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, gatewayVip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Generates VPN client package for P2S client of the virtual network gateway
            /// in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the generate virtual network gateway VPN client
            /// package operation.
            /// </param>
            public static string BeginGeneratevpnclientpackage(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VpnClientParameters parameters)
            {
                return operations.BeginGeneratevpnclientpackageAsync(resourceGroupName, virtualNetworkGatewayName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates VPN client package for P2S client of the virtual network gateway
            /// in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the generate virtual network gateway VPN client
            /// package operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> BeginGeneratevpnclientpackageAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VpnClientParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGeneratevpnclientpackageWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The GetBgpPeerStatus operation retrieves the status of all BGP peers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='peer'>
            /// The IP address of the peer to retrieve the status of.
            /// </param>
            public static BgpPeerStatusListResult BeginGetBgpPeerStatus(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string peer = default(string))
            {
                return operations.BeginGetBgpPeerStatusAsync(resourceGroupName, virtualNetworkGatewayName, peer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The GetBgpPeerStatus operation retrieves the status of all BGP peers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='peer'>
            /// The IP address of the peer to retrieve the status of.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BgpPeerStatusListResult> BeginGetBgpPeerStatusAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string peer = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGetBgpPeerStatusWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, peer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation retrieves a list of routes the virtual network gateway has
            /// learned, including routes learned from BGP peers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            public static GatewayRouteListResult BeginGetLearnedRoutes(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
            {
                return operations.BeginGetLearnedRoutesAsync(resourceGroupName, virtualNetworkGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation retrieves a list of routes the virtual network gateway has
            /// learned, including routes learned from BGP peers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayRouteListResult> BeginGetLearnedRoutesAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGetLearnedRoutesWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation retrieves a list of routes the virtual network gateway is
            /// advertising to the specified peer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='peer'>
            /// The IP address of the peer
            /// </param>
            public static GatewayRouteListResult BeginGetAdvertisedRoutes(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string peer)
            {
                return operations.BeginGetAdvertisedRoutesAsync(resourceGroupName, virtualNetworkGatewayName, peer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation retrieves a list of routes the virtual network gateway is
            /// advertising to the specified peer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkGatewayName'>
            /// The name of the virtual network gateway.
            /// </param>
            /// <param name='peer'>
            /// The IP address of the peer
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GatewayRouteListResult> BeginGetAdvertisedRoutesAsync(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, string peer, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGetAdvertisedRoutesWithHttpMessagesAsync(resourceGroupName, virtualNetworkGatewayName, peer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all virtual network gateways by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualNetworkGateway> ListNext(this IVirtualNetworkGatewaysOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all virtual network gateways by resource group.
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
            public static async Task<IPage<VirtualNetworkGateway>> ListNextAsync(this IVirtualNetworkGatewaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
