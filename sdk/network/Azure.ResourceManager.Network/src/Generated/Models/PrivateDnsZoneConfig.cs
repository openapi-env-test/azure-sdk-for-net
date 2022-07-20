// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> PrivateDnsZoneConfig resource. </summary>
    public partial class PrivateDnsZoneConfig
    {
        /// <summary> Initializes a new instance of PrivateDnsZoneConfig. </summary>
        public PrivateDnsZoneConfig()
        {
            RecordSets = new ChangeTrackingList<RecordSet>();
        }

        /// <summary> Initializes a new instance of PrivateDnsZoneConfig. </summary>
        /// <param name="name"> Name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="id"> The id of the privateDnsZoneConfig. </param>
        /// <param name="resourceType"> Type of resource. Will be specified as private dns zone configurations. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="privateDnsZoneId"> The resource id of the private dns zone. </param>
        /// <param name="provisioningState"> The provisioning state of the private dns zone group resource. </param>
        /// <param name="recordSets"> A collection of information regarding a recordSet, holding information to identify private resources. </param>
        internal PrivateDnsZoneConfig(string name, string id, string resourceType, ETag? etag, string privateDnsZoneId, NetworkProvisioningState? provisioningState, IReadOnlyList<RecordSet> recordSets)
        {
            Name = name;
            Id = id;
            ResourceType = resourceType;
            Etag = etag;
            PrivateDnsZoneId = privateDnsZoneId;
            ProvisioningState = provisioningState;
            RecordSets = recordSets;
        }

        /// <summary> Name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> The id of the privateDnsZoneConfig. </summary>
        public string Id { get; }
        /// <summary> Type of resource. Will be specified as private dns zone configurations. </summary>
        public string ResourceType { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? Etag { get; }
        /// <summary> The resource id of the private dns zone. </summary>
        public string PrivateDnsZoneId { get; set; }
        /// <summary> The provisioning state of the private dns zone group resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> A collection of information regarding a recordSet, holding information to identify private resources. </summary>
        public IReadOnlyList<RecordSet> RecordSets { get; }
    }
}
