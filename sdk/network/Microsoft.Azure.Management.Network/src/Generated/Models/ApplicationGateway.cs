// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ApplicationGateways resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGateway : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGateway class.
        /// </summary>
        public ApplicationGateway()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGateway class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">Gets or sets sku of application gateway
        /// resource</param>
        /// <param name="operationalState">Gets operational state of
        /// application gateway resource. Possible values include: 'Stopped',
        /// 'Starting', 'Running', 'Stopping'</param>
        /// <param name="gatewayIPConfigurations">Gets or sets subnets of
        /// application gateway resource</param>
        /// <param name="sslCertificates">Gets or sets ssl certificates of
        /// application gateway resource</param>
        /// <param name="frontendIPConfigurations">Gets or sets frontend IP
        /// addresses of application gateway resource</param>
        /// <param name="frontendPorts">Gets or sets frontend ports of
        /// application gateway resource</param>
        /// <param name="backendAddressPools">Gets or sets backend address pool
        /// of application gateway resource</param>
        /// <param name="backendHttpSettingsCollection">Gets or sets backend
        /// http settings of application gateway resource</param>
        /// <param name="httpListeners">Gets or sets HTTP listeners of
        /// application gateway resource</param>
        /// <param name="requestRoutingRules">Gets or sets request routing
        /// rules of application gateway resource</param>
        /// <param name="resourceGuid">Gets or sets resource guid property of
        /// the ApplicationGateway resource</param>
        /// <param name="provisioningState">Gets or sets Provisioning state of
        /// the ApplicationGateway resource Updating/Deleting/Failed</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated</param>
        public ApplicationGateway(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ApplicationGatewaySku sku = default(ApplicationGatewaySku), string operationalState = default(string), IList<ApplicationGatewayIPConfiguration> gatewayIPConfigurations = default(IList<ApplicationGatewayIPConfiguration>), IList<ApplicationGatewaySslCertificate> sslCertificates = default(IList<ApplicationGatewaySslCertificate>), IList<ApplicationGatewayFrontendIPConfiguration> frontendIPConfigurations = default(IList<ApplicationGatewayFrontendIPConfiguration>), IList<ApplicationGatewayFrontendPort> frontendPorts = default(IList<ApplicationGatewayFrontendPort>), IList<ApplicationGatewayBackendAddressPool> backendAddressPools = default(IList<ApplicationGatewayBackendAddressPool>), IList<ApplicationGatewayBackendHttpSettings> backendHttpSettingsCollection = default(IList<ApplicationGatewayBackendHttpSettings>), IList<ApplicationGatewayHttpListener> httpListeners = default(IList<ApplicationGatewayHttpListener>), IList<ApplicationGatewayRequestRoutingRule> requestRoutingRules = default(IList<ApplicationGatewayRequestRoutingRule>), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            OperationalState = operationalState;
            GatewayIPConfigurations = gatewayIPConfigurations;
            SslCertificates = sslCertificates;
            FrontendIPConfigurations = frontendIPConfigurations;
            FrontendPorts = frontendPorts;
            BackendAddressPools = backendAddressPools;
            BackendHttpSettingsCollection = backendHttpSettingsCollection;
            HttpListeners = httpListeners;
            RequestRoutingRules = requestRoutingRules;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets sku of application gateway resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public ApplicationGatewaySku Sku { get; set; }

        /// <summary>
        /// Gets operational state of application gateway resource. Possible
        /// values include: 'Stopped', 'Starting', 'Running', 'Stopping'
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationalState")]
        public string OperationalState { get; private set; }

        /// <summary>
        /// Gets or sets subnets of application gateway resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayIPConfigurations")]
        public IList<ApplicationGatewayIPConfiguration> GatewayIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets ssl certificates of application gateway resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.sslCertificates")]
        public IList<ApplicationGatewaySslCertificate> SslCertificates { get; set; }

        /// <summary>
        /// Gets or sets frontend IP addresses of application gateway resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfigurations")]
        public IList<ApplicationGatewayFrontendIPConfiguration> FrontendIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets frontend ports of application gateway resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendPorts")]
        public IList<ApplicationGatewayFrontendPort> FrontendPorts { get; set; }

        /// <summary>
        /// Gets or sets backend address pool of application gateway resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPools")]
        public IList<ApplicationGatewayBackendAddressPool> BackendAddressPools { get; set; }

        /// <summary>
        /// Gets or sets backend http settings of application gateway resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendHttpSettingsCollection")]
        public IList<ApplicationGatewayBackendHttpSettings> BackendHttpSettingsCollection { get; set; }

        /// <summary>
        /// Gets or sets HTTP listeners of application gateway resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpListeners")]
        public IList<ApplicationGatewayHttpListener> HttpListeners { get; set; }

        /// <summary>
        /// Gets or sets request routing rules of application gateway resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestRoutingRules")]
        public IList<ApplicationGatewayRequestRoutingRule> RequestRoutingRules { get; set; }

        /// <summary>
        /// Gets or sets resource guid property of the ApplicationGateway
        /// resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets or sets Provisioning state of the ApplicationGateway resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
