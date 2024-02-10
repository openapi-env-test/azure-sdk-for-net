// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> Imaging procedures. </summary>
    internal partial class ImagingProcedureRecommendation : ProcedureRecommendation
    {
        /// <summary> Initializes a new instance of <see cref="ImagingProcedureRecommendation"/>. </summary>
        /// <param name="imagingProcedures"> Imaging procedures. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="imagingProcedures"/> is null. </exception>
        public ImagingProcedureRecommendation(IEnumerable<ImagingProcedure> imagingProcedures)
        {
            Argument.AssertNotNull(imagingProcedures, nameof(imagingProcedures));

            Kind = "imagingProcedureRecommendation";
            ProcedureCodes = new ChangeTrackingList<FhirR4CodeableConcept>();
            ImagingProcedures = imagingProcedures.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ImagingProcedureRecommendation"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="procedureCodes"> LOINC codes for the procedure. </param>
        /// <param name="imagingProcedures"> Imaging procedures. </param>
        internal ImagingProcedureRecommendation(string kind, IList<FhirR4CodeableConcept> procedureCodes, IList<ImagingProcedure> imagingProcedures) : base(kind)
        {
            ProcedureCodes = procedureCodes;
            ImagingProcedures = imagingProcedures;
        }

        /// <summary> LOINC codes for the procedure. </summary>
        public IList<FhirR4CodeableConcept> ProcedureCodes { get; }
        /// <summary> Imaging procedures. </summary>
        public IList<ImagingProcedure> ImagingProcedures { get; }
    }
}
