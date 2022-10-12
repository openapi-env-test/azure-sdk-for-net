// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class ArtifactDeploymentStatusProperties
    {
        internal static ArtifactDeploymentStatusProperties DeserializeArtifactDeploymentStatusProperties(JsonElement element)
        {
            Optional<string> deploymentStatus = default;
            Optional<int> artifactsApplied = default;
            Optional<int> totalArtifacts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentStatus"))
                {
                    deploymentStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactsApplied"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    artifactsApplied = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalArtifacts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalArtifacts = property.Value.GetInt32();
                    continue;
                }
            }
            return new ArtifactDeploymentStatusProperties(deploymentStatus.Value, Optional.ToNullable(artifactsApplied), Optional.ToNullable(totalArtifacts));
        }
    }
}
