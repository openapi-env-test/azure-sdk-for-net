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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Network Client
    /// </summary>
    public partial interface INetworkManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The subscription credentials which uniquely identify the Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Client API version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IApplicationGatewaysOperations.
        /// </summary>
        IApplicationGatewaysOperations ApplicationGateways { get; }

        /// <summary>
        /// Gets the IApplicationSecurityGroupsOperations.
        /// </summary>
        IApplicationSecurityGroupsOperations ApplicationSecurityGroups { get; }

        /// <summary>
        /// Gets the IAvailableDelegationsOperations.
        /// </summary>
        IAvailableDelegationsOperations AvailableDelegations { get; }

        /// <summary>
        /// Gets the IAvailableResourceGroupDelegationsOperations.
        /// </summary>
        IAvailableResourceGroupDelegationsOperations AvailableResourceGroupDelegations { get; }

        /// <summary>
        /// Gets the IAvailableServiceAliasesOperations.
        /// </summary>
        IAvailableServiceAliasesOperations AvailableServiceAliases { get; }

        /// <summary>
        /// Gets the IAzureFirewallsOperations.
        /// </summary>
        IAzureFirewallsOperations AzureFirewalls { get; }

        /// <summary>
        /// Gets the IAzureFirewallFqdnTagsOperations.
        /// </summary>
        IAzureFirewallFqdnTagsOperations AzureFirewallFqdnTags { get; }

        /// <summary>
        /// Gets the IBastionHostsOperations.
        /// </summary>
        IBastionHostsOperations BastionHosts { get; }

        /// <summary>
        /// Gets the IDdosCustomPoliciesOperations.
        /// </summary>
        IDdosCustomPoliciesOperations DdosCustomPolicies { get; }

        /// <summary>
        /// Gets the IDdosProtectionPlansOperations.
        /// </summary>
        IDdosProtectionPlansOperations DdosProtectionPlans { get; }

        /// <summary>
        /// Gets the IAvailableEndpointServicesOperations.
        /// </summary>
        IAvailableEndpointServicesOperations AvailableEndpointServices { get; }

        /// <summary>
        /// Gets the IExpressRouteCircuitAuthorizationsOperations.
        /// </summary>
        IExpressRouteCircuitAuthorizationsOperations ExpressRouteCircuitAuthorizations { get; }

        /// <summary>
        /// Gets the IExpressRouteCircuitPeeringsOperations.
        /// </summary>
        IExpressRouteCircuitPeeringsOperations ExpressRouteCircuitPeerings { get; }

        /// <summary>
        /// Gets the IExpressRouteCircuitConnectionsOperations.
        /// </summary>
        IExpressRouteCircuitConnectionsOperations ExpressRouteCircuitConnections { get; }

        /// <summary>
        /// Gets the IPeerExpressRouteCircuitConnectionsOperations.
        /// </summary>
        IPeerExpressRouteCircuitConnectionsOperations PeerExpressRouteCircuitConnections { get; }

        /// <summary>
        /// Gets the IExpressRouteCircuitsOperations.
        /// </summary>
        IExpressRouteCircuitsOperations ExpressRouteCircuits { get; }

        /// <summary>
        /// Gets the IExpressRouteServiceProvidersOperations.
        /// </summary>
        IExpressRouteServiceProvidersOperations ExpressRouteServiceProviders { get; }

        /// <summary>
        /// Gets the IExpressRouteCrossConnectionsOperations.
        /// </summary>
        IExpressRouteCrossConnectionsOperations ExpressRouteCrossConnections { get; }

        /// <summary>
        /// Gets the IExpressRouteCrossConnectionPeeringsOperations.
        /// </summary>
        IExpressRouteCrossConnectionPeeringsOperations ExpressRouteCrossConnectionPeerings { get; }

        /// <summary>
        /// Gets the IExpressRouteGatewaysOperations.
        /// </summary>
        IExpressRouteGatewaysOperations ExpressRouteGateways { get; }

        /// <summary>
        /// Gets the IExpressRouteConnectionsOperations.
        /// </summary>
        IExpressRouteConnectionsOperations ExpressRouteConnections { get; }

        /// <summary>
        /// Gets the IExpressRoutePortsLocationsOperations.
        /// </summary>
        IExpressRoutePortsLocationsOperations ExpressRoutePortsLocations { get; }

        /// <summary>
        /// Gets the IExpressRoutePortsOperations.
        /// </summary>
        IExpressRoutePortsOperations ExpressRoutePorts { get; }

        /// <summary>
        /// Gets the IExpressRouteLinksOperations.
        /// </summary>
        IExpressRouteLinksOperations ExpressRouteLinks { get; }

        /// <summary>
        /// Gets the IFirewallPoliciesOperations.
        /// </summary>
        IFirewallPoliciesOperations FirewallPolicies { get; }

        /// <summary>
        /// Gets the IFirewallPolicyRuleGroupsOperations.
        /// </summary>
        IFirewallPolicyRuleGroupsOperations FirewallPolicyRuleGroups { get; }

        /// <summary>
        /// Gets the IIpGroupsOperations.
        /// </summary>
        IIpGroupsOperations IpGroups { get; }

        /// <summary>
        /// Gets the ILoadBalancersOperations.
        /// </summary>
        ILoadBalancersOperations LoadBalancers { get; }

        /// <summary>
        /// Gets the ILoadBalancerBackendAddressPoolsOperations.
        /// </summary>
        ILoadBalancerBackendAddressPoolsOperations LoadBalancerBackendAddressPools { get; }

        /// <summary>
        /// Gets the ILoadBalancerFrontendIPConfigurationsOperations.
        /// </summary>
        ILoadBalancerFrontendIPConfigurationsOperations LoadBalancerFrontendIPConfigurations { get; }

        /// <summary>
        /// Gets the IInboundNatRulesOperations.
        /// </summary>
        IInboundNatRulesOperations InboundNatRules { get; }

        /// <summary>
        /// Gets the ILoadBalancerLoadBalancingRulesOperations.
        /// </summary>
        ILoadBalancerLoadBalancingRulesOperations LoadBalancerLoadBalancingRules { get; }

        /// <summary>
        /// Gets the ILoadBalancerOutboundRulesOperations.
        /// </summary>
        ILoadBalancerOutboundRulesOperations LoadBalancerOutboundRules { get; }

        /// <summary>
        /// Gets the ILoadBalancerNetworkInterfacesOperations.
        /// </summary>
        ILoadBalancerNetworkInterfacesOperations LoadBalancerNetworkInterfaces { get; }

        /// <summary>
        /// Gets the ILoadBalancerProbesOperations.
        /// </summary>
        ILoadBalancerProbesOperations LoadBalancerProbes { get; }

        /// <summary>
        /// Gets the IConnectivityConfigurationsOperations.
        /// </summary>
        IConnectivityConfigurationsOperations ConnectivityConfigurations { get; }

        /// <summary>
        /// Gets the ISecurityConfigurationsOperations.
        /// </summary>
        ISecurityConfigurationsOperations SecurityConfigurations { get; }

        /// <summary>
        /// Gets the ISecurityConfigurationRulesOperations.
        /// </summary>
        ISecurityConfigurationRulesOperations SecurityConfigurationRules { get; }

        /// <summary>
        /// Gets the ICommitsOperations.
        /// </summary>
        ICommitsOperations Commits { get; }

        /// <summary>
        /// Gets the INetworkGroupsOperations.
        /// </summary>
        INetworkGroupsOperations NetworkGroups { get; }

        /// <summary>
        /// Gets the IActiveConfigurationsOperations.
        /// </summary>
        IActiveConfigurationsOperations ActiveConfigurations { get; }

        /// <summary>
        /// Gets the INetworkManagersOperations.
        /// </summary>
        INetworkManagersOperations NetworkManagers { get; }

        /// <summary>
        /// Gets the INatGatewaysOperations.
        /// </summary>
        INatGatewaysOperations NatGateways { get; }

        /// <summary>
        /// Gets the INetworkInterfacesOperations.
        /// </summary>
        INetworkInterfacesOperations NetworkInterfaces { get; }

        /// <summary>
        /// Gets the INetworkInterfaceIPConfigurationsOperations.
        /// </summary>
        INetworkInterfaceIPConfigurationsOperations NetworkInterfaceIPConfigurations { get; }

        /// <summary>
        /// Gets the INetworkInterfaceLoadBalancersOperations.
        /// </summary>
        INetworkInterfaceLoadBalancersOperations NetworkInterfaceLoadBalancers { get; }

        /// <summary>
        /// Gets the INetworkInterfaceTapConfigurationsOperations.
        /// </summary>
        INetworkInterfaceTapConfigurationsOperations NetworkInterfaceTapConfigurations { get; }

        /// <summary>
        /// Gets the INetworkProfilesOperations.
        /// </summary>
        INetworkProfilesOperations NetworkProfiles { get; }

        /// <summary>
        /// Gets the INetworkSecurityGroupsOperations.
        /// </summary>
        INetworkSecurityGroupsOperations NetworkSecurityGroups { get; }

        /// <summary>
        /// Gets the ISecurityRulesOperations.
        /// </summary>
        ISecurityRulesOperations SecurityRules { get; }

        /// <summary>
        /// Gets the IDefaultSecurityRulesOperations.
        /// </summary>
        IDefaultSecurityRulesOperations DefaultSecurityRules { get; }

        /// <summary>
        /// Gets the INetworkWatchersOperations.
        /// </summary>
        INetworkWatchersOperations NetworkWatchers { get; }

        /// <summary>
        /// Gets the IPacketCapturesOperations.
        /// </summary>
        IPacketCapturesOperations PacketCaptures { get; }

        /// <summary>
        /// Gets the IConnectionMonitorsOperations.
        /// </summary>
        IConnectionMonitorsOperations ConnectionMonitors { get; }

        /// <summary>
        /// Gets the IFlowLogsOperations.
        /// </summary>
        IFlowLogsOperations FlowLogs { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IPrivateEndpointsOperations.
        /// </summary>
        IPrivateEndpointsOperations PrivateEndpoints { get; }

        /// <summary>
        /// Gets the IAvailablePrivateEndpointTypesOperations.
        /// </summary>
        IAvailablePrivateEndpointTypesOperations AvailablePrivateEndpointTypes { get; }

        /// <summary>
        /// Gets the IPrivateLinkServicesOperations.
        /// </summary>
        IPrivateLinkServicesOperations PrivateLinkServices { get; }

        /// <summary>
        /// Gets the IPublicIPAddressesOperations.
        /// </summary>
        IPublicIPAddressesOperations PublicIPAddresses { get; }

        /// <summary>
        /// Gets the IPublicIPPrefixesOperations.
        /// </summary>
        IPublicIPPrefixesOperations PublicIPPrefixes { get; }

        /// <summary>
        /// Gets the IRouteFiltersOperations.
        /// </summary>
        IRouteFiltersOperations RouteFilters { get; }

        /// <summary>
        /// Gets the IRouteFilterRulesOperations.
        /// </summary>
        IRouteFilterRulesOperations RouteFilterRules { get; }

        /// <summary>
        /// Gets the IRouteTablesOperations.
        /// </summary>
        IRouteTablesOperations RouteTables { get; }

        /// <summary>
        /// Gets the IRoutesOperations.
        /// </summary>
        IRoutesOperations Routes { get; }

        /// <summary>
        /// Gets the IBgpServiceCommunitiesOperations.
        /// </summary>
        IBgpServiceCommunitiesOperations BgpServiceCommunities { get; }

        /// <summary>
        /// Gets the IServiceEndpointPoliciesOperations.
        /// </summary>
        IServiceEndpointPoliciesOperations ServiceEndpointPolicies { get; }

        /// <summary>
        /// Gets the IServiceEndpointPolicyDefinitionsOperations.
        /// </summary>
        IServiceEndpointPolicyDefinitionsOperations ServiceEndpointPolicyDefinitions { get; }

        /// <summary>
        /// Gets the IServiceTagsOperations.
        /// </summary>
        IServiceTagsOperations ServiceTags { get; }

        /// <summary>
        /// Gets the IUsagesOperations.
        /// </summary>
        IUsagesOperations Usages { get; }

        /// <summary>
        /// Gets the IVirtualNetworksOperations.
        /// </summary>
        IVirtualNetworksOperations VirtualNetworks { get; }

        /// <summary>
        /// Gets the ISubnetsOperations.
        /// </summary>
        ISubnetsOperations Subnets { get; }

        /// <summary>
        /// Gets the IResourceNavigationLinksOperations.
        /// </summary>
        IResourceNavigationLinksOperations ResourceNavigationLinks { get; }

        /// <summary>
        /// Gets the IServiceAssociationLinksOperations.
        /// </summary>
        IServiceAssociationLinksOperations ServiceAssociationLinks { get; }

        /// <summary>
        /// Gets the IVirtualNetworkPeeringsOperations.
        /// </summary>
        IVirtualNetworkPeeringsOperations VirtualNetworkPeerings { get; }

        /// <summary>
        /// Gets the IVirtualNetworkGatewaysOperations.
        /// </summary>
        IVirtualNetworkGatewaysOperations VirtualNetworkGateways { get; }

        /// <summary>
        /// Gets the IVirtualNetworkGatewayConnectionsOperations.
        /// </summary>
        IVirtualNetworkGatewayConnectionsOperations VirtualNetworkGatewayConnections { get; }

        /// <summary>
        /// Gets the ILocalNetworkGatewaysOperations.
        /// </summary>
        ILocalNetworkGatewaysOperations LocalNetworkGateways { get; }

        /// <summary>
        /// Gets the IVirtualNetworkTapsOperations.
        /// </summary>
        IVirtualNetworkTapsOperations VirtualNetworkTaps { get; }

        /// <summary>
        /// Gets the IVirtualRoutersOperations.
        /// </summary>
        IVirtualRoutersOperations VirtualRouters { get; }

        /// <summary>
        /// Gets the IVirtualRouterPeeringsOperations.
        /// </summary>
        IVirtualRouterPeeringsOperations VirtualRouterPeerings { get; }

        /// <summary>
        /// Gets the IVirtualWansOperations.
        /// </summary>
        IVirtualWansOperations VirtualWans { get; }

        /// <summary>
        /// Gets the IVpnSitesOperations.
        /// </summary>
        IVpnSitesOperations VpnSites { get; }

        /// <summary>
        /// Gets the IVpnSiteLinksOperations.
        /// </summary>
        IVpnSiteLinksOperations VpnSiteLinks { get; }

        /// <summary>
        /// Gets the IVpnSitesConfigurationOperations.
        /// </summary>
        IVpnSitesConfigurationOperations VpnSitesConfiguration { get; }

        /// <summary>
        /// Gets the IVpnServerConfigurationsOperations.
        /// </summary>
        IVpnServerConfigurationsOperations VpnServerConfigurations { get; }

        /// <summary>
        /// Gets the IVirtualHubsOperations.
        /// </summary>
        IVirtualHubsOperations VirtualHubs { get; }

        /// <summary>
        /// Gets the IHubVirtualNetworkConnectionsOperations.
        /// </summary>
        IHubVirtualNetworkConnectionsOperations HubVirtualNetworkConnections { get; }

        /// <summary>
        /// Gets the IVpnGatewaysOperations.
        /// </summary>
        IVpnGatewaysOperations VpnGateways { get; }

        /// <summary>
        /// Gets the IVpnConnectionsOperations.
        /// </summary>
        IVpnConnectionsOperations VpnConnections { get; }

        /// <summary>
        /// Gets the IVpnSiteLinkConnectionsOperations.
        /// </summary>
        IVpnSiteLinkConnectionsOperations VpnSiteLinkConnections { get; }

        /// <summary>
        /// Gets the IVpnLinkConnectionsOperations.
        /// </summary>
        IVpnLinkConnectionsOperations VpnLinkConnections { get; }

        /// <summary>
        /// Gets the IP2sVpnGatewaysOperations.
        /// </summary>
        IP2sVpnGatewaysOperations P2sVpnGateways { get; }

        /// <summary>
        /// Gets the IVpnServerConfigurationsAssociatedWithVirtualWanOperations.
        /// </summary>
        IVpnServerConfigurationsAssociatedWithVirtualWanOperations VpnServerConfigurationsAssociatedWithVirtualWan { get; }

        /// <summary>
        /// Gets the IVirtualHubRouteTableV2sOperations.
        /// </summary>
        IVirtualHubRouteTableV2sOperations VirtualHubRouteTableV2s { get; }

        /// <summary>
        /// Gets the IWebApplicationFirewallPoliciesOperations.
        /// </summary>
        IWebApplicationFirewallPoliciesOperations WebApplicationFirewallPolicies { get; }

        /// <summary>
        /// Creates a Bastion Shareable Links for all the VMs specified in the
        /// request.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='bastionHostName'>
        /// The name of the Bastion Host.
        /// </param>
        /// <param name='bslRequest'>
        /// Post request for all the Bastion Shareable Link endpoints.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BastionShareableLink>>> PutBastionShareableLinkWithHttpMessagesAsync(string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the Bastion Shareable Links for all the VMs specified in
        /// the request.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='bastionHostName'>
        /// The name of the Bastion Host.
        /// </param>
        /// <param name='bslRequest'>
        /// Post request for all the Bastion Shareable Link endpoints.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteBastionShareableLinkWithHttpMessagesAsync(string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Return the Bastion Shareable Links for all the VMs specified in the
        /// request.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='bastionHostName'>
        /// The name of the Bastion Host.
        /// </param>
        /// <param name='bslRequest'>
        /// Post request for all the Bastion Shareable Link endpoints.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BastionShareableLink>>> GetBastionShareableLinkWithHttpMessagesAsync(string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the list of currently active sessions on the Bastion.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='bastionHostName'>
        /// The name of the Bastion Host.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BastionActiveSession>>> GetActiveSessionsWithHttpMessagesAsync(string resourceGroupName, string bastionHostName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the list of currently active sessions on the Bastion.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='bastionHostName'>
        /// The name of the Bastion Host.
        /// </param>
        /// <param name='sessionIds'>
        /// The list of sessionids to disconnect.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BastionSessionState>>> DisconnectActiveSessionsWithHttpMessagesAsync(string resourceGroupName, string bastionHostName, SessionIds sessionIds, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Checks whether a domain name in the cloudapp.azure.com zone is
        /// available for use.
        /// </summary>
        /// <param name='location'>
        /// The location of the domain name.
        /// </param>
        /// <param name='domainNameLabel'>
        /// The domain name to be verified. It must conform to the following
        /// regular expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DnsNameAvailabilityResult>> CheckDnsNameAvailabilityWithHttpMessagesAsync(string location, string domainNameLabel, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gives the supported security providers for the virtual wan.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='virtualWANName'>
        /// The name of the VirtualWAN for which supported security providers
        /// are needed.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualWanSecurityProviders>> SupportedSecurityProvidersWithHttpMessagesAsync(string resourceGroupName, string virtualWANName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generates a unique VPN profile for P2S clients for VirtualWan and
        /// associated VpnServerConfiguration combination in the specified
        /// resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='virtualWANName'>
        /// The name of the VirtualWAN whose associated VpnServerConfigurations
        /// is needed.
        /// </param>
        /// <param name='vpnClientParams'>
        /// Parameters supplied to the generate VirtualWan VPN profile
        /// generation operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VpnProfileResponse>> GeneratevirtualwanvpnserverconfigurationvpnprofileWithHttpMessagesAsync(string resourceGroupName, string virtualWANName, VirtualWanVpnProfileParameters vpnClientParams, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates a Bastion Shareable Links for all the VMs specified in the
        /// request.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='bastionHostName'>
        /// The name of the Bastion Host.
        /// </param>
        /// <param name='bslRequest'>
        /// Post request for all the Bastion Shareable Link endpoints.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BastionShareableLink>>> BeginPutBastionShareableLinkWithHttpMessagesAsync(string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the Bastion Shareable Links for all the VMs specified in
        /// the request.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='bastionHostName'>
        /// The name of the Bastion Host.
        /// </param>
        /// <param name='bslRequest'>
        /// Post request for all the Bastion Shareable Link endpoints.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteBastionShareableLinkWithHttpMessagesAsync(string resourceGroupName, string bastionHostName, BastionShareableLinkListRequest bslRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the list of currently active sessions on the Bastion.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='bastionHostName'>
        /// The name of the Bastion Host.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BastionActiveSession>>> BeginGetActiveSessionsWithHttpMessagesAsync(string resourceGroupName, string bastionHostName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generates a unique VPN profile for P2S clients for VirtualWan and
        /// associated VpnServerConfiguration combination in the specified
        /// resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='virtualWANName'>
        /// The name of the VirtualWAN whose associated VpnServerConfigurations
        /// is needed.
        /// </param>
        /// <param name='vpnClientParams'>
        /// Parameters supplied to the generate VirtualWan VPN profile
        /// generation operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VpnProfileResponse>> BeginGeneratevirtualwanvpnserverconfigurationvpnprofileWithHttpMessagesAsync(string resourceGroupName, string virtualWANName, VirtualWanVpnProfileParameters vpnClientParams, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates a Bastion Shareable Links for all the VMs specified in the
        /// request.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BastionShareableLink>>> PutBastionShareableLinkNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Return the Bastion Shareable Links for all the VMs specified in the
        /// request.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BastionShareableLink>>> GetBastionShareableLinkNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the list of currently active sessions on the Bastion.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BastionActiveSession>>> GetActiveSessionsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the list of currently active sessions on the Bastion.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BastionSessionState>>> DisconnectActiveSessionsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates a Bastion Shareable Links for all the VMs specified in the
        /// request.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BastionShareableLink>>> BeginPutBastionShareableLinkNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the list of currently active sessions on the Bastion.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BastionActiveSession>>> BeginGetActiveSessionsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
