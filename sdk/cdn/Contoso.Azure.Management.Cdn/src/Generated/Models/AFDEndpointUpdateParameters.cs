// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Contoso.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties required to create or update an endpoint.
    /// </summary>
    [JsonTransformation]
    public partial class AFDEndpointUpdateParameters : IResource
    {
        /// <summary>
        /// Initializes a new instance of the AFDEndpointUpdateParameters
        /// class.
        /// </summary>
        public AFDEndpointUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AFDEndpointUpdateParameters
        /// class.
        /// </summary>
        /// <param name="tags">Endpoint tags.</param>
        /// <param name="originResponseTimeoutSeconds">Send and receive timeout
        /// on forwarding request to the origin. When timeout is reached, the
        /// request fails and returns.</param>
        /// <param name="enabledState">Whether to enable use of this rule.
        /// Permitted values are 'Enabled' or 'Disabled'. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        public AFDEndpointUpdateParameters(IDictionary<string, string> tags = default(IDictionary<string, string>), int? originResponseTimeoutSeconds = default(int?), string enabledState = default(string))
        {
            Tags = tags;
            OriginResponseTimeoutSeconds = originResponseTimeoutSeconds;
            EnabledState = enabledState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets endpoint tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets send and receive timeout on forwarding request to the
        /// origin. When timeout is reached, the request fails and returns.
        /// </summary>
        [JsonProperty(PropertyName = "properties.originResponseTimeoutSeconds")]
        public int? OriginResponseTimeoutSeconds { get; set; }

        /// <summary>
        /// Gets or sets whether to enable use of this rule. Permitted values
        /// are 'Enabled' or 'Disabled'. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabledState")]
        public string EnabledState { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OriginResponseTimeoutSeconds < 16)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "OriginResponseTimeoutSeconds", 16);
            }
        }
    }
}
