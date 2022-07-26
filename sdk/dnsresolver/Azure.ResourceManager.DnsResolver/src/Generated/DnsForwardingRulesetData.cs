// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DnsResolver.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary> A class representing the DnsForwardingRuleset data model. </summary>
    public partial class DnsForwardingRulesetData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DnsForwardingRulesetData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="dnsResolverOutboundEndpoints"> The reference to the DNS resolver outbound endpoints that are used to route DNS queries matching the forwarding rules in the ruleset to the target DNS servers. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsResolverOutboundEndpoints"/> is null. </exception>
        public DnsForwardingRulesetData(AzureLocation location, IEnumerable<WritableSubResource> dnsResolverOutboundEndpoints) : base(location)
        {
            if (dnsResolverOutboundEndpoints == null)
            {
                throw new ArgumentNullException(nameof(dnsResolverOutboundEndpoints));
            }

            DnsResolverOutboundEndpoints = dnsResolverOutboundEndpoints.ToList();
        }

        /// <summary> Initializes a new instance of DnsForwardingRulesetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="eTag"> ETag of the DNS forwarding ruleset. </param>
        /// <param name="dnsResolverOutboundEndpoints"> The reference to the DNS resolver outbound endpoints that are used to route DNS queries matching the forwarding rules in the ruleset to the target DNS servers. </param>
        /// <param name="provisioningState"> The current provisioning state of the DNS forwarding ruleset. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="resourceGuid"> The resourceGuid for the DNS forwarding ruleset. </param>
        internal DnsForwardingRulesetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? eTag, IList<WritableSubResource> dnsResolverOutboundEndpoints, ProvisioningState? provisioningState, string resourceGuid) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = eTag;
            DnsResolverOutboundEndpoints = dnsResolverOutboundEndpoints;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
        }

        /// <summary> ETag of the DNS forwarding ruleset. </summary>
        public ETag? ETag { get; }
        /// <summary> The reference to the DNS resolver outbound endpoints that are used to route DNS queries matching the forwarding rules in the ruleset to the target DNS servers. </summary>
        public IList<WritableSubResource> DnsResolverOutboundEndpoints { get; }
        /// <summary> The current provisioning state of the DNS forwarding ruleset. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The resourceGuid for the DNS forwarding ruleset. </summary>
        public string ResourceGuid { get; }
    }
}
