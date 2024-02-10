// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> Document administrative metadata. </summary>
    public partial class DocumentAdministrativeMetadata
    {
        /// <summary> Initializes a new instance of <see cref="DocumentAdministrativeMetadata"/>. </summary>
        public DocumentAdministrativeMetadata()
        {
            OrderedProcedures = new ChangeTrackingList<FhirR4Extendible>();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentAdministrativeMetadata"/>. </summary>
        /// <param name="orderedProcedures"> List of procedure information associated with the document. </param>
        /// <param name="encounterId"> Reference to the encounter associated with the document. </param>
        internal DocumentAdministrativeMetadata(IList<FhirR4Extendible> orderedProcedures, string encounterId)
        {
            OrderedProcedures = orderedProcedures;
            EncounterId = encounterId;
        }

        /// <summary> List of procedure information associated with the document. </summary>
        public IList<FhirR4Extendible> OrderedProcedures { get; }
        /// <summary> Reference to the encounter associated with the document. </summary>
        public string EncounterId { get; set; }
    }
}
