// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Documentation update contract details. </summary>
    public partial class DocumentationContractPatch
    {
        /// <summary> Initializes a new instance of <see cref="DocumentationContractPatch"/>. </summary>
        public DocumentationContractPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DocumentationContractPatch"/>. </summary>
        /// <param name="title"> documentation title. </param>
        /// <param name="content"> Markdown documentation content. </param>
        internal DocumentationContractPatch(string title, string content)
        {
            Title = title;
            Content = content;
        }

        /// <summary> documentation title. </summary>
        public string Title { get; set; }
        /// <summary> Markdown documentation content. </summary>
        public string Content { get; set; }
    }
}
