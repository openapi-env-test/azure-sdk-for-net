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
    /// Extension methods for VirtualNetworksOperations.
    /// </summary>
    public static partial class VirtualNetworksOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            public static void Delete(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName)
            {
                operations.DeleteAsync(resourceGroupName, virtualNetworkName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified virtual network by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            public static VirtualNetwork Get(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, virtualNetworkName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified virtual network by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetwork> GetAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a virtual network in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update virtual network operation
            /// </param>
            public static VirtualNetwork CreateOrUpdate(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetwork parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, virtualNetworkName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a virtual network in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update virtual network operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetwork> CreateOrUpdateAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetwork parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a virtual network tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update virtual network tags.
            /// </param>
            public static VirtualNetwork UpdateTags(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, TagsObject parameters)
            {
                return operations.UpdateTagsAsync(resourceGroupName, virtualNetworkName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a virtual network tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update virtual network tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetwork> UpdateTagsAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, TagsObject parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all virtual networks in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<VirtualNetwork> ListAll(this IVirtualNetworksOperations operations)
            {
                return operations.ListAllAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all virtual networks in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetwork>> ListAllAsync(this IVirtualNetworksOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all virtual networks in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<VirtualNetwork> List(this IVirtualNetworksOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all virtual networks in a resource group.
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
            public static async Task<IPage<VirtualNetwork>> ListAsync(this IVirtualNetworksOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checks whether a private IP address is available for use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='ipAddress'>
            /// The private IP address to be verified.
            /// </param>
            public static IPAddressAvailabilityResult CheckIPAddressAvailability(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, string ipAddress)
            {
                return operations.CheckIPAddressAvailabilityAsync(resourceGroupName, virtualNetworkName, ipAddress).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks whether a private IP address is available for use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='ipAddress'>
            /// The private IP address to be verified.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPAddressAvailabilityResult> CheckIPAddressAvailabilityAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, string ipAddress, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckIPAddressAvailabilityWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, ipAddress, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists usage stats.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            public static IPage<VirtualNetworkUsage> ListUsage(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName)
            {
                return operations.ListUsageAsync(resourceGroupName, virtualNetworkName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists usage stats.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetworkUsage>> ListUsageAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListUsageWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            public static void BeginDelete(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName)
            {
                operations.BeginDeleteAsync(resourceGroupName, virtualNetworkName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a virtual network in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update virtual network operation
            /// </param>
            public static VirtualNetwork BeginCreateOrUpdate(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetwork parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, virtualNetworkName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a virtual network in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update virtual network operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetwork> BeginCreateOrUpdateAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, VirtualNetwork parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a virtual network tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update virtual network tags.
            /// </param>
            public static VirtualNetwork BeginUpdateTags(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, TagsObject parameters)
            {
                return operations.BeginUpdateTagsAsync(resourceGroupName, virtualNetworkName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a virtual network tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update virtual network tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetwork> BeginUpdateTagsAsync(this IVirtualNetworksOperations operations, string resourceGroupName, string virtualNetworkName, TagsObject parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateTagsWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all virtual networks in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualNetwork> ListAllNext(this IVirtualNetworksOperations operations, string nextPageLink)
            {
                return operations.ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all virtual networks in a subscription.
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
            public static async Task<IPage<VirtualNetwork>> ListAllNextAsync(this IVirtualNetworksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all virtual networks in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualNetwork> ListNext(this IVirtualNetworksOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all virtual networks in a resource group.
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
            public static async Task<IPage<VirtualNetwork>> ListNextAsync(this IVirtualNetworksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists usage stats.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualNetworkUsage> ListUsageNext(this IVirtualNetworksOperations operations, string nextPageLink)
            {
                return operations.ListUsageNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists usage stats.
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
            public static async Task<IPage<VirtualNetworkUsage>> ListUsageNextAsync(this IVirtualNetworksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListUsageNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
