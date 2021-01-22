// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create or update automation account
    /// operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AutomationAccountCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AutomationAccountCreateOrUpdateParameters class.
        /// </summary>
        public AutomationAccountCreateOrUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AutomationAccountCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="sku">Gets or sets account SKU.</param>
        /// <param name="encryption">Set the encryption properties for the
        /// automation account</param>
        /// <param name="name">Gets or sets name of the resource.</param>
        /// <param name="location">Gets or sets the location of the
        /// resource.</param>
        /// <param name="identity">Sets the identity property for automation
        /// account</param>
        /// <param name="tags">Gets or sets the tags attached to the
        /// resource.</param>
        public AutomationAccountCreateOrUpdateParameters(Sku sku = default(Sku), EncryptionProperties encryption = default(EncryptionProperties), string name = default(string), string location = default(string), Identity identity = default(Identity), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Sku = sku;
            Encryption = encryption;
            Name = name;
            Location = location;
            Identity = identity;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets account SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets set the encryption properties for the automation
        /// account
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public EncryptionProperties Encryption { get; set; }

        /// <summary>
        /// Gets or sets name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets sets the identity property for automation account
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets the tags attached to the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
