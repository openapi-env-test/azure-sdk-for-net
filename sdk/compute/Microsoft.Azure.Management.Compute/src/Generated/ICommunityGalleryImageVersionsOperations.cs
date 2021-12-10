// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CommunityGalleryImageVersionsOperations operations.
    /// </summary>
    public partial interface ICommunityGalleryImageVersionsOperations
    {
        /// <summary>
        /// Get a community gallery image version.
        /// </summary>
        /// <param name='location'>
        /// Resource location.
        /// </param>
        /// <param name='publicGalleryName'>
        /// The public name of the community gallery.
        /// </param>
        /// <param name='galleryImageName'>
        /// The name of the community gallery image definition.
        /// </param>
        /// <param name='galleryImageVersionName'>
        /// The name of the community gallery image version. Needs to follow
        /// semantic version name pattern: The allowed characters are digit and
        /// period. Digits must be within the range of a 32-bit integer.
        /// Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CommunityGalleryImageVersion>> GetWithHttpMessagesAsync(string location, string publicGalleryName, string galleryImageName, string galleryImageVersionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
