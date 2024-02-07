// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the TagProductLinkContract data model.
    /// Tag-product link details.
    /// </summary>
    public partial class TagProductLinkContractData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="TagProductLinkContractData"/>. </summary>
        public TagProductLinkContractData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TagProductLinkContractData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="productId"> Full resource Id of a product. </param>
        internal TagProductLinkContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string productId) : base(id, name, resourceType, systemData)
        {
            ProductId = productId;
        }

        /// <summary> Full resource Id of a product. </summary>
        public string ProductId { get; set; }
    }
}
