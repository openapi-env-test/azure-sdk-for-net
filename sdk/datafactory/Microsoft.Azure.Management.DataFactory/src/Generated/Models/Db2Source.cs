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
    /// A copy activity source for Db2 databases.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Db2Source")]
    public partial class Db2Source : TabularSource
    {
        /// <summary>
        /// Initializes a new instance of the Db2Source class.
        /// </summary>
        public Db2Source()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Db2Source class.
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
        /// <param name="queryTimeout">Query timeout. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="additionalColumns">Specifies the additional columns to
        /// be added to source data. Type: array of objects(AdditionalColumns)
        /// (or Expression with resultType array of objects).</param>
        /// <param name="query">Database query. Type: string (or Expression
        /// with resultType string).</param>
        public Db2Source(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object disableMetricsCollection = default(object), object queryTimeout = default(object), object additionalColumns = default(object), object query = default(object))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, queryTimeout, additionalColumns)
        {
            Query = query;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets database query. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public object Query { get; set; }

    }
}
