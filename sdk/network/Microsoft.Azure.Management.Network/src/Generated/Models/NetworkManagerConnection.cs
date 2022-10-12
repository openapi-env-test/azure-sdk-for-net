// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Network Manager Connection resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetworkManagerConnection : ChildResource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkManagerConnection class.
        /// </summary>
        public NetworkManagerConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkManagerConnection class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="networkManagerId">Network Manager Id.</param>
        /// <param name="connectionState">Connection state. Possible values
        /// include: 'Connected', 'Pending', 'Conflict', 'Revoked',
        /// 'Rejected'</param>
        /// <param name="description">A description of the network manager
        /// connection.</param>
        /// <param name="systemData">The system metadata related to this
        /// resource.</param>
        public NetworkManagerConnection(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), string networkManagerId = default(string), string connectionState = default(string), string description = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type, etag)
        {
            NetworkManagerId = networkManagerId;
            ConnectionState = connectionState;
            Description = description;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets network Manager Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkManagerId")]
        public string NetworkManagerId { get; set; }

        /// <summary>
        /// Gets or sets connection state. Possible values include:
        /// 'Connected', 'Pending', 'Conflict', 'Revoked', 'Rejected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionState")]
        public string ConnectionState { get; set; }

        /// <summary>
        /// Gets or sets a description of the network manager connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the system metadata related to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
