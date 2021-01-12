// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Contoso.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// CDN profile is a logical grouping of endpoints that share the same
    /// settings, such as CDN provider and pricing tier.
    /// </summary>
    [JsonTransformation]
    public partial class Profile : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Profile class.
        /// </summary>
        public Profile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Profile class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="sku">The pricing tier (defines a CDN provider, feature
        /// list and rate) of the CDN profile.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="resourceState">Resource status of the profile.
        /// Possible values include: 'Creating', 'Active', 'Deleting',
        /// 'Disabled'</param>
        /// <param name="provisioningState">Provisioning status of the
        /// profile.</param>
        /// <param name="frontdoorId">The Id of the frontdoor.</param>
        public Profile(string location, Sku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SystemData systemData = default(SystemData), string resourceState = default(string), string provisioningState = default(string), string frontdoorId = default(string))
            : base(location, id, name, type, tags, systemData)
        {
            Sku = sku;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
            FrontdoorId = frontdoorId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the pricing tier (defines a CDN provider, feature list
        /// and rate) of the CDN profile.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets resource status of the profile. Possible values include:
        /// 'Creating', 'Active', 'Deleting', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; private set; }

        /// <summary>
        /// Gets provisioning status of the profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the Id of the frontdoor.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontdoorId")]
        public string FrontdoorId { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
        }
    }
}
