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
    using System.Linq;

    /// <summary>
    /// Transformation for data flow source.
    /// </summary>
    public partial class DataFlowSource : Transformation
    {
        /// <summary>
        /// Initializes a new instance of the DataFlowSource class.
        /// </summary>
        public DataFlowSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataFlowSource class.
        /// </summary>
        /// <param name="name">Transformation name.</param>
        /// <param name="description">Transformation description.</param>
        /// <param name="dataset">Dataset reference.</param>
        public DataFlowSource(string name, string description = default(string), DatasetReference dataset = default(DatasetReference))
            : base(name, description)
        {
            Dataset = dataset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets dataset reference.
        /// </summary>
        [JsonProperty(PropertyName = "dataset")]
        public DatasetReference Dataset { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Dataset != null)
            {
                Dataset.Validate();
            }
        }
    }
}
