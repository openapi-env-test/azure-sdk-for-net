// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the AuthorizationProviderContract data model.
    /// Authorization Provider contract.
    /// </summary>
    public partial class AuthorizationProviderContractData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AuthorizationProviderContractData"/>. </summary>
        public AuthorizationProviderContractData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AuthorizationProviderContractData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Authorization Provider name. Must be 1 to 300 characters long. </param>
        /// <param name="identityProvider"> Identity provider name. Must be 1 to 300 characters long. </param>
        /// <param name="oauth2"> OAuth2 settings. </param>
        internal AuthorizationProviderContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string identityProvider, AuthorizationProviderOAuth2Settings oauth2) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            IdentityProvider = identityProvider;
            Oauth2 = oauth2;
        }

        /// <summary> Authorization Provider name. Must be 1 to 300 characters long. </summary>
        public string DisplayName { get; set; }
        /// <summary> Identity provider name. Must be 1 to 300 characters long. </summary>
        public string IdentityProvider { get; set; }
        /// <summary> OAuth2 settings. </summary>
        public AuthorizationProviderOAuth2Settings Oauth2 { get; set; }
    }
}
