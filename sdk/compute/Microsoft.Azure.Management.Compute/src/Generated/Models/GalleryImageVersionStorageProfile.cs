// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This is the storage profile of a Gallery Image Version.
    /// </summary>
    public partial class GalleryImageVersionStorageProfile
    {
        /// <summary>
        /// Initializes a new instance of the GalleryImageVersionStorageProfile
        /// class.
        /// </summary>
        public GalleryImageVersionStorageProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryImageVersionStorageProfile
        /// class.
        /// </summary>
        /// <param name="dataDiskImages">A list of data disk images.</param>
        public GalleryImageVersionStorageProfile(GalleryOSDiskImage osDiskImage = default(GalleryOSDiskImage), IList<GalleryDataDiskImage> dataDiskImages = default(IList<GalleryDataDiskImage>))
        {
            OsDiskImage = osDiskImage;
            DataDiskImages = dataDiskImages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "osDiskImage")]
        public GalleryOSDiskImage OsDiskImage { get; private set; }

        /// <summary>
        /// Gets a list of data disk images.
        /// </summary>
        [JsonProperty(PropertyName = "dataDiskImages")]
        public IList<GalleryDataDiskImage> DataDiskImages { get; private set; }

    }
}
