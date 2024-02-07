// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> Configuration Name list which will be set based on different target resource, client type, auth type. </summary>
    internal partial class ConfigurationNameResult
    {
        /// <summary> Initializes a new instance of <see cref="ConfigurationNameResult"/>. </summary>
        internal ConfigurationNameResult()
        {
            Value = new ChangeTrackingList<ConfigurationNameItem>();
        }

        /// <summary> Initializes a new instance of <see cref="ConfigurationNameResult"/>. </summary>
        /// <param name="value"> Expected configuration names for each target service. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        internal ConfigurationNameResult(IReadOnlyList<ConfigurationNameItem> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Expected configuration names for each target service. </summary>
        public IReadOnlyList<ConfigurationNameItem> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}
