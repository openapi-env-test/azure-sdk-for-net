// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    /// <summary> A description of a part of a route, comprised of a list of points. Each additional waypoint provided in the request will result in an additional leg in the returned route. </summary>
    public partial class RouteLeg
    {

        /// <summary> Summary object for route section. </summary>
        public RouteLegSummary Summary { get; }
    }
}
