// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterUpgradeProfile
    {
        internal static ManagedClusterUpgradeProfile DeserializeManagedClusterUpgradeProfile(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            ManagedClusterPoolUpgradeProfile controlPlaneProfile = default;
            IReadOnlyList<ManagedClusterPoolUpgradeProfile> agentPoolProfiles = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("controlPlaneProfile"))
                        {
                            controlPlaneProfile = ManagedClusterPoolUpgradeProfile.DeserializeManagedClusterPoolUpgradeProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("agentPoolProfiles"))
                        {
                            List<ManagedClusterPoolUpgradeProfile> array = new List<ManagedClusterPoolUpgradeProfile>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedClusterPoolUpgradeProfile.DeserializeManagedClusterPoolUpgradeProfile(item));
                            }
                            agentPoolProfiles = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagedClusterUpgradeProfile(id.Value, name.Value, type.Value, controlPlaneProfile, agentPoolProfiles);
        }
    }
}
