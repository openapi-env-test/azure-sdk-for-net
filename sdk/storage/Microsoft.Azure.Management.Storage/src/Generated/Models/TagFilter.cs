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
    /// Tag based filtering for blob objects
    /// </summary>
    public partial class TagFilter
    {
        /// <summary>
        /// Initializes a new instance of the TagFilter class.
        /// </summary>
        public TagFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagFilter class.
        /// </summary>
        /// <param name="name">This is the filter tag name, it can have 1 - 128
        /// characters</param>
        /// <param name="op">This is the comparison operator which is used for
        /// object comparison and filtering. Only == (equality operator) is
        /// currently supported</param>
        /// <param name="value">This is the filter tag value field used for tag
        /// based filtering, it can have 1 - 256 characters</param>
        public TagFilter(string name, string op, string value)
        {
            Name = name;
            Op = op;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this is the filter tag name, it can have 1 - 128
        /// characters
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets this is the comparison operator which is used for
        /// object comparison and filtering. Only == (equality operator) is
        /// currently supported
        /// </summary>
        [JsonProperty(PropertyName = "op")]
        public string Op { get; set; }

        /// <summary>
        /// Gets or sets this is the filter tag value field used for tag based
        /// filtering, it can have 1 - 256 characters
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Op == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Op");
            }
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
            if (Name != null)
            {
                if (Name.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 128);
                }
                if (Name.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 1);
                }
            }
            if (Value != null)
            {
                if (Value.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Value", 256);
                }
                if (Value.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Value", 1);
                }
            }
        }
    }
}
