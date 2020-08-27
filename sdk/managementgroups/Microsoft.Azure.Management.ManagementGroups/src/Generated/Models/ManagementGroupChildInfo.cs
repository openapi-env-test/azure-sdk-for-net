// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagementGroups.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The child information of a management group.
    /// </summary>
    public partial class ManagementGroupChildInfo
    {
        /// <summary>
        /// Initializes a new instance of the ManagementGroupChildInfo class.
        /// </summary>
        public ManagementGroupChildInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementGroupChildInfo class.
        /// </summary>
        /// <param name="type">The type of child resource.</param>
        /// <param name="id">The fully qualified ID for the child resource
        /// (management group or subscription).  For example,
        /// /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000</param>
        /// <param name="name">The name of the child entity.</param>
        /// <param name="displayName">The friendly name of the child
        /// resource.</param>
        /// <param name="children">The list of children.</param>
        public ManagementGroupChildInfo(string type = default(string), string id = default(string), string name = default(string), string displayName = default(string), IList<ManagementGroupChildInfo> children = default(IList<ManagementGroupChildInfo>))
        {
            Type = type;
            Id = id;
            Name = name;
            DisplayName = displayName;
            Children = children;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of child resource.
        /// </summary>
        /// <remarks>
        /// The fully qualified resource type which includes provider namespace
        /// (e.g. Microsoft.Management/managementGroups). Possible values
        /// include: 'Microsoft.Management/managementGroups', '/subscriptions'
        /// </remarks>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the fully qualified ID for the child resource
        /// (management group or subscription).  For example,
        /// /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the child entity.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the friendly name of the child resource.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the list of children.
        /// </summary>
        [JsonProperty(PropertyName = "children")]
        public IList<ManagementGroupChildInfo> Children { get; set; }

    }
}
