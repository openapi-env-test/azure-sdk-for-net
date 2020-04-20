// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateStoreOfferOperations.
    /// </summary>
    public static partial class PrivateStoreOfferOperationsExtensions
    {
            /// <summary>
            /// Deletes an offer from the given private store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateStoreId'>
            /// The store ID - must use the tenant ID
            /// </param>
            /// <param name='offerId'>
            /// The offer ID to update or delete
            /// </param>
            public static void Delete(this IPrivateStoreOfferOperations operations, string privateStoreId, string offerId)
            {
                operations.DeleteAsync(privateStoreId, offerId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an offer from the given private store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateStoreId'>
            /// The store ID - must use the tenant ID
            /// </param>
            /// <param name='offerId'>
            /// The offer ID to update or delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateStoreOfferOperations operations, string privateStoreId, string offerId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(privateStoreId, offerId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets information about a specific offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateStoreId'>
            /// The store ID - must use the tenant ID
            /// </param>
            /// <param name='offerId'>
            /// The offer ID to update or delete
            /// </param>
            public static Offer Get(this IPrivateStoreOfferOperations operations, string privateStoreId, string offerId)
            {
                return operations.GetAsync(privateStoreId, offerId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about a specific offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateStoreId'>
            /// The store ID - must use the tenant ID
            /// </param>
            /// <param name='offerId'>
            /// The offer ID to update or delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Offer> GetAsync(this IPrivateStoreOfferOperations operations, string privateStoreId, string offerId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(privateStoreId, offerId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update or add an offer to the default collection of the private store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateStoreId'>
            /// The store ID - must use the tenant ID
            /// </param>
            /// <param name='offerId'>
            /// The offer ID to update or delete
            /// </param>
            /// <param name='payload'>
            /// </param>
            public static Offer CreateOrUpdate(this IPrivateStoreOfferOperations operations, string privateStoreId, string offerId, OfferProperties payload = default(OfferProperties))
            {
                return operations.CreateOrUpdateAsync(privateStoreId, offerId, payload).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update or add an offer to the default collection of the private store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateStoreId'>
            /// The store ID - must use the tenant ID
            /// </param>
            /// <param name='offerId'>
            /// The offer ID to update or delete
            /// </param>
            /// <param name='payload'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Offer> CreateOrUpdateAsync(this IPrivateStoreOfferOperations operations, string privateStoreId, string offerId, OfferProperties payload = default(OfferProperties), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(privateStoreId, offerId, payload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
