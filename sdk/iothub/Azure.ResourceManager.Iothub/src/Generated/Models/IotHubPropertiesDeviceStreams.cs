// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Iothub.Models
{
    /// <summary> The device streams properties of iothub. </summary>
    internal partial class IotHubPropertiesDeviceStreams
    {
        /// <summary> Initializes a new instance of IotHubPropertiesDeviceStreams. </summary>
        public IotHubPropertiesDeviceStreams()
        {
            StreamingEndpoints = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of IotHubPropertiesDeviceStreams. </summary>
        /// <param name="streamingEndpoints"> List of Device Streams Endpoints. </param>
        internal IotHubPropertiesDeviceStreams(IList<string> streamingEndpoints)
        {
            StreamingEndpoints = streamingEndpoints;
        }

        /// <summary> List of Device Streams Endpoints. </summary>
        public IList<string> StreamingEndpoints { get; }
    }
}
