// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The routes table associated with the ExpressRouteCircuit
    /// </summary>
    public partial class ExpressRouteCircuitRoutesTable
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitRoutesTable
        /// class.
        /// </summary>
        public ExpressRouteCircuitRoutesTable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitRoutesTable
        /// class.
        /// </summary>
        /// <param name="nextHopType">Gets NextHopType. Possible values
        /// include: 'VirtualNetworkGateway', 'VnetLocal', 'Internet',
        /// 'VirtualAppliance', 'None'</param>
        /// <param name="addressPrefix">Gets AddressPrefix.</param>
        /// <param name="nextHopIP">Gets NextHopIP.</param>
        /// <param name="asPath">Gets AsPath.</param>
        public ExpressRouteCircuitRoutesTable(string nextHopType, string addressPrefix = default(string), string nextHopIP = default(string), string asPath = default(string))
        {
            AddressPrefix = addressPrefix;
            NextHopType = nextHopType;
            NextHopIP = nextHopIP;
            AsPath = asPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets AddressPrefix.
        /// </summary>
        [JsonProperty(PropertyName = "addressPrefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// Gets NextHopType. Possible values include: 'VirtualNetworkGateway',
        /// 'VnetLocal', 'Internet', 'VirtualAppliance', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "nextHopType")]
        public string NextHopType { get; set; }

        /// <summary>
        /// Gets NextHopIP.
        /// </summary>
        [JsonProperty(PropertyName = "nextHopIP")]
        public string NextHopIP { get; set; }

        /// <summary>
        /// Gets AsPath.
        /// </summary>
        [JsonProperty(PropertyName = "asPath")]
        public string AsPath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NextHopType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NextHopType");
            }
        }
    }
}
