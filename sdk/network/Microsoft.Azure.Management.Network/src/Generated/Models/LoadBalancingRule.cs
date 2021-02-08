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
    using System.Linq;

    /// <summary>
    /// Rules of the load balancer
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LoadBalancingRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the LoadBalancingRule class.
        /// </summary>
        public LoadBalancingRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoadBalancingRule class.
        /// </summary>
        /// <param name="backendAddressPool">Gets or sets  a reference to a
        /// pool of DIPs. Inbound traffic is randomly load balanced across IPs
        /// in the backend IPs</param>
        /// <param name="protocol">Gets or sets the transport protocol for the
        /// external endpoint. Possible values are Udp or Tcp. Possible values
        /// include: 'Udp', 'Tcp'</param>
        /// <param name="frontendPort">Gets or sets the port for the external
        /// endpoint. You can specify any port number you choose, but the port
        /// numbers specified for each role in the service must be unique.
        /// Possible values range between 1 and 65535, inclusive</param>
        /// <param name="enableFloatingIP">Configures a virtual machine's
        /// endpoint for the floating IP capability required to configure a SQL
        /// AlwaysOn availability Group. This setting is required when using
        /// the SQL Always ON availability Groups in SQL server. This setting
        /// can't be changed after you create the endpoint</param>
        /// <param name="id">Resource Id</param>
        /// <param name="frontendIPConfiguration">Gets or sets a reference to
        /// frontend IP Addresses</param>
        /// <param name="probe">Gets or sets the reference of the load balancer
        /// probe used by the Load Balancing rule.</param>
        /// <param name="loadDistribution">Gets or sets the load distribution
        /// policy for this rule. Possible values include: 'Default',
        /// 'SourceIP', 'SourceIPProtocol'</param>
        /// <param name="backendPort">Gets or sets a port used for internal
        /// connections on the endpoint. The localPort attribute maps the
        /// eternal port of the endpoint to an internal port on a role. This is
        /// useful in scenarios where a role must communicate to an internal
        /// component on a port that is different from the one that is exposed
        /// externally. If not specified, the value of localPort is the same as
        /// the port attribute. Set the value of localPort to '*' to
        /// automatically assign an unallocated port that is discoverable using
        /// the runtime API</param>
        /// <param name="idleTimeoutInMinutes">Gets or sets the timeout for the
        /// Tcp idle connection. The value can be set between 4 and 30 minutes.
        /// The default value is 4 minutes. This element is only used when the
        /// protocol is set to Tcp</param>
        /// <param name="provisioningState">Gets or sets Provisioning state of
        /// the PublicIP resource Updating/Deleting/Failed</param>
        /// <param name="name">Gets name of the resource that is unique within
        /// a resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public LoadBalancingRule(SubResource backendAddressPool, string protocol, int frontendPort, bool enableFloatingIP, string id = default(string), SubResource frontendIPConfiguration = default(SubResource), SubResource probe = default(SubResource), string loadDistribution = default(string), int? backendPort = default(int?), int? idleTimeoutInMinutes = default(int?), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            FrontendIPConfiguration = frontendIPConfiguration;
            BackendAddressPool = backendAddressPool;
            Probe = probe;
            Protocol = protocol;
            LoadDistribution = loadDistribution;
            FrontendPort = frontendPort;
            BackendPort = backendPort;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            EnableFloatingIP = enableFloatingIP;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a reference to frontend IP Addresses
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfiguration")]
        public SubResource FrontendIPConfiguration { get; set; }

        /// <summary>
        /// Gets or sets  a reference to a pool of DIPs. Inbound traffic is
        /// randomly load balanced across IPs in the backend IPs
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets the reference of the load balancer probe used by the
        /// Load Balancing rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.probe")]
        public SubResource Probe { get; set; }

        /// <summary>
        /// Gets or sets the transport protocol for the external endpoint.
        /// Possible values are Udp or Tcp. Possible values include: 'Udp',
        /// 'Tcp'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the load distribution policy for this rule. Possible
        /// values include: 'Default', 'SourceIP', 'SourceIPProtocol'
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadDistribution")]
        public string LoadDistribution { get; set; }

        /// <summary>
        /// Gets or sets the port for the external endpoint. You can specify
        /// any port number you choose, but the port numbers specified for each
        /// role in the service must be unique. Possible values range between 1
        /// and 65535, inclusive
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendPort")]
        public int FrontendPort { get; set; }

        /// <summary>
        /// Gets or sets a port used for internal connections on the endpoint.
        /// The localPort attribute maps the eternal port of the endpoint to an
        /// internal port on a role. This is useful in scenarios where a role
        /// must communicate to an internal component on a port that is
        /// different from the one that is exposed externally. If not
        /// specified, the value of localPort is the same as the port
        /// attribute. Set the value of localPort to '*' to automatically
        /// assign an unallocated port that is discoverable using the runtime
        /// API
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendPort")]
        public int? BackendPort { get; set; }

        /// <summary>
        /// Gets or sets the timeout for the Tcp idle connection. The value can
        /// be set between 4 and 30 minutes. The default value is 4 minutes.
        /// This element is only used when the protocol is set to Tcp
        /// </summary>
        [JsonProperty(PropertyName = "properties.idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets or sets configures a virtual machine's endpoint for the
        /// floating IP capability required to configure a SQL AlwaysOn
        /// availability Group. This setting is required when using the SQL
        /// Always ON availability Groups in SQL server. This setting can't be
        /// changed after you create the endpoint
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableFloatingIP")]
        public bool EnableFloatingIP { get; set; }

        /// <summary>
        /// Gets or sets Provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BackendAddressPool == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BackendAddressPool");
            }
            if (Protocol == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Protocol");
            }
        }
    }
}
