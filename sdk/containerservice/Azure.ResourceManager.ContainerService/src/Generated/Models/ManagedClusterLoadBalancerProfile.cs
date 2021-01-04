// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Profile of the managed cluster load balancer. </summary>
    public partial class ManagedClusterLoadBalancerProfile
    {
        /// <summary> Initializes a new instance of ManagedClusterLoadBalancerProfile. </summary>
        public ManagedClusterLoadBalancerProfile()
        {
            EffectiveOutboundIPs = new ChangeTrackingList<ResourceReference>();
        }

        /// <summary> Initializes a new instance of ManagedClusterLoadBalancerProfile. </summary>
        /// <param name="managedOutboundIPs"> Desired managed outbound IPs for the cluster load balancer. </param>
        /// <param name="outboundIPPrefixes"> Desired outbound IP Prefix resources for the cluster load balancer. </param>
        /// <param name="outboundIPs"> Desired outbound IP resources for the cluster load balancer. </param>
        /// <param name="effectiveOutboundIPs"> The effective outbound IP resources of the cluster load balancer. </param>
        /// <param name="allocatedOutboundPorts"> Desired number of allocated SNAT ports per VM. Allowed values must be in the range of 0 to 64000 (inclusive). The default value is 0 which results in Azure dynamically allocating ports. </param>
        /// <param name="idleTimeoutInMinutes"> Desired outbound flow idle timeout in minutes. Allowed values must be in the range of 4 to 120 (inclusive). The default value is 30 minutes. </param>
        internal ManagedClusterLoadBalancerProfile(ManagedClusterLoadBalancerProfileManagedOutboundIPs managedOutboundIPs, ManagedClusterLoadBalancerProfileOutboundIPPrefixes outboundIPPrefixes, ManagedClusterLoadBalancerProfileOutboundIPs outboundIPs, IList<ResourceReference> effectiveOutboundIPs, int? allocatedOutboundPorts, int? idleTimeoutInMinutes)
        {
            ManagedOutboundIPs = managedOutboundIPs;
            OutboundIPPrefixes = outboundIPPrefixes;
            OutboundIPs = outboundIPs;
            EffectiveOutboundIPs = effectiveOutboundIPs;
            AllocatedOutboundPorts = allocatedOutboundPorts;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
        }

        /// <summary> Desired managed outbound IPs for the cluster load balancer. </summary>
        public ManagedClusterLoadBalancerProfileManagedOutboundIPs ManagedOutboundIPs { get; set; }
        /// <summary> Desired outbound IP Prefix resources for the cluster load balancer. </summary>
        public ManagedClusterLoadBalancerProfileOutboundIPPrefixes OutboundIPPrefixes { get; set; }
        /// <summary> Desired outbound IP resources for the cluster load balancer. </summary>
        public ManagedClusterLoadBalancerProfileOutboundIPs OutboundIPs { get; set; }
        /// <summary> The effective outbound IP resources of the cluster load balancer. </summary>
        public IList<ResourceReference> EffectiveOutboundIPs { get; }
        /// <summary> Desired number of allocated SNAT ports per VM. Allowed values must be in the range of 0 to 64000 (inclusive). The default value is 0 which results in Azure dynamically allocating ports. </summary>
        public int? AllocatedOutboundPorts { get; set; }
        /// <summary> Desired outbound flow idle timeout in minutes. Allowed values must be in the range of 4 to 120 (inclusive). The default value is 30 minutes. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
    }
}
