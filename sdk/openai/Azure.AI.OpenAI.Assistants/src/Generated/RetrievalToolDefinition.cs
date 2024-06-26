// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The input definition information for a retrieval tool as used to configure an assistant. </summary>
    public partial class RetrievalToolDefinition : ToolDefinition
    {
        /// <summary> Initializes a new instance of <see cref="RetrievalToolDefinition"/>. </summary>
        public RetrievalToolDefinition()
        {
            Type = "retrieval";
        }

        /// <summary> Initializes a new instance of <see cref="RetrievalToolDefinition"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RetrievalToolDefinition(string type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
        }
    }
}
