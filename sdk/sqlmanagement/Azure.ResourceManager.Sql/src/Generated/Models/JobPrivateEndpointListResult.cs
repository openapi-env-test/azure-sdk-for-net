// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of job agent private endpoints. </summary>
    internal partial class JobPrivateEndpointListResult
    {
        /// <summary> Initializes a new instance of <see cref="JobPrivateEndpointListResult"/>. </summary>
        internal JobPrivateEndpointListResult()
        {
            Value = new ChangeTrackingList<JobPrivateEndpointData>();
        }

        /// <summary> Initializes a new instance of <see cref="JobPrivateEndpointListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal JobPrivateEndpointListResult(IReadOnlyList<JobPrivateEndpointData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<JobPrivateEndpointData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
