// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The list of available versions for an agent pool. </summary>
    public partial class AgentPoolAvailableVersions
    {
        /// <summary> Initializes a new instance of AgentPoolAvailableVersions. </summary>
        internal AgentPoolAvailableVersions()
        {
            AgentPoolVersions = new ChangeTrackingList<AgentPoolAvailableVersionsPropertiesAgentPoolVersionsItem>();
        }

        /// <summary> Initializes a new instance of AgentPoolAvailableVersions. </summary>
        /// <param name="id"> Id of the agent pool available versions. </param>
        /// <param name="name"> Name of the agent pool available versions. </param>
        /// <param name="type"> Type of the agent pool  available versions. </param>
        /// <param name="agentPoolVersions"> List of versions available for agent pool. </param>
        internal AgentPoolAvailableVersions(string id, string name, string type, IReadOnlyList<AgentPoolAvailableVersionsPropertiesAgentPoolVersionsItem> agentPoolVersions)
        {
            Id = id;
            Name = name;
            Type = type;
            AgentPoolVersions = agentPoolVersions;
        }

        /// <summary> Id of the agent pool available versions. </summary>
        public string Id { get; }
        /// <summary> Name of the agent pool available versions. </summary>
        public string Name { get; }
        /// <summary> Type of the agent pool  available versions. </summary>
        public string Type { get; }
        /// <summary> List of versions available for agent pool. </summary>
        public IReadOnlyList<AgentPoolAvailableVersionsPropertiesAgentPoolVersionsItem> AgentPoolVersions { get; }
    }
}
