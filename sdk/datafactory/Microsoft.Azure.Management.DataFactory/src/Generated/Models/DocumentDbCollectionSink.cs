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
    /// A copy activity Document Database Collection sink.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DocumentDbCollectionSink")]
    public partial class DocumentDbCollectionSink : CopySink
    {
        /// <summary>
        /// Initializes a new instance of the DocumentDbCollectionSink class.
        /// </summary>
        public DocumentDbCollectionSink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DocumentDbCollectionSink class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="writeBatchSize">Write batch size. Type: integer (or
        /// Expression with resultType integer), minimum: 0.</param>
        /// <param name="writeBatchTimeout">Write batch timeout. Type: string
        /// (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="sinkRetryCount">Sink retry count. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="sinkRetryWait">Sink retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the sink data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="disableMetricsCollection">If true, disable data store
        /// metrics collection. Default is false. Type: boolean (or Expression
        /// with resultType boolean).</param>
        /// <param name="nestingSeparator">Nested properties separator. Default
        /// is . (dot). Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="writeBehavior">Describes how to write data to Azure
        /// Cosmos DB. Type: string (or Expression with resultType string).
        /// Allowed values: insert and upsert.</param>
        public DocumentDbCollectionSink(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object writeBatchSize = default(object), object writeBatchTimeout = default(object), object sinkRetryCount = default(object), object sinkRetryWait = default(object), object maxConcurrentConnections = default(object), object disableMetricsCollection = default(object), object nestingSeparator = default(object), object writeBehavior = default(object))
            : base(additionalProperties, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection)
        {
            NestingSeparator = nestingSeparator;
            WriteBehavior = writeBehavior;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets nested properties separator. Default is . (dot). Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "nestingSeparator")]
        public object NestingSeparator { get; set; }

        /// <summary>
        /// Gets or sets describes how to write data to Azure Cosmos DB. Type:
        /// string (or Expression with resultType string). Allowed values:
        /// insert and upsert.
        /// </summary>
        [JsonProperty(PropertyName = "writeBehavior")]
        public object WriteBehavior { get; set; }

    }
}
