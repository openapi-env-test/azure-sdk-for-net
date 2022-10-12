// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> Peering location is where connectivity could be established to the Microsoft Cloud Edge. </summary>
    public partial class PeeringLocation : ResourceData
    {
        /// <summary> Initializes a new instance of PeeringLocation. </summary>
        public PeeringLocation()
        {
        }

        /// <summary> Initializes a new instance of PeeringLocation. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of peering that the peering location supports. </param>
        /// <param name="direct"> The properties that define a direct peering location. </param>
        /// <param name="exchange"> The properties that define an exchange peering location. </param>
        /// <param name="peeringLocationValue"> The name of the peering location. </param>
        /// <param name="country"> The country in which the peering location exists. </param>
        /// <param name="azureRegion"> The Azure region associated with the peering location. </param>
        internal PeeringLocation(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PeeringKind? kind, DirectPeeringLocationProperties direct, PeeringLocationPropertiesExchange exchange, string peeringLocationValue, string country, AzureLocation? azureRegion) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            Direct = direct;
            Exchange = exchange;
            PeeringLocationValue = peeringLocationValue;
            Country = country;
            AzureRegion = azureRegion;
        }

        /// <summary> The kind of peering that the peering location supports. </summary>
        public PeeringKind? Kind { get; set; }
        /// <summary> The properties that define a direct peering location. </summary>
        public DirectPeeringLocationProperties Direct { get; set; }
        /// <summary> The properties that define an exchange peering location. </summary>
        internal PeeringLocationPropertiesExchange Exchange { get; set; }
        /// <summary> The list of exchange peering facilities at the peering location. </summary>
        public IList<ExchangePeeringFacility> ExchangePeeringFacilities
        {
            get
            {
                if (Exchange is null)
                    Exchange = new PeeringLocationPropertiesExchange();
                return Exchange.PeeringFacilities;
            }
        }

        /// <summary> The name of the peering location. </summary>
        public string PeeringLocationValue { get; set; }
        /// <summary> The country in which the peering location exists. </summary>
        public string Country { get; set; }
        /// <summary> The Azure region associated with the peering location. </summary>
        public AzureLocation? AzureRegion { get; set; }
    }
}
