// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ChangeAnalysis.Models
{
    /// <summary> Data of a property change. </summary>
    public partial class PropertyChange
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

        /// <summary> Initializes a new instance of <see cref="PropertyChange"/>. </summary>
        internal PropertyChange()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PropertyChange"/>. </summary>
        /// <param name="changeType"> The type of the change. </param>
        /// <param name="changeCategory"> The change category. </param>
        /// <param name="jsonPath"> The json path of the changed property. </param>
        /// <param name="displayName"> The enhanced display name of the json path. E.g., the json path value[0].properties will be translated to something meaningful like slots["Staging"].properties. </param>
        /// <param name="level"></param>
        /// <param name="description"> The description of the changed property. </param>
        /// <param name="oldValue"> The value of the property before the change. </param>
        /// <param name="newValue"> The value of the property after the change. </param>
        /// <param name="isDataMasked"> The boolean indicating whether the oldValue and newValue are masked. The values are masked if it contains sensitive information that the user doesn't have access to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PropertyChange(ChangeType? changeType, ChangeCategory? changeCategory, string jsonPath, string displayName, PropertyChangeLevel? level, string description, string oldValue, string newValue, bool? isDataMasked, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ChangeType = changeType;
            ChangeCategory = changeCategory;
            JsonPath = jsonPath;
            DisplayName = displayName;
            Level = level;
            Description = description;
            OldValue = oldValue;
            NewValue = newValue;
            IsDataMasked = isDataMasked;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of the change. </summary>
        public ChangeType? ChangeType { get; }
        /// <summary> The change category. </summary>
        public ChangeCategory? ChangeCategory { get; }
        /// <summary> The json path of the changed property. </summary>
        public string JsonPath { get; }
        /// <summary> The enhanced display name of the json path. E.g., the json path value[0].properties will be translated to something meaningful like slots["Staging"].properties. </summary>
        public string DisplayName { get; }
        /// <summary> Gets the level. </summary>
        public PropertyChangeLevel? Level { get; }
        /// <summary> The description of the changed property. </summary>
        public string Description { get; }
        /// <summary> The value of the property before the change. </summary>
        public string OldValue { get; }
        /// <summary> The value of the property after the change. </summary>
        public string NewValue { get; }
        /// <summary> The boolean indicating whether the oldValue and newValue are masked. The values are masked if it contains sensitive information that the user doesn't have access to. </summary>
        public bool? IsDataMasked { get; }
    }
}
