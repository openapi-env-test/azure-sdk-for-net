// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary> A class representing the SecuritySubAssessment data model. </summary>
    public partial class SecuritySubAssessmentData : ResourceData
    {
        /// <summary> Initializes a new instance of SecuritySubAssessmentData. </summary>
        public SecuritySubAssessmentData()
        {
        }

        /// <summary> Initializes a new instance of SecuritySubAssessmentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="idPropertiesId"> Vulnerability ID. </param>
        /// <param name="displayName"> User friendly display name of the sub-assessment. </param>
        /// <param name="status"> Status of the sub-assessment. </param>
        /// <param name="remediation"> Information on how to remediate this sub-assessment. </param>
        /// <param name="impact"> Description of the impact of this sub-assessment. </param>
        /// <param name="category"> Category of the sub-assessment. </param>
        /// <param name="description"> Human readable description of the assessment status. </param>
        /// <param name="timeGenerated"> The date and time the sub-assessment was generated. </param>
        /// <param name="resourceDetails">
        /// Details of the resource that was assessed
        /// Please note <see cref="ResourceDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureResourceDetails"/>, <see cref="OnPremiseResourceDetails"/> and <see cref="OnPremiseSqlResourceDetails"/>.
        /// </param>
        /// <param name="additionalData">
        /// Details of the sub-assessment
        /// Please note <see cref="AdditionalData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContainerRegistryVulnerabilityProperties"/>, <see cref="ServerVulnerabilityProperties"/> and <see cref="SqlServerVulnerabilityProperties"/>.
        /// </param>
        internal SecuritySubAssessmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string idPropertiesId, string displayName, SubAssessmentStatus status, string remediation, string impact, string category, string description, DateTimeOffset? timeGenerated, ResourceDetails resourceDetails, AdditionalData additionalData) : base(id, name, resourceType, systemData)
        {
            IdPropertiesId = idPropertiesId;
            DisplayName = displayName;
            Status = status;
            Remediation = remediation;
            Impact = impact;
            Category = category;
            Description = description;
            TimeGenerated = timeGenerated;
            ResourceDetails = resourceDetails;
            AdditionalData = additionalData;
        }

        /// <summary> Vulnerability ID. </summary>
        public string IdPropertiesId { get; }
        /// <summary> User friendly display name of the sub-assessment. </summary>
        public string DisplayName { get; }
        /// <summary> Status of the sub-assessment. </summary>
        public SubAssessmentStatus Status { get; set; }
        /// <summary> Information on how to remediate this sub-assessment. </summary>
        public string Remediation { get; }
        /// <summary> Description of the impact of this sub-assessment. </summary>
        public string Impact { get; }
        /// <summary> Category of the sub-assessment. </summary>
        public string Category { get; }
        /// <summary> Human readable description of the assessment status. </summary>
        public string Description { get; }
        /// <summary> The date and time the sub-assessment was generated. </summary>
        public DateTimeOffset? TimeGenerated { get; }
        /// <summary>
        /// Details of the resource that was assessed
        /// Please note <see cref="ResourceDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureResourceDetails"/>, <see cref="OnPremiseResourceDetails"/> and <see cref="OnPremiseSqlResourceDetails"/>.
        /// </summary>
        public ResourceDetails ResourceDetails { get; set; }
        /// <summary>
        /// Details of the sub-assessment
        /// Please note <see cref="AdditionalData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContainerRegistryVulnerabilityProperties"/>, <see cref="ServerVulnerabilityProperties"/> and <see cref="SqlServerVulnerabilityProperties"/>.
        /// </summary>
        public AdditionalData AdditionalData { get; set; }
    }
}
