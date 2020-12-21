// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base class for output.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Format")]
    public partial class Format
    {
        /// <summary>
        /// Initializes a new instance of the Format class.
        /// </summary>
        public Format()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Format class.
        /// </summary>
        /// <param name="filenamePattern">The pattern of the file names for the
        /// generated output files. The following macros are supported in the
        /// file name: {Basename} - An expansion macro that will use the name
        /// of the input video file. If the base name(the file suffix is not
        /// included) of the input video file is less than 32 characters long,
        /// the base name of input video files will be used. If the length of
        /// base name of the input video file exceeds 32 characters, the base
        /// name is truncated to the first 32 characters in total length.
        /// {Extension} - The appropriate extension for this format. {Label} -
        /// The label assigned to the codec/layer. {Index} - A unique index for
        /// thumbnails. Only applicable to thumbnails. {Bitrate} - The
        /// audio/video bitrate. Not applicable to thumbnails. {Codec} - The
        /// type of the audio/video codec. Any unsubstituted macros will be
        /// collapsed and removed from the filename.</param>
        public Format(string filenamePattern)
        {
            FilenamePattern = filenamePattern;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the pattern of the file names for the generated output
        /// files. The following macros are supported in the file name:
        /// {Basename} - An expansion macro that will use the name of the input
        /// video file. If the base name(the file suffix is not included) of
        /// the input video file is less than 32 characters long, the base name
        /// of input video files will be used. If the length of base name of
        /// the input video file exceeds 32 characters, the base name is
        /// truncated to the first 32 characters in total length. {Extension} -
        /// The appropriate extension for this format. {Label} - The label
        /// assigned to the codec/layer. {Index} - A unique index for
        /// thumbnails. Only applicable to thumbnails. {Bitrate} - The
        /// audio/video bitrate. Not applicable to thumbnails. {Codec} - The
        /// type of the audio/video codec. Any unsubstituted macros will be
        /// collapsed and removed from the filename.
        /// </summary>
        [JsonProperty(PropertyName = "filenamePattern")]
        public string FilenamePattern { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FilenamePattern == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FilenamePattern");
            }
        }
    }
}
