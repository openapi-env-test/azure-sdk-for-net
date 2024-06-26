// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The source image used for creating the disk. </summary>
    public partial class ImageDiskReference
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ImageDiskReference"/>. </summary>
        public ImageDiskReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImageDiskReference"/>. </summary>
        /// <param name="id"> A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image reference. </param>
        /// <param name="sharedGalleryImageId"> A relative uri containing a direct shared Azure Compute Gallery image reference. </param>
        /// <param name="communityGalleryImageId"> A relative uri containing a community Azure Compute Gallery image reference. </param>
        /// <param name="lun"> If the disk is created from an image's data disk, this is an index that indicates which of the data disks in the image to use. For OS disks, this field is null. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageDiskReference(ResourceIdentifier id, string sharedGalleryImageId, string communityGalleryImageId, int? lun, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            SharedGalleryImageId = sharedGalleryImageId;
            CommunityGalleryImageId = communityGalleryImageId;
            Lun = lun;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image reference. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> A relative uri containing a direct shared Azure Compute Gallery image reference. </summary>
        public string SharedGalleryImageId { get; set; }
        /// <summary> A relative uri containing a community Azure Compute Gallery image reference. </summary>
        public string CommunityGalleryImageId { get; set; }
        /// <summary> If the disk is created from an image's data disk, this is an index that indicates which of the data disks in the image to use. For OS disks, this field is null. </summary>
        public int? Lun { get; set; }
    }
}
