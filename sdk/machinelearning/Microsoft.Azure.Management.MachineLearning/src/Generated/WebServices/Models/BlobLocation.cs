// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the access location for a blob.
    /// </summary>
    public partial class BlobLocation
    {
        /// <summary>
        /// Initializes a new instance of the BlobLocation class.
        /// </summary>
        public BlobLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobLocation class.
        /// </summary>
        /// <param name="uri">The URI from which the blob is accessible from.
        /// For example, aml://abc for system assets or https://xyz for user
        /// assets or payload.</param>
        /// <param name="credentials">Access credentials for the blob, if
        /// applicable (e.g. blob specified by storage account connection
        /// string + blob URI)</param>
        public BlobLocation(string uri, string credentials = default(string))
        {
            Uri = uri;
            Credentials = credentials;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URI from which the blob is accessible from. For
        /// example, aml://abc for system assets or https://xyz for user assets
        /// or payload.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets access credentials for the blob, if applicable (e.g.
        /// blob specified by storage account connection string + blob URI)
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public string Credentials { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Uri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Uri");
            }
        }
    }
}
