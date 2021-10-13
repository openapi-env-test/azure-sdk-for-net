// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Properties for the database account. </summary>
    public partial class ServiceResource : ARMProxyResource
    {
        /// <summary> Initializes a new instance of ServiceResource. </summary>
        public ServiceResource()
        {
        }

        /// <summary> Initializes a new instance of ServiceResource. </summary>
        /// <param name="id"> The unique resource identifier of the database account. </param>
        /// <param name="name"> The name of the database account. </param>
        /// <param name="type"> The type of Azure resource. </param>
        /// <param name="properties"> Services response resource. </param>
        internal ServiceResource(string id, string name, string type, ServiceResourceProperties properties) : base(id, name, type)
        {
            Properties = properties;
        }

        /// <summary> Services response resource. </summary>
        public ServiceResourceProperties Properties { get; set; }
    }
}
