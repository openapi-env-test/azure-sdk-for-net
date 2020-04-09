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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Detailed transfer status.
    /// </summary>
    public partial class DetailedTransferStatus
    {
        /// <summary>
        /// Initializes a new instance of the DetailedTransferStatus class.
        /// </summary>
        public DetailedTransferStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DetailedTransferStatus class.
        /// </summary>
        /// <param name="productType">Type of product that is transferred.
        /// Possible values include: 'AzureSubscription',
        /// 'AzureReservation'</param>
        /// <param name="productId">The ID of the product that is
        /// transferred.</param>
        /// <param name="transferStatus">Transfer status. Possible values
        /// include: 'NotStarted', 'InProgress', 'Completed', 'Failed'</param>
        /// <param name="errorDetails">Error details for transfer
        /// execution.</param>
        public DetailedTransferStatus(string productType = default(string), string productId = default(string), string transferStatus = default(string), Error errorDetails = default(Error))
        {
            ProductType = productType;
            ProductId = productId;
            TransferStatus = transferStatus;
            ErrorDetails = errorDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets type of product that is transferred. Possible values include:
        /// 'AzureSubscription', 'AzureReservation'
        /// </summary>
        [JsonProperty(PropertyName = "productType")]
        public string ProductType { get; private set; }

        /// <summary>
        /// Gets the ID of the product that is transferred.
        /// </summary>
        [JsonProperty(PropertyName = "productId")]
        public string ProductId { get; private set; }

        /// <summary>
        /// Gets transfer status. Possible values include: 'NotStarted',
        /// 'InProgress', 'Completed', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "transferStatus")]
        public string TransferStatus { get; private set; }

        /// <summary>
        /// Gets or sets error details for transfer execution.
        /// </summary>
        [JsonProperty(PropertyName = "errorDetails")]
        public Error ErrorDetails { get; set; }

    }
}
