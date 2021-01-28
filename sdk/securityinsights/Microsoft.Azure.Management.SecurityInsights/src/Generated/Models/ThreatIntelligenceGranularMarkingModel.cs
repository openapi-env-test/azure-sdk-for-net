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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes threat granular marking model entity
    /// </summary>
    public partial class ThreatIntelligenceGranularMarkingModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ThreatIntelligenceGranularMarkingModel class.
        /// </summary>
        public ThreatIntelligenceGranularMarkingModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ThreatIntelligenceGranularMarkingModel class.
        /// </summary>
        /// <param name="language">Language granular marking model</param>
        /// <param name="markingRef">marking reference granular marking
        /// model</param>
        /// <param name="selectors">granular marking model selectors</param>
        public ThreatIntelligenceGranularMarkingModel(string language = default(string), int? markingRef = default(int?), IList<string> selectors = default(IList<string>))
        {
            Language = language;
            MarkingRef = markingRef;
            Selectors = selectors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets language granular marking model
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets marking reference granular marking model
        /// </summary>
        [JsonProperty(PropertyName = "markingRef")]
        public int? MarkingRef { get; set; }

        /// <summary>
        /// Gets or sets granular marking model selectors
        /// </summary>
        [JsonProperty(PropertyName = "selectors")]
        public IList<string> Selectors { get; set; }

    }
}
