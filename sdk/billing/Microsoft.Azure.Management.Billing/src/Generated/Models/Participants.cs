// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The details about a participant.
    /// </summary>
    public partial class Participants
    {
        /// <summary>
        /// Initializes a new instance of the Participants class.
        /// </summary>
        public Participants()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Participants class.
        /// </summary>
        /// <param name="status">The acceptance status of the
        /// participant.</param>
        /// <param name="statusDate">The date when the status got
        /// changed.</param>
        /// <param name="email">The email address of the participant.</param>
        public Participants(string status = default(string), System.DateTime? statusDate = default(System.DateTime?), string email = default(string))
        {
            Status = status;
            StatusDate = statusDate;
            Email = email;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the acceptance status of the participant.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the date when the status got changed.
        /// </summary>
        [JsonProperty(PropertyName = "statusDate")]
        public System.DateTime? StatusDate { get; private set; }

        /// <summary>
        /// Gets the email address of the participant.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; private set; }

    }
}
