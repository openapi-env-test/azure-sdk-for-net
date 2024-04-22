// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The VNet solution for linker. </summary>
    public partial class VnetSolution
    {
        /// <summary> Initializes a new instance of <see cref="VnetSolution"/>. </summary>
        public VnetSolution()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VnetSolution"/>. </summary>
        /// <param name="solutionType"> Type of VNet solution. </param>
        /// <param name="deleteOrUpdateBehavior"> Indicates whether to clean up previous operation when Linker is updating or deleting. </param>
        internal VnetSolution(VnetSolutionType? solutionType, DeleteOrUpdateBehavior? deleteOrUpdateBehavior)
        {
            SolutionType = solutionType;
            DeleteOrUpdateBehavior = deleteOrUpdateBehavior;
        }

        /// <summary> Type of VNet solution. </summary>
        public VnetSolutionType? SolutionType { get; set; }
        /// <summary> Indicates whether to clean up previous operation when Linker is updating or deleting. </summary>
        public DeleteOrUpdateBehavior? DeleteOrUpdateBehavior { get; set; }
    }
}
