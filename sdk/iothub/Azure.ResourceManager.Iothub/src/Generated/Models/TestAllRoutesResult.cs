// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Iothub.Models
{
    /// <summary> Result of testing all routes. </summary>
    public partial class TestAllRoutesResult
    {
        /// <summary> Initializes a new instance of TestAllRoutesResult. </summary>
        internal TestAllRoutesResult()
        {
            Routes = new ChangeTrackingList<MatchedRoute>();
        }

        /// <summary> Initializes a new instance of TestAllRoutesResult. </summary>
        /// <param name="routes"> JSON-serialized array of matched routes. </param>
        internal TestAllRoutesResult(IReadOnlyList<MatchedRoute> routes)
        {
            Routes = routes;
        }

        /// <summary> JSON-serialized array of matched routes. </summary>
        public IReadOnlyList<MatchedRoute> Routes { get; }
    }
}
