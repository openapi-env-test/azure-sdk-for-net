// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the role properties. </summary>
    public partial class CloudServiceRoleProfileProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudServiceRoleProfileProperties"/>. </summary>
        public CloudServiceRoleProfileProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudServiceRoleProfileProperties"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="sku"> Describes the cloud service role sku. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudServiceRoleProfileProperties(string name, CloudServiceRoleSku sku, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Sku = sku;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource name. </summary>
        public string Name { get; set; }
        /// <summary> Describes the cloud service role sku. </summary>
        public CloudServiceRoleSku Sku { get; set; }
    }
}
