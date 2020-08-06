// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Identity Provider details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IdentityProviderContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IdentityProviderContract class.
        /// </summary>
        public IdentityProviderContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentityProviderContract class.
        /// </summary>
        /// <param name="clientId">Client Id of the Application in the external
        /// Identity Provider. It is App ID for Facebook login, Client ID for
        /// Google login, App ID for Microsoft.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type for API Management
        /// resource.</param>
        /// <param name="identityProviderContractType">Identity Provider Type
        /// identifier. Possible values include: 'facebook', 'google',
        /// 'microsoft', 'twitter', 'aad', 'aadB2C'</param>
        /// <param name="signinTenant">The TenantId to use instead of Common
        /// when logging into Active Directory</param>
        /// <param name="allowedTenants">List of Allowed Tenants when
        /// configuring Azure Active Directory login.</param>
        /// <param name="authority">OpenID Connect discovery endpoint hostname
        /// for AAD or AAD B2C.</param>
        /// <param name="signupPolicyName">Signup Policy Name. Only applies to
        /// AAD B2C Identity Provider.</param>
        /// <param name="signinPolicyName">Signin Policy Name. Only applies to
        /// AAD B2C Identity Provider.</param>
        /// <param name="profileEditingPolicyName">Profile Editing Policy Name.
        /// Only applies to AAD B2C Identity Provider.</param>
        /// <param name="passwordResetPolicyName">Password Reset Policy Name.
        /// Only applies to AAD B2C Identity Provider.</param>
        /// <param name="clientSecret">Client secret of the Application in
        /// external Identity Provider, used to authenticate login request. For
        /// example, it is App Secret for Facebook login, API Key for Google
        /// login, Public Key for Microsoft. This property will not be filled
        /// on 'GET' operations! Use '/listSecrets' POST request to get the
        /// value.</param>
        public IdentityProviderContract(string clientId, string id = default(string), string name = default(string), string type = default(string), string identityProviderContractType = default(string), string signinTenant = default(string), IList<string> allowedTenants = default(IList<string>), string authority = default(string), string signupPolicyName = default(string), string signinPolicyName = default(string), string profileEditingPolicyName = default(string), string passwordResetPolicyName = default(string), string clientSecret = default(string))
            : base(id, name, type)
        {
            IdentityProviderContractType = identityProviderContractType;
            SigninTenant = signinTenant;
            AllowedTenants = allowedTenants;
            Authority = authority;
            SignupPolicyName = signupPolicyName;
            SigninPolicyName = signinPolicyName;
            ProfileEditingPolicyName = profileEditingPolicyName;
            PasswordResetPolicyName = passwordResetPolicyName;
            ClientId = clientId;
            ClientSecret = clientSecret;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identity Provider Type identifier. Possible values
        /// include: 'facebook', 'google', 'microsoft', 'twitter', 'aad',
        /// 'aadB2C'
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public string IdentityProviderContractType { get; set; }

        /// <summary>
        /// Gets or sets the TenantId to use instead of Common when logging
        /// into Active Directory
        /// </summary>
        [JsonProperty(PropertyName = "properties.signinTenant")]
        public string SigninTenant { get; set; }

        /// <summary>
        /// Gets or sets list of Allowed Tenants when configuring Azure Active
        /// Directory login.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedTenants")]
        public IList<string> AllowedTenants { get; set; }

        /// <summary>
        /// Gets or sets openID Connect discovery endpoint hostname for AAD or
        /// AAD B2C.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authority")]
        public string Authority { get; set; }

        /// <summary>
        /// Gets or sets signup Policy Name. Only applies to AAD B2C Identity
        /// Provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.signupPolicyName")]
        public string SignupPolicyName { get; set; }

        /// <summary>
        /// Gets or sets signin Policy Name. Only applies to AAD B2C Identity
        /// Provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.signinPolicyName")]
        public string SigninPolicyName { get; set; }

        /// <summary>
        /// Gets or sets profile Editing Policy Name. Only applies to AAD B2C
        /// Identity Provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.profileEditingPolicyName")]
        public string ProfileEditingPolicyName { get; set; }

        /// <summary>
        /// Gets or sets password Reset Policy Name. Only applies to AAD B2C
        /// Identity Provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.passwordResetPolicyName")]
        public string PasswordResetPolicyName { get; set; }

        /// <summary>
        /// Gets or sets client Id of the Application in the external Identity
        /// Provider. It is App ID for Facebook login, Client ID for Google
        /// login, App ID for Microsoft.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets client secret of the Application in external Identity
        /// Provider, used to authenticate login request. For example, it is
        /// App Secret for Facebook login, API Key for Google login, Public Key
        /// for Microsoft. This property will not be filled on 'GET'
        /// operations! Use '/listSecrets' POST request to get the value.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ClientId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClientId");
            }
            if (AllowedTenants != null)
            {
                if (AllowedTenants.Count > 32)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "AllowedTenants", 32);
                }
            }
            if (SignupPolicyName != null)
            {
                if (SignupPolicyName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SignupPolicyName", 1);
                }
            }
            if (SigninPolicyName != null)
            {
                if (SigninPolicyName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SigninPolicyName", 1);
                }
            }
            if (ProfileEditingPolicyName != null)
            {
                if (ProfileEditingPolicyName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ProfileEditingPolicyName", 1);
                }
            }
            if (PasswordResetPolicyName != null)
            {
                if (PasswordResetPolicyName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "PasswordResetPolicyName", 1);
                }
            }
            if (ClientId != null)
            {
                if (ClientId.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ClientId", 1);
                }
            }
            if (ClientSecret != null)
            {
                if (ClientSecret.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ClientSecret", 1);
                }
            }
        }
    }
}
