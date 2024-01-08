// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The CapacityReservationGroupInstanceView. </summary>
    public partial class CapacityReservationGroupInstanceView
    {
        /// <summary> Initializes a new instance of <see cref="CapacityReservationGroupInstanceView"/>. </summary>
        internal CapacityReservationGroupInstanceView()
        {
            CapacityReservations = new ChangeTrackingList<CapacityReservationInstanceViewWithName>();
            SharedSubscriptionIds = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="CapacityReservationGroupInstanceView"/>. </summary>
        /// <param name="capacityReservations"> List of instance view of the capacity reservations under the capacity reservation group. </param>
        /// <param name="sharedSubscriptionIds"> List of the subscriptions that the capacity reservation group is shared with. **Note:** Minimum api-version: 2023-09-01. Please refer to https://aka.ms/computereservationsharing for more details. </param>
        internal CapacityReservationGroupInstanceView(IReadOnlyList<CapacityReservationInstanceViewWithName> capacityReservations, IReadOnlyList<SubResource> sharedSubscriptionIds)
        {
            CapacityReservations = capacityReservations;
            SharedSubscriptionIds = sharedSubscriptionIds;
        }

        /// <summary> List of instance view of the capacity reservations under the capacity reservation group. </summary>
        public IReadOnlyList<CapacityReservationInstanceViewWithName> CapacityReservations { get; }
        /// <summary> List of the subscriptions that the capacity reservation group is shared with. **Note:** Minimum api-version: 2023-09-01. Please refer to https://aka.ms/computereservationsharing for more details. </summary>
        public IReadOnlyList<SubResource> SharedSubscriptionIds { get; }
    }
}
