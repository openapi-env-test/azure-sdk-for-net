// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The replication policy rule between two containers.
    /// </summary>
    public partial class ObjectReplicationPolicyRule
    {
        /// <summary>
        /// Initializes a new instance of the ObjectReplicationPolicyRule
        /// class.
        /// </summary>
        public ObjectReplicationPolicyRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ObjectReplicationPolicyRule
        /// class.
        /// </summary>
        /// <param name="sourceContainer">Required. Source container
        /// name.</param>
        /// <param name="destinationContainer">Required. Destination container
        /// name.</param>
        /// <param name="ruleId">Rule Id is auto-generated for each new rule on
        /// destination account. It is required for put policy on source
        /// account.</param>
        /// <param name="filters">Optional. An object that defines the filter
        /// set.</param>
        public ObjectReplicationPolicyRule(string sourceContainer, string destinationContainer, string ruleId = default(string), ObjectReplicationPolicyFilter filters = default(ObjectReplicationPolicyFilter))
        {
            RuleId = ruleId;
            SourceContainer = sourceContainer;
            DestinationContainer = destinationContainer;
            Filters = filters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets rule Id is auto-generated for each new rule on
        /// destination account. It is required for put policy on source
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "ruleId")]
        public string RuleId { get; set; }

        /// <summary>
        /// Gets or sets required. Source container name.
        /// </summary>
        [JsonProperty(PropertyName = "sourceContainer")]
        public string SourceContainer { get; set; }

        /// <summary>
        /// Gets or sets required. Destination container name.
        /// </summary>
        [JsonProperty(PropertyName = "destinationContainer")]
        public string DestinationContainer { get; set; }

        /// <summary>
        /// Gets or sets optional. An object that defines the filter set.
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public ObjectReplicationPolicyFilter Filters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceContainer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceContainer");
            }
            if (DestinationContainer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DestinationContainer");
            }
        }
    }
}
