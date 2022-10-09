// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Agrifood.Models
{
    public partial class UnitSystemsInfo
    {
        internal static UnitSystemsInfo DeserializeUnitSystemsInfo(JsonElement element)
        {
            string key = default;
            IReadOnlyList<string> values = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    values = array;
                    continue;
                }
            }
            return new UnitSystemsInfo(key, values);
        }
    }
}
