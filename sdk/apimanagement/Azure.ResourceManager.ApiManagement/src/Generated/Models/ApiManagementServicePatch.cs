// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Parameter supplied to Update Api Management Service. </summary>
    public partial class ApiManagementServicePatch : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ApiManagementServicePatch"/>. </summary>
        public ApiManagementServicePatch()
        {
            Zones = new ChangeTrackingList<string>();
            HostnameConfigurations = new ChangeTrackingList<HostnameConfiguration>();
            PublicIPAddresses = new ChangeTrackingList<IPAddress>();
            PrivateIPAddresses = new ChangeTrackingList<IPAddress>();
            AdditionalLocations = new ChangeTrackingList<AdditionalLocation>();
            CustomProperties = new ChangeTrackingDictionary<string, string>();
            Certificates = new ChangeTrackingList<CertificateConfiguration>();
            OutboundPublicIPAddresses = new ChangeTrackingList<string>();
            PrivateEndpointConnections = new ChangeTrackingList<RemotePrivateEndpointConnectionWrapper>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementServicePatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> SKU properties of the API Management service. </param>
        /// <param name="identity"> Managed service identity of the Api Management service. </param>
        /// <param name="etag"> ETag of the resource. </param>
        /// <param name="zones"> A list of availability zones denoting where the resource needs to come from. </param>
        /// <param name="notificationSenderEmail"> Email address from which the notification will be sent. </param>
        /// <param name="provisioningState"> The current provisioning state of the API Management service which can be one of the following: Created/Activating/Succeeded/Updating/Failed/Stopped/Terminating/TerminationFailed/Deleted. </param>
        /// <param name="targetProvisioningState"> The provisioning state of the API Management service, which is targeted by the long running operation started on the service. </param>
        /// <param name="createdAtUtc"> Creation UTC date of the API Management service.The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard. </param>
        /// <param name="gatewayUri"> Gateway URL of the API Management service. </param>
        /// <param name="gatewayRegionalUri"> Gateway URL of the API Management service in the Default Region. </param>
        /// <param name="portalUri"> Publisher portal endpoint Url of the API Management service. </param>
        /// <param name="managementApiUri"> Management API endpoint URL of the API Management service. </param>
        /// <param name="scmUri"> SCM endpoint URL of the API Management service. </param>
        /// <param name="developerPortalUri"> DEveloper Portal endpoint URL of the API Management service. </param>
        /// <param name="hostnameConfigurations"> Custom hostname configuration of the API Management service. </param>
        /// <param name="publicIPAddresses"> Public Static Load Balanced IP addresses of the API Management service in Primary region. Available only for Basic, Standard, Premium and Isolated SKU. </param>
        /// <param name="privateIPAddresses"> Private Static Load Balanced IP addresses of the API Management service in Primary region which is deployed in an Internal Virtual Network. Available only for Basic, Standard, Premium and Isolated SKU. </param>
        /// <param name="publicIPAddressId"> Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed service in the region. Supported only for Developer and Premium SKU being deployed in Virtual Network. </param>
        /// <param name="publicNetworkAccess"> Whether or not public endpoint access is allowed for this API Management service.  Value is optional but if passed in, must be 'Enabled' or 'Disabled'. If 'Disabled', private endpoints are the exclusive access method. Default value is 'Enabled'. </param>
        /// <param name="configurationApi"> Configuration API configuration of the API Management service. </param>
        /// <param name="virtualNetworkConfiguration"> Virtual network configuration of the API Management service. </param>
        /// <param name="additionalLocations"> Additional datacenter locations of the API Management service. </param>
        /// <param name="customProperties"> Custom properties of the API Management service.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TripleDes168` will disable the cipher TLS_RSA_WITH_3DES_EDE_CBC_SHA for all TLS(1.0, 1.1 and 1.2).&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls11` can be used to disable just TLS 1.1.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls10` can be used to disable TLS 1.0 on an API Management service.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls11` can be used to disable just TLS 1.1 for communications with backends.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls10` can be used to disable TLS 1.0 for communications with backends.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Protocols.Server.Http2` can be used to enable HTTP2 protocol on an API Management service.&lt;/br&gt;Not specifying any of these properties on PATCH operation will reset omitted properties' values to their defaults. For all the settings except Http2 the default value is `True` if the service was created on or before April 1, 2018 and `False` otherwise. Http2 setting's default value is `False`.&lt;/br&gt;&lt;/br&gt;You can disable any of the following ciphers by using settings `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.[cipher_name]`: TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA256, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA. For example, `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TLS_RSA_WITH_AES_128_CBC_SHA256`:`false`. The default value is `true` for them.&lt;/br&gt; Note: The following ciphers can't be disabled since they are required by internal platform components: TLS_AES_256_GCM_SHA384,TLS_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256. </param>
        /// <param name="certificates"> List of Certificates that need to be installed in the API Management service. Max supported certificates that can be installed is 10. </param>
        /// <param name="enableClientCertificate"> Property only meant to be used for Consumption SKU Service. This enforces a client certificate to be presented on each request to the gateway. This also enables the ability to authenticate the certificate in the policy on the gateway. </param>
        /// <param name="natGatewayState"> Property can be used to enable NAT Gateway for this API Management service. </param>
        /// <param name="outboundPublicIPAddresses"> Outbound public IPV4 address prefixes associated with NAT Gateway deployed service. Available only for Premium SKU on stv2 platform. </param>
        /// <param name="disableGateway"> Property only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in master region. </param>
        /// <param name="virtualNetworkType"> The type of VPN in which API Management service needs to be configured in. None (Default Value) means the API Management service is not part of any Virtual Network, External means the API Management deployment is set up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is setup inside a Virtual Network having an Intranet Facing Endpoint only. </param>
        /// <param name="apiVersionConstraint"> Control Plane Apis version constraint for the API Management service. </param>
        /// <param name="restore"> Undelete Api Management Service if it was previously soft-deleted. If this flag is specified and set to True all other properties will be ignored. </param>
        /// <param name="privateEndpointConnections"> List of Private Endpoint Connections of this service. </param>
        /// <param name="platformVersion"> Compute Platform Version running the service in this location. </param>
        /// <param name="legacyPortalStatus"> Status of legacy portal in the API Management service. </param>
        /// <param name="developerPortalStatus"> Status of developer portal in this API Management service. </param>
        /// <param name="publisherEmail"> Publisher email. </param>
        /// <param name="publisherName"> Publisher name. </param>
        /// <param name="tags"> Resource tags. </param>
        internal ApiManagementServicePatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ApiManagementServiceSkuProperties sku, ManagedServiceIdentity identity, ETag? etag, IList<string> zones, string notificationSenderEmail, string provisioningState, string targetProvisioningState, DateTimeOffset? createdAtUtc, Uri gatewayUri, Uri gatewayRegionalUri, Uri portalUri, Uri managementApiUri, Uri scmUri, Uri developerPortalUri, IList<HostnameConfiguration> hostnameConfigurations, IReadOnlyList<IPAddress> publicIPAddresses, IReadOnlyList<IPAddress> privateIPAddresses, ResourceIdentifier publicIPAddressId, PublicNetworkAccess? publicNetworkAccess, ConfigurationApi configurationApi, VirtualNetworkConfiguration virtualNetworkConfiguration, IList<AdditionalLocation> additionalLocations, IDictionary<string, string> customProperties, IList<CertificateConfiguration> certificates, bool? enableClientCertificate, NatGatewayState? natGatewayState, IReadOnlyList<string> outboundPublicIPAddresses, bool? disableGateway, VirtualNetworkType? virtualNetworkType, ApiVersionConstraint apiVersionConstraint, bool? restore, IList<RemotePrivateEndpointConnectionWrapper> privateEndpointConnections, PlatformVersion? platformVersion, LegacyPortalStatus? legacyPortalStatus, DeveloperPortalStatus? developerPortalStatus, string publisherEmail, string publisherName, IDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            Identity = identity;
            ETag = etag;
            Zones = zones;
            NotificationSenderEmail = notificationSenderEmail;
            ProvisioningState = provisioningState;
            TargetProvisioningState = targetProvisioningState;
            CreatedAtUtc = createdAtUtc;
            GatewayUri = gatewayUri;
            GatewayRegionalUri = gatewayRegionalUri;
            PortalUri = portalUri;
            ManagementApiUri = managementApiUri;
            ScmUri = scmUri;
            DeveloperPortalUri = developerPortalUri;
            HostnameConfigurations = hostnameConfigurations;
            PublicIPAddresses = publicIPAddresses;
            PrivateIPAddresses = privateIPAddresses;
            PublicIPAddressId = publicIPAddressId;
            PublicNetworkAccess = publicNetworkAccess;
            ConfigurationApi = configurationApi;
            VirtualNetworkConfiguration = virtualNetworkConfiguration;
            AdditionalLocations = additionalLocations;
            CustomProperties = customProperties;
            Certificates = certificates;
            EnableClientCertificate = enableClientCertificate;
            NatGatewayState = natGatewayState;
            OutboundPublicIPAddresses = outboundPublicIPAddresses;
            DisableGateway = disableGateway;
            VirtualNetworkType = virtualNetworkType;
            ApiVersionConstraint = apiVersionConstraint;
            Restore = restore;
            PrivateEndpointConnections = privateEndpointConnections;
            PlatformVersion = platformVersion;
            LegacyPortalStatus = legacyPortalStatus;
            DeveloperPortalStatus = developerPortalStatus;
            PublisherEmail = publisherEmail;
            PublisherName = publisherName;
            Tags = tags;
        }

        /// <summary> SKU properties of the API Management service. </summary>
        public ApiManagementServiceSkuProperties Sku { get; set; }
        /// <summary> Managed service identity of the Api Management service. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> ETag of the resource. </summary>
        public ETag? ETag { get; }
        /// <summary> A list of availability zones denoting where the resource needs to come from. </summary>
        public IList<string> Zones { get; }
        /// <summary> Email address from which the notification will be sent. </summary>
        public string NotificationSenderEmail { get; set; }
        /// <summary> The current provisioning state of the API Management service which can be one of the following: Created/Activating/Succeeded/Updating/Failed/Stopped/Terminating/TerminationFailed/Deleted. </summary>
        public string ProvisioningState { get; }
        /// <summary> The provisioning state of the API Management service, which is targeted by the long running operation started on the service. </summary>
        public string TargetProvisioningState { get; }
        /// <summary> Creation UTC date of the API Management service.The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard. </summary>
        public DateTimeOffset? CreatedAtUtc { get; }
        /// <summary> Gateway URL of the API Management service. </summary>
        public Uri GatewayUri { get; }
        /// <summary> Gateway URL of the API Management service in the Default Region. </summary>
        public Uri GatewayRegionalUri { get; }
        /// <summary> Publisher portal endpoint Url of the API Management service. </summary>
        public Uri PortalUri { get; }
        /// <summary> Management API endpoint URL of the API Management service. </summary>
        public Uri ManagementApiUri { get; }
        /// <summary> SCM endpoint URL of the API Management service. </summary>
        public Uri ScmUri { get; }
        /// <summary> DEveloper Portal endpoint URL of the API Management service. </summary>
        public Uri DeveloperPortalUri { get; }
        /// <summary> Custom hostname configuration of the API Management service. </summary>
        public IList<HostnameConfiguration> HostnameConfigurations { get; }
        /// <summary> Public Static Load Balanced IP addresses of the API Management service in Primary region. Available only for Basic, Standard, Premium and Isolated SKU. </summary>
        public IReadOnlyList<IPAddress> PublicIPAddresses { get; }
        /// <summary> Private Static Load Balanced IP addresses of the API Management service in Primary region which is deployed in an Internal Virtual Network. Available only for Basic, Standard, Premium and Isolated SKU. </summary>
        public IReadOnlyList<IPAddress> PrivateIPAddresses { get; }
        /// <summary> Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed service in the region. Supported only for Developer and Premium SKU being deployed in Virtual Network. </summary>
        public ResourceIdentifier PublicIPAddressId { get; set; }
        /// <summary> Whether or not public endpoint access is allowed for this API Management service.  Value is optional but if passed in, must be 'Enabled' or 'Disabled'. If 'Disabled', private endpoints are the exclusive access method. Default value is 'Enabled'. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Configuration API configuration of the API Management service. </summary>
        internal ConfigurationApi ConfigurationApi { get; set; }
        /// <summary> Indication whether or not the legacy Configuration API (v1) should be exposed on the API Management service. Value is optional but must be 'Enabled' or 'Disabled'. If 'Disabled', legacy Configuration API (v1) will not be available for self-hosted gateways. Default value is 'Enabled'. </summary>
        public LegacyApiState? LegacyApi
        {
            get => ConfigurationApi is null ? default : ConfigurationApi.LegacyApi;
            set
            {
                if (ConfigurationApi is null)
                    ConfigurationApi = new ConfigurationApi();
                ConfigurationApi.LegacyApi = value;
            }
        }

        /// <summary> Virtual network configuration of the API Management service. </summary>
        public VirtualNetworkConfiguration VirtualNetworkConfiguration { get; set; }
        /// <summary> Additional datacenter locations of the API Management service. </summary>
        public IList<AdditionalLocation> AdditionalLocations { get; }
        /// <summary> Custom properties of the API Management service.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TripleDes168` will disable the cipher TLS_RSA_WITH_3DES_EDE_CBC_SHA for all TLS(1.0, 1.1 and 1.2).&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls11` can be used to disable just TLS 1.1.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls10` can be used to disable TLS 1.0 on an API Management service.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls11` can be used to disable just TLS 1.1 for communications with backends.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls10` can be used to disable TLS 1.0 for communications with backends.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Protocols.Server.Http2` can be used to enable HTTP2 protocol on an API Management service.&lt;/br&gt;Not specifying any of these properties on PATCH operation will reset omitted properties' values to their defaults. For all the settings except Http2 the default value is `True` if the service was created on or before April 1, 2018 and `False` otherwise. Http2 setting's default value is `False`.&lt;/br&gt;&lt;/br&gt;You can disable any of the following ciphers by using settings `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.[cipher_name]`: TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA256, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA. For example, `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TLS_RSA_WITH_AES_128_CBC_SHA256`:`false`. The default value is `true` for them.&lt;/br&gt; Note: The following ciphers can't be disabled since they are required by internal platform components: TLS_AES_256_GCM_SHA384,TLS_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256. </summary>
        public IDictionary<string, string> CustomProperties { get; }
        /// <summary> List of Certificates that need to be installed in the API Management service. Max supported certificates that can be installed is 10. </summary>
        public IList<CertificateConfiguration> Certificates { get; }
        /// <summary> Property only meant to be used for Consumption SKU Service. This enforces a client certificate to be presented on each request to the gateway. This also enables the ability to authenticate the certificate in the policy on the gateway. </summary>
        public bool? EnableClientCertificate { get; set; }
        /// <summary> Property can be used to enable NAT Gateway for this API Management service. </summary>
        public NatGatewayState? NatGatewayState { get; set; }
        /// <summary> Outbound public IPV4 address prefixes associated with NAT Gateway deployed service. Available only for Premium SKU on stv2 platform. </summary>
        public IReadOnlyList<string> OutboundPublicIPAddresses { get; }
        /// <summary> Property only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in master region. </summary>
        public bool? DisableGateway { get; set; }
        /// <summary> The type of VPN in which API Management service needs to be configured in. None (Default Value) means the API Management service is not part of any Virtual Network, External means the API Management deployment is set up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is setup inside a Virtual Network having an Intranet Facing Endpoint only. </summary>
        public VirtualNetworkType? VirtualNetworkType { get; set; }
        /// <summary> Control Plane Apis version constraint for the API Management service. </summary>
        internal ApiVersionConstraint ApiVersionConstraint { get; set; }
        /// <summary> Limit control plane API calls to API Management service with version equal to or newer than this value. </summary>
        public string MinApiVersion
        {
            get => ApiVersionConstraint is null ? default : ApiVersionConstraint.MinApiVersion;
            set
            {
                if (ApiVersionConstraint is null)
                    ApiVersionConstraint = new ApiVersionConstraint();
                ApiVersionConstraint.MinApiVersion = value;
            }
        }

        /// <summary> Undelete Api Management Service if it was previously soft-deleted. If this flag is specified and set to True all other properties will be ignored. </summary>
        public bool? Restore { get; set; }
        /// <summary> List of Private Endpoint Connections of this service. </summary>
        public IList<RemotePrivateEndpointConnectionWrapper> PrivateEndpointConnections { get; }
        /// <summary> Compute Platform Version running the service in this location. </summary>
        public PlatformVersion? PlatformVersion { get; }
        /// <summary> Status of legacy portal in the API Management service. </summary>
        public LegacyPortalStatus? LegacyPortalStatus { get; set; }
        /// <summary> Status of developer portal in this API Management service. </summary>
        public DeveloperPortalStatus? DeveloperPortalStatus { get; set; }
        /// <summary> Publisher email. </summary>
        public string PublisherEmail { get; set; }
        /// <summary> Publisher name. </summary>
        public string PublisherName { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
