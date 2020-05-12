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
    /// A copy activity Salesforce Service Cloud sink.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SalesforceServiceCloudSink")]
    public partial class SalesforceServiceCloudSink : CopySink
    {
        /// <summary>
        /// Initializes a new instance of the SalesforceServiceCloudSink class.
        /// </summary>
        public SalesforceServiceCloudSink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SalesforceServiceCloudSink class.
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
        /// <param name="writeBehavior">The write behavior for the operation.
        /// Default is Insert. Possible values include: 'Insert',
        /// 'Upsert'</param>
        /// <param name="externalIdFieldName">The name of the external ID field
        /// for upsert operation. Default value is 'Id' column. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="ignoreNullValues">The flag indicating whether or not
        /// to ignore null values from input dataset (except key fields) during
        /// write operation. Default value is false. If set it to true, it
        /// means ADF will leave the data in the destination object unchanged
        /// when doing upsert/update operation and insert defined default value
        /// when doing insert operation, versus ADF will update the data in the
        /// destination object to NULL when doing upsert/update operation and
        /// insert NULL value when doing insert operation. Type: boolean (or
        /// Expression with resultType boolean).</param>
        public SalesforceServiceCloudSink(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object writeBatchSize = default(object), object writeBatchTimeout = default(object), object sinkRetryCount = default(object), object sinkRetryWait = default(object), object maxConcurrentConnections = default(object), string writeBehavior = default(string), object externalIdFieldName = default(object), object ignoreNullValues = default(object))
            : base(additionalProperties, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections)
        {
            WriteBehavior = writeBehavior;
            ExternalIdFieldName = externalIdFieldName;
            IgnoreNullValues = ignoreNullValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the write behavior for the operation. Default is
        /// Insert. Possible values include: 'Insert', 'Upsert'
        /// </summary>
        [JsonProperty(PropertyName = "writeBehavior")]
        public string WriteBehavior { get; set; }

        /// <summary>
        /// Gets or sets the name of the external ID field for upsert
        /// operation. Default value is 'Id' column. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "externalIdFieldName")]
        public object ExternalIdFieldName { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether or not to ignore null
        /// values from input dataset (except key fields) during write
        /// operation. Default value is false. If set it to true, it means ADF
        /// will leave the data in the destination object unchanged when doing
        /// upsert/update operation and insert defined default value when doing
        /// insert operation, versus ADF will update the data in the
        /// destination object to NULL when doing upsert/update operation and
        /// insert NULL value when doing insert operation. Type: boolean (or
        /// Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "ignoreNullValues")]
        public object IgnoreNullValues { get; set; }

    }
}
