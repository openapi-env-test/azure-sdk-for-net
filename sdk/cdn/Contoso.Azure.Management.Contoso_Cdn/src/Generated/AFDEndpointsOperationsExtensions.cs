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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AFDEndpointsOperations.
    /// </summary>
    public static partial class AFDEndpointsOperationsExtensions
    {
            /// <summary>
            /// Lists existing AzureFrontDoor endpoints.
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
            public static IPage<AFDEndpoint> ListByProfile(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName)
            {
                return operations.ListByProfileAsync(resourceGroupName, profileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists existing AzureFrontDoor endpoints.
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
            public static async Task<IPage<AFDEndpoint>> ListByProfileAsync(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByProfileWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an existing AzureFrontDoor endpoint with the specified endpoint name
            /// under the specified subscription, resource group and profile.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            public static AFDEndpoint Get(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                return operations.GetAsync(resourceGroupName, profileName, endpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an existing AzureFrontDoor endpoint with the specified endpoint name
            /// under the specified subscription, resource group and profile.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AFDEndpoint> GetAsync(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new AzureFrontDoor endpoint with the specified endpoint name
            /// under the specified subscription, resource group and profile.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='endpoint'>
            /// Endpoint properties
            /// </param>
            public static AFDEndpoint Create(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, AFDEndpoint endpoint)
            {
                return operations.CreateAsync(resourceGroupName, profileName, endpointName, endpoint).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new AzureFrontDoor endpoint with the specified endpoint name
            /// under the specified subscription, resource group and profile.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='endpoint'>
            /// Endpoint properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AFDEndpoint> CreateAsync(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, AFDEndpoint endpoint, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, endpoint, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing AzureFrontDoor endpoint with the specified endpoint
            /// name under the specified subscription, resource group and profile. Only
            /// tags can be updated after creating an endpoint. To update origins, use the
            /// Update Origin operation. To update origin groups, use the Update Origin
            /// group operation. To update domains, use the Update Custom Domain operation.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='endpointUpdateProperties'>
            /// Endpoint update properties
            /// </param>
            public static AFDEndpoint Update(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, AFDEndpointUpdateParameters endpointUpdateProperties)
            {
                return operations.UpdateAsync(resourceGroupName, profileName, endpointName, endpointUpdateProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing AzureFrontDoor endpoint with the specified endpoint
            /// name under the specified subscription, resource group and profile. Only
            /// tags can be updated after creating an endpoint. To update origins, use the
            /// Update Origin operation. To update origin groups, use the Update Origin
            /// group operation. To update domains, use the Update Custom Domain operation.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='endpointUpdateProperties'>
            /// Endpoint update properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AFDEndpoint> UpdateAsync(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, AFDEndpointUpdateParameters endpointUpdateProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, endpointUpdateProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing AzureFrontDoor endpoint with the specified endpoint
            /// name under the specified subscription, resource group and profile.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            public static void Delete(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                operations.DeleteAsync(resourceGroupName, profileName, endpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing AzureFrontDoor endpoint with the specified endpoint
            /// name under the specified subscription, resource group and profile.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Removes a content from AzureFrontDoor.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='contentPaths'>
            /// The path to the content to be purged. Can describe a file path or a wild
            /// card directory.
            /// </param>
            /// <param name='domains'>
            /// List of domains.
            /// </param>
            public static void PurgeContent(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, IList<string> contentPaths, IList<string> domains = default(IList<string>))
            {
                operations.PurgeContentAsync(resourceGroupName, profileName, endpointName, contentPaths, domains).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes a content from AzureFrontDoor.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='contentPaths'>
            /// The path to the content to be purged. Can describe a file path or a wild
            /// card directory.
            /// </param>
            /// <param name='domains'>
            /// List of domains.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PurgeContentAsync(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, IList<string> contentPaths, IList<string> domains = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PurgeContentWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, contentPaths, domains, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Checks the quota and actual usage of endpoints under the given CDN profile.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            public static IPage<Usage> ListResourceUsage(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                return operations.ListResourceUsageAsync(resourceGroupName, profileName, endpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks the quota and actual usage of endpoints under the given CDN profile.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Usage>> ListResourceUsageAsync(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListResourceUsageWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Validates the custom domain mapping to ensure it maps to the correct CDN
            /// endpoint in DNS.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='hostName'>
            /// The host name of the custom domain. Must be a domain name.
            /// </param>
            public static ValidateCustomDomainOutput ValidateCustomDomain(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, string hostName)
            {
                return operations.ValidateCustomDomainAsync(resourceGroupName, profileName, endpointName, hostName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validates the custom domain mapping to ensure it maps to the correct CDN
            /// endpoint in DNS.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='hostName'>
            /// The host name of the custom domain. Must be a domain name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ValidateCustomDomainOutput> ValidateCustomDomainAsync(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, string hostName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidateCustomDomainWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, hostName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new AzureFrontDoor endpoint with the specified endpoint name
            /// under the specified subscription, resource group and profile.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='endpoint'>
            /// Endpoint properties
            /// </param>
            public static AFDEndpoint BeginCreate(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, AFDEndpoint endpoint)
            {
                return operations.BeginCreateAsync(resourceGroupName, profileName, endpointName, endpoint).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new AzureFrontDoor endpoint with the specified endpoint name
            /// under the specified subscription, resource group and profile.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='endpoint'>
            /// Endpoint properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AFDEndpoint> BeginCreateAsync(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, AFDEndpoint endpoint, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, endpoint, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing AzureFrontDoor endpoint with the specified endpoint
            /// name under the specified subscription, resource group and profile. Only
            /// tags can be updated after creating an endpoint. To update origins, use the
            /// Update Origin operation. To update origin groups, use the Update Origin
            /// group operation. To update domains, use the Update Custom Domain operation.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='endpointUpdateProperties'>
            /// Endpoint update properties
            /// </param>
            public static AFDEndpoint BeginUpdate(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, AFDEndpointUpdateParameters endpointUpdateProperties)
            {
                return operations.BeginUpdateAsync(resourceGroupName, profileName, endpointName, endpointUpdateProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing AzureFrontDoor endpoint with the specified endpoint
            /// name under the specified subscription, resource group and profile. Only
            /// tags can be updated after creating an endpoint. To update origins, use the
            /// Update Origin operation. To update origin groups, use the Update Origin
            /// group operation. To update domains, use the Update Custom Domain operation.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='endpointUpdateProperties'>
            /// Endpoint update properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AFDEndpoint> BeginUpdateAsync(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, AFDEndpointUpdateParameters endpointUpdateProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, endpointUpdateProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing AzureFrontDoor endpoint with the specified endpoint
            /// name under the specified subscription, resource group and profile.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            public static void BeginDelete(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                operations.BeginDeleteAsync(resourceGroupName, profileName, endpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing AzureFrontDoor endpoint with the specified endpoint
            /// name under the specified subscription, resource group and profile.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Removes a content from AzureFrontDoor.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='contentPaths'>
            /// The path to the content to be purged. Can describe a file path or a wild
            /// card directory.
            /// </param>
            /// <param name='domains'>
            /// List of domains.
            /// </param>
            public static void BeginPurgeContent(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, IList<string> contentPaths, IList<string> domains = default(IList<string>))
            {
                operations.BeginPurgeContentAsync(resourceGroupName, profileName, endpointName, contentPaths, domains).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes a content from AzureFrontDoor.
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
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='contentPaths'>
            /// The path to the content to be purged. Can describe a file path or a wild
            /// card directory.
            /// </param>
            /// <param name='domains'>
            /// List of domains.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginPurgeContentAsync(this IAFDEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, IList<string> contentPaths, IList<string> domains = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginPurgeContentWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, contentPaths, domains, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists existing AzureFrontDoor endpoints.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AFDEndpoint> ListByProfileNext(this IAFDEndpointsOperations operations, string nextPageLink)
            {
                return operations.ListByProfileNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists existing AzureFrontDoor endpoints.
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
            public static async Task<IPage<AFDEndpoint>> ListByProfileNextAsync(this IAFDEndpointsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByProfileNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checks the quota and actual usage of endpoints under the given CDN profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Usage> ListResourceUsageNext(this IAFDEndpointsOperations operations, string nextPageLink)
            {
                return operations.ListResourceUsageNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks the quota and actual usage of endpoints under the given CDN profile.
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
            public static async Task<IPage<Usage>> ListResourceUsageNextAsync(this IAFDEndpointsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListResourceUsageNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
