// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Iothub.Models
{
    /// <summary> Position where the route error happened. </summary>
    public partial class RouteErrorPosition
    {
        /// <summary> Initializes a new instance of RouteErrorPosition. </summary>
        internal RouteErrorPosition()
        {
        }

        /// <summary> Initializes a new instance of RouteErrorPosition. </summary>
        /// <param name="line"> Line where the route error happened. </param>
        /// <param name="column"> Column where the route error happened. </param>
        internal RouteErrorPosition(int? line, int? column)
        {
            Line = line;
            Column = column;
        }

        /// <summary> Line where the route error happened. </summary>
        public int? Line { get; }
        /// <summary> Column where the route error happened. </summary>
        public int? Column { get; }
    }
}
