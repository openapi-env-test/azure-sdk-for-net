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
    /// GalleriesOperations operations.
    /// </summary>
    public partial interface IGalleriesOperations
    {
        /// <summary>
        /// Create or update a Shared Image Gallery.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery. The allowed characters are
        /// alphabets and numbers with dots and periods allowed in the middle.
        /// The maximum length is 80 characters.
        /// </param>
        /// <param name='gallery'>
        /// Parameters supplied to the create or update Shared Image Gallery
        /// operation.
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
        Task<AzureOperationResponse<Gallery>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string galleryName, Gallery gallery, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a Shared Image Gallery.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery. The allowed characters are
        /// alphabets and numbers with dots and periods allowed in the middle.
        /// The maximum length is 80 characters.
        /// </param>
        /// <param name='gallery'>
        /// Parameters supplied to the update Shared Image Gallery operation.
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
        Task<AzureOperationResponse<Gallery>> UpdateWithHttpMessagesAsync(string resourceGroupName, string galleryName, GalleryUpdate gallery, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves information about a Shared Image Gallery.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery.
        /// </param>
        /// <param name='select'>
        /// The select expression to apply on the operation. Possible values
        /// include: 'Permissions'
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
        Task<AzureOperationResponse<Gallery>> GetWithHttpMessagesAsync(string resourceGroupName, string galleryName, string select = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List galleries under a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
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
        Task<AzureOperationResponse<IPage<Gallery>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List galleries under a subscription.
        /// </summary>
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
        Task<AzureOperationResponse<IPage<Gallery>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a Shared Image Gallery.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery. The allowed characters are
        /// alphabets and numbers with dots and periods allowed in the middle.
        /// The maximum length is 80 characters.
        /// </param>
        /// <param name='gallery'>
        /// Parameters supplied to the create or update Shared Image Gallery
        /// operation.
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
        Task<AzureOperationResponse<Gallery>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string galleryName, Gallery gallery, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a Shared Image Gallery.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='galleryName'>
        /// The name of the Shared Image Gallery. The allowed characters are
        /// alphabets and numbers with dots and periods allowed in the middle.
        /// The maximum length is 80 characters.
        /// </param>
        /// <param name='gallery'>
        /// Parameters supplied to the update Shared Image Gallery operation.
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
        Task<AzureOperationResponse<Gallery>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string galleryName, GalleryUpdate gallery, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List galleries under a resource group.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
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
        Task<AzureOperationResponse<IPage<Gallery>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List galleries under a subscription.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
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
        Task<AzureOperationResponse<IPage<Gallery>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
