// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Iothub.Models
{
    /// <summary> The properties for a group information object. </summary>
    public partial class GroupIdInformationProperties
    {
        /// <summary> Initializes a new instance of GroupIdInformationProperties. </summary>
        internal GroupIdInformationProperties()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of GroupIdInformationProperties. </summary>
        /// <param name="groupId"> The group id. </param>
        /// <param name="requiredMembers"> The required members for a specific group id. </param>
        /// <param name="requiredZoneNames"> The required DNS zones for a specific group id. </param>
        internal GroupIdInformationProperties(string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> The group id. </summary>
        public string GroupId { get; }
        /// <summary> The required members for a specific group id. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The required DNS zones for a specific group id. </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
    }
}
