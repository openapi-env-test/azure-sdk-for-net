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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity Azure Data Explorer (Kusto) source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureDataExplorerSource")]
    public partial class AzureDataExplorerSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the AzureDataExplorerSource class.
        /// </summary>
        public AzureDataExplorerSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureDataExplorerSource class.
        /// </summary>
        /// <param name="query">Database query. Should be a Kusto Query
        /// Language (KQL) query. Type: string (or Expression with resultType
        /// string).</param>
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
        /// <param name="noTruncation">The name of the Boolean option that
        /// controls whether truncation is applied to result-sets that go
        /// beyond a certain row-count limit.</param>
        /// <param name="queryTimeout">Query timeout. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9]))..</param>
        /// <param name="additionalColumns">Specifies the additional columns to
        /// be added to source data. Type: array of objects(AdditionalColumns)
        /// (or Expression with resultType array of objects).</param>
        public AzureDataExplorerSource(object query, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object disableMetricsCollection = default(object), object noTruncation = default(object), object queryTimeout = default(object), object additionalColumns = default(object))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection)
        {
            Query = query;
            NoTruncation = noTruncation;
            QueryTimeout = queryTimeout;
            AdditionalColumns = additionalColumns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets database query. Should be a Kusto Query Language (KQL)
        /// query. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public object Query { get; set; }

        /// <summary>
        /// Gets or sets the name of the Boolean option that controls whether
        /// truncation is applied to result-sets that go beyond a certain
        /// row-count limit.
        /// </summary>
        [JsonProperty(PropertyName = "noTruncation")]
        public object NoTruncation { get; set; }

        /// <summary>
        /// Gets or sets query timeout. Type: string (or Expression with
        /// resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9]))..
        /// </summary>
        [JsonProperty(PropertyName = "queryTimeout")]
        public object QueryTimeout { get; set; }

        /// <summary>
        /// Gets or sets specifies the additional columns to be added to source
        /// data. Type: array of objects(AdditionalColumns) (or Expression with
        /// resultType array of objects).
        /// </summary>
        [JsonProperty(PropertyName = "additionalColumns")]
        public object AdditionalColumns { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Query == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Query");
            }
        }
    }
}
