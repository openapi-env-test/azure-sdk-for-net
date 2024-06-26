// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Application Gateway global configuration. </summary>
    public partial class ApplicationGatewayGlobalConfiguration
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

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayGlobalConfiguration"/>. </summary>
        public ApplicationGatewayGlobalConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayGlobalConfiguration"/>. </summary>
        /// <param name="enableRequestBuffering"> Enable request buffering. </param>
        /// <param name="enableResponseBuffering"> Enable response buffering. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayGlobalConfiguration(bool? enableRequestBuffering, bool? enableResponseBuffering, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EnableRequestBuffering = enableRequestBuffering;
            EnableResponseBuffering = enableResponseBuffering;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Enable request buffering. </summary>
        public bool? EnableRequestBuffering { get; set; }
        /// <summary> Enable response buffering. </summary>
        public bool? EnableResponseBuffering { get; set; }
    }
}
