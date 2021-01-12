// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Contoso.Azure.Management.Cdn.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Output of check resource usage API.
    /// </summary>
    public partial class ResourceUsage
    {
        /// <summary>
        /// Initializes a new instance of the ResourceUsage class.
        /// </summary>
        public ResourceUsage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceUsage class.
        /// </summary>
        /// <param name="resourceType">Resource type for which the usage is
        /// provided.</param>
        /// <param name="unit">Unit of the usage. e.g. Count.</param>
        /// <param name="currentValue">Actual value of usage on the specified
        /// resource type.</param>
        /// <param name="limit">Quota of the specified resource type.</param>
        public ResourceUsage(string resourceType = default(string), string unit = default(string), int? currentValue = default(int?), int? limit = default(int?))
        {
            ResourceType = resourceType;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource type for which the usage is provided.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; private set; }

        /// <summary>
        /// Gets unit of the usage. e.g. Count.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets actual value of usage on the specified resource type.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public int? CurrentValue { get; private set; }

        /// <summary>
        /// Gets quota of the specified resource type.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; private set; }

    }
}
