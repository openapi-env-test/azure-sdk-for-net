// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A billing subscription.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BillingSubscription : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BillingSubscription class.
        /// </summary>
        public BillingSubscription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingSubscription class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">The name of the subscription.</param>
        /// <param name="subscriptionId">The ID of the subscription.</param>
        /// <param name="subscriptionBillingStatus">The current billing status
        /// of the subscription. Possible values include: 'Active', 'Inactive',
        /// 'Abandoned', 'Deleted', 'Warning'</param>
        /// <param name="lastMonthCharges">The last month charges.</param>
        /// <param name="monthToDateCharges">The current month to date
        /// charges.</param>
        /// <param name="billingProfileId">The ID of the billing profile to
        /// which the subscription is billed.</param>
        /// <param name="billingProfileDisplayName">The name of the billing
        /// profile to which the subscription is billed.</param>
        /// <param name="costCenter">The cost center applied to the
        /// subscription.</param>
        /// <param name="customerId">The ID of the customer for whom the
        /// subscription was created. The field is applicable only for
        /// Microsoft Partner Agreement billing account.</param>
        /// <param name="customerDisplayName">The name of the customer for whom
        /// the subscription was created. The field is applicable only for
        /// Microsoft Partner Agreement billing account.</param>
        /// <param name="invoiceSectionId">The ID of the invoice section to
        /// which the subscription is billed.</param>
        /// <param name="invoiceSectionDisplayName">The name of the invoice
        /// section to which the subscription is billed.</param>
        /// <param name="reseller">Reseller for this subscription.</param>
        /// <param name="skuId">The sku ID of the Azure plan for the
        /// subscription.</param>
        /// <param name="skuDescription">The sku description of the Azure plan
        /// for the subscription.</param>
        /// <param name="suspensionReasons">The suspension reason for a
        /// subscription. Applies only to subscriptions in Microsoft Online
        /// Services Program billing accounts.</param>
        public BillingSubscription(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), System.Guid? subscriptionId = default(System.Guid?), string subscriptionBillingStatus = default(string), Amount lastMonthCharges = default(Amount), Amount monthToDateCharges = default(Amount), string billingProfileId = default(string), string billingProfileDisplayName = default(string), string costCenter = default(string), string customerId = default(string), string customerDisplayName = default(string), string invoiceSectionId = default(string), string invoiceSectionDisplayName = default(string), Reseller reseller = default(Reseller), string skuId = default(string), string skuDescription = default(string), IList<string> suspensionReasons = default(IList<string>))
            : base(id, name, type)
        {
            DisplayName = displayName;
            SubscriptionId = subscriptionId;
            SubscriptionBillingStatus = subscriptionBillingStatus;
            LastMonthCharges = lastMonthCharges;
            MonthToDateCharges = monthToDateCharges;
            BillingProfileId = billingProfileId;
            BillingProfileDisplayName = billingProfileDisplayName;
            CostCenter = costCenter;
            CustomerId = customerId;
            CustomerDisplayName = customerDisplayName;
            InvoiceSectionId = invoiceSectionId;
            InvoiceSectionDisplayName = invoiceSectionDisplayName;
            Reseller = reseller;
            SkuId = skuId;
            SkuDescription = skuDescription;
            SuspensionReasons = suspensionReasons;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the ID of the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public System.Guid? SubscriptionId { get; private set; }

        /// <summary>
        /// Gets or sets the current billing status of the subscription.
        /// Possible values include: 'Active', 'Inactive', 'Abandoned',
        /// 'Deleted', 'Warning'
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionBillingStatus")]
        public string SubscriptionBillingStatus { get; set; }

        /// <summary>
        /// Gets the last month charges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastMonthCharges")]
        public Amount LastMonthCharges { get; private set; }

        /// <summary>
        /// Gets the current month to date charges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.monthToDateCharges")]
        public Amount MonthToDateCharges { get; private set; }

        /// <summary>
        /// Gets the ID of the billing profile to which the subscription is
        /// billed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileId")]
        public string BillingProfileId { get; private set; }

        /// <summary>
        /// Gets the name of the billing profile to which the subscription is
        /// billed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileDisplayName")]
        public string BillingProfileDisplayName { get; private set; }

        /// <summary>
        /// Gets or sets the cost center applied to the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.costCenter")]
        public string CostCenter { get; set; }

        /// <summary>
        /// Gets the ID of the customer for whom the subscription was created.
        /// The field is applicable only for Microsoft Partner Agreement
        /// billing account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerId")]
        public string CustomerId { get; private set; }

        /// <summary>
        /// Gets the name of the customer for whom the subscription was
        /// created. The field is applicable only for Microsoft Partner
        /// Agreement billing account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerDisplayName")]
        public string CustomerDisplayName { get; private set; }

        /// <summary>
        /// Gets the ID of the invoice section to which the subscription is
        /// billed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionId")]
        public string InvoiceSectionId { get; private set; }

        /// <summary>
        /// Gets the name of the invoice section to which the subscription is
        /// billed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionDisplayName")]
        public string InvoiceSectionDisplayName { get; private set; }

        /// <summary>
        /// Gets reseller for this subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reseller")]
        public Reseller Reseller { get; private set; }

        /// <summary>
        /// Gets or sets the sku ID of the Azure plan for the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuId")]
        public string SkuId { get; set; }

        /// <summary>
        /// Gets the sku description of the Azure plan for the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuDescription")]
        public string SkuDescription { get; private set; }

        /// <summary>
        /// Gets the suspension reason for a subscription. Applies only to
        /// subscriptions in Microsoft Online Services Program billing
        /// accounts.
        /// </summary>
        [JsonProperty(PropertyName = "properties.suspensionReasons")]
        public IList<string> SuspensionReasons { get; private set; }

    }
}
