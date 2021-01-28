// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Contoso.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents MDATP (Microsoft Defender Advanced Threat Protection)
    /// requirements check request.
    /// </summary>
    [Newtonsoft.Json.JsonObject("MicrosoftDefenderAdvancedThreatProtection")]
    [Rest.Serialization.JsonTransformation]
    public partial class MDATPCheckRequirements : DataConnectorsCheckRequirements
    {
        /// <summary>
        /// Initializes a new instance of the MDATPCheckRequirements class.
        /// </summary>
        public MDATPCheckRequirements()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MDATPCheckRequirements class.
        /// </summary>
        /// <param name="tenantId">The tenant id to connect to, and get the
        /// data from.</param>
        public MDATPCheckRequirements(string tenantId = default(string))
        {
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tenant id to connect to, and get the data from.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; set; }

    }
}
