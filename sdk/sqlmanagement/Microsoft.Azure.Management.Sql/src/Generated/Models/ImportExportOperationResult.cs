// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An ImportExport operation result resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ImportExportOperationResult : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ImportExportOperationResult
        /// class.
        /// </summary>
        public ImportExportOperationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportExportOperationResult
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="requestId">Request Id.</param>
        /// <param name="requestType">Request type.</param>
        /// <param name="queuedTime">Queued time.</param>
        /// <param name="lastModifiedTime">Last modified time.</param>
        /// <param name="blobUri">Blob Uri.</param>
        /// <param name="serverName">Server name.</param>
        /// <param name="databaseName">Database name.</param>
        /// <param name="status">Operation status.</param>
        /// <param name="errorMessage">Error message.</param>
        public ImportExportOperationResult(string id = default(string), string name = default(string), string type = default(string), System.Guid? requestId = default(System.Guid?), string requestType = default(string), string queuedTime = default(string), string lastModifiedTime = default(string), string blobUri = default(string), string serverName = default(string), string databaseName = default(string), string status = default(string), string errorMessage = default(string))
            : base(id, name, type)
        {
            RequestId = requestId;
            RequestType = requestType;
            QueuedTime = queuedTime;
            LastModifiedTime = lastModifiedTime;
            BlobUri = blobUri;
            ServerName = serverName;
            DatabaseName = databaseName;
            Status = status;
            ErrorMessage = errorMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets request Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestId")]
        public System.Guid? RequestId { get; private set; }

        /// <summary>
        /// Gets request type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestType")]
        public string RequestType { get; private set; }

        /// <summary>
        /// Gets queued time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.queuedTime")]
        public string QueuedTime { get; private set; }

        /// <summary>
        /// Gets last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public string LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets blob Uri.
        /// </summary>
        [JsonProperty(PropertyName = "properties.blobUri")]
        public string BlobUri { get; private set; }

        /// <summary>
        /// Gets server name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverName")]
        public string ServerName { get; private set; }

        /// <summary>
        /// Gets database name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseName")]
        public string DatabaseName { get; private set; }

        /// <summary>
        /// Gets operation status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets error message.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorMessage")]
        public string ErrorMessage { get; private set; }

    }
}
