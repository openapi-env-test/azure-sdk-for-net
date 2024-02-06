// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> Optional settings to control how fields are processed when using a configured Azure Cosmos DB resource. </summary>
    public partial class AzureCosmosDBFieldMappingOptions
    {
        /// <summary> Initializes a new instance of <see cref="AzureCosmosDBFieldMappingOptions"/>. </summary>
        /// <param name="contentFieldNames"> The names of index fields that should be treated as content. </param>
        /// <param name="vectorFieldNames"> The names of fields that represent vector data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contentFieldNames"/> or <paramref name="vectorFieldNames"/> is null. </exception>
        public AzureCosmosDBFieldMappingOptions(IEnumerable<string> contentFieldNames, IEnumerable<string> vectorFieldNames)
        {
            Argument.AssertNotNull(contentFieldNames, nameof(contentFieldNames));
            Argument.AssertNotNull(vectorFieldNames, nameof(vectorFieldNames));

            ContentFieldNames = contentFieldNames.ToList();
            VectorFieldNames = vectorFieldNames.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AzureCosmosDBFieldMappingOptions"/>. </summary>
        /// <param name="titleFieldName"> The name of the index field to use as a title. </param>
        /// <param name="urlFieldName"> The name of the index field to use as a URL. </param>
        /// <param name="filepathFieldName"> The name of the index field to use as a filepath. </param>
        /// <param name="contentFieldNames"> The names of index fields that should be treated as content. </param>
        /// <param name="contentFieldSeparator"> The separator pattern that content fields should use. </param>
        /// <param name="vectorFieldNames"> The names of fields that represent vector data. </param>
        internal AzureCosmosDBFieldMappingOptions(string titleFieldName, string urlFieldName, string filepathFieldName, IList<string> contentFieldNames, string contentFieldSeparator, IList<string> vectorFieldNames)
        {
            TitleFieldName = titleFieldName;
            UrlFieldName = urlFieldName;
            FilepathFieldName = filepathFieldName;
            ContentFieldNames = contentFieldNames;
            ContentFieldSeparator = contentFieldSeparator;
            VectorFieldNames = vectorFieldNames;
        }

        /// <summary> The name of the index field to use as a title. </summary>
        public string TitleFieldName { get; set; }
        /// <summary> The name of the index field to use as a URL. </summary>
        public string UrlFieldName { get; set; }
        /// <summary> The name of the index field to use as a filepath. </summary>
        public string FilepathFieldName { get; set; }
        /// <summary> The names of index fields that should be treated as content. </summary>
        public IList<string> ContentFieldNames { get; }
        /// <summary> The separator pattern that content fields should use. </summary>
        public string ContentFieldSeparator { get; set; }
        /// <summary> The names of fields that represent vector data. </summary>
        public IList<string> VectorFieldNames { get; }
    }
}
