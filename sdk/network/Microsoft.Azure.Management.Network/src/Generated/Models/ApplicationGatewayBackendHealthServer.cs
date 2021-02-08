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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Application gateway backendhealth http settings.
    /// </summary>
    public partial class ApplicationGatewayBackendHealthServer
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthServer class.
        /// </summary>
        public ApplicationGatewayBackendHealthServer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthServer class.
        /// </summary>
        /// <param name="address">IP address or FQDN of backend server.</param>
        /// <param name="ipConfiguration">Reference of IP configuration of
        /// backend server.</param>
        /// <param name="health">Health of backend server. Possible values
        /// include: 'Unknown', 'Up', 'Down', 'Partial', 'Draining'</param>
        public ApplicationGatewayBackendHealthServer(string address = default(string), SubResource ipConfiguration = default(SubResource), string health = default(string))
        {
            Address = address;
            IpConfiguration = ipConfiguration;
            Health = health;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets IP address or FQDN of backend server.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets reference of IP configuration of backend server.
        /// </summary>
        [JsonProperty(PropertyName = "ipConfiguration")]
        public SubResource IpConfiguration { get; set; }

        /// <summary>
        /// Gets or sets health of backend server. Possible values include:
        /// 'Unknown', 'Up', 'Down', 'Partial', 'Draining'
        /// </summary>
        [JsonProperty(PropertyName = "health")]
        public string Health { get; set; }

    }
}
