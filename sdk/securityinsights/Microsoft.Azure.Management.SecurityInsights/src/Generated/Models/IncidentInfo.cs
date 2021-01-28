// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Contoso.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes related incident information for the bookmark
    /// </summary>
    public partial class IncidentInfo
    {
        /// <summary>
        /// Initializes a new instance of the IncidentInfo class.
        /// </summary>
        public IncidentInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IncidentInfo class.
        /// </summary>
        /// <param name="incidentId">Incident Id</param>
        /// <param name="severity">The severity of the incident. Possible
        /// values include: 'Critical', 'High', 'Medium', 'Low',
        /// 'Informational'</param>
        /// <param name="title">The title of the incident</param>
        /// <param name="relationName">Relation Name</param>
        public IncidentInfo(string incidentId, string severity, string title, string relationName)
        {
            IncidentId = incidentId;
            Severity = severity;
            Title = title;
            RelationName = relationName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets incident Id
        /// </summary>
        [JsonProperty(PropertyName = "incidentId")]
        public string IncidentId { get; set; }

        /// <summary>
        /// Gets or sets the severity of the incident. Possible values include:
        /// 'Critical', 'High', 'Medium', 'Low', 'Informational'
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets the title of the incident
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets relation Name
        /// </summary>
        [JsonProperty(PropertyName = "relationName")]
        public string RelationName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (IncidentId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IncidentId");
            }
            if (Severity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Severity");
            }
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (RelationName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RelationName");
            }
        }
    }
}
