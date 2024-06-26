// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Existing recovery availability set input. </summary>
    public partial class ExistingRecoveryAvailabilitySet : RecoveryAvailabilitySetCustomDetails
    {
        /// <summary> Initializes a new instance of <see cref="ExistingRecoveryAvailabilitySet"/>. </summary>
        public ExistingRecoveryAvailabilitySet()
        {
            ResourceType = "Existing";
        }

        /// <summary> Initializes a new instance of <see cref="ExistingRecoveryAvailabilitySet"/>. </summary>
        /// <param name="resourceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryAvailabilitySetId"> The recovery availability set Id. Will throw error, if resource does not exist. </param>
        internal ExistingRecoveryAvailabilitySet(string resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier recoveryAvailabilitySetId) : base(resourceType, serializedAdditionalRawData)
        {
            RecoveryAvailabilitySetId = recoveryAvailabilitySetId;
            ResourceType = resourceType ?? "Existing";
        }

        /// <summary> The recovery availability set Id. Will throw error, if resource does not exist. </summary>
        public ResourceIdentifier RecoveryAvailabilitySetId { get; set; }
    }
}
