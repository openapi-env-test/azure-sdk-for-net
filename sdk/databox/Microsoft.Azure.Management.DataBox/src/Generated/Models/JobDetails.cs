// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Job details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("JobDetails")]
    public partial class JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the JobDetails class.
        /// </summary>
        public JobDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobDetails class.
        /// </summary>
        /// <param name="contactDetails">Contact details for notification and
        /// shipping.</param>
        /// <param name="jobStages">List of stages that run in the job.</param>
        /// <param name="shippingAddress">Shipping address of the
        /// customer.</param>
        /// <param name="deliveryPackage">Delivery package shipping
        /// details.</param>
        /// <param name="returnPackage">Return package shipping
        /// details.</param>
        /// <param name="dataImportDetails">Details of the data to be imported
        /// into azure.</param>
        /// <param name="dataExportDetails">Details of the data to be exported
        /// from azure.</param>
        /// <param name="preferences">Preferences for the order.</param>
        /// <param name="copyLogDetails">List of copy log details.</param>
        /// <param name="reverseShipmentLabelSasKey">Shared access key to
        /// download the return shipment label</param>
        /// <param name="chainOfCustodySasKey">Shared access key to download
        /// the chain of custody logs</param>
        /// <param name="keyEncryptionKey">Details about which key encryption
        /// type is being used.</param>
        /// <param name="expectedDataSizeInTeraBytes">The expected size of the
        /// data, which needs to be transferred in this job, in
        /// terabytes.</param>
        public JobDetails(ContactDetails contactDetails, IList<JobStages> jobStages = default(IList<JobStages>), ShippingAddress shippingAddress = default(ShippingAddress), PackageShippingDetails deliveryPackage = default(PackageShippingDetails), PackageShippingDetails returnPackage = default(PackageShippingDetails), IList<DataImportDetails> dataImportDetails = default(IList<DataImportDetails>), IList<DataExportDetails> dataExportDetails = default(IList<DataExportDetails>), Preferences preferences = default(Preferences), IList<CopyLogDetails> copyLogDetails = default(IList<CopyLogDetails>), string reverseShipmentLabelSasKey = default(string), string chainOfCustodySasKey = default(string), KeyEncryptionKey keyEncryptionKey = default(KeyEncryptionKey), int? expectedDataSizeInTeraBytes = default(int?))
        {
            JobStages = jobStages;
            ContactDetails = contactDetails;
            ShippingAddress = shippingAddress;
            DeliveryPackage = deliveryPackage;
            ReturnPackage = returnPackage;
            DataImportDetails = dataImportDetails;
            DataExportDetails = dataExportDetails;
            Preferences = preferences;
            CopyLogDetails = copyLogDetails;
            ReverseShipmentLabelSasKey = reverseShipmentLabelSasKey;
            ChainOfCustodySasKey = chainOfCustodySasKey;
            KeyEncryptionKey = keyEncryptionKey;
            ExpectedDataSizeInTeraBytes = expectedDataSizeInTeraBytes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of stages that run in the job.
        /// </summary>
        [JsonProperty(PropertyName = "jobStages")]
        public IList<JobStages> JobStages { get; private set; }

        /// <summary>
        /// Gets or sets contact details for notification and shipping.
        /// </summary>
        [JsonProperty(PropertyName = "contactDetails")]
        public ContactDetails ContactDetails { get; set; }

        /// <summary>
        /// Gets or sets shipping address of the customer.
        /// </summary>
        [JsonProperty(PropertyName = "shippingAddress")]
        public ShippingAddress ShippingAddress { get; set; }

        /// <summary>
        /// Gets delivery package shipping details.
        /// </summary>
        [JsonProperty(PropertyName = "deliveryPackage")]
        public PackageShippingDetails DeliveryPackage { get; private set; }

        /// <summary>
        /// Gets return package shipping details.
        /// </summary>
        [JsonProperty(PropertyName = "returnPackage")]
        public PackageShippingDetails ReturnPackage { get; private set; }

        /// <summary>
        /// Gets or sets details of the data to be imported into azure.
        /// </summary>
        [JsonProperty(PropertyName = "dataImportDetails")]
        public IList<DataImportDetails> DataImportDetails { get; set; }

        /// <summary>
        /// Gets or sets details of the data to be exported from azure.
        /// </summary>
        [JsonProperty(PropertyName = "dataExportDetails")]
        public IList<DataExportDetails> DataExportDetails { get; set; }

        /// <summary>
        /// Gets or sets preferences for the order.
        /// </summary>
        [JsonProperty(PropertyName = "preferences")]
        public Preferences Preferences { get; set; }

        /// <summary>
        /// Gets list of copy log details.
        /// </summary>
        [JsonProperty(PropertyName = "copyLogDetails")]
        public IList<CopyLogDetails> CopyLogDetails { get; private set; }

        /// <summary>
        /// Gets shared access key to download the return shipment label
        /// </summary>
        [JsonProperty(PropertyName = "reverseShipmentLabelSasKey")]
        public string ReverseShipmentLabelSasKey { get; private set; }

        /// <summary>
        /// Gets shared access key to download the chain of custody logs
        /// </summary>
        [JsonProperty(PropertyName = "chainOfCustodySasKey")]
        public string ChainOfCustodySasKey { get; private set; }

        /// <summary>
        /// Gets or sets details about which key encryption type is being used.
        /// </summary>
        [JsonProperty(PropertyName = "keyEncryptionKey")]
        public KeyEncryptionKey KeyEncryptionKey { get; set; }

        /// <summary>
        /// Gets or sets the expected size of the data, which needs to be
        /// transferred in this job, in terabytes.
        /// </summary>
        [JsonProperty(PropertyName = "expectedDataSizeInTeraBytes")]
        public int? ExpectedDataSizeInTeraBytes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContactDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContactDetails");
            }
            if (ContactDetails != null)
            {
                ContactDetails.Validate();
            }
            if (ShippingAddress != null)
            {
                ShippingAddress.Validate();
            }
            if (DataImportDetails != null)
            {
                foreach (var element in DataImportDetails)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (DataExportDetails != null)
            {
                foreach (var element1 in DataExportDetails)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Preferences != null)
            {
                Preferences.Validate();
            }
            if (KeyEncryptionKey != null)
            {
                KeyEncryptionKey.Validate();
            }
        }
    }
}
