// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The security profile of a gallery image version. </summary>
    internal partial class ImageVersionSecurityProfile
    {
        /// <summary> Initializes a new instance of <see cref="ImageVersionSecurityProfile"/>. </summary>
        public ImageVersionSecurityProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImageVersionSecurityProfile"/>. </summary>
        /// <param name="uefiSettings"> Contains UEFI settings for the image version. </param>
        internal ImageVersionSecurityProfile(GalleryImageVersionUefiSettings uefiSettings)
        {
            UefiSettings = uefiSettings;
        }

        /// <summary> Contains UEFI settings for the image version. </summary>
        public GalleryImageVersionUefiSettings UefiSettings { get; set; }
    }
}
