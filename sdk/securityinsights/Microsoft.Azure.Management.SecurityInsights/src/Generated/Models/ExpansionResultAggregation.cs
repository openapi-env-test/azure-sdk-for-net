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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information of a specific aggregation in the expansion result.
    /// </summary>
    public partial class ExpansionResultAggregation
    {
        /// <summary>
        /// Initializes a new instance of the ExpansionResultAggregation class.
        /// </summary>
        public ExpansionResultAggregation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpansionResultAggregation class.
        /// </summary>
        /// <param name="count">Total number of aggregations of the given kind
        /// (and aggregationType if given) in the expansion result.</param>
        /// <param name="entityKind">The kind of the aggregated entity.
        /// Possible values include: 'Account', 'Host', 'File',
        /// 'AzureResource', 'CloudApplication', 'DnsResolution', 'FileHash',
        /// 'Ip', 'Malware', 'Process', 'RegistryKey', 'RegistryValue',
        /// 'SecurityGroup', 'Url', 'IoTDevice', 'SecurityAlert', 'Bookmark',
        /// 'MailCluster', 'MailMessage', 'Mailbox', 'SubmissionMail'</param>
        /// <param name="aggregationType">The common type of the aggregation.
        /// (for e.g. entity field name)</param>
        /// <param name="displayName">The display name of the aggregation by
        /// type.</param>
        public ExpansionResultAggregation(int count, string entityKind, string aggregationType = default(string), string displayName = default(string))
        {
            AggregationType = aggregationType;
            Count = count;
            DisplayName = displayName;
            EntityKind = entityKind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the common type of the aggregation. (for e.g. entity
        /// field name)
        /// </summary>
        [JsonProperty(PropertyName = "aggregationType")]
        public string AggregationType { get; set; }

        /// <summary>
        /// Gets or sets total number of aggregations of the given kind (and
        /// aggregationType if given) in the expansion result.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the display name of the aggregation by type.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the kind of the aggregated entity. Possible values
        /// include: 'Account', 'Host', 'File', 'AzureResource',
        /// 'CloudApplication', 'DnsResolution', 'FileHash', 'Ip', 'Malware',
        /// 'Process', 'RegistryKey', 'RegistryValue', 'SecurityGroup', 'Url',
        /// 'IoTDevice', 'SecurityAlert', 'Bookmark', 'MailCluster',
        /// 'MailMessage', 'Mailbox', 'SubmissionMail'
        /// </summary>
        [JsonProperty(PropertyName = "entityKind")]
        public string EntityKind { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EntityKind == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EntityKind");
            }
        }
    }
}
