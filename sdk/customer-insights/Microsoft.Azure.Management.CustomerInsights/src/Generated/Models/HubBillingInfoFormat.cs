// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Hub billing info.
    /// </summary>
    public partial class HubBillingInfoFormat
    {
        /// <summary>
        /// Initializes a new instance of the HubBillingInfoFormat class.
        /// </summary>
        public HubBillingInfoFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HubBillingInfoFormat class.
        /// </summary>
        /// <param name="skuName">The sku name.</param>
        /// <param name="minUnits">The minimum number of units will be billed.
        /// One unit is 10,000 Profiles and 100,000 Interactions.</param>
        /// <param name="maxUnits">The maximum number of units can be used.
        /// One unit is 10,000 Profiles and 100,000 Interactions.</param>
        public HubBillingInfoFormat(string skuName = default(string), int? minUnits = default(int?), int? maxUnits = default(int?))
        {
            SkuName = skuName;
            MinUnits = minUnits;
            MaxUnits = maxUnits;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the sku name.
        /// </summary>
        [JsonProperty(PropertyName = "skuName")]
        public string SkuName { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of units will be billed. One unit
        /// is 10,000 Profiles and 100,000 Interactions.
        /// </summary>
        [JsonProperty(PropertyName = "minUnits")]
        public int? MinUnits { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of units can be used.  One unit is
        /// 10,000 Profiles and 100,000 Interactions.
        /// </summary>
        [JsonProperty(PropertyName = "maxUnits")]
        public int? MaxUnits { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MinUnits > 10)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MinUnits", 10);
            }
            if (MinUnits < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinUnits", 1);
            }
            if (MaxUnits > 10)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxUnits", 10);
            }
            if (MaxUnits < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxUnits", 1);
            }
        }
    }
}
