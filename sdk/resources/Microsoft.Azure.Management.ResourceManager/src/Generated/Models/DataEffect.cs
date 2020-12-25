// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The data effect definition.
    /// </summary>
    public partial class DataEffect
    {
        /// <summary>
        /// Initializes a new instance of the DataEffect class.
        /// </summary>
        public DataEffect()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataEffect class.
        /// </summary>
        /// <param name="name">The data effect name.</param>
        /// <param name="detailsSchema">The data effect details schema.</param>
        public DataEffect(string name = default(string), object detailsSchema = default(object))
        {
            Name = name;
            DetailsSchema = detailsSchema;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the data effect name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the data effect details schema.
        /// </summary>
        [JsonProperty(PropertyName = "detailsSchema")]
        public object DetailsSchema { get; set; }

    }
}
