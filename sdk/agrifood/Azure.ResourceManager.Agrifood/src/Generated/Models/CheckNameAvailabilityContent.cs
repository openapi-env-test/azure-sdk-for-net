// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Agrifood.Models
{
    /// <summary> The check availability request body. </summary>
    public partial class CheckNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of CheckNameAvailabilityContent. </summary>
        public CheckNameAvailabilityContent()
        {
        }

        /// <summary> The name of the resource for which availability needs to be checked. </summary>
        public string Name { get; set; }
        /// <summary> The resource type. </summary>
        public string ResourceType { get; set; }
    }
}
