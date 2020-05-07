// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The ZipDeflate compression read settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ZipDeflateReadSettings")]
    public partial class ZipDeflateReadSettings : CompressionReadSettings
    {
        /// <summary>
        /// Initializes a new instance of the ZipDeflateReadSettings class.
        /// </summary>
        public ZipDeflateReadSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ZipDeflateReadSettings class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="preserveZipFileNameAsFolder">Preserve the zip file
        /// name as folder path. Type: boolean (or Expression with resultType
        /// boolean).</param>
        public ZipDeflateReadSettings(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object preserveZipFileNameAsFolder = default(object))
            : base(additionalProperties)
        {
            PreserveZipFileNameAsFolder = preserveZipFileNameAsFolder;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets preserve the zip file name as folder path. Type:
        /// boolean (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "preserveZipFileNameAsFolder")]
        public object PreserveZipFileNameAsFolder { get; set; }

    }
}
