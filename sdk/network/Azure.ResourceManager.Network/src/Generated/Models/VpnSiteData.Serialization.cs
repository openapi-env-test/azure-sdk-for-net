// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VpnSiteData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
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
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualWan))
            {
                writer.WritePropertyName("virtualWan");
                JsonSerializer.Serialize(writer, VirtualWan);
            }
            if (Optional.IsDefined(DeviceProperties))
            {
                writer.WritePropertyName("deviceProperties");
                writer.WriteObjectValue(DeviceProperties);
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress");
                writer.WriteStringValue(IPAddress);
            }
            if (Optional.IsDefined(SiteKey))
            {
                writer.WritePropertyName("siteKey");
                writer.WriteStringValue(SiteKey);
            }
            if (Optional.IsDefined(AddressSpace))
            {
                writer.WritePropertyName("addressSpace");
                writer.WriteObjectValue(AddressSpace);
            }
            if (Optional.IsDefined(BgpProperties))
            {
                writer.WritePropertyName("bgpProperties");
                writer.WriteObjectValue(BgpProperties);
            }
            if (Optional.IsDefined(IsSecuritySite))
            {
                writer.WritePropertyName("isSecuritySite");
                writer.WriteBooleanValue(IsSecuritySite.Value);
            }
            if (Optional.IsCollectionDefined(VpnSiteLinks))
            {
                writer.WritePropertyName("vpnSiteLinks");
                writer.WriteStartArray();
                foreach (var item in VpnSiteLinks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(O365Policy))
            {
                writer.WritePropertyName("o365Policy");
                writer.WriteObjectValue(O365Policy);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VpnSiteData DeserializeVpnSiteData(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<WritableSubResource> virtualWan = default;
            Optional<DeviceProperties> deviceProperties = default;
            Optional<string> ipAddress = default;
            Optional<string> siteKey = default;
            Optional<AddressSpace> addressSpace = default;
            Optional<BgpSettings> bgpProperties = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<bool> isSecuritySite = default;
            Optional<IList<VpnSiteLinkData>> vpnSiteLinks = default;
            Optional<O365PolicyProperties> o365Policy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualWan"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualWan = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("deviceProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deviceProperties = DeviceProperties.DeserializeDeviceProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"))
                        {
                            ipAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("siteKey"))
                        {
                            siteKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("addressSpace"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            addressSpace = AddressSpace.DeserializeAddressSpace(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("bgpProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bgpProperties = BgpSettings.DeserializeBgpSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isSecuritySite"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isSecuritySite = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("vpnSiteLinks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VpnSiteLinkData> array = new List<VpnSiteLinkData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnSiteLinkData.DeserializeVpnSiteLinkData(item));
                            }
                            vpnSiteLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("o365Policy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            o365Policy = O365PolicyProperties.DeserializeO365PolicyProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VpnSiteData(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, virtualWan, deviceProperties.Value, ipAddress.Value, siteKey.Value, addressSpace.Value, bgpProperties.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(isSecuritySite), Optional.ToList(vpnSiteLinks), o365Policy.Value);
        }
    }
}
