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
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EntityQueryItemPropertiesDataTypesItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EntityQueryItemPropertiesDataTypesItem class.
        /// </summary>
        public EntityQueryItemPropertiesDataTypesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// EntityQueryItemPropertiesDataTypesItem class.
        /// </summary>
        /// <param name="dataType">Data type name</param>
        public EntityQueryItemPropertiesDataTypesItem(string dataType = default(string))
        {
            DataType = dataType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets data type name
        /// </summary>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }

    }
}
