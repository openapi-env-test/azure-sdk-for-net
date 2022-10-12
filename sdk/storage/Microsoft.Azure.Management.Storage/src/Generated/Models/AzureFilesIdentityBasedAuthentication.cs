// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Settings for Azure Files identity based authentication.
    /// </summary>
    public partial class AzureFilesIdentityBasedAuthentication
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureFilesIdentityBasedAuthentication class.
        /// </summary>
        public AzureFilesIdentityBasedAuthentication()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureFilesIdentityBasedAuthentication class.
        /// </summary>
        /// <param name="directoryServiceOptions">Indicates the directory
        /// service used. Note that this enum may be extended in the future.
        /// Possible values include: 'None', 'AADDS', 'AD', 'AADKERB'</param>
        /// <param name="activeDirectoryProperties">Required if
        /// directoryServiceOptions are AD, optional if they are
        /// AADKERB.</param>
        /// <param name="defaultSharePermission">Default share permission for
        /// users using Kerberos authentication if RBAC role is not assigned.
        /// Possible values include: 'None', 'StorageFileDataSmbShareReader',
        /// 'StorageFileDataSmbShareContributor',
        /// 'StorageFileDataSmbShareElevatedContributor'</param>
        public AzureFilesIdentityBasedAuthentication(string directoryServiceOptions, ActiveDirectoryProperties activeDirectoryProperties = default(ActiveDirectoryProperties), string defaultSharePermission = default(string))
        {
            DirectoryServiceOptions = directoryServiceOptions;
            ActiveDirectoryProperties = activeDirectoryProperties;
            DefaultSharePermission = defaultSharePermission;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates the directory service used. Note that this
        /// enum may be extended in the future. Possible values include:
        /// 'None', 'AADDS', 'AD', 'AADKERB'
        /// </summary>
        [JsonProperty(PropertyName = "directoryServiceOptions")]
        public string DirectoryServiceOptions { get; set; }

        /// <summary>
        /// Gets or sets required if directoryServiceOptions are AD, optional
        /// if they are AADKERB.
        /// </summary>
        [JsonProperty(PropertyName = "activeDirectoryProperties")]
        public ActiveDirectoryProperties ActiveDirectoryProperties { get; set; }

        /// <summary>
        /// Gets or sets default share permission for users using Kerberos
        /// authentication if RBAC role is not assigned. Possible values
        /// include: 'None', 'StorageFileDataSmbShareReader',
        /// 'StorageFileDataSmbShareContributor',
        /// 'StorageFileDataSmbShareElevatedContributor'
        /// </summary>
        [JsonProperty(PropertyName = "defaultSharePermission")]
        public string DefaultSharePermission { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DirectoryServiceOptions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DirectoryServiceOptions");
            }
            if (ActiveDirectoryProperties != null)
            {
                ActiveDirectoryProperties.Validate();
            }
        }
    }
}
