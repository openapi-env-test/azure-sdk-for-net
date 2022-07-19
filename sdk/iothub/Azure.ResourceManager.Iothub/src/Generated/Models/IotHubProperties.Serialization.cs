// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Iothub;

namespace Azure.ResourceManager.Iothub.Models
{
    public partial class IotHubProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AuthorizationPolicies))
            {
                writer.WritePropertyName("authorizationPolicies");
                writer.WriteStartArray();
                foreach (var item in AuthorizationPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth");
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (Optional.IsDefined(DisableDeviceSAS))
            {
                writer.WritePropertyName("disableDeviceSAS");
                writer.WriteBooleanValue(DisableDeviceSAS.Value);
            }
            if (Optional.IsDefined(DisableModuleSAS))
            {
                writer.WritePropertyName("disableModuleSAS");
                writer.WriteBooleanValue(DisableModuleSAS.Value);
            }
            if (Optional.IsDefined(RestrictOutboundNetworkAccess))
            {
                writer.WritePropertyName("restrictOutboundNetworkAccess");
                writer.WriteBooleanValue(RestrictOutboundNetworkAccess.Value);
            }
            if (Optional.IsCollectionDefined(AllowedFqdnList))
            {
                writer.WritePropertyName("allowedFqdnList");
                writer.WriteStartArray();
                foreach (var item in AllowedFqdnList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IPFilterRules))
            {
                writer.WritePropertyName("ipFilterRules");
                writer.WriteStartArray();
                foreach (var item in IPFilterRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkRuleSets))
            {
                writer.WritePropertyName("networkRuleSets");
                writer.WriteObjectValue(NetworkRuleSets);
            }
            if (Optional.IsDefined(MinTlsVersion))
            {
                writer.WritePropertyName("minTlsVersion");
                writer.WriteStringValue(MinTlsVersion);
            }
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections");
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EventHubEndpoints))
            {
                writer.WritePropertyName("eventHubEndpoints");
                writer.WriteStartObject();
                foreach (var item in EventHubEndpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Routing))
            {
                writer.WritePropertyName("routing");
                writer.WriteObjectValue(Routing);
            }
            if (Optional.IsCollectionDefined(StorageEndpoints))
            {
                writer.WritePropertyName("storageEndpoints");
                writer.WriteStartObject();
                foreach (var item in StorageEndpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(MessagingEndpoints))
            {
                writer.WritePropertyName("messagingEndpoints");
                writer.WriteStartObject();
                foreach (var item in MessagingEndpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(EnableFileUploadNotifications))
            {
                writer.WritePropertyName("enableFileUploadNotifications");
                writer.WriteBooleanValue(EnableFileUploadNotifications.Value);
            }
            if (Optional.IsDefined(CloudToDevice))
            {
                writer.WritePropertyName("cloudToDevice");
                writer.WriteObjectValue(CloudToDevice);
            }
            if (Optional.IsDefined(Comments))
            {
                writer.WritePropertyName("comments");
                writer.WriteStringValue(Comments);
            }
            if (Optional.IsDefined(Features))
            {
                writer.WritePropertyName("features");
                writer.WriteStringValue(Features.Value.ToString());
            }
            if (Optional.IsDefined(EnableDataResidency))
            {
                writer.WritePropertyName("enableDataResidency");
                writer.WriteBooleanValue(EnableDataResidency.Value);
            }
            if (Optional.IsDefined(RootCertificate))
            {
                writer.WritePropertyName("rootCertificate");
                writer.WriteObjectValue(RootCertificate);
            }
            writer.WriteEndObject();
        }

        internal static IotHubProperties DeserializeIotHubProperties(JsonElement element)
        {
            Optional<IList<SharedAccessSignatureAuthorizationRule>> authorizationPolicies = default;
            Optional<bool> disableLocalAuth = default;
            Optional<bool> disableDeviceSAS = default;
            Optional<bool> disableModuleSAS = default;
            Optional<bool> restrictOutboundNetworkAccess = default;
            Optional<IList<string>> allowedFqdnList = default;
            Optional<PublicNetworkAccess> publicNetworkAccess = default;
            Optional<IList<IPFilterRule>> ipFilterRules = default;
            Optional<NetworkRuleSetProperties> networkRuleSets = default;
            Optional<string> minTlsVersion = default;
            Optional<IList<IothubPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<string> provisioningState = default;
            Optional<string> state = default;
            Optional<string> hostName = default;
            Optional<IDictionary<string, EventHubProperties>> eventHubEndpoints = default;
            Optional<RoutingProperties> routing = default;
            Optional<IDictionary<string, StorageEndpointProperties>> storageEndpoints = default;
            Optional<IDictionary<string, MessagingEndpointProperties>> messagingEndpoints = default;
            Optional<bool> enableFileUploadNotifications = default;
            Optional<CloudToDeviceProperties> cloudToDevice = default;
            Optional<string> comments = default;
            Optional<Capability> features = default;
            Optional<IReadOnlyList<IotHubLocationDescription>> locations = default;
            Optional<bool> enableDataResidency = default;
            Optional<RootCertificateProperties> rootCertificate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizationPolicies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SharedAccessSignatureAuthorizationRule> array = new List<SharedAccessSignatureAuthorizationRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SharedAccessSignatureAuthorizationRule.DeserializeSharedAccessSignatureAuthorizationRule(item));
                    }
                    authorizationPolicies = array;
                    continue;
                }
                if (property.NameEquals("disableLocalAuth"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableLocalAuth = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableDeviceSAS"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableDeviceSAS = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableModuleSAS"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableModuleSAS = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("restrictOutboundNetworkAccess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    restrictOutboundNetworkAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedFqdnList"))
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
                    allowedFqdnList = array;
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    publicNetworkAccess = new PublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipFilterRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IPFilterRule> array = new List<IPFilterRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPFilterRule.DeserializeIPFilterRule(item));
                    }
                    ipFilterRules = array;
                    continue;
                }
                if (property.NameEquals("networkRuleSets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    networkRuleSets = NetworkRuleSetProperties.DeserializeNetworkRuleSetProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("minTlsVersion"))
                {
                    minTlsVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IothubPrivateEndpointConnectionData> array = new List<IothubPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IothubPrivateEndpointConnectionData.DeserializeIothubPrivateEndpointConnectionData(item));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventHubEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, EventHubProperties> dictionary = new Dictionary<string, EventHubProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EventHubProperties.DeserializeEventHubProperties(property0.Value));
                    }
                    eventHubEndpoints = dictionary;
                    continue;
                }
                if (property.NameEquals("routing"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    routing = RoutingProperties.DeserializeRoutingProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("storageEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, StorageEndpointProperties> dictionary = new Dictionary<string, StorageEndpointProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, StorageEndpointProperties.DeserializeStorageEndpointProperties(property0.Value));
                    }
                    storageEndpoints = dictionary;
                    continue;
                }
                if (property.NameEquals("messagingEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, MessagingEndpointProperties> dictionary = new Dictionary<string, MessagingEndpointProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MessagingEndpointProperties.DeserializeMessagingEndpointProperties(property0.Value));
                    }
                    messagingEndpoints = dictionary;
                    continue;
                }
                if (property.NameEquals("enableFileUploadNotifications"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableFileUploadNotifications = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloudToDevice"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cloudToDevice = CloudToDeviceProperties.DeserializeCloudToDeviceProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("comments"))
                {
                    comments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("features"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    features = new Capability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("locations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IotHubLocationDescription> array = new List<IotHubLocationDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubLocationDescription.DeserializeIotHubLocationDescription(item));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("enableDataResidency"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableDataResidency = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rootCertificate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rootCertificate = RootCertificateProperties.DeserializeRootCertificateProperties(property.Value);
                    continue;
                }
            }
            return new IotHubProperties(Optional.ToList(authorizationPolicies), Optional.ToNullable(disableLocalAuth), Optional.ToNullable(disableDeviceSAS), Optional.ToNullable(disableModuleSAS), Optional.ToNullable(restrictOutboundNetworkAccess), Optional.ToList(allowedFqdnList), Optional.ToNullable(publicNetworkAccess), Optional.ToList(ipFilterRules), networkRuleSets.Value, minTlsVersion.Value, Optional.ToList(privateEndpointConnections), provisioningState.Value, state.Value, hostName.Value, Optional.ToDictionary(eventHubEndpoints), routing.Value, Optional.ToDictionary(storageEndpoints), Optional.ToDictionary(messagingEndpoints), Optional.ToNullable(enableFileUploadNotifications), cloudToDevice.Value, comments.Value, Optional.ToNullable(features), Optional.ToList(locations), Optional.ToNullable(enableDataResidency), rootCertificate.Value);
        }
    }
}
