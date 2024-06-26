// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Application Gateway autoscale configuration. </summary>
    public partial class ApplicationGatewayAutoscaleConfiguration
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

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayAutoscaleConfiguration"/>. </summary>
        /// <param name="minCapacity"> Lower bound on number of Application Gateway capacity. </param>
        public ApplicationGatewayAutoscaleConfiguration(int minCapacity)
        {
            MinCapacity = minCapacity;
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayAutoscaleConfiguration"/>. </summary>
        /// <param name="minCapacity"> Lower bound on number of Application Gateway capacity. </param>
        /// <param name="maxCapacity"> Upper bound on number of Application Gateway capacity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayAutoscaleConfiguration(int minCapacity, int? maxCapacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MinCapacity = minCapacity;
            MaxCapacity = maxCapacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayAutoscaleConfiguration"/> for deserialization. </summary>
        internal ApplicationGatewayAutoscaleConfiguration()
        {
        }

        /// <summary> Lower bound on number of Application Gateway capacity. </summary>
        public int MinCapacity { get; set; }
        /// <summary> Upper bound on number of Application Gateway capacity. </summary>
        public int? MaxCapacity { get; set; }
    }
}
