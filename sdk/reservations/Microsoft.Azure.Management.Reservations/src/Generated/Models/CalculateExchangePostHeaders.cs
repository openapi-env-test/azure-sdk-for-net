// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Post operation.
    /// </summary>
    public partial class CalculateExchangePostHeaders
    {
        /// <summary>
        /// Initializes a new instance of the CalculateExchangePostHeaders
        /// class.
        /// </summary>
        public CalculateExchangePostHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CalculateExchangePostHeaders
        /// class.
        /// </summary>
        /// <param name="location">URL to query for the status of the
        /// operation.</param>
        /// <param name="retryAfter">Clients should wait for the Retry-After
        /// interval before polling again</param>
        public CalculateExchangePostHeaders(string location = default(string), int? retryAfter = default(int?))
        {
            Location = location;
            RetryAfter = retryAfter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URL to query for the status of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets clients should wait for the Retry-After interval
        /// before polling again
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public int? RetryAfter { get; set; }

    }
}
