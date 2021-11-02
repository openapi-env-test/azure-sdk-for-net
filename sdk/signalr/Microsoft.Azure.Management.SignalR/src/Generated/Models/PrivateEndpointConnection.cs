// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A private endpoint connection to an azure resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateEndpointConnection : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateEndpointConnection class.
        /// </summary>
        public PrivateEndpointConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateEndpointConnection class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource - e.g.
        /// "Microsoft.SignalRService/SignalR"</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        /// <param name="provisioningState">Provisioning state of the private
        /// endpoint connection. Possible values include: 'Unknown',
        /// 'Succeeded', 'Failed', 'Canceled', 'Running', 'Creating',
        /// 'Updating', 'Deleting', 'Moving'</param>
        /// <param name="privateEndpoint">Private endpoint associated with the
        /// private endpoint connection</param>
        /// <param name="groupIds">Group IDs</param>
        /// <param name="privateLinkServiceConnectionState">Connection
        /// state</param>
        public PrivateEndpointConnection(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string provisioningState = default(string), PrivateEndpoint privateEndpoint = default(PrivateEndpoint), IList<string> groupIds = default(IList<string>), PrivateLinkServiceConnectionState privateLinkServiceConnectionState = default(PrivateLinkServiceConnectionState))
            : base(id, name, type)
        {
            SystemData = systemData;
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            GroupIds = groupIds;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets metadata pertaining to creation and last modification of the
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets provisioning state of the private endpoint connection.
        /// Possible values include: 'Unknown', 'Succeeded', 'Failed',
        /// 'Canceled', 'Running', 'Creating', 'Updating', 'Deleting', 'Moving'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets private endpoint associated with the private endpoint
        /// connection
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpoint")]
        public PrivateEndpoint PrivateEndpoint { get; set; }

        /// <summary>
        /// Gets group IDs
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupIds")]
        public IList<string> GroupIds { get; private set; }

        /// <summary>
        /// Gets or sets connection state
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkServiceConnectionState")]
        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }

    }
}
