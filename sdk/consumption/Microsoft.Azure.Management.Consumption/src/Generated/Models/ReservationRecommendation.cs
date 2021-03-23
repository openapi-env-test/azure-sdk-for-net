// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A reservation recommendation resource.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ReservationRecommendation")]
    public partial class ReservationRecommendation
    {
        /// <summary>
        /// Initializes a new instance of the ReservationRecommendation class.
        /// </summary>
        public ReservationRecommendation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReservationRecommendation class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="etag">Resource etag.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="location">Resource location</param>
        /// <param name="sku">Resource sku</param>
        public ReservationRecommendation(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), string sku = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Etag = etag;
            Tags = tags;
            Location = location;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets resource etag.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; private set; }

        /// <summary>
        /// Gets resource location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets resource sku
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; private set; }

    }
}
