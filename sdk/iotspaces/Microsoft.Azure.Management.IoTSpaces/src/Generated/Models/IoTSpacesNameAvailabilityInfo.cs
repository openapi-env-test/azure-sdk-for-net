// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IoTSpaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties indicating whether a given IoTSpaces service name is
    /// available.
    /// </summary>
    public partial class IoTSpacesNameAvailabilityInfo
    {
        /// <summary>
        /// Initializes a new instance of the IoTSpacesNameAvailabilityInfo
        /// class.
        /// </summary>
        public IoTSpacesNameAvailabilityInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IoTSpacesNameAvailabilityInfo
        /// class.
        /// </summary>
        /// <param name="nameAvailable">The value which indicates whether the
        /// provided name is available.</param>
        /// <param name="reason">The reason for unavailability. Possible values
        /// include: 'Invalid', 'AlreadyExists'</param>
        /// <param name="message">The detailed reason message.</param>
        public IoTSpacesNameAvailabilityInfo(bool? nameAvailable = default(bool?), IoTSpacesNameUnavailabilityReason? reason = default(IoTSpacesNameUnavailabilityReason?), string message = default(string))
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the value which indicates whether the provided name is
        /// available.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; private set; }

        /// <summary>
        /// Gets the reason for unavailability. Possible values include:
        /// 'Invalid', 'AlreadyExists'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public IoTSpacesNameUnavailabilityReason? Reason { get; private set; }

        /// <summary>
        /// Gets or sets the detailed reason message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
