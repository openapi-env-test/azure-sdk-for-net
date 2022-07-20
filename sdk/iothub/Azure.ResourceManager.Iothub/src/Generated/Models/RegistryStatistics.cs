// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Iothub.Models
{
    /// <summary> Identity registry statistics. </summary>
    public partial class RegistryStatistics
    {
        /// <summary> Initializes a new instance of RegistryStatistics. </summary>
        internal RegistryStatistics()
        {
        }

        /// <summary> Initializes a new instance of RegistryStatistics. </summary>
        /// <param name="totalDeviceCount"> The total count of devices in the identity registry. </param>
        /// <param name="enabledDeviceCount"> The count of enabled devices in the identity registry. </param>
        /// <param name="disabledDeviceCount"> The count of disabled devices in the identity registry. </param>
        internal RegistryStatistics(long? totalDeviceCount, long? enabledDeviceCount, long? disabledDeviceCount)
        {
            TotalDeviceCount = totalDeviceCount;
            EnabledDeviceCount = enabledDeviceCount;
            DisabledDeviceCount = disabledDeviceCount;
        }

        /// <summary> The total count of devices in the identity registry. </summary>
        public long? TotalDeviceCount { get; }
        /// <summary> The count of enabled devices in the identity registry. </summary>
        public long? EnabledDeviceCount { get; }
        /// <summary> The count of disabled devices in the identity registry. </summary>
        public long? DisabledDeviceCount { get; }
    }
}
