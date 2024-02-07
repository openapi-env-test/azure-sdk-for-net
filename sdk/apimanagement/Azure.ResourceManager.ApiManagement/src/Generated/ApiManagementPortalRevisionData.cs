// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiManagementPortalRevision data model.
    /// Portal Revision's contract details.
    /// </summary>
    public partial class ApiManagementPortalRevisionData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ApiManagementPortalRevisionData"/>. </summary>
        public ApiManagementPortalRevisionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementPortalRevisionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Portal revision description. </param>
        /// <param name="statusDetails"> Portal revision publishing status details. </param>
        /// <param name="status"> Status of the portal's revision. </param>
        /// <param name="isCurrent"> Indicates if the portal's revision is public. </param>
        /// <param name="createdOn"> Portal's revision creation date and time. </param>
        /// <param name="updatedOn"> Last updated date and time. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        internal ApiManagementPortalRevisionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string statusDetails, PortalRevisionStatus? status, bool? isCurrent, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string provisioningState) : base(id, name, resourceType, systemData)
        {
            Description = description;
            StatusDetails = statusDetails;
            Status = status;
            IsCurrent = isCurrent;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            ProvisioningState = provisioningState;
        }

        /// <summary> Portal revision description. </summary>
        public string Description { get; set; }
        /// <summary> Portal revision publishing status details. </summary>
        public string StatusDetails { get; }
        /// <summary> Status of the portal's revision. </summary>
        public PortalRevisionStatus? Status { get; }
        /// <summary> Indicates if the portal's revision is public. </summary>
        public bool? IsCurrent { get; set; }
        /// <summary> Portal's revision creation date and time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Last updated date and time. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> The provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
