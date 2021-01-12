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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Input of CheckNameAvailability API.
    /// </summary>
    public partial class CheckNameAvailabilityInput
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityInput class.
        /// </summary>
        public CheckNameAvailabilityInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityInput class.
        /// </summary>
        /// <param name="name">The resource name to validate.</param>
        public CheckNameAvailabilityInput(string name)
        {
            Name = name;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for CheckNameAvailabilityInput class.
        /// </summary>
        static CheckNameAvailabilityInput()
        {
            Type = "Microsoft.Cdn/Profiles/Endpoints";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource name to validate.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of the resource whose name is to be validated.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

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
        }
    }
}
