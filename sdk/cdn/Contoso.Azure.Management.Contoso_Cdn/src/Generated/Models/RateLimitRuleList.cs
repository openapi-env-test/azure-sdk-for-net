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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines contents of rate limit rules
    /// </summary>
    public partial class RateLimitRuleList
    {
        /// <summary>
        /// Initializes a new instance of the RateLimitRuleList class.
        /// </summary>
        public RateLimitRuleList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RateLimitRuleList class.
        /// </summary>
        /// <param name="rules">List of rules</param>
        public RateLimitRuleList(IList<RateLimitRule> rules = default(IList<RateLimitRule>))
        {
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of rules
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<RateLimitRule> Rules { get; set; }

    }
}
