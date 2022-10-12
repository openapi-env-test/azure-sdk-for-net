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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Scope of Network Manager.
    /// </summary>
    public partial class NetworkManagerPropertiesNetworkManagerScopes
    {
        /// <summary>
        /// Initializes a new instance of the
        /// NetworkManagerPropertiesNetworkManagerScopes class.
        /// </summary>
        public NetworkManagerPropertiesNetworkManagerScopes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// NetworkManagerPropertiesNetworkManagerScopes class.
        /// </summary>
        /// <param name="managementGroups">List of management groups.</param>
        /// <param name="subscriptions">List of subscriptions.</param>
        /// <param name="crossTenantScopes">List of cross tenant
        /// scopes.</param>
        public NetworkManagerPropertiesNetworkManagerScopes(IList<string> managementGroups = default(IList<string>), IList<string> subscriptions = default(IList<string>), IList<CrossTenantScopes> crossTenantScopes = default(IList<CrossTenantScopes>))
        {
            ManagementGroups = managementGroups;
            Subscriptions = subscriptions;
            CrossTenantScopes = crossTenantScopes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of management groups.
        /// </summary>
        [JsonProperty(PropertyName = "managementGroups")]
        public IList<string> ManagementGroups { get; set; }

        /// <summary>
        /// Gets or sets list of subscriptions.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptions")]
        public IList<string> Subscriptions { get; set; }

        /// <summary>
        /// Gets list of cross tenant scopes.
        /// </summary>
        [JsonProperty(PropertyName = "crossTenantScopes")]
        public IList<CrossTenantScopes> CrossTenantScopes { get; private set; }

    }
}
