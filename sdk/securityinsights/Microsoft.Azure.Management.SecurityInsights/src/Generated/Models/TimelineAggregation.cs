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
    /// timeline aggregation information per kind
    /// </summary>
    public partial class TimelineAggregation
    {
        /// <summary>
        /// Initializes a new instance of the TimelineAggregation class.
        /// </summary>
        public TimelineAggregation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimelineAggregation class.
        /// </summary>
        /// <param name="count">the total items found for a kind</param>
        /// <param name="kind">the query kind. Possible values include:
        /// 'Activity', 'Bookmark', 'SecurityAlert'</param>
        public TimelineAggregation(int count, string kind)
        {
            Count = count;
            Kind = kind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the total items found for a kind
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the query kind. Possible values include: 'Activity',
        /// 'Bookmark', 'SecurityAlert'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Kind == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Kind");
            }
        }
    }
}
