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
    /// Describes a managed rule group.
    /// </summary>
    public partial class ManagedRuleGroupDefinition
    {
        /// <summary>
        /// Initializes a new instance of the ManagedRuleGroupDefinition class.
        /// </summary>
        public ManagedRuleGroupDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedRuleGroupDefinition class.
        /// </summary>
        /// <param name="ruleGroupName">Name of the managed rule group.</param>
        /// <param name="description">Description of the managed rule
        /// group.</param>
        /// <param name="rules">List of rules within the managed rule
        /// group.</param>
        public ManagedRuleGroupDefinition(string ruleGroupName = default(string), string description = default(string), IList<ManagedRuleDefinition> rules = default(IList<ManagedRuleDefinition>))
        {
            RuleGroupName = ruleGroupName;
            Description = description;
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the managed rule group.
        /// </summary>
        [JsonProperty(PropertyName = "ruleGroupName")]
        public string RuleGroupName { get; private set; }

        /// <summary>
        /// Gets description of the managed rule group.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets list of rules within the managed rule group.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<ManagedRuleDefinition> Rules { get; private set; }

    }
}
