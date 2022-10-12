// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary> A class representing the MdeOnboardingData data model. </summary>
    public partial class MdeOnboardingDataData : ResourceData
    {
        /// <summary> Initializes a new instance of MdeOnboardingDataData. </summary>
        public MdeOnboardingDataData()
        {
        }

        /// <summary> Initializes a new instance of MdeOnboardingDataData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="onboardingPackageWindows"> The onboarding package used to onboard Windows machines to MDE, coded in base64. This can also be used for onboarding using the dedicated VM Extension. </param>
        /// <param name="onboardingPackageLinux"> The onboarding package used to onboard Linux machines to MDE, coded in base64. This can also be used for onboarding using the dedicated VM Extension. </param>
        internal MdeOnboardingDataData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, byte[] onboardingPackageWindows, byte[] onboardingPackageLinux) : base(id, name, resourceType, systemData)
        {
            OnboardingPackageWindows = onboardingPackageWindows;
            OnboardingPackageLinux = onboardingPackageLinux;
        }

        /// <summary> The onboarding package used to onboard Windows machines to MDE, coded in base64. This can also be used for onboarding using the dedicated VM Extension. </summary>
        public byte[] OnboardingPackageWindows { get; set; }
        /// <summary> The onboarding package used to onboard Linux machines to MDE, coded in base64. This can also be used for onboarding using the dedicated VM Extension. </summary>
        public byte[] OnboardingPackageLinux { get; set; }
    }
}
