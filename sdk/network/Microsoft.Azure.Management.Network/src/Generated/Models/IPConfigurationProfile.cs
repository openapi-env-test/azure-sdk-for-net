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
    /// IP configuration profile child resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IPConfigurationProfile : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the IPConfigurationProfile class.
        /// </summary>
        public IPConfigurationProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IPConfigurationProfile class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="subnet">The reference of the subnet resource to create
        /// a container network interface ip configuration.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource.</param>
        /// <param name="name">The name of the resource. This name can be used
        /// to access the resource.</param>
        /// <param name="type">Sub Resource type.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public IPConfigurationProfile(string id = default(string), Subnet subnet = default(Subnet), string provisioningState = default(string), string name = default(string), string type = default(string), string etag = default(string))
            : base(id)
        {
            Subnet = subnet;
            ProvisioningState = provisioningState;
            Name = name;
            Type = type;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reference of the subnet resource to create a
        /// container network interface ip configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public Subnet Subnet { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource. This name can be used to
        /// access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets sub Resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
