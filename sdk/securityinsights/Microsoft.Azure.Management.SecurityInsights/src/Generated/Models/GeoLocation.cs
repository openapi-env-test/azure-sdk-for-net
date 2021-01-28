// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Contoso.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The geo-location context attached to the ip entity
    /// </summary>
    public partial class GeoLocation
    {
        /// <summary>
        /// Initializes a new instance of the GeoLocation class.
        /// </summary>
        public GeoLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoLocation class.
        /// </summary>
        /// <param name="asn">Autonomous System Number</param>
        /// <param name="city">City name</param>
        /// <param name="countryCode">The country code according to ISO 3166
        /// format</param>
        /// <param name="countryName">Country name according to ISO 3166 Alpha
        /// 2: the lowercase of the English Short Name</param>
        /// <param name="latitude">The longitude of the identified location,
        /// expressed as a floating point number with range of -180 to 180,
        /// with positive numbers representing East and negative numbers
        /// representing West. Latitude and longitude are derived from the city
        /// or postal code.</param>
        /// <param name="longitude">The latitude of the identified location,
        /// expressed as a floating point number with range of - 90 to 90, with
        /// positive numbers representing North and negative numbers
        /// representing South. Latitude and longitude are derived from the
        /// city or postal code.</param>
        /// <param name="state">State name</param>
        public GeoLocation(int? asn = default(int?), string city = default(string), string countryCode = default(string), string countryName = default(string), double? latitude = default(double?), double? longitude = default(double?), string state = default(string))
        {
            Asn = asn;
            City = city;
            CountryCode = countryCode;
            CountryName = countryName;
            Latitude = latitude;
            Longitude = longitude;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets autonomous System Number
        /// </summary>
        [JsonProperty(PropertyName = "asn")]
        public int? Asn { get; private set; }

        /// <summary>
        /// Gets city name
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; private set; }

        /// <summary>
        /// Gets the country code according to ISO 3166 format
        /// </summary>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; private set; }

        /// <summary>
        /// Gets country name according to ISO 3166 Alpha 2: the lowercase of
        /// the English Short Name
        /// </summary>
        [JsonProperty(PropertyName = "countryName")]
        public string CountryName { get; private set; }

        /// <summary>
        /// Gets the longitude of the identified location, expressed as a
        /// floating point number with range of -180 to 180, with positive
        /// numbers representing East and negative numbers representing West.
        /// Latitude and longitude are derived from the city or postal code.
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; private set; }

        /// <summary>
        /// Gets the latitude of the identified location, expressed as a
        /// floating point number with range of - 90 to 90, with positive
        /// numbers representing North and negative numbers representing South.
        /// Latitude and longitude are derived from the city or postal code.
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; private set; }

        /// <summary>
        /// Gets state name
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; private set; }

    }
}
