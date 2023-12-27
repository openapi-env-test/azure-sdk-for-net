// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary>
    /// The parameters of the dryrun
    /// Please note <see cref="DryrunParameters"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CreateOrUpdateDryrunParameters"/>.
    /// </summary>
    public abstract partial class DryrunParameters
    {
        /// <summary> Initializes a new instance of <see cref="DryrunParameters"/>. </summary>
        protected DryrunParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DryrunParameters"/>. </summary>
        /// <param name="actionName"> The name of action for you dryrun job. </param>
        internal DryrunParameters(DryrunActionName actionName)
        {
            ActionName = actionName;
        }

        /// <summary> The name of action for you dryrun job. </summary>
        internal DryrunActionName ActionName { get; set; }
    }
}
