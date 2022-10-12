// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List of available columns for sorting. </summary>
    public partial class ThreatIntelligenceSortingCriteria
    {
        /// <summary> Initializes a new instance of ThreatIntelligenceSortingCriteria. </summary>
        public ThreatIntelligenceSortingCriteria()
        {
        }

        /// <summary> Column name. </summary>
        public string ItemKey { get; set; }
        /// <summary> Sorting order (ascending/descending/unsorted). </summary>
        public ThreatIntelligenceSortingCriteriaEnum? SortOrder { get; set; }
    }
}
