// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The relevant Role Assignments. </summary>
    internal partial class SqlRoleAssignmentListResult
    {
        /// <summary> Initializes a new instance of SqlRoleAssignmentListResult. </summary>
        internal SqlRoleAssignmentListResult()
        {
            Value = new ChangeTrackingList<SqlRoleAssignmentGetResults>();
        }

        /// <summary> Initializes a new instance of SqlRoleAssignmentListResult. </summary>
        /// <param name="value"> List of Role Assignments and their properties. </param>
        internal SqlRoleAssignmentListResult(IReadOnlyList<SqlRoleAssignmentGetResults> value)
        {
            Value = value;
        }

        /// <summary> List of Role Assignments and their properties. </summary>
        public IReadOnlyList<SqlRoleAssignmentGetResults> Value { get; }
    }
}
