// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The response from the List maintenance configurations operation. </summary>
    public partial class MaintenanceConfigurationListResult
    {
        /// <summary> Initializes a new instance of MaintenanceConfigurationListResult. </summary>
        internal MaintenanceConfigurationListResult()
        {
            Value = new ChangeTrackingList<MaintenanceConfiguration>();
        }

        /// <summary> Initializes a new instance of MaintenanceConfigurationListResult. </summary>
        /// <param name="value"> The list of maintenance configurations. </param>
        /// <param name="nextLink"> The URL to get the next set of maintenance configuration results. </param>
        internal MaintenanceConfigurationListResult(IReadOnlyList<MaintenanceConfiguration> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of maintenance configurations. </summary>
        public IReadOnlyList<MaintenanceConfiguration> Value { get; }
        /// <summary> The URL to get the next set of maintenance configuration results. </summary>
        public string NextLink { get; }
    }
}
