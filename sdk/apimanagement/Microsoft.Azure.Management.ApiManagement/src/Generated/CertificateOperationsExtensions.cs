// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CertificateOperations.
    /// </summary>
    public static partial class CertificateOperationsExtensions
    {
            /// <summary>
            /// Lists a collection of all certificates in the specified service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<CertificateContract> ListByService(this ICertificateOperations operations, string resourceGroupName, string serviceName, ODataQuery<CertificateContract> odataQuery = default(ODataQuery<CertificateContract>))
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of all certificates in the specified service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CertificateContract>> ListByServiceAsync(this ICertificateOperations operations, string resourceGroupName, string serviceName, ODataQuery<CertificateContract> odataQuery = default(ODataQuery<CertificateContract>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the certificate specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='certificateId'>
            /// Identifier of the certificate entity. Must be unique in the current API
            /// Management service instance.
            /// </param>
            public static CertificateGetEntityTagHeaders GetEntityTag(this ICertificateOperations operations, string resourceGroupName, string serviceName, string certificateId)
            {
                return operations.GetEntityTagAsync(resourceGroupName, serviceName, certificateId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the certificate specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='certificateId'>
            /// Identifier of the certificate entity. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateGetEntityTagHeaders> GetEntityTagAsync(this ICertificateOperations operations, string resourceGroupName, string serviceName, string certificateId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, certificateId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets the details of the certificate specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='certificateId'>
            /// Identifier of the certificate entity. Must be unique in the current API
            /// Management service instance.
            /// </param>
            public static CertificateContract Get(this ICertificateOperations operations, string resourceGroupName, string serviceName, string certificateId)
            {
                return operations.GetAsync(resourceGroupName, serviceName, certificateId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of the certificate specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='certificateId'>
            /// Identifier of the certificate entity. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateContract> GetAsync(this ICertificateOperations operations, string resourceGroupName, string serviceName, string certificateId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, certificateId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the certificate being used for authentication with the
            /// backend.
            /// <see href="https://azure.microsoft.com/en-us/documentation/articles/api-management-howto-mutual-certificates/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='certificateId'>
            /// Identifier of the certificate entity. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='parameters'>
            /// Create or Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            public static CertificateContract CreateOrUpdate(this ICertificateOperations operations, string resourceGroupName, string serviceName, string certificateId, CertificateCreateOrUpdateParameters parameters, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, certificateId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the certificate being used for authentication with the
            /// backend.
            /// <see href="https://azure.microsoft.com/en-us/documentation/articles/api-management-howto-mutual-certificates/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='certificateId'>
            /// Identifier of the certificate entity. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='parameters'>
            /// Create or Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateContract> CreateOrUpdateAsync(this ICertificateOperations operations, string resourceGroupName, string serviceName, string certificateId, CertificateCreateOrUpdateParameters parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, certificateId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes specific certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='certificateId'>
            /// Identifier of the certificate entity. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Delete(this ICertificateOperations operations, string resourceGroupName, string serviceName, string certificateId, string ifMatch)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, certificateId, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes specific certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='certificateId'>
            /// Identifier of the certificate entity. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ICertificateOperations operations, string resourceGroupName, string serviceName, string certificateId, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, certificateId, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// From KeyVault, Refresh the certificate being used for authentication with
            /// the backend.
            /// <see href="https://azure.microsoft.com/en-us/documentation/articles/api-management-howto-mutual-certificates/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='certificateId'>
            /// Identifier of the certificate entity. Must be unique in the current API
            /// Management service instance.
            /// </param>
            public static CertificateContract RefreshSecret(this ICertificateOperations operations, string resourceGroupName, string serviceName, string certificateId)
            {
                return operations.RefreshSecretAsync(resourceGroupName, serviceName, certificateId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// From KeyVault, Refresh the certificate being used for authentication with
            /// the backend.
            /// <see href="https://azure.microsoft.com/en-us/documentation/articles/api-management-howto-mutual-certificates/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='certificateId'>
            /// Identifier of the certificate entity. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateContract> RefreshSecretAsync(this ICertificateOperations operations, string resourceGroupName, string serviceName, string certificateId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RefreshSecretWithHttpMessagesAsync(resourceGroupName, serviceName, certificateId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists a collection of all certificates in the specified service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CertificateContract> ListByServiceNext(this ICertificateOperations operations, string nextPageLink)
            {
                return operations.ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of all certificates in the specified service instance.
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
            public static async Task<IPage<CertificateContract>> ListByServiceNextAsync(this ICertificateOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
