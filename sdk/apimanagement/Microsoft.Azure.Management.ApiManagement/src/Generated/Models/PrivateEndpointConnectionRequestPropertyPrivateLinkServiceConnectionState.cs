// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The connection state of the private endpoint connection.
    /// </summary>
    public partial class PrivateEndpointConnectionRequestPropertyPrivateLinkServiceConnectionState
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionRequestPropertyPrivateLinkServiceConnectionState
        /// class.
        /// </summary>
        public PrivateEndpointConnectionRequestPropertyPrivateLinkServiceConnectionState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionRequestPropertyPrivateLinkServiceConnectionState
        /// class.
        /// </summary>
        /// <param name="status">Status of a private endpoint
        /// connection.</param>
        /// <param name="description">The description of this private endpoint
        /// connection request.</param>
        public PrivateEndpointConnectionRequestPropertyPrivateLinkServiceConnectionState(string status = default(string), string description = default(string))
        {
            Status = status;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status of a private endpoint connection.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the description of this private endpoint connection
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
