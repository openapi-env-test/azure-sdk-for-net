// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// A specific representation of configurable options for Azure Cosmos DB when using it as an Azure OpenAI chat
    /// extension.
    /// </summary>
    public partial class AzureCosmosDBChatExtensionConfiguration : AzureChatExtensionConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="AzureCosmosDBChatExtensionConfiguration"/>. </summary>
        /// <param name="type">
        ///   The label for the type of an Azure chat extension. This typically corresponds to a matching Azure resource.
        ///   Azure chat extensions are only compatible with Azure OpenAI.
        /// </param>
        /// <param name="parameters"> The parameters to use when configuring Azure OpenAI CosmosDB chat extensions. </param>
        internal AzureCosmosDBChatExtensionConfiguration(AzureChatExtensionType type, AzureCosmosDBChatExtensionParameters parameters) : base(type)
        {
            Parameters = parameters;
        }
    }
}
