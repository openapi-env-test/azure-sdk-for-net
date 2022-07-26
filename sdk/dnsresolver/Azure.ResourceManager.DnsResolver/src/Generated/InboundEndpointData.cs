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

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary> A class representing the InboundEndpoint data model. </summary>
    public partial class InboundEndpointData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of InboundEndpointData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="ipConfigurations"> IP configurations for the inbound endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipConfigurations"/> is null. </exception>
        public InboundEndpointData(AzureLocation location, IEnumerable<IPConfiguration> ipConfigurations) : base(location)
        {
            if (ipConfigurations == null)
            {
                throw new ArgumentNullException(nameof(ipConfigurations));
            }

            IPConfigurations = ipConfigurations.ToList();
        }

        /// <summary> Initializes a new instance of InboundEndpointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="eTag"> ETag of the inbound endpoint. </param>
        /// <param name="ipConfigurations"> IP configurations for the inbound endpoint. </param>
        /// <param name="provisioningState"> The current provisioning state of the inbound endpoint. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="resourceGuid"> The resourceGuid property of the inbound endpoint resource. </param>
        internal InboundEndpointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? eTag, IList<IPConfiguration> ipConfigurations, ProvisioningState? provisioningState, string resourceGuid) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = eTag;
            IPConfigurations = ipConfigurations;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
        }

        /// <summary> ETag of the inbound endpoint. </summary>
        public ETag? ETag { get; }
        /// <summary> IP configurations for the inbound endpoint. </summary>
        public IList<IPConfiguration> IPConfigurations { get; }
        /// <summary> The current provisioning state of the inbound endpoint. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The resourceGuid property of the inbound endpoint resource. </summary>
        public string ResourceGuid { get; }
    }
}
