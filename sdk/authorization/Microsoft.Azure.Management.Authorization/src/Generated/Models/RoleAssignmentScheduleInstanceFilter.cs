// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Role assignment schedule instance filter
    /// </summary>
    public partial class RoleAssignmentScheduleInstanceFilter
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RoleAssignmentScheduleInstanceFilter class.
        /// </summary>
        public RoleAssignmentScheduleInstanceFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RoleAssignmentScheduleInstanceFilter class.
        /// </summary>
        /// <param name="principalId">Returns role assignment schedule
        /// instances of the specific principal.</param>
        /// <param name="roleDefinitionId">Returns role assignment schedule
        /// instances of the specific role definition.</param>
        /// <param name="status">Returns role assignment schedule instances of
        /// the specific status.</param>
        /// <param name="roleAssignmentScheduleId">Returns role assignment
        /// schedule instances belonging to a specific role assignment
        /// schedule.</param>
        public RoleAssignmentScheduleInstanceFilter(string principalId = default(string), string roleDefinitionId = default(string), string status = default(string), string roleAssignmentScheduleId = default(string))
        {
            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
            Status = status;
            RoleAssignmentScheduleId = roleAssignmentScheduleId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets returns role assignment schedule instances of the
        /// specific principal.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets returns role assignment schedule instances of the
        /// specific role definition.
        /// </summary>
        [JsonProperty(PropertyName = "roleDefinitionId")]
        public string RoleDefinitionId { get; set; }

        /// <summary>
        /// Gets or sets returns role assignment schedule instances of the
        /// specific status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets returns role assignment schedule instances belonging
        /// to a specific role assignment schedule.
        /// </summary>
        [JsonProperty(PropertyName = "roleAssignmentScheduleId")]
        public string RoleAssignmentScheduleId { get; set; }

    }
}
