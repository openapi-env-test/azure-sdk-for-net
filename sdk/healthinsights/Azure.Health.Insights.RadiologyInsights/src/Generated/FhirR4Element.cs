// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary>
    /// The base definition for all elements contained inside a resource.
    /// Based on [FHIR Element](https://www.hl7.org/fhir/R4/element.html)
    /// </summary>
    public partial class FhirR4Element
    {
        /// <summary> Initializes a new instance of <see cref="FhirR4Element"/>. </summary>
        internal FhirR4Element()
        {
            Extension = new ChangeTrackingList<FhirR4Extension>();
        }

        /// <summary> Initializes a new instance of <see cref="FhirR4Element"/>. </summary>
        /// <param name="id"> Unique id for inter-element referencing. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        internal FhirR4Element(string id, IReadOnlyList<FhirR4Extension> extension)
        {
            Id = id;
            Extension = extension;
        }

        /// <summary> Unique id for inter-element referencing. </summary>
        public string Id { get; }
        /// <summary> Additional Content defined by implementations. </summary>
        public IReadOnlyList<FhirR4Extension> Extension { get; }
    }
}
