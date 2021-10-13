// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update Cosmos DB Graph resource. </summary>
    public partial class GraphResourceCreateUpdateParameters : ARMResourceProperties
    {
        /// <summary> Initializes a new instance of GraphResourceCreateUpdateParameters. </summary>
        /// <param name="resource"> The standard JSON format of a Graph resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resource"/> is null. </exception>
        public GraphResourceCreateUpdateParameters(GraphResource resource)
        {
            if (resource == null)
            {
                throw new ArgumentNullException(nameof(resource));
            }

            Resource = resource;
        }

        /// <summary> Initializes a new instance of GraphResourceCreateUpdateParameters. </summary>
        /// <param name="id"> The unique resource identifier of the ARM resource. </param>
        /// <param name="name"> The name of the ARM resource. </param>
        /// <param name="type"> The type of Azure resource. </param>
        /// <param name="location"> The location of the resource group to which the resource belongs. </param>
        /// <param name="tags"> Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with &quot;defaultExperience&quot;: &quot;Cassandra&quot;. Current &quot;defaultExperience&quot; values also include &quot;Table&quot;, &quot;Graph&quot;, &quot;DocumentDB&quot;, and &quot;MongoDB&quot;. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="resource"> The standard JSON format of a Graph resource. </param>
        /// <param name="options"> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </param>
        internal GraphResourceCreateUpdateParameters(string id, string name, string type, string location, IDictionary<string, string> tags, ManagedServiceIdentity identity, GraphResource resource, CreateUpdateOptions options) : base(id, name, type, location, tags, identity)
        {
            Resource = resource;
            Options = options;
        }

        /// <summary> The standard JSON format of a Graph resource. </summary>
        public GraphResource Resource { get; set; }
        /// <summary> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </summary>
        public CreateUpdateOptions Options { get; set; }
    }
}
