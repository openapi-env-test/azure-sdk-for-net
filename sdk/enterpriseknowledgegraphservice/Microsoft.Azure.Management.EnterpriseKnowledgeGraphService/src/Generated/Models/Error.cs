// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EnterpriseKnowledgeGraphService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// EnterpriseKnowledgeGraph Service error object.
    /// </summary>
    public partial class Error
    {
        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        public Error()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        /// <param name="errorProperty">The error body.</param>
        public Error(ErrorBody errorProperty = default(ErrorBody))
        {
            ErrorProperty = errorProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the error body.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorBody ErrorProperty { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ErrorProperty != null)
            {
                ErrorProperty.Validate();
            }
        }
    }
}
