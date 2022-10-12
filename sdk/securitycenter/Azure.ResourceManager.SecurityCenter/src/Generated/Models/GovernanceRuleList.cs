// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Page of a security governanceRules list. </summary>
    internal partial class GovernanceRuleList
    {
        /// <summary> Initializes a new instance of GovernanceRuleList. </summary>
        internal GovernanceRuleList()
        {
            Value = new ChangeTrackingList<GovernanceRuleData>();
        }

        /// <summary> Initializes a new instance of GovernanceRuleList. </summary>
        /// <param name="value"> Collection of governanceRules in this page. </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        internal GovernanceRuleList(IReadOnlyList<GovernanceRuleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of governanceRules in this page. </summary>
        public IReadOnlyList<GovernanceRuleData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
