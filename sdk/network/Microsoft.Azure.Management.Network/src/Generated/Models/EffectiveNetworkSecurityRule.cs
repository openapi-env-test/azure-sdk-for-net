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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Effective network security rules.
    /// </summary>
    public partial class EffectiveNetworkSecurityRule
    {
        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityRule
        /// class.
        /// </summary>
        public EffectiveNetworkSecurityRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityRule
        /// class.
        /// </summary>
        /// <param name="name">The name of the security rule specified by the
        /// user (if created by the user).</param>
        /// <param name="protocol">The network protocol this rule applies to.
        /// Possible values are: 'Tcp', 'Udp', and '*'. Possible values
        /// include: 'Tcp', 'Udp', '*'</param>
        /// <param name="sourcePortRange">The source port or range.</param>
        /// <param name="destinationPortRange">The destination port or
        /// range.</param>
        /// <param name="sourceAddressPrefix">The source address
        /// prefix.</param>
        /// <param name="destinationAddressPrefix">The destination address
        /// prefix.</param>
        /// <param name="expandedSourceAddressPrefix">The expanded source
        /// address prefix.</param>
        /// <param name="expandedDestinationAddressPrefix">Expanded destination
        /// address prefix.</param>
        /// <param name="access">Whether network traffic is allowed or denied.
        /// Possible values are: 'Allow' and 'Deny'. Possible values include:
        /// 'Allow', 'Deny'</param>
        /// <param name="priority">The priority of the rule.</param>
        /// <param name="direction">The direction of the rule. Possible values
        /// are: 'Inbound and Outbound'. Possible values include: 'Inbound',
        /// 'Outbound'</param>
        public EffectiveNetworkSecurityRule(string name = default(string), string protocol = default(string), string sourcePortRange = default(string), string destinationPortRange = default(string), string sourceAddressPrefix = default(string), string destinationAddressPrefix = default(string), IList<string> expandedSourceAddressPrefix = default(IList<string>), IList<string> expandedDestinationAddressPrefix = default(IList<string>), string access = default(string), int? priority = default(int?), string direction = default(string))
        {
            Name = name;
            Protocol = protocol;
            SourcePortRange = sourcePortRange;
            DestinationPortRange = destinationPortRange;
            SourceAddressPrefix = sourceAddressPrefix;
            DestinationAddressPrefix = destinationAddressPrefix;
            ExpandedSourceAddressPrefix = expandedSourceAddressPrefix;
            ExpandedDestinationAddressPrefix = expandedDestinationAddressPrefix;
            Access = access;
            Priority = priority;
            Direction = direction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the security rule specified by the user
        /// (if created by the user).
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the network protocol this rule applies to. Possible
        /// values are: 'Tcp', 'Udp', and '*'. Possible values include: 'Tcp',
        /// 'Udp', '*'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the source port or range.
        /// </summary>
        [JsonProperty(PropertyName = "sourcePortRange")]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// Gets or sets the destination port or range.
        /// </summary>
        [JsonProperty(PropertyName = "destinationPortRange")]
        public string DestinationPortRange { get; set; }

        /// <summary>
        /// Gets or sets the source address prefix.
        /// </summary>
        [JsonProperty(PropertyName = "sourceAddressPrefix")]
        public string SourceAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the destination address prefix.
        /// </summary>
        [JsonProperty(PropertyName = "destinationAddressPrefix")]
        public string DestinationAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the expanded source address prefix.
        /// </summary>
        [JsonProperty(PropertyName = "expandedSourceAddressPrefix")]
        public IList<string> ExpandedSourceAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets expanded destination address prefix.
        /// </summary>
        [JsonProperty(PropertyName = "expandedDestinationAddressPrefix")]
        public IList<string> ExpandedDestinationAddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets whether network traffic is allowed or denied. Possible
        /// values are: 'Allow' and 'Deny'. Possible values include: 'Allow',
        /// 'Deny'
        /// </summary>
        [JsonProperty(PropertyName = "access")]
        public string Access { get; set; }

        /// <summary>
        /// Gets or sets the priority of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the direction of the rule. Possible values are:
        /// 'Inbound and Outbound'. Possible values include: 'Inbound',
        /// 'Outbound'
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public string Direction { get; set; }

    }
}
