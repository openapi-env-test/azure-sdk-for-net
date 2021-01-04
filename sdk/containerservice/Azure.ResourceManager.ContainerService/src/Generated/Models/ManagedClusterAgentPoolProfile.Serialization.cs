// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterAgentPoolProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count");
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize");
                writer.WriteStringValue(VmSize.Value.ToString());
            }
            if (Optional.IsDefined(OsDiskSizeGB))
            {
                writer.WritePropertyName("osDiskSizeGB");
                writer.WriteNumberValue(OsDiskSizeGB.Value);
            }
            if (Optional.IsDefined(OsDiskType))
            {
                writer.WritePropertyName("osDiskType");
                writer.WriteStringValue(OsDiskType.Value.ToString());
            }
            if (Optional.IsDefined(KubeletDiskType))
            {
                writer.WritePropertyName("kubeletDiskType");
                writer.WriteStringValue(KubeletDiskType.Value.ToString());
            }
            if (Optional.IsDefined(VnetSubnetID))
            {
                writer.WritePropertyName("vnetSubnetID");
                writer.WriteStringValue(VnetSubnetID);
            }
            if (Optional.IsDefined(PodSubnetID))
            {
                writer.WritePropertyName("podSubnetID");
                writer.WriteStringValue(PodSubnetID);
            }
            if (Optional.IsDefined(MaxPods))
            {
                writer.WritePropertyName("maxPods");
                writer.WriteNumberValue(MaxPods.Value);
            }
            if (Optional.IsDefined(OsType))
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OsType.Value.ToString());
            }
            if (Optional.IsDefined(MaxCount))
            {
                writer.WritePropertyName("maxCount");
                writer.WriteNumberValue(MaxCount.Value);
            }
            if (Optional.IsDefined(MinCount))
            {
                writer.WritePropertyName("minCount");
                writer.WriteNumberValue(MinCount.Value);
            }
            if (Optional.IsDefined(EnableAutoScaling))
            {
                writer.WritePropertyName("enableAutoScaling");
                writer.WriteBooleanValue(EnableAutoScaling.Value);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(OrchestratorVersion))
            {
                writer.WritePropertyName("orchestratorVersion");
                writer.WriteStringValue(OrchestratorVersion);
            }
            if (Optional.IsDefined(UpgradeSettings))
            {
                writer.WritePropertyName("upgradeSettings");
                writer.WriteObjectValue(UpgradeSettings);
            }
            if (Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones");
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableNodePublicIP))
            {
                writer.WritePropertyName("enableNodePublicIP");
                writer.WriteBooleanValue(EnableNodePublicIP.Value);
            }
            if (Optional.IsDefined(ScaleSetPriority))
            {
                writer.WritePropertyName("scaleSetPriority");
                writer.WriteStringValue(ScaleSetPriority.Value.ToString());
            }
            if (Optional.IsDefined(ScaleSetEvictionPolicy))
            {
                writer.WritePropertyName("scaleSetEvictionPolicy");
                writer.WriteStringValue(ScaleSetEvictionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(SpotMaxPrice))
            {
                writer.WritePropertyName("spotMaxPrice");
                writer.WriteNumberValue(SpotMaxPrice.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(NodeLabels))
            {
                writer.WritePropertyName("nodeLabels");
                writer.WriteStartObject();
                foreach (var item in NodeLabels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(NodeTaints))
            {
                writer.WritePropertyName("nodeTaints");
                writer.WriteStartArray();
                foreach (var item in NodeTaints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProximityPlacementGroupID))
            {
                writer.WritePropertyName("proximityPlacementGroupID");
                writer.WriteStringValue(ProximityPlacementGroupID);
            }
            if (Optional.IsDefined(KubeletConfig))
            {
                writer.WritePropertyName("kubeletConfig");
                writer.WriteObjectValue(KubeletConfig);
            }
            if (Optional.IsDefined(LinuxOSConfig))
            {
                writer.WritePropertyName("linuxOSConfig");
                writer.WriteObjectValue(LinuxOSConfig);
            }
            if (Optional.IsDefined(EnableEncryptionAtHost))
            {
                writer.WritePropertyName("enableEncryptionAtHost");
                writer.WriteBooleanValue(EnableEncryptionAtHost.Value);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterAgentPoolProfile DeserializeManagedClusterAgentPoolProfile(JsonElement element)
        {
            string name = default;
            Optional<int> count = default;
            Optional<ContainerServiceVMSizeTypes> vmSize = default;
            Optional<int> osDiskSizeGB = default;
            Optional<OSDiskType> osDiskType = default;
            Optional<KubeletDiskType> kubeletDiskType = default;
            Optional<string> vnetSubnetID = default;
            Optional<string> podSubnetID = default;
            Optional<int> maxPods = default;
            Optional<OSType> osType = default;
            Optional<int> maxCount = default;
            Optional<int> minCount = default;
            Optional<bool> enableAutoScaling = default;
            Optional<AgentPoolType> type = default;
            Optional<AgentPoolMode> mode = default;
            Optional<string> orchestratorVersion = default;
            Optional<string> nodeImageVersion = default;
            Optional<AgentPoolUpgradeSettings> upgradeSettings = default;
            Optional<string> provisioningState = default;
            Optional<PowerState> powerState = default;
            Optional<IList<string>> availabilityZones = default;
            Optional<bool> enableNodePublicIP = default;
            Optional<ScaleSetPriority> scaleSetPriority = default;
            Optional<ScaleSetEvictionPolicy> scaleSetEvictionPolicy = default;
            Optional<float> spotMaxPrice = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IDictionary<string, string>> nodeLabels = default;
            Optional<IList<string>> nodeTaints = default;
            Optional<string> proximityPlacementGroupID = default;
            Optional<KubeletConfig> kubeletConfig = default;
            Optional<LinuxOSConfig> linuxOSConfig = default;
            Optional<bool> enableEncryptionAtHost = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vmSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vmSize = new ContainerServiceVMSizeTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osDiskSizeGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osDiskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("osDiskType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osDiskType = new OSDiskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kubeletDiskType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kubeletDiskType = new KubeletDiskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vnetSubnetID"))
                {
                    vnetSubnetID = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("podSubnetID"))
                {
                    podSubnetID = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxPods"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxPods = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("osType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osType = new OSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableAutoScaling"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableAutoScaling = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new AgentPoolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mode = new AgentPoolMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("orchestratorVersion"))
                {
                    orchestratorVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeImageVersion"))
                {
                    nodeImageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    upgradeSettings = AgentPoolUpgradeSettings.DeserializeAgentPoolUpgradeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("powerState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    powerState = PowerState.DeserializePowerState(property.Value);
                    continue;
                }
                if (property.NameEquals("availabilityZones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    availabilityZones = array;
                    continue;
                }
                if (property.NameEquals("enableNodePublicIP"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableNodePublicIP = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("scaleSetPriority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scaleSetPriority = new ScaleSetPriority(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scaleSetEvictionPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scaleSetEvictionPolicy = new ScaleSetEvictionPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("spotMaxPrice"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    spotMaxPrice = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("nodeLabels"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    nodeLabels = dictionary;
                    continue;
                }
                if (property.NameEquals("nodeTaints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    nodeTaints = array;
                    continue;
                }
                if (property.NameEquals("proximityPlacementGroupID"))
                {
                    proximityPlacementGroupID = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kubeletConfig"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kubeletConfig = KubeletConfig.DeserializeKubeletConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("linuxOSConfig"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linuxOSConfig = LinuxOSConfig.DeserializeLinuxOSConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("enableEncryptionAtHost"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableEncryptionAtHost = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ManagedClusterAgentPoolProfile(Optional.ToNullable(count), Optional.ToNullable(vmSize), Optional.ToNullable(osDiskSizeGB), Optional.ToNullable(osDiskType), Optional.ToNullable(kubeletDiskType), vnetSubnetID.Value, podSubnetID.Value, Optional.ToNullable(maxPods), Optional.ToNullable(osType), Optional.ToNullable(maxCount), Optional.ToNullable(minCount), Optional.ToNullable(enableAutoScaling), Optional.ToNullable(type), Optional.ToNullable(mode), orchestratorVersion.Value, nodeImageVersion.Value, upgradeSettings.Value, provisioningState.Value, powerState.Value, Optional.ToList(availabilityZones), Optional.ToNullable(enableNodePublicIP), Optional.ToNullable(scaleSetPriority), Optional.ToNullable(scaleSetEvictionPolicy), Optional.ToNullable(spotMaxPrice), Optional.ToDictionary(tags), Optional.ToDictionary(nodeLabels), Optional.ToList(nodeTaints), proximityPlacementGroupID.Value, kubeletConfig.Value, linuxOSConfig.Value, Optional.ToNullable(enableEncryptionAtHost), name);
        }
    }
}
