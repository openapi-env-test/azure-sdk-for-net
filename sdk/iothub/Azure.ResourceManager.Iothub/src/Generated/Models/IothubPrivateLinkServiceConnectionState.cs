// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Iothub.Models
{
    /// <summary> The current state of a private endpoint connection. </summary>
    public partial class IothubPrivateLinkServiceConnectionState
    {
        /// <summary> Initializes a new instance of IothubPrivateLinkServiceConnectionState. </summary>
        /// <param name="status"> The status of a private endpoint connection. </param>
        /// <param name="description"> The description for the current state of a private endpoint connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="description"/> is null. </exception>
        public IothubPrivateLinkServiceConnectionState(PrivateLinkServiceConnectionStatus status, string description)
        {
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }

            Status = status;
            Description = description;
        }

        /// <summary> Initializes a new instance of IothubPrivateLinkServiceConnectionState. </summary>
        /// <param name="status"> The status of a private endpoint connection. </param>
        /// <param name="description"> The description for the current state of a private endpoint connection. </param>
        /// <param name="actionsRequired"> Actions required for a private endpoint connection. </param>
        internal IothubPrivateLinkServiceConnectionState(PrivateLinkServiceConnectionStatus status, string description, string actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary> The status of a private endpoint connection. </summary>
        public PrivateLinkServiceConnectionStatus Status { get; set; }
        /// <summary> The description for the current state of a private endpoint connection. </summary>
        public string Description { get; set; }
        /// <summary> Actions required for a private endpoint connection. </summary>
        public string ActionsRequired { get; set; }
    }
}
