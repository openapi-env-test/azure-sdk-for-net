// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class representing a data connection.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DataConnection")]
    public partial class DataConnection : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the DataConnection class.
        /// </summary>
        public DataConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataConnection class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="location">Resource location.</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        public DataConnection(string id = default(string), string name = default(string), string type = default(string), string location = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            Location = location;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets azure Resource Manager metadata containing createdBy and
        /// modifiedBy information.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
