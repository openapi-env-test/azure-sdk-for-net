// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceGraph.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The options for history request evaluation
    /// </summary>
    public partial class ResourcesHistoryRequestOptions
    {
        /// <summary>
        /// Initializes a new instance of the ResourcesHistoryRequestOptions
        /// class.
        /// </summary>
        public ResourcesHistoryRequestOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourcesHistoryRequestOptions
        /// class.
        /// </summary>
        /// <param name="interval">The time interval used to fetch
        /// history.</param>
        /// <param name="top">The maximum number of rows that the query should
        /// return. Overrides the page size when ```$skipToken``` property is
        /// present.</param>
        /// <param name="skip">The number of rows to skip from the beginning of
        /// the results. Overrides the next page offset when ```$skipToken```
        /// property is present.</param>
        /// <param name="skipToken">Continuation token for pagination,
        /// capturing the next page size and offset, as well as the context of
        /// the query.</param>
        /// <param name="resultFormat">Defines in which format query result
        /// returned. Possible values include: 'table', 'objectArray'</param>
        public ResourcesHistoryRequestOptions(DateTimeInterval interval = default(DateTimeInterval), int? top = default(int?), int? skip = default(int?), string skipToken = default(string), ResultFormat? resultFormat = default(ResultFormat?))
        {
            Interval = interval;
            Top = top;
            Skip = skip;
            SkipToken = skipToken;
            ResultFormat = resultFormat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time interval used to fetch history.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public DateTimeInterval Interval { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of rows that the query should
        /// return. Overrides the page size when ```$skipToken``` property is
        /// present.
        /// </summary>
        [JsonProperty(PropertyName = "$top")]
        public int? Top { get; set; }

        /// <summary>
        /// Gets or sets the number of rows to skip from the beginning of the
        /// results. Overrides the next page offset when ```$skipToken```
        /// property is present.
        /// </summary>
        [JsonProperty(PropertyName = "$skip")]
        public int? Skip { get; set; }

        /// <summary>
        /// Gets or sets continuation token for pagination, capturing the next
        /// page size and offset, as well as the context of the query.
        /// </summary>
        [JsonProperty(PropertyName = "$skipToken")]
        public string SkipToken { get; set; }

        /// <summary>
        /// Gets or sets defines in which format query result returned.
        /// Possible values include: 'table', 'objectArray'
        /// </summary>
        [JsonProperty(PropertyName = "resultFormat")]
        public ResultFormat? ResultFormat { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Interval != null)
            {
                Interval.Validate();
            }
            if (Top > 1000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Top", 1000);
            }
            if (Top < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Top", 1);
            }
            if (Skip < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Skip", 0);
            }
        }
    }
}
