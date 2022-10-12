// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class DataConnectionValidationResult
    {
        internal static DataConnectionValidationResult DeserializeDataConnectionValidationResult(JsonElement element)
        {
            Optional<string> errorMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorMessage"))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
            }
            return new DataConnectionValidationResult(errorMessage.Value);
        }
    }
}
