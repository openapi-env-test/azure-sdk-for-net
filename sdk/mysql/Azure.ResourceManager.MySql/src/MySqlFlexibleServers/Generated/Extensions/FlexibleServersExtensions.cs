// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql.FlexibleServers.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.MySql.FlexibleServers. </summary>
    public static partial class FlexibleServersExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary>
        /// Get private DNS zone suffix in the cloud.
        /// Request Path: /providers/Microsoft.DBforMySQL/getPrivateDnsZoneSuffix
        /// Operation Id: GetPrivateDnsZoneSuffix_Execute
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>> ExecuteGetPrivateDnsZoneSuffixAsync(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(tenantResource).ExecuteGetPrivateDnsZoneSuffixAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get private DNS zone suffix in the cloud.
        /// Request Path: /providers/Microsoft.DBforMySQL/getPrivateDnsZoneSuffix
        /// Operation Id: GetPrivateDnsZoneSuffix_Execute
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<MySqlFlexibleServerPrivateDnsZoneSuffixResponse> ExecuteGetPrivateDnsZoneSuffix(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenantResource).ExecuteGetPrivateDnsZoneSuffix(cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/flexibleServers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<MySqlFlexibleServerResource> GetMySqlFlexibleServersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetMySqlFlexibleServersAsync(cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/flexibleServers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<MySqlFlexibleServerResource> GetMySqlFlexibleServers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetMySqlFlexibleServers(cancellationToken);
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilities
        /// Operation Id: LocationBasedCapabilities_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlFlexibleServerCapabilityProperties" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<MySqlFlexibleServerCapabilityProperties> GetLocationBasedCapabilitiesAsync(this SubscriptionResource subscriptionResource, AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetLocationBasedCapabilitiesAsync(locationName, cancellationToken);
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilities
        /// Operation Id: LocationBasedCapabilities_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlFlexibleServerCapabilityProperties" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<MySqlFlexibleServerCapabilityProperties> GetLocationBasedCapabilities(this SubscriptionResource subscriptionResource, AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetLocationBasedCapabilities(locationName, cancellationToken);
        }

        /// <summary>
        /// Get virtual network subnet usage for a given vNet resource id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/checkVirtualNetworkSubnetUsage
        /// Operation Id: CheckVirtualNetworkSubnetUsage_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="mySqlFlexibleServerVirtualNetworkSubnetUsageParameter"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mySqlFlexibleServerVirtualNetworkSubnetUsageParameter"/> is null. </exception>
        public static async Task<Response<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>> ExecuteCheckVirtualNetworkSubnetUsageAsync(this SubscriptionResource subscriptionResource, AzureLocation locationName, MySqlFlexibleServerVirtualNetworkSubnetUsageParameter mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, nameof(mySqlFlexibleServerVirtualNetworkSubnetUsageParameter));

            return await GetExtensionClient(subscriptionResource).ExecuteCheckVirtualNetworkSubnetUsageAsync(locationName, mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get virtual network subnet usage for a given vNet resource id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/checkVirtualNetworkSubnetUsage
        /// Operation Id: CheckVirtualNetworkSubnetUsage_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="mySqlFlexibleServerVirtualNetworkSubnetUsageParameter"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mySqlFlexibleServerVirtualNetworkSubnetUsageParameter"/> is null. </exception>
        public static Response<MySqlFlexibleServerVirtualNetworkSubnetUsageResult> ExecuteCheckVirtualNetworkSubnetUsage(this SubscriptionResource subscriptionResource, AzureLocation locationName, MySqlFlexibleServerVirtualNetworkSubnetUsageParameter mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, nameof(mySqlFlexibleServerVirtualNetworkSubnetUsageParameter));

            return GetExtensionClient(subscriptionResource).ExecuteCheckVirtualNetworkSubnetUsage(locationName, mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, cancellationToken);
        }

        /// <summary>
        /// Check the availability of name for server
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/checkNameAvailability
        /// Operation Id: CheckNameAvailability_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="content"> The required parameters for checking if server name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<MySqlFlexibleServerNameAvailabilityResult>> CheckMySqlFlexibleServerNameAvailabilityAsync(this SubscriptionResource subscriptionResource, AzureLocation locationName, MySqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckMySqlFlexibleServerNameAvailabilityAsync(locationName, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of name for server
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/checkNameAvailability
        /// Operation Id: CheckNameAvailability_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="content"> The required parameters for checking if server name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<MySqlFlexibleServerNameAvailabilityResult> CheckMySqlFlexibleServerNameAvailability(this SubscriptionResource subscriptionResource, AzureLocation locationName, MySqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckMySqlFlexibleServerNameAvailability(locationName, content, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of MySqlFlexibleServerResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of MySqlFlexibleServerResources and their operations over a MySqlFlexibleServerResource. </returns>
        public static MySqlFlexibleServerCollection GetMySqlFlexibleServers(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetMySqlFlexibleServers();
        }

        /// <summary>
        /// Gets information about a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<MySqlFlexibleServerResource>> GetMySqlFlexibleServerAsync(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetMySqlFlexibleServers().GetAsync(serverName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<MySqlFlexibleServerResource> GetMySqlFlexibleServer(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetMySqlFlexibleServers().Get(serverName, cancellationToken);
        }

        #region MySqlFlexibleServerResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlFlexibleServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlFlexibleServerResource.CreateResourceIdentifier" /> to create a <see cref="MySqlFlexibleServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlFlexibleServerResource" /> object. </returns>
        public static MySqlFlexibleServerResource GetMySqlFlexibleServerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlFlexibleServerResource.ValidateResourceId(id);
                return new MySqlFlexibleServerResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlFlexibleServerBackupResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlFlexibleServerBackupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlFlexibleServerBackupResource.CreateResourceIdentifier" /> to create a <see cref="MySqlFlexibleServerBackupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlFlexibleServerBackupResource" /> object. </returns>
        public static MySqlFlexibleServerBackupResource GetMySqlFlexibleServerBackupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlFlexibleServerBackupResource.ValidateResourceId(id);
                return new MySqlFlexibleServerBackupResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlFlexibleServerFirewallRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlFlexibleServerFirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlFlexibleServerFirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="MySqlFlexibleServerFirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlFlexibleServerFirewallRuleResource" /> object. </returns>
        public static MySqlFlexibleServerFirewallRuleResource GetMySqlFlexibleServerFirewallRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlFlexibleServerFirewallRuleResource.ValidateResourceId(id);
                return new MySqlFlexibleServerFirewallRuleResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlFlexibleServerDatabaseResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlFlexibleServerDatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlFlexibleServerDatabaseResource.CreateResourceIdentifier" /> to create a <see cref="MySqlFlexibleServerDatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlFlexibleServerDatabaseResource" /> object. </returns>
        public static MySqlFlexibleServerDatabaseResource GetMySqlFlexibleServerDatabaseResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlFlexibleServerDatabaseResource.ValidateResourceId(id);
                return new MySqlFlexibleServerDatabaseResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlFlexibleServerConfigurationResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlFlexibleServerConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlFlexibleServerConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="MySqlFlexibleServerConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlFlexibleServerConfigurationResource" /> object. </returns>
        public static MySqlFlexibleServerConfigurationResource GetMySqlFlexibleServerConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlFlexibleServerConfigurationResource.ValidateResourceId(id);
                return new MySqlFlexibleServerConfigurationResource(client, id);
            }
            );
        }
        #endregion
    }
}
