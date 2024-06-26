// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> Details of the user's elastic account. </summary>
    public partial class ElasticCloudUser
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

        /// <summary> Initializes a new instance of <see cref="ElasticCloudUser"/>. </summary>
        public ElasticCloudUser()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ElasticCloudUser"/>. </summary>
        /// <param name="emailAddress"> Email of the Elastic User Account. </param>
        /// <param name="id"> User Id of the elastic account of the User. </param>
        /// <param name="elasticCloudSsoDefaultUri"> Elastic cloud default dashboard sso URL of the Elastic user account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ElasticCloudUser(string emailAddress, string id, Uri elasticCloudSsoDefaultUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EmailAddress = emailAddress;
            Id = id;
            ElasticCloudSsoDefaultUri = elasticCloudSsoDefaultUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Email of the Elastic User Account. </summary>
        public string EmailAddress { get; }
        /// <summary> User Id of the elastic account of the User. </summary>
        public string Id { get; }
        /// <summary> Elastic cloud default dashboard sso URL of the Elastic user account. </summary>
        public Uri ElasticCloudSsoDefaultUri { get; }
    }
}
