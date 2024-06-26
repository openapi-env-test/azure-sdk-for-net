// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> ARM provisioning state, see https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property. </summary>
    public readonly partial struct StorageCacheProvisioningStateType : IEquatable<StorageCacheProvisioningStateType>
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private const string CancelledValue = "Cancelled";

        /// <summary> Cancelled. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static StorageCacheProvisioningStateType Cancelled { get; } = new StorageCacheProvisioningStateType(CancelledValue);
    }
}
