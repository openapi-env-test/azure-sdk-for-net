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
    /// <summary> Radiology code with types : used in imaging procedure recommendation for contrast and view. </summary>
    internal partial class RadiologyCodeWithTypes
    {
        /// <summary> Initializes a new instance of <see cref="RadiologyCodeWithTypes"/>. </summary>
        /// <param name="code"> The SNOMED CT code indicates whether imaging was conducted with or without contrast in the case of contrast, and in the case of views, it denotes the number of views. </param>
        /// <param name="types"> The collection of types will indicate the contrast substance used in the case of contrast and, in the case of views, it will specify the types of views, such as lateral and frontal, etc. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="types"/> is null. </exception>
        public RadiologyCodeWithTypes(FhirR4CodeableConcept code, IEnumerable<FhirR4CodeableConcept> types)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(types, nameof(types));

            Code = code;
            Types = types.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RadiologyCodeWithTypes"/>. </summary>
        /// <param name="code"> The SNOMED CT code indicates whether imaging was conducted with or without contrast in the case of contrast, and in the case of views, it denotes the number of views. </param>
        /// <param name="types"> The collection of types will indicate the contrast substance used in the case of contrast and, in the case of views, it will specify the types of views, such as lateral and frontal, etc. </param>
        internal RadiologyCodeWithTypes(FhirR4CodeableConcept code, IList<FhirR4CodeableConcept> types)
        {
            Code = code;
            Types = types;
        }

        /// <summary> The SNOMED CT code indicates whether imaging was conducted with or without contrast in the case of contrast, and in the case of views, it denotes the number of views. </summary>
        public FhirR4CodeableConcept Code { get; set; }
        /// <summary> The collection of types will indicate the contrast substance used in the case of contrast and, in the case of views, it will specify the types of views, such as lateral and frontal, etc. </summary>
        public IList<FhirR4CodeableConcept> Types { get; }
    }
}
