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
    /// Extension methods for ExpressRoutePortsOperations.
    /// </summary>
    public static partial class ExpressRoutePortsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified ExpressRoutePort resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of the ExpressRoutePort resource.
            /// </param>
            public static void Delete(this IExpressRoutePortsOperations operations, string resourceGroupName, string expressRoutePortName)
            {
                operations.DeleteAsync(resourceGroupName, expressRoutePortName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified ExpressRoutePort resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of the ExpressRoutePort resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IExpressRoutePortsOperations operations, string resourceGroupName, string expressRoutePortName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, expressRoutePortName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves the requested ExpressRoutePort resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of ExpressRoutePort.
            /// </param>
            public static ExpressRoutePort Get(this IExpressRoutePortsOperations operations, string resourceGroupName, string expressRoutePortName)
            {
                return operations.GetAsync(resourceGroupName, expressRoutePortName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the requested ExpressRoutePort resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of ExpressRoutePort.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRoutePort> GetAsync(this IExpressRoutePortsOperations operations, string resourceGroupName, string expressRoutePortName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, expressRoutePortName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the specified ExpressRoutePort resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of the ExpressRoutePort resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create ExpressRoutePort operation.
            /// </param>
            public static ExpressRoutePort CreateOrUpdate(this IExpressRoutePortsOperations operations, string resourceGroupName, string expressRoutePortName, ExpressRoutePort parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, expressRoutePortName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified ExpressRoutePort resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of the ExpressRoutePort resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create ExpressRoutePort operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRoutePort> CreateOrUpdateAsync(this IExpressRoutePortsOperations operations, string resourceGroupName, string expressRoutePortName, ExpressRoutePort parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, expressRoutePortName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update ExpressRoutePort tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of the ExpressRoutePort resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update ExpressRoutePort resource tags.
            /// </param>
            public static ExpressRoutePort UpdateTags(this IExpressRoutePortsOperations operations, string resourceGroupName, string expressRoutePortName, TagsObject parameters)
            {
                return operations.UpdateTagsAsync(resourceGroupName, expressRoutePortName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update ExpressRoutePort tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of the ExpressRoutePort resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update ExpressRoutePort resource tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRoutePort> UpdateTagsAsync(this IExpressRoutePortsOperations operations, string resourceGroupName, string expressRoutePortName, TagsObject parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, expressRoutePortName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the ExpressRoutePort resources in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<ExpressRoutePort> ListByResourceGroup(this IExpressRoutePortsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the ExpressRoutePort resources in the specified resource group.
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
            public static async Task<IPage<ExpressRoutePort>> ListByResourceGroupAsync(this IExpressRoutePortsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the ExpressRoutePort resources in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ExpressRoutePort> List(this IExpressRoutePortsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the ExpressRoutePort resources in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExpressRoutePort>> ListAsync(this IExpressRoutePortsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified ExpressRoutePort resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of the ExpressRoutePort resource.
            /// </param>
            public static void BeginDelete(this IExpressRoutePortsOperations operations, string resourceGroupName, string expressRoutePortName)
            {
                operations.BeginDeleteAsync(resourceGroupName, expressRoutePortName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified ExpressRoutePort resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of the ExpressRoutePort resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IExpressRoutePortsOperations operations, string resourceGroupName, string expressRoutePortName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, expressRoutePortName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates the specified ExpressRoutePort resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of the ExpressRoutePort resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create ExpressRoutePort operation.
            /// </param>
            public static ExpressRoutePort BeginCreateOrUpdate(this IExpressRoutePortsOperations operations, string resourceGroupName, string expressRoutePortName, ExpressRoutePort parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, expressRoutePortName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified ExpressRoutePort resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of the ExpressRoutePort resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create ExpressRoutePort operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRoutePort> BeginCreateOrUpdateAsync(this IExpressRoutePortsOperations operations, string resourceGroupName, string expressRoutePortName, ExpressRoutePort parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, expressRoutePortName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the ExpressRoutePort resources in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ExpressRoutePort> ListByResourceGroupNext(this IExpressRoutePortsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the ExpressRoutePort resources in the specified resource group.
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
            public static async Task<IPage<ExpressRoutePort>> ListByResourceGroupNextAsync(this IExpressRoutePortsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the ExpressRoutePort resources in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ExpressRoutePort> ListNext(this IExpressRoutePortsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the ExpressRoutePort resources in the specified subscription.
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
            public static async Task<IPage<ExpressRoutePort>> ListNextAsync(this IExpressRoutePortsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
