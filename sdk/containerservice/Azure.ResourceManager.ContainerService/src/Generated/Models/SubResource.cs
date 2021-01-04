// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Reference to another subresource. </summary>
    public partial class SubResource
    {
        /// <summary> Initializes a new instance of SubResource. </summary>
        public SubResource()
        {
        }

        /// <summary> Initializes a new instance of SubResource. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="type"> Resource type. </param>
        internal SubResource(string id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        /// <summary> Resource ID. </summary>
        public string Id { get; }
        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
    }
}
