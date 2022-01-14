// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The amount with exchange rate.
    /// </summary>
    public partial class AmountWithExchangeRate : Amount
    {
        /// <summary>
        /// Initializes a new instance of the AmountWithExchangeRate class.
        /// </summary>
        public AmountWithExchangeRate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AmountWithExchangeRate class.
        /// </summary>
        /// <param name="currency">Amount currency.</param>
        /// <param name="value">Amount.</param>
        /// <param name="exchangeRate">The exchange rate.</param>
        /// <param name="exchangeRateMonth">The exchange rate month.</param>
        public AmountWithExchangeRate(string currency = default(string), decimal? value = default(decimal?), decimal? exchangeRate = default(decimal?), int? exchangeRateMonth = default(int?))
            : base(currency, value)
        {
            ExchangeRate = exchangeRate;
            ExchangeRateMonth = exchangeRateMonth;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the exchange rate.
        /// </summary>
        [JsonProperty(PropertyName = "exchangeRate")]
        public decimal? ExchangeRate { get; private set; }

        /// <summary>
        /// Gets the exchange rate month.
        /// </summary>
        [JsonProperty(PropertyName = "exchangeRateMonth")]
        public int? ExchangeRateMonth { get; private set; }

    }
}
