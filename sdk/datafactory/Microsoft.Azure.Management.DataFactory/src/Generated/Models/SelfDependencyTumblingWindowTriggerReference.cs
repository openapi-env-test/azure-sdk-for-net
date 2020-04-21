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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Self referenced tumbling window trigger dependency.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SelfDependencyTumblingWindowTriggerReference")]
    public partial class SelfDependencyTumblingWindowTriggerReference : DependencyReference
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SelfDependencyTumblingWindowTriggerReference class.
        /// </summary>
        public SelfDependencyTumblingWindowTriggerReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SelfDependencyTumblingWindowTriggerReference class.
        /// </summary>
        /// <param name="offset">Timespan applied to the start time of a
        /// tumbling window when evaluating dependency.</param>
        /// <param name="size">The size of the window when evaluating the
        /// dependency. If undefined the frequency of the tumbling window will
        /// be used.</param>
        public SelfDependencyTumblingWindowTriggerReference(string offset, string size = default(string))
        {
            Offset = offset;
            Size = size;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets timespan applied to the start time of a tumbling
        /// window when evaluating dependency.
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public string Offset { get; set; }

        /// <summary>
        /// Gets or sets the size of the window when evaluating the dependency.
        /// If undefined the frequency of the tumbling window will be used.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Offset == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Offset");
            }
            if (Offset != null)
            {
                if (Offset.Length > 15)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Offset", 15);
                }
                if (Offset.Length < 8)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Offset", 8);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(Offset, "-((\\d+)\\.)?(\\d\\d):(60|([0-5][0-9])):(60|([0-5][0-9]))"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Offset", "-((\\d+)\\.)?(\\d\\d):(60|([0-5][0-9])):(60|([0-5][0-9]))");
                }
            }
            if (Size != null)
            {
                if (Size.Length > 15)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Size", 15);
                }
                if (Size.Length < 8)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Size", 8);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(Size, "((\\d+)\\.)?(\\d\\d):(60|([0-5][0-9])):(60|([0-5][0-9]))"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Size", "((\\d+)\\.)?(\\d\\d):(60|([0-5][0-9])):(60|([0-5][0-9]))");
                }
            }
        }
    }
}
