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
    /// Azure blobFS write settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureBlobFSWriteSettings")]
    public partial class AzureBlobFSWriteSettings : StoreWriteSettings
    {
        /// <summary>
        /// Initializes a new instance of the AzureBlobFSWriteSettings class.
        /// </summary>
        public AzureBlobFSWriteSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureBlobFSWriteSettings class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the source data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="disableMetricsCollection">If true, disable data store
        /// metrics collection. Default is false. Type: boolean (or Expression
        /// with resultType boolean).</param>
        /// <param name="copyBehavior">The type of copy behavior for copy
        /// sink.</param>
        /// <param name="blockSizeInMB">Indicates the block size(MB) when
        /// writing data to blob. Type: integer (or Expression with resultType
        /// integer).</param>
        public AzureBlobFSWriteSettings(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object maxConcurrentConnections = default(object), object disableMetricsCollection = default(object), object copyBehavior = default(object), object blockSizeInMB = default(object))
            : base(additionalProperties, maxConcurrentConnections, disableMetricsCollection, copyBehavior)
        {
            BlockSizeInMB = blockSizeInMB;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates the block size(MB) when writing data to
        /// blob. Type: integer (or Expression with resultType integer).
        /// </summary>
        [JsonProperty(PropertyName = "blockSizeInMB")]
        public object BlockSizeInMB { get; set; }

    }
}
