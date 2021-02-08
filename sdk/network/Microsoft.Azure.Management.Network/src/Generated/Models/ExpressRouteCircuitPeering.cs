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
    /// Peering in an ExpressRouteCircuit resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteCircuitPeering : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitPeering class.
        /// </summary>
        public ExpressRouteCircuitPeering()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitPeering class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="peeringType">The peering type. Possible values
        /// include: 'AzurePublicPeering', 'AzurePrivatePeering',
        /// 'MicrosoftPeering'</param>
        /// <param name="state">The peering state. Possible values include:
        /// 'Disabled', 'Enabled'</param>
        /// <param name="azureASN">The Azure ASN.</param>
        /// <param name="peerASN">The peer ASN.</param>
        /// <param name="primaryPeerAddressPrefix">The primary address
        /// prefix.</param>
        /// <param name="secondaryPeerAddressPrefix">The secondary address
        /// prefix.</param>
        /// <param name="primaryAzurePort">The primary port.</param>
        /// <param name="secondaryAzurePort">The secondary port.</param>
        /// <param name="sharedKey">The shared key.</param>
        /// <param name="vlanId">The VLAN ID.</param>
        /// <param name="microsoftPeeringConfig">The Microsoft peering
        /// configuration.</param>
        /// <param name="stats">The peering stats of express route
        /// circuit.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// express route circuit peering resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="gatewayManagerEtag">The GatewayManager Etag.</param>
        /// <param name="lastModifiedBy">Who was the last to modify the
        /// peering.</param>
        /// <param name="routeFilter">The reference of the RouteFilter
        /// resource.</param>
        /// <param name="ipv6PeeringConfig">The IPv6 peering
        /// configuration.</param>
        /// <param name="expressRouteConnection">The ExpressRoute
        /// connection.</param>
        /// <param name="connections">The list of circuit connections
        /// associated with Azure Private Peering for this circuit.</param>
        /// <param name="peeredConnections">The list of peered circuit
        /// connections associated with Azure Private Peering for this
        /// circuit.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ExpressRouteCircuitPeering(string id = default(string), string peeringType = default(string), string state = default(string), int? azureASN = default(int?), long? peerASN = default(long?), string primaryPeerAddressPrefix = default(string), string secondaryPeerAddressPrefix = default(string), string primaryAzurePort = default(string), string secondaryAzurePort = default(string), string sharedKey = default(string), int? vlanId = default(int?), ExpressRouteCircuitPeeringConfig microsoftPeeringConfig = default(ExpressRouteCircuitPeeringConfig), ExpressRouteCircuitStats stats = default(ExpressRouteCircuitStats), string provisioningState = default(string), string gatewayManagerEtag = default(string), string lastModifiedBy = default(string), SubResource routeFilter = default(SubResource), Ipv6ExpressRouteCircuitPeeringConfig ipv6PeeringConfig = default(Ipv6ExpressRouteCircuitPeeringConfig), ExpressRouteConnectionId expressRouteConnection = default(ExpressRouteConnectionId), IList<ExpressRouteCircuitConnection> connections = default(IList<ExpressRouteCircuitConnection>), IList<PeerExpressRouteCircuitConnection> peeredConnections = default(IList<PeerExpressRouteCircuitConnection>), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            PeeringType = peeringType;
            State = state;
            AzureASN = azureASN;
            PeerASN = peerASN;
            PrimaryPeerAddressPrefix = primaryPeerAddressPrefix;
            SecondaryPeerAddressPrefix = secondaryPeerAddressPrefix;
            PrimaryAzurePort = primaryAzurePort;
            SecondaryAzurePort = secondaryAzurePort;
            SharedKey = sharedKey;
            VlanId = vlanId;
            MicrosoftPeeringConfig = microsoftPeeringConfig;
            Stats = stats;
            ProvisioningState = provisioningState;
            GatewayManagerEtag = gatewayManagerEtag;
            LastModifiedBy = lastModifiedBy;
            RouteFilter = routeFilter;
            Ipv6PeeringConfig = ipv6PeeringConfig;
            ExpressRouteConnection = expressRouteConnection;
            Connections = connections;
            PeeredConnections = peeredConnections;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the peering type. Possible values include:
        /// 'AzurePublicPeering', 'AzurePrivatePeering', 'MicrosoftPeering'
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringType")]
        public string PeeringType { get; set; }

        /// <summary>
        /// Gets or sets the peering state. Possible values include:
        /// 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the Azure ASN.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureASN")]
        public int? AzureASN { get; set; }

        /// <summary>
        /// Gets or sets the peer ASN.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerASN")]
        public long? PeerASN { get; set; }

        /// <summary>
        /// Gets or sets the primary address prefix.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryPeerAddressPrefix")]
        public string PrimaryPeerAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the secondary address prefix.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryPeerAddressPrefix")]
        public string SecondaryPeerAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the primary port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryAzurePort")]
        public string PrimaryAzurePort { get; set; }

        /// <summary>
        /// Gets or sets the secondary port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryAzurePort")]
        public string SecondaryAzurePort { get; set; }

        /// <summary>
        /// Gets or sets the shared key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// Gets or sets the VLAN ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vlanId")]
        public int? VlanId { get; set; }

        /// <summary>
        /// Gets or sets the Microsoft peering configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.microsoftPeeringConfig")]
        public ExpressRouteCircuitPeeringConfig MicrosoftPeeringConfig { get; set; }

        /// <summary>
        /// Gets or sets the peering stats of express route circuit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.stats")]
        public ExpressRouteCircuitStats Stats { get; set; }

        /// <summary>
        /// Gets the provisioning state of the express route circuit peering
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the GatewayManager Etag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayManagerEtag")]
        public string GatewayManagerEtag { get; set; }

        /// <summary>
        /// Gets who was the last to modify the peering.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedBy")]
        public string LastModifiedBy { get; private set; }

        /// <summary>
        /// Gets or sets the reference of the RouteFilter resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routeFilter")]
        public SubResource RouteFilter { get; set; }

        /// <summary>
        /// Gets or sets the IPv6 peering configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipv6PeeringConfig")]
        public Ipv6ExpressRouteCircuitPeeringConfig Ipv6PeeringConfig { get; set; }

        /// <summary>
        /// Gets or sets the ExpressRoute connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expressRouteConnection")]
        public ExpressRouteConnectionId ExpressRouteConnection { get; set; }

        /// <summary>
        /// Gets or sets the list of circuit connections associated with Azure
        /// Private Peering for this circuit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connections")]
        public IList<ExpressRouteCircuitConnection> Connections { get; set; }

        /// <summary>
        /// Gets the list of peered circuit connections associated with Azure
        /// Private Peering for this circuit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeredConnections")]
        public IList<PeerExpressRouteCircuitConnection> PeeredConnections { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PeerASN > 4294967295)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "PeerASN", 4294967295);
            }
            if (PeerASN < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "PeerASN", 1);
            }
        }
    }
}
