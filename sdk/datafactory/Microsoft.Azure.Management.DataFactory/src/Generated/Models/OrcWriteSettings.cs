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
    /// Orc write settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("OrcWriteSettings")]
    public partial class OrcWriteSettings : FormatWriteSettings
    {
        /// <summary>
        /// Initializes a new instance of the OrcWriteSettings class.
        /// </summary>
        public OrcWriteSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrcWriteSettings class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="maxRowsPerFile">Limit the written file's row count to
        /// be smaller than or equal to the specified count. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="fileNamePrefix">Specifies the file name pattern
        /// &lt;fileNamePrefix&gt;_&lt;fileIndex&gt;.&lt;fileExtension&gt; when
        /// copy from non-file based store without partitionOptions. Type:
        /// string (or Expression with resultType string).</param>
        public OrcWriteSettings(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object maxRowsPerFile = default(object), object fileNamePrefix = default(object))
            : base(additionalProperties)
        {
            MaxRowsPerFile = maxRowsPerFile;
            FileNamePrefix = fileNamePrefix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets limit the written file's row count to be smaller than
        /// or equal to the specified count. Type: integer (or Expression with
        /// resultType integer).
        /// </summary>
        [JsonProperty(PropertyName = "maxRowsPerFile")]
        public object MaxRowsPerFile { get; set; }

        /// <summary>
        /// Gets or sets specifies the file name pattern
        /// &amp;lt;fileNamePrefix&amp;gt;_&amp;lt;fileIndex&amp;gt;.&amp;lt;fileExtension&amp;gt;
        /// when copy from non-file based store without partitionOptions. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "fileNamePrefix")]
        public object FileNamePrefix { get; set; }

    }
}
