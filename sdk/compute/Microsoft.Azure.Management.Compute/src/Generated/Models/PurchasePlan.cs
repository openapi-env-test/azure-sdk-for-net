// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Used for establishing the purchase context of any 3rd Party artifact
    /// through MarketPlace.
    /// </summary>
    public partial class PurchasePlan
    {
        /// <summary>
        /// Initializes a new instance of the PurchasePlan class.
        /// </summary>
        public PurchasePlan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PurchasePlan class.
        /// </summary>
        /// <param name="name">The plan ID.</param>
        /// <param name="publisher">The publisher ID.</param>
        /// <param name="product">Specifies the product of the image from the
        /// marketplace. This is the same value as Offer under the
        /// imageReference element.</param>
        /// <param name="promotionCode">The Offer Promotion Code.</param>
        public PurchasePlan(string name, string publisher, string product, string promotionCode = default(string))
        {
            Name = name;
            Publisher = publisher;
            Product = product;
            PromotionCode = promotionCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the plan ID.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the publisher ID.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets specifies the product of the image from the
        /// marketplace. This is the same value as Offer under the
        /// imageReference element.
        /// </summary>
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets the Offer Promotion Code.
        /// </summary>
        [JsonProperty(PropertyName = "promotionCode")]
        public string PromotionCode { get; set; }

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
            if (Publisher == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Publisher");
            }
            if (Product == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Product");
            }
        }
    }
}
