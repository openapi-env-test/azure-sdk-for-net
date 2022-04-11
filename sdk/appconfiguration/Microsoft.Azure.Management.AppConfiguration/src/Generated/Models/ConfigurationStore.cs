// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppConfiguration.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration store along with all resource properties. The
    /// Configuration Store will have all information to begin utilizing it.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConfigurationStore : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the ConfigurationStore class.
        /// </summary>
        public ConfigurationStore()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConfigurationStore class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="sku">The sku of the configuration store.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="identity">The managed identity information, if
        /// configured.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// configuration store. Possible values include: 'Creating',
        /// 'Updating', 'Deleting', 'Succeeded', 'Failed', 'Canceled'</param>
        /// <param name="creationDate">The creation date of configuration
        /// store.</param>
        /// <param name="endpoint">The DNS endpoint where the configuration
        /// store API will be available.</param>
        /// <param name="encryption">The encryption settings of the
        /// configuration store.</param>
        /// <param name="privateEndpointConnections">The list of private
        /// endpoint connections that are set up for this resource.</param>
        /// <param name="publicNetworkAccess">Control permission for data plane
        /// traffic coming from public networks while private endpoint is
        /// enabled. Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="disableLocalAuth">Disables all authentication methods
        /// other than AAD authentication.</param>
        /// <param name="softDeleteRetentionInDays">The amount of time in days
        /// that the configuration store will be retained when it is soft
        /// deleted.</param>
        /// <param name="enablePurgeProtection">Property specifying whether
        /// protection against purge is enabled for this configuration
        /// store.</param>
        /// <param name="createMode">Indicates whether the configuration store
        /// need to be recovered. Possible values include: 'Recover',
        /// 'Default'</param>
        /// <param name="systemData">Resource system metadata.</param>
        public ConfigurationStore(string location, Sku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ResourceIdentity identity = default(ResourceIdentity), string provisioningState = default(string), System.DateTime? creationDate = default(System.DateTime?), string endpoint = default(string), EncryptionProperties encryption = default(EncryptionProperties), IList<PrivateEndpointConnectionReference> privateEndpointConnections = default(IList<PrivateEndpointConnectionReference>), string publicNetworkAccess = default(string), bool? disableLocalAuth = default(bool?), int? softDeleteRetentionInDays = default(int?), bool? enablePurgeProtection = default(bool?), CreateMode? createMode = default(CreateMode?), SystemData systemData = default(SystemData))
            : base(location, id, name, type, tags)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            CreationDate = creationDate;
            Endpoint = endpoint;
            Encryption = encryption;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            DisableLocalAuth = disableLocalAuth;
            SoftDeleteRetentionInDays = softDeleteRetentionInDays;
            EnablePurgeProtection = enablePurgeProtection;
            CreateMode = createMode;
            Sku = sku;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the managed identity information, if configured.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ResourceIdentity Identity { get; set; }

        /// <summary>
        /// Gets the provisioning state of the configuration store. Possible
        /// values include: 'Creating', 'Updating', 'Deleting', 'Succeeded',
        /// 'Failed', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the creation date of configuration store.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets the DNS endpoint where the configuration store API will be
        /// available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoint")]
        public string Endpoint { get; private set; }

        /// <summary>
        /// Gets or sets the encryption settings of the configuration store.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public EncryptionProperties Encryption { get; set; }

        /// <summary>
        /// Gets the list of private endpoint connections that are set up for
        /// this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnectionReference> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets or sets control permission for data plane traffic coming from
        /// public networks while private endpoint is enabled. Possible values
        /// include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets disables all authentication methods other than AAD
        /// authentication.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disableLocalAuth")]
        public bool? DisableLocalAuth { get; set; }

        /// <summary>
        /// Gets or sets the amount of time in days that the configuration
        /// store will be retained when it is soft deleted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.softDeleteRetentionInDays")]
        public int? SoftDeleteRetentionInDays { get; set; }

        /// <summary>
        /// Gets or sets property specifying whether protection against purge
        /// is enabled for this configuration store.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enablePurgeProtection")]
        public bool? EnablePurgeProtection { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the configuration store need to be
        /// recovered. Possible values include: 'Recover', 'Default'
        /// </summary>
        [JsonProperty(PropertyName = "properties.createMode")]
        public CreateMode? CreateMode { get; set; }

        /// <summary>
        /// Gets or sets the sku of the configuration store.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets resource system metadata.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (PrivateEndpointConnections != null)
            {
                foreach (var element in PrivateEndpointConnections)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
