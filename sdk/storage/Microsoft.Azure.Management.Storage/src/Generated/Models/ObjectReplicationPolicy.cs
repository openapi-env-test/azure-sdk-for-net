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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The replication policy between two storage accounts. Multiple rules can
    /// be defined in one policy.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ObjectReplicationPolicy : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ObjectReplicationPolicy class.
        /// </summary>
        public ObjectReplicationPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ObjectReplicationPolicy class.
        /// </summary>
        /// <param name="sourceAccount">Required. Source account name.</param>
        /// <param name="destinationAccount">Required. Destination account
        /// name.</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="policyId">A unique id for object replication
        /// policy.</param>
        /// <param name="enabledTime">Indicates when the policy is enabled on
        /// the source account.</param>
        /// <param name="rules">The storage account object replication
        /// rules.</param>
        public ObjectReplicationPolicy(string sourceAccount, string destinationAccount, string id = default(string), string name = default(string), string type = default(string), string policyId = default(string), System.DateTime? enabledTime = default(System.DateTime?), IList<ObjectReplicationPolicyRule> rules = default(IList<ObjectReplicationPolicyRule>))
            : base(id, name, type)
        {
            PolicyId = policyId;
            EnabledTime = enabledTime;
            SourceAccount = sourceAccount;
            DestinationAccount = destinationAccount;
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a unique id for object replication policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policyId")]
        public string PolicyId { get; private set; }

        /// <summary>
        /// Gets indicates when the policy is enabled on the source account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabledTime")]
        public System.DateTime? EnabledTime { get; private set; }

        /// <summary>
        /// Gets or sets required. Source account name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceAccount")]
        public string SourceAccount { get; set; }

        /// <summary>
        /// Gets or sets required. Destination account name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationAccount")]
        public string DestinationAccount { get; set; }

        /// <summary>
        /// Gets or sets the storage account object replication rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rules")]
        public IList<ObjectReplicationPolicyRule> Rules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceAccount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceAccount");
            }
            if (DestinationAccount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DestinationAccount");
            }
            if (Rules != null)
            {
                foreach (var element in Rules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
