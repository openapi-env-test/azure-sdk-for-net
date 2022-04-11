// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppConfiguration.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The key-value resource along with all resource properties.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class KeyValue : IResource
    {
        /// <summary>
        /// Initializes a new instance of the KeyValue class.
        /// </summary>
        public KeyValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyValue class.
        /// </summary>
        /// <param name="id">The resource ID.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="key">The primary identifier of a key-value.
        /// The key is used in unison with the label to uniquely identify a
        /// key-value.</param>
        /// <param name="label">A value used to group key-values.
        /// The label is used in unison with the key to uniquely identify a
        /// key-value.</param>
        /// <param name="value">The value of the key-value.</param>
        /// <param name="contentType">The content type of the key-value's
        /// value.
        /// Providing a proper content-type can enable transformations of
        /// values when they are retrieved by applications.</param>
        /// <param name="eTag">An ETag indicating the state of a key-value
        /// within a configuration store.</param>
        /// <param name="lastModified">The last time a modifying operation was
        /// performed on the given key-value.</param>
        /// <param name="locked">A value indicating whether the key-value is
        /// locked.
        /// A locked key-value may not be modified until it is
        /// unlocked.</param>
        /// <param name="tags">A dictionary of tags that can help identify what
        /// a key-value may be applicable for.</param>
        public KeyValue(string id = default(string), string name = default(string), string type = default(string), string key = default(string), string label = default(string), string value = default(string), string contentType = default(string), string eTag = default(string), System.DateTime? lastModified = default(System.DateTime?), bool? locked = default(bool?), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Id = id;
            Name = name;
            Type = type;
            Key = key;
            Label = label;
            Value = value;
            ContentType = contentType;
            ETag = eTag;
            LastModified = lastModified;
            Locked = locked;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the primary identifier of a key-value.
        /// The key is used in unison with the label to uniquely identify a
        /// key-value.
        /// </summary>
        [JsonProperty(PropertyName = "properties.key")]
        public string Key { get; private set; }

        /// <summary>
        /// Gets a value used to group key-values.
        /// The label is used in unison with the key to uniquely identify a
        /// key-value.
        /// </summary>
        [JsonProperty(PropertyName = "properties.label")]
        public string Label { get; private set; }

        /// <summary>
        /// Gets or sets the value of the key-value.
        /// </summary>
        [JsonProperty(PropertyName = "properties.value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the content type of the key-value's value.
        /// Providing a proper content-type can enable transformations of
        /// values when they are retrieved by applications.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets an ETag indicating the state of a key-value within a
        /// configuration store.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eTag")]
        public string ETag { get; private set; }

        /// <summary>
        /// Gets the last time a modifying operation was performed on the given
        /// key-value.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModified")]
        public System.DateTime? LastModified { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the key-value is locked.
        /// A locked key-value may not be modified until it is unlocked.
        /// </summary>
        [JsonProperty(PropertyName = "properties.locked")]
        public bool? Locked { get; private set; }

        /// <summary>
        /// Gets or sets a dictionary of tags that can help identify what a
        /// key-value may be applicable for.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
