// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The format definition of a storage.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DatasetStorageFormat")]
    public partial class DatasetStorageFormat
    {
        /// <summary>
        /// Initializes a new instance of the DatasetStorageFormat class.
        /// </summary>
        public DatasetStorageFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetStorageFormat class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="serializer">Serializer. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="deserializer">Deserializer. Type: string (or
        /// Expression with resultType string).</param>
        public DatasetStorageFormat(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object serializer = default(object), object deserializer = default(object))
        {
            AdditionalProperties = additionalProperties;
            Serializer = serializer;
            Deserializer = deserializer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets serializer. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "serializer")]
        public object Serializer { get; set; }

        /// <summary>
        /// Gets or sets deserializer. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "deserializer")]
        public object Deserializer { get; set; }

    }
}
