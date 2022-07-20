// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Iothub.Models
{
    /// <summary> Public representation of one of the locations where a resource is provisioned. </summary>
    public partial class IotHubLocationDescription
    {
        /// <summary> Initializes a new instance of IotHubLocationDescription. </summary>
        internal IotHubLocationDescription()
        {
        }

        /// <summary> Initializes a new instance of IotHubLocationDescription. </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="role"> The role of the region, can be either primary or secondary. The primary region is where the IoT hub is currently provisioned. The secondary region is the Azure disaster recovery (DR) paired region and also the region where the IoT hub can failover to. </param>
        internal IotHubLocationDescription(AzureLocation? location, IotHubReplicaRoleType? role)
        {
            Location = location;
            Role = role;
        }

        /// <summary> The name of the Azure region. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The role of the region, can be either primary or secondary. The primary region is where the IoT hub is currently provisioned. The secondary region is the Azure disaster recovery (DR) paired region and also the region where the IoT hub can failover to. </summary>
        public IotHubReplicaRoleType? Role { get; }
    }
}
