// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> FhirService patch properties. </summary>
    public partial class FhirServicePatch : HealthcareApisResourceTags
    {
        /// <summary> Initializes a new instance of <see cref="FhirServicePatch"/>. </summary>
        public FhirServicePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FhirServicePatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="identity"> Setting indicating whether the service has a managed identity associated with it. </param>
        internal FhirServicePatch(IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ManagedServiceIdentity identity) : base(tags, serializedAdditionalRawData)
        {
            Identity = identity;
        }

        /// <summary> Setting indicating whether the service has a managed identity associated with it. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
