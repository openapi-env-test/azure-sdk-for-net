// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> The content of a search facet result item. </summary>
    public partial class SearchFacetItem
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SearchFacetItem"/>. </summary>
        public SearchFacetItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SearchFacetItem"/>. </summary>
        /// <param name="count"> The count of the facet item. </param>
        /// <param name="facet"> The name of the facet item. </param>
        /// <param name="sort"> Define the sorting criteria for items. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchFacetItem(int? count, string facet, SearchFacetSort sort, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Count = count;
            Facet = facet;
            Sort = sort;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The count of the facet item. </summary>
        public int? Count { get; set; }
        /// <summary> The name of the facet item. </summary>
        public string Facet { get; set; }
        /// <summary> Define the sorting criteria for items. </summary>
        public SearchFacetSort Sort { get; set; }
    }
}
