// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Confluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Agreement Terms definition
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConfluentAgreementResource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the ConfluentAgreementResource class.
        /// </summary>
        public ConfluentAgreementResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConfluentAgreementResource class.
        /// </summary>
        /// <param name="id">The ARM id of the resource.</param>
        /// <param name="name">The name of the agreement.</param>
        /// <param name="type">The type of the agreement.</param>
        /// <param name="publisher">Publisher identifier string.</param>
        /// <param name="product">Product identifier string.</param>
        /// <param name="plan">Plan identifier string.</param>
        /// <param name="licenseTextLink">Link to HTML with Microsoft and
        /// Publisher terms.</param>
        /// <param name="privacyPolicyLink">Link to the privacy policy of the
        /// publisher.</param>
        /// <param name="retrieveDatetime">Date and time in UTC of when the
        /// terms were accepted. This is empty if Accepted is false.</param>
        /// <param name="signature">Terms signature.</param>
        /// <param name="accepted">If any version of the terms have been
        /// accepted, otherwise false.</param>
        public ConfluentAgreementResource(string id = default(string), string name = default(string), string type = default(string), string publisher = default(string), string product = default(string), string plan = default(string), string licenseTextLink = default(string), string privacyPolicyLink = default(string), System.DateTime? retrieveDatetime = default(System.DateTime?), string signature = default(string), bool? accepted = default(bool?))
        {
            Id = id;
            Name = name;
            Type = type;
            Publisher = publisher;
            Product = product;
            Plan = plan;
            LicenseTextLink = licenseTextLink;
            PrivacyPolicyLink = privacyPolicyLink;
            RetrieveDatetime = retrieveDatetime;
            Signature = signature;
            Accepted = accepted;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ARM id of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the agreement.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of the agreement.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets publisher identifier string.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets product identifier string.
        /// </summary>
        [JsonProperty(PropertyName = "properties.product")]
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets plan identifier string.
        /// </summary>
        [JsonProperty(PropertyName = "properties.plan")]
        public string Plan { get; set; }

        /// <summary>
        /// Gets or sets link to HTML with Microsoft and Publisher terms.
        /// </summary>
        [JsonProperty(PropertyName = "properties.licenseTextLink")]
        public string LicenseTextLink { get; set; }

        /// <summary>
        /// Gets or sets link to the privacy policy of the publisher.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privacyPolicyLink")]
        public string PrivacyPolicyLink { get; set; }

        /// <summary>
        /// Gets or sets date and time in UTC of when the terms were accepted.
        /// This is empty if Accepted is false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retrieveDatetime")]
        public System.DateTime? RetrieveDatetime { get; set; }

        /// <summary>
        /// Gets or sets terms signature.
        /// </summary>
        [JsonProperty(PropertyName = "properties.signature")]
        public string Signature { get; set; }

        /// <summary>
        /// Gets or sets if any version of the terms have been accepted,
        /// otherwise false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accepted")]
        public bool? Accepted { get; set; }

    }
}
