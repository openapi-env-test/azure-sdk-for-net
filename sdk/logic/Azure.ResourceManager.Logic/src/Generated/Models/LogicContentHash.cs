// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The content hash. </summary>
    public partial class LogicContentHash
    {
        /// <summary> Initializes a new instance of LogicContentHash. </summary>
        internal LogicContentHash()
        {
        }

        /// <summary> Initializes a new instance of LogicContentHash. </summary>
        /// <param name="algorithm"> The algorithm of the content hash. </param>
        /// <param name="value"> The value of the content hash. </param>
        internal LogicContentHash(string algorithm, string value)
        {
            Algorithm = algorithm;
            Value = value;
        }

        /// <summary> The algorithm of the content hash. </summary>
        public string Algorithm { get; }
        /// <summary> The value of the content hash. </summary>
        public string Value { get; }
    }
}
