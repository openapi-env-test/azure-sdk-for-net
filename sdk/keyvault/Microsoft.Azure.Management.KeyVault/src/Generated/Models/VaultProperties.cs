// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of the vault
    /// </summary>
    public partial class VaultProperties
    {
        /// <summary>
        /// Initializes a new instance of the VaultProperties class.
        /// </summary>
        public VaultProperties()
        {
            Sku = new Sku();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VaultProperties class.
        /// </summary>
        /// <param name="tenantId">The Azure Active Directory tenant ID that
        /// should be used for authenticating requests to the key
        /// vault.</param>
        /// <param name="sku">SKU details</param>
        /// <param name="accessPolicies">An array of 0 to 1024 identities that
        /// have access to the key vault. All identities in the array must use
        /// the same tenant ID as the key vault's tenant ID. When `createMode`
        /// is set to `recover`, access policies are not required. Otherwise,
        /// access policies are required.</param>
        /// <param name="vaultUri">The URI of the vault for performing
        /// operations on keys and secrets.</param>
        /// <param name="enabledForDeployment">Property to specify whether
        /// Azure Virtual Machines are permitted to retrieve certificates
        /// stored as secrets from the key vault.</param>
        /// <param name="enabledForDiskEncryption">Property to specify whether
        /// Azure Disk Encryption is permitted to retrieve secrets from the
        /// vault and unwrap keys.</param>
        /// <param name="enabledForTemplateDeployment">Property to specify
        /// whether Azure Resource Manager is permitted to retrieve secrets
        /// from the key vault.</param>
        /// <param name="enableSoftDelete">Property to specify whether the
        /// 'soft delete' functionality is enabled for this key vault. It does
        /// not accept false value.</param>
        /// <param name="createMode">The vault's create mode to indicate
        /// whether the vault need to be recovered or not. Possible values
        /// include: 'recover', 'default'</param>
        /// <param name="enablePurgeProtection">Property specifying whether
        /// protection against purge is enabled for this vault. Setting this
        /// property to true activates protection against purge for this vault
        /// and its content - only the Key Vault service may initiate a hard,
        /// irrecoverable deletion. The setting is effective only if soft
        /// delete is also enabled. Enabling this functionality is irreversible
        /// - that is, the property does not accept false as its value.</param>
        /// <param name="networkAcls">Rules governing the accessibility of the
        /// key vault from specific network locations.</param>
        /// <param name="privateEndpointConnections">List of private endpoint
        /// connections associated with the key vault.</param>
        public VaultProperties(System.Guid tenantId, Sku sku, IList<AccessPolicyEntry> accessPolicies = default(IList<AccessPolicyEntry>), string vaultUri = default(string), bool? enabledForDeployment = default(bool?), bool? enabledForDiskEncryption = default(bool?), bool? enabledForTemplateDeployment = default(bool?), bool? enableSoftDelete = default(bool?), CreateMode? createMode = default(CreateMode?), bool? enablePurgeProtection = default(bool?), NetworkRuleSet networkAcls = default(NetworkRuleSet), IList<PrivateEndpointConnectionItem> privateEndpointConnections = default(IList<PrivateEndpointConnectionItem>))
        {
            TenantId = tenantId;
            Sku = sku;
            AccessPolicies = accessPolicies;
            VaultUri = vaultUri;
            EnabledForDeployment = enabledForDeployment;
            EnabledForDiskEncryption = enabledForDiskEncryption;
            EnabledForTemplateDeployment = enabledForTemplateDeployment;
            EnableSoftDelete = enableSoftDelete;
            CreateMode = createMode;
            EnablePurgeProtection = enablePurgeProtection;
            NetworkAcls = networkAcls;
            PrivateEndpointConnections = privateEndpointConnections;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Active Directory tenant ID that should be
        /// used for authenticating requests to the key vault.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid TenantId { get; set; }

        /// <summary>
        /// Gets or sets SKU details
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets an array of 0 to 1024 identities that have access to
        /// the key vault. All identities in the array must use the same tenant
        /// ID as the key vault's tenant ID. When `createMode` is set to
        /// `recover`, access policies are not required. Otherwise, access
        /// policies are required.
        /// </summary>
        [JsonProperty(PropertyName = "accessPolicies")]
        public IList<AccessPolicyEntry> AccessPolicies { get; set; }

        /// <summary>
        /// Gets or sets the URI of the vault for performing operations on keys
        /// and secrets.
        /// </summary>
        [JsonProperty(PropertyName = "vaultUri")]
        public string VaultUri { get; set; }

        /// <summary>
        /// Gets or sets property to specify whether Azure Virtual Machines are
        /// permitted to retrieve certificates stored as secrets from the key
        /// vault.
        /// </summary>
        [JsonProperty(PropertyName = "enabledForDeployment")]
        public bool? EnabledForDeployment { get; set; }

        /// <summary>
        /// Gets or sets property to specify whether Azure Disk Encryption is
        /// permitted to retrieve secrets from the vault and unwrap keys.
        /// </summary>
        [JsonProperty(PropertyName = "enabledForDiskEncryption")]
        public bool? EnabledForDiskEncryption { get; set; }

        /// <summary>
        /// Gets or sets property to specify whether Azure Resource Manager is
        /// permitted to retrieve secrets from the key vault.
        /// </summary>
        [JsonProperty(PropertyName = "enabledForTemplateDeployment")]
        public bool? EnabledForTemplateDeployment { get; set; }

        /// <summary>
        /// Gets or sets property to specify whether the 'soft delete'
        /// functionality is enabled for this key vault. It does not accept
        /// false value.
        /// </summary>
        [JsonProperty(PropertyName = "enableSoftDelete")]
        public bool? EnableSoftDelete { get; set; }

        /// <summary>
        /// Gets or sets the vault's create mode to indicate whether the vault
        /// need to be recovered or not. Possible values include: 'recover',
        /// 'default'
        /// </summary>
        [JsonProperty(PropertyName = "createMode")]
        public CreateMode? CreateMode { get; set; }

        /// <summary>
        /// Gets or sets property specifying whether protection against purge
        /// is enabled for this vault. Setting this property to true activates
        /// protection against purge for this vault and its content - only the
        /// Key Vault service may initiate a hard, irrecoverable deletion. The
        /// setting is effective only if soft delete is also enabled. Enabling
        /// this functionality is irreversible - that is, the property does not
        /// accept false as its value.
        /// </summary>
        [JsonProperty(PropertyName = "enablePurgeProtection")]
        public bool? EnablePurgeProtection { get; set; }

        /// <summary>
        /// Gets or sets rules governing the accessibility of the key vault
        /// from specific network locations.
        /// </summary>
        [JsonProperty(PropertyName = "networkAcls")]
        public NetworkRuleSet NetworkAcls { get; set; }

        /// <summary>
        /// Gets list of private endpoint connections associated with the key
        /// vault.
        /// </summary>
        [JsonProperty(PropertyName = "privateEndpointConnections")]
        public IList<PrivateEndpointConnectionItem> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (AccessPolicies != null)
            {
                foreach (var element in AccessPolicies)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
