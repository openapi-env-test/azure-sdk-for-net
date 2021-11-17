// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Messaging.WebPubSub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for AddConnectionToGroup operation.
    /// </summary>
    public partial class WebPubSubAddConnectionToGroupHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// WebPubSubAddConnectionToGroupHeaders class.
        /// </summary>
        public WebPubSubAddConnectionToGroupHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// WebPubSubAddConnectionToGroupHeaders class.
        /// </summary>
        public WebPubSubAddConnectionToGroupHeaders(string errorCode = default(string))
        {
            ErrorCode = errorCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-error-code")]
        public string ErrorCode { get; set; }

    }
}
