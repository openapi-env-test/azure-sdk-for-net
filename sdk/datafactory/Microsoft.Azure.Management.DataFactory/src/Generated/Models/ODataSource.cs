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
    /// A copy activity source for OData source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ODataSource")]
    public partial class ODataSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the ODataSource class.
        /// </summary>
        public ODataSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataSource class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the source data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="disableMetricsCollection">If true, disable data store
        /// metrics collection. Default is false. Type: boolean (or Expression
        /// with resultType boolean).</param>
        /// <param name="query">OData query. For example, "$top=1". Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="httpRequestTimeout">The timeout (TimeSpan) to get an
        /// HTTP response. It is the timeout to get a response, not the timeout
        /// to read response data. Default value: 00:05:00. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="additionalColumns">Specifies the additional columns to
        /// be added to source data. Type: array of objects(AdditionalColumns)
        /// (or Expression with resultType array of objects).</param>
        public ODataSource(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object disableMetricsCollection = default(object), object query = default(object), object httpRequestTimeout = default(object), object additionalColumns = default(object))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection)
        {
            Query = query;
            HttpRequestTimeout = httpRequestTimeout;
            AdditionalColumns = additionalColumns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets oData query. For example, "$top=1". Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public object Query { get; set; }

        /// <summary>
        /// Gets or sets the timeout (TimeSpan) to get an HTTP response. It is
        /// the timeout to get a response, not the timeout to read response
        /// data. Default value: 00:05:00. Type: string (or Expression with
        /// resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "httpRequestTimeout")]
        public object HttpRequestTimeout { get; set; }

        /// <summary>
        /// Gets or sets specifies the additional columns to be added to source
        /// data. Type: array of objects(AdditionalColumns) (or Expression with
        /// resultType array of objects).
        /// </summary>
        [JsonProperty(PropertyName = "additionalColumns")]
        public object AdditionalColumns { get; set; }

    }
}
