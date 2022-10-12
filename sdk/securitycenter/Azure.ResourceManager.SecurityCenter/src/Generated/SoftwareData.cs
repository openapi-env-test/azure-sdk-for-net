// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary> A class representing the Software data model. </summary>
    public partial class SoftwareData : ResourceData
    {
        /// <summary> Initializes a new instance of SoftwareData. </summary>
        public SoftwareData()
        {
        }

        /// <summary> Initializes a new instance of SoftwareData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="deviceId"> Unique identifier for the virtual machine in the service. </param>
        /// <param name="osPlatform"> Platform of the operating system running on the device. </param>
        /// <param name="vendor"> Name of the software vendor. </param>
        /// <param name="softwareName"> Name of the software product. </param>
        /// <param name="version"> Version number of the software product. </param>
        /// <param name="endOfSupportStatus"> End of support status. </param>
        /// <param name="endOfSupportDate"> The end of support date in case the product is upcoming end of support. </param>
        /// <param name="numberOfKnownVulnerabilities"> Number of weaknesses. </param>
        /// <param name="firstSeenAt"> First time that the software was seen in the device. </param>
        internal SoftwareData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string deviceId, string osPlatform, string vendor, string softwareName, string version, EndOfSupportStatus? endOfSupportStatus, string endOfSupportDate, int? numberOfKnownVulnerabilities, string firstSeenAt) : base(id, name, resourceType, systemData)
        {
            DeviceId = deviceId;
            OSPlatform = osPlatform;
            Vendor = vendor;
            SoftwareName = softwareName;
            Version = version;
            EndOfSupportStatus = endOfSupportStatus;
            EndOfSupportDate = endOfSupportDate;
            NumberOfKnownVulnerabilities = numberOfKnownVulnerabilities;
            FirstSeenAt = firstSeenAt;
        }

        /// <summary> Unique identifier for the virtual machine in the service. </summary>
        public string DeviceId { get; set; }
        /// <summary> Platform of the operating system running on the device. </summary>
        public string OSPlatform { get; set; }
        /// <summary> Name of the software vendor. </summary>
        public string Vendor { get; set; }
        /// <summary> Name of the software product. </summary>
        public string SoftwareName { get; set; }
        /// <summary> Version number of the software product. </summary>
        public string Version { get; set; }
        /// <summary> End of support status. </summary>
        public EndOfSupportStatus? EndOfSupportStatus { get; set; }
        /// <summary> The end of support date in case the product is upcoming end of support. </summary>
        public string EndOfSupportDate { get; set; }
        /// <summary> Number of weaknesses. </summary>
        public int? NumberOfKnownVulnerabilities { get; set; }
        /// <summary> First time that the software was seen in the device. </summary>
        public string FirstSeenAt { get; set; }
    }
}
