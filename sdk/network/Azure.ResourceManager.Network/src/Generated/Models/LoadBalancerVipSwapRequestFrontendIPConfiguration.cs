// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VIP swap request&apos;s frontend IP configuration object. </summary>
    public partial class LoadBalancerVipSwapRequestFrontendIPConfiguration
    {
        /// <summary> Initializes a new instance of LoadBalancerVipSwapRequestFrontendIPConfiguration. </summary>
        public LoadBalancerVipSwapRequestFrontendIPConfiguration()
        {
        }

        /// <summary> The ID of frontend IP configuration resource. </summary>
        public string Id { get; set; }
        /// <summary> A reference to public IP address resource. </summary>
        internal WritableSubResource PublicIPAddress { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PublicIPAddressId
        {
            get => PublicIPAddress is null ? default : PublicIPAddress.Id;
            set
            {
                if (PublicIPAddress is null)
                    PublicIPAddress = new WritableSubResource();
                PublicIPAddress.Id = value;
            }
        }
    }
}
