// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureData.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UsageUploadRequest
    {
        /// <summary>
        /// Initializes a new instance of the UsageUploadRequest class.
        /// </summary>
        public UsageUploadRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageUploadRequest class.
        /// </summary>
        public UsageUploadRequest(string exportType = default(string), System.DateTime? dataTimestamp = default(System.DateTime?), IList<UsageRecord> data = default(IList<UsageRecord>), string signature = default(string))
        {
            ExportType = exportType;
            DataTimestamp = dataTimestamp;
            Data = data;
            Signature = signature;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exportType")]
        public string ExportType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataTimestamp")]
        public System.DateTime? DataTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<UsageRecord> Data { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signature")]
        public string Signature { get; set; }

    }
}
