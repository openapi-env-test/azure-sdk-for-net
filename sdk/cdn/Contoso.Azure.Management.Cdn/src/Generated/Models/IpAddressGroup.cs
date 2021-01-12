// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Contoso.Azure.Management.Cdn.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// CDN Ip address group
    /// </summary>
    public partial class IpAddressGroup
    {
        /// <summary>
        /// Initializes a new instance of the IpAddressGroup class.
        /// </summary>
        public IpAddressGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IpAddressGroup class.
        /// </summary>
        /// <param name="deliveryRegion">The delivery region of the ip address
        /// group</param>
        /// <param name="ipv4Addresses">The list of ip v4 addresses.</param>
        /// <param name="ipv6Addresses">The list of ip v6 addresses.</param>
        public IpAddressGroup(string deliveryRegion = default(string), IList<CidrIpAddress> ipv4Addresses = default(IList<CidrIpAddress>), IList<CidrIpAddress> ipv6Addresses = default(IList<CidrIpAddress>))
        {
            DeliveryRegion = deliveryRegion;
            Ipv4Addresses = ipv4Addresses;
            Ipv6Addresses = ipv6Addresses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the delivery region of the ip address group
        /// </summary>
        [JsonProperty(PropertyName = "deliveryRegion")]
        public string DeliveryRegion { get; set; }

        /// <summary>
        /// Gets or sets the list of ip v4 addresses.
        /// </summary>
        [JsonProperty(PropertyName = "ipv4Addresses")]
        public IList<CidrIpAddress> Ipv4Addresses { get; set; }

        /// <summary>
        /// Gets or sets the list of ip v6 addresses.
        /// </summary>
        [JsonProperty(PropertyName = "ipv6Addresses")]
        public IList<CidrIpAddress> Ipv6Addresses { get; set; }

    }
}
