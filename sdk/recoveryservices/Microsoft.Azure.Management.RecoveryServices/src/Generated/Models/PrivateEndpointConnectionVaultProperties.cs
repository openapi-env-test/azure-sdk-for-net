// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information to be stored in Vault properties as an element of
    /// privateEndpointConnections List.
    /// </summary>
    public partial class PrivateEndpointConnectionVaultProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionVaultProperties class.
        /// </summary>
        public PrivateEndpointConnectionVaultProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PrivateEndpointConnectionVaultProperties class.
        /// </summary>
        /// <param name="id">Format of id
        /// subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.[Service]/{resource}/{resourceName}/privateEndpointConnections/{connectionName}.</param>
        public PrivateEndpointConnectionVaultProperties(string id = default(string), PrivateEndpointConnection properties = default(PrivateEndpointConnection))
        {
            Id = id;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets format of id
        /// subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.[Service]/{resource}/{resourceName}/privateEndpointConnections/{connectionName}.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public PrivateEndpointConnection Properties { get; set; }

    }
}
