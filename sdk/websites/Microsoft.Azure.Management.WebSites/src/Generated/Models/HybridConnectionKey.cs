// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Hybrid Connection key contract. This has the send key name and value
    /// for a Hybrid Connection.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class HybridConnectionKey : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the HybridConnectionKey class.
        /// </summary>
        public HybridConnectionKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HybridConnectionKey class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        /// <param name="sendKeyName">The name of the send key.</param>
        /// <param name="sendKeyValue">The value of the send key.</param>
        public HybridConnectionKey(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), SystemData systemData = default(SystemData), string sendKeyName = default(string), string sendKeyValue = default(string))
            : base(id, name, kind, type, systemData)
        {
            SendKeyName = sendKeyName;
            SendKeyValue = sendKeyValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the send key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sendKeyName")]
        public string SendKeyName { get; private set; }

        /// <summary>
        /// Gets the value of the send key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sendKeyValue")]
        public string SendKeyValue { get; private set; }

    }
}
