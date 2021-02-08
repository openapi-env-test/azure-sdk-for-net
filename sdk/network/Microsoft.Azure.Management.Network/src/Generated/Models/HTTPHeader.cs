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
    using System.Linq;

    /// <summary>
    /// Describes the HTTP header.
    /// </summary>
    public partial class HTTPHeader
    {
        /// <summary>
        /// Initializes a new instance of the HTTPHeader class.
        /// </summary>
        public HTTPHeader()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HTTPHeader class.
        /// </summary>
        /// <param name="name">The name in HTTP header.</param>
        /// <param name="value">The value in HTTP header.</param>
        public HTTPHeader(string name = default(string), string value = default(string))
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name in HTTP header.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value in HTTP header.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
