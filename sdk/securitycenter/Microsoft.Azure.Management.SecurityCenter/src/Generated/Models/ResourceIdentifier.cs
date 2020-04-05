// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A resource identifier for an alert which can be used to direct the
    /// alert to the right product exposure group (tenant, workspace,
    /// subscription etc.).
    /// </summary>
    public partial class ResourceIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the ResourceIdentifier class.
        /// </summary>
        public ResourceIdentifier()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceIdentifier class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        public ResourceIdentifier(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>))
        {
            AdditionalProperties = additionalProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

    }
}
