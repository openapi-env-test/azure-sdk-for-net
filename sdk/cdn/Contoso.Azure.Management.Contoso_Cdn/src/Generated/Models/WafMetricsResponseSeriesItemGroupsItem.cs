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

    public partial class WafMetricsResponseSeriesItemGroupsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// WafMetricsResponseSeriesItemGroupsItem class.
        /// </summary>
        public WafMetricsResponseSeriesItemGroupsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// WafMetricsResponseSeriesItemGroupsItem class.
        /// </summary>
        public WafMetricsResponseSeriesItemGroupsItem(string name = default(string), string value = default(string))
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
