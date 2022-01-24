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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AuthorizationScopeFilter.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuthorizationScopeFilter
    {
        [EnumMember(Value = "AtScopeAndBelow")]
        AtScopeAndBelow,
        [EnumMember(Value = "AtScopeAndAbove")]
        AtScopeAndAbove,
        [EnumMember(Value = "AtScopeExact")]
        AtScopeExact,
        [EnumMember(Value = "AtScopeAboveAndBelow")]
        AtScopeAboveAndBelow
    }
    internal static class AuthorizationScopeFilterEnumExtension
    {
        internal static string ToSerializedValue(this AuthorizationScopeFilter? value)
        {
            return value == null ? null : ((AuthorizationScopeFilter)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AuthorizationScopeFilter value)
        {
            switch( value )
            {
                case AuthorizationScopeFilter.AtScopeAndBelow:
                    return "AtScopeAndBelow";
                case AuthorizationScopeFilter.AtScopeAndAbove:
                    return "AtScopeAndAbove";
                case AuthorizationScopeFilter.AtScopeExact:
                    return "AtScopeExact";
                case AuthorizationScopeFilter.AtScopeAboveAndBelow:
                    return "AtScopeAboveAndBelow";
            }
            return null;
        }

        internal static AuthorizationScopeFilter? ParseAuthorizationScopeFilter(this string value)
        {
            switch( value )
            {
                case "AtScopeAndBelow":
                    return AuthorizationScopeFilter.AtScopeAndBelow;
                case "AtScopeAndAbove":
                    return AuthorizationScopeFilter.AtScopeAndAbove;
                case "AtScopeExact":
                    return AuthorizationScopeFilter.AtScopeExact;
                case "AtScopeAboveAndBelow":
                    return AuthorizationScopeFilter.AtScopeAboveAndBelow;
            }
            return null;
        }
    }
}
