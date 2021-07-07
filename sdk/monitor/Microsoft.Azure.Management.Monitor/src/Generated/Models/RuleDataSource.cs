// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The resource from which the rule collects its data.
    /// </summary>
    [Newtonsoft.Json.JsonObject("RuleDataSource")]
    public partial class RuleDataSource
    {
        /// <summary>
        /// Initializes a new instance of the RuleDataSource class.
        /// </summary>
        public RuleDataSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RuleDataSource class.
        /// </summary>
        /// <param name="resourceUri">the resource identifier of the resource
        /// the rule monitors. **NOTE**: this property cannot be updated for an
        /// existing rule.</param>
        /// <param name="legacyResourceId">the legacy resource identifier of
        /// the resource the rule monitors. **NOTE**: this property cannot be
        /// updated for an existing rule.</param>
        /// <param name="resourceLocation">the location of the
        /// resource.</param>
        /// <param name="metricNamespace">the namespace of the metric.</param>
        public RuleDataSource(string resourceUri = default(string), string legacyResourceId = default(string), string resourceLocation = default(string), string metricNamespace = default(string))
        {
            ResourceUri = resourceUri;
            LegacyResourceId = legacyResourceId;
            ResourceLocation = resourceLocation;
            MetricNamespace = metricNamespace;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource identifier of the resource the rule
        /// monitors. **NOTE**: this property cannot be updated for an existing
        /// rule.
        /// </summary>
        [JsonProperty(PropertyName = "resourceUri")]
        public string ResourceUri { get; set; }

        /// <summary>
        /// Gets or sets the legacy resource identifier of the resource the
        /// rule monitors. **NOTE**: this property cannot be updated for an
        /// existing rule.
        /// </summary>
        [JsonProperty(PropertyName = "legacyResourceId")]
        public string LegacyResourceId { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourceLocation")]
        public string ResourceLocation { get; set; }

        /// <summary>
        /// Gets or sets the namespace of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "metricNamespace")]
        public string MetricNamespace { get; set; }

    }
}
