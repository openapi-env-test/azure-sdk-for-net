// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB location get result. </summary>
    public partial class LocationGetResult : ARMProxyResource
    {
        /// <summary> Initializes a new instance of LocationGetResult. </summary>
        public LocationGetResult()
        {
        }

        /// <summary> Initializes a new instance of LocationGetResult. </summary>
        /// <param name="id"> The unique resource identifier of the database account. </param>
        /// <param name="name"> The name of the database account. </param>
        /// <param name="type"> The type of Azure resource. </param>
        /// <param name="properties"> Cosmos DB location metadata. </param>
        internal LocationGetResult(string id, string name, string type, LocationProperties properties) : base(id, name, type)
        {
            Properties = properties;
        }

        /// <summary> Cosmos DB location metadata. </summary>
        public LocationProperties Properties { get; set; }
    }
}
