// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Contoso.Azure.Management.Cdn
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SecretsOperations.
    /// </summary>
    public static partial class SecretsOperationsExtensions
    {
            /// <summary>
            /// Lists existing AzureFrontDoor secrets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            public static IPage<Secret> ListByProfile(this ISecretsOperations operations, string resourceGroupName, string profileName)
            {
                return operations.ListByProfileAsync(resourceGroupName, profileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists existing AzureFrontDoor secrets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Secret>> ListByProfileAsync(this ISecretsOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByProfileWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an existing Secret within a profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            public static Secret Get(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName)
            {
                return operations.GetAsync(resourceGroupName, profileName, secretName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an existing Secret within a profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Secret> GetAsync(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, secretName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Secret within the specified profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            /// <param name='parameters'>
            /// object which contains secret parameters
            /// </param>
            public static Secret Create(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName, SecretParameters parameters = default(SecretParameters))
            {
                return operations.CreateAsync(resourceGroupName, profileName, secretName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Secret within the specified profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            /// <param name='parameters'>
            /// object which contains secret parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Secret> CreateAsync(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName, SecretParameters parameters = default(SecretParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, profileName, secretName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing Secret within a profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            /// <param name='parameters'>
            /// object which contains secret parameters
            /// </param>
            public static Secret Update(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName, SecretParameters parameters = default(SecretParameters))
            {
                return operations.UpdateAsync(resourceGroupName, profileName, secretName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing Secret within a profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            /// <param name='parameters'>
            /// object which contains secret parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Secret> UpdateAsync(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName, SecretParameters parameters = default(SecretParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, profileName, secretName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing Secret within profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            public static void Delete(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName)
            {
                operations.DeleteAsync(resourceGroupName, profileName, secretName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing Secret within profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, secretName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new Secret within the specified profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            /// <param name='parameters'>
            /// object which contains secret parameters
            /// </param>
            public static Secret BeginCreate(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName, SecretParameters parameters = default(SecretParameters))
            {
                return operations.BeginCreateAsync(resourceGroupName, profileName, secretName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Secret within the specified profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            /// <param name='parameters'>
            /// object which contains secret parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Secret> BeginCreateAsync(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName, SecretParameters parameters = default(SecretParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, profileName, secretName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing Secret within a profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            /// <param name='parameters'>
            /// object which contains secret parameters
            /// </param>
            public static Secret BeginUpdate(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName, SecretParameters parameters = default(SecretParameters))
            {
                return operations.BeginUpdateAsync(resourceGroupName, profileName, secretName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing Secret within a profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            /// <param name='parameters'>
            /// object which contains secret parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Secret> BeginUpdateAsync(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName, SecretParameters parameters = default(SecretParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, profileName, secretName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing Secret within profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            public static void BeginDelete(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName)
            {
                operations.BeginDeleteAsync(resourceGroupName, profileName, secretName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing Secret within profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='secretName'>
            /// Name of the Secret under the profile.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ISecretsOperations operations, string resourceGroupName, string profileName, string secretName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, profileName, secretName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists existing AzureFrontDoor secrets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Secret> ListByProfileNext(this ISecretsOperations operations, string nextPageLink)
            {
                return operations.ListByProfileNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists existing AzureFrontDoor secrets.
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
            public static async Task<IPage<Secret>> ListByProfileNextAsync(this ISecretsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByProfileNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
