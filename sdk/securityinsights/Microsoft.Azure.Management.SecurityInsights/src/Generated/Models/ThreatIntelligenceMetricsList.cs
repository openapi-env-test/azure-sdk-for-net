// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Contoso.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of all the threat intelligence metric fields (type/threat
    /// type/source).
    /// </summary>
    public partial class ThreatIntelligenceMetricsList
    {
        /// <summary>
        /// Initializes a new instance of the ThreatIntelligenceMetricsList
        /// class.
        /// </summary>
        public ThreatIntelligenceMetricsList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ThreatIntelligenceMetricsList
        /// class.
        /// </summary>
        /// <param name="value">Array of threat intelligence metric fields
        /// (type/threat type/source).</param>
        public ThreatIntelligenceMetricsList(IList<ThreatIntelligenceMetrics> value)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets array of threat intelligence metric fields
        /// (type/threat type/source).
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ThreatIntelligenceMetrics> Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
