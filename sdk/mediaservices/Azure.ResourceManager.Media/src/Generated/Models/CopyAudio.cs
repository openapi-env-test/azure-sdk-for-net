// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> A codec flag, which tells the encoder to copy the input audio bitstream. </summary>
    public partial class CopyAudio : CodecBasicProperties
    {
        /// <summary> Initializes a new instance of CopyAudio. </summary>
        public CopyAudio()
        {
            OdataType = "#Microsoft.Media.CopyAudio";
        }

        /// <summary> Initializes a new instance of CopyAudio. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="label"> An optional label for the codec. The label can be used to control muxing behavior. </param>
        internal CopyAudio(string odataType, string label) : base(odataType, label)
        {
            OdataType = odataType ?? "#Microsoft.Media.CopyAudio";
        }
    }
}
