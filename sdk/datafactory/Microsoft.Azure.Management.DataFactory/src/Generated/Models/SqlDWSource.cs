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
    /// A copy activity SQL Data Warehouse source.
    /// </summary>
    public partial class SqlDWSource : TabularSource
    {
        /// <summary>
        /// Initializes a new instance of the SqlDWSource class.
        /// </summary>
        public SqlDWSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlDWSource class.
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
        /// <param name="queryTimeout">Query timeout. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="additionalColumns">Specifies the additional columns to
        /// be added to source data. Type: array of objects (or Expression with
        /// resultType array of objects).</param>
        /// <param name="sqlReaderQuery">SQL Data Warehouse reader query. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="sqlReaderStoredProcedureName">Name of the stored
        /// procedure for a SQL Data Warehouse source. This cannot be used at
        /// the same time as SqlReaderQuery. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="storedProcedureParameters">Value and type setting for
        /// stored procedure parameters. Example: "{Parameter1: {value: "1",
        /// type: "int"}}". Type: object (or Expression with resultType
        /// object), itemType: StoredProcedureParameter.</param>
        /// <param name="partitionOption">The partition mechanism that will be
        /// used for Sql read in parallel. Possible values include: "None",
        /// "PhysicalPartitionsOfTable", "DynamicRange".</param>
        /// <param name="partitionSettings">The settings that will be leveraged
        /// for Sql source partitioning.</param>
        public SqlDWSource(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object queryTimeout = default(object), IList<AdditionalColumns> additionalColumns = default(IList<AdditionalColumns>), object sqlReaderQuery = default(object), object sqlReaderStoredProcedureName = default(object), object storedProcedureParameters = default(object), object partitionOption = default(object), SqlPartitionSettings partitionSettings = default(SqlPartitionSettings))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, queryTimeout, additionalColumns)
        {
            SqlReaderQuery = sqlReaderQuery;
            SqlReaderStoredProcedureName = sqlReaderStoredProcedureName;
            StoredProcedureParameters = storedProcedureParameters;
            PartitionOption = partitionOption;
            PartitionSettings = partitionSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SQL Data Warehouse reader query. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "sqlReaderQuery")]
        public object SqlReaderQuery { get; set; }

        /// <summary>
        /// Gets or sets name of the stored procedure for a SQL Data Warehouse
        /// source. This cannot be used at the same time as SqlReaderQuery.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "sqlReaderStoredProcedureName")]
        public object SqlReaderStoredProcedureName { get; set; }

        /// <summary>
        /// Gets or sets value and type setting for stored procedure
        /// parameters. Example: "{Parameter1: {value: "1", type: "int"}}".
        /// Type: object (or Expression with resultType object), itemType:
        /// StoredProcedureParameter.
        /// </summary>
        [JsonProperty(PropertyName = "storedProcedureParameters")]
        public object StoredProcedureParameters { get; set; }

        /// <summary>
        /// Gets or sets the partition mechanism that will be used for Sql read
        /// in parallel. Possible values include: "None",
        /// "PhysicalPartitionsOfTable", "DynamicRange".
        /// </summary>
        [JsonProperty(PropertyName = "partitionOption")]
        public object PartitionOption { get; set; }

        /// <summary>
        /// Gets or sets the settings that will be leveraged for Sql source
        /// partitioning.
        /// </summary>
        [JsonProperty(PropertyName = "partitionSettings")]
        public SqlPartitionSettings PartitionSettings { get; set; }

    }
}
