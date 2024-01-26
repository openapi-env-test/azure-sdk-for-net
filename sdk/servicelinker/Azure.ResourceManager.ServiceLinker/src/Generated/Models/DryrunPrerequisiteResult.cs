// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary>
    /// A result of dryrun
    /// Please note <see cref="DryrunPrerequisiteResult"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BasicErrorDryrunPrerequisiteResult"/> and <see cref="PermissionsMissingDryrunPrerequisiteResult"/>.
    /// </summary>
    public abstract partial class DryrunPrerequisiteResult
    {
        /// <summary> Initializes a new instance of <see cref="DryrunPrerequisiteResult"/>. </summary>
        protected DryrunPrerequisiteResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DryrunPrerequisiteResult"/>. </summary>
        /// <param name="resultType"> The type of dryrun result. </param>
        internal DryrunPrerequisiteResult(DryrunPrerequisiteResultType resultType)
        {
            ResultType = resultType;
        }

        /// <summary> The type of dryrun result. </summary>
        internal DryrunPrerequisiteResultType ResultType { get; set; }
    }
}
