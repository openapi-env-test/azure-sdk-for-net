// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceLinker;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The list of dryrun. </summary>
    internal partial class DryrunList
    {
        /// <summary> Initializes a new instance of <see cref="DryrunList"/>. </summary>
        internal DryrunList()
        {
            Value = new ChangeTrackingList<DryrunResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="DryrunList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of dryrun list. </param>
        /// <param name="value"> The list of dryrun. </param>
        internal DryrunList(string nextLink, IReadOnlyList<DryrunResourceData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of dryrun list. </summary>
        public string NextLink { get; }
        /// <summary> The list of dryrun. </summary>
        public IReadOnlyList<DryrunResourceData> Value { get; }
    }
}
