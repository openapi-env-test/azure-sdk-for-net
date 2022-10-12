// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Disk update resource. </summary>
    public partial class ManagedDiskPatch
    {
        /// <summary> Initializes a new instance of ManagedDiskPatch. </summary>
        public ManagedDiskPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS, Premium_ZRS, StandardSSD_ZRS, or PremiumV2_LRS. </summary>
        public DiskSku Sku { get; set; }
        /// <summary> the Operating System type. </summary>
        public SupportedOperatingSystemType? OSType { get; set; }
        /// <summary> If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk&apos;s size. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot. </summary>
        public EncryptionSettingsGroup EncryptionSettingsGroup { get; set; }
        /// <summary> The number of IOPS allowed for this disk; only settable for UltraSSD disks. One operation can transfer between 4k and 256k bytes. </summary>
        public long? DiskIopsReadWrite { get; set; }
        /// <summary> The bandwidth allowed for this disk; only settable for UltraSSD disks. MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10. </summary>
        public long? DiskMBpsReadWrite { get; set; }
        /// <summary> The total number of IOPS that will be allowed across all VMs mounting the shared disk as ReadOnly. One operation can transfer between 4k and 256k bytes. </summary>
        public long? DiskIopsReadOnly { get; set; }
        /// <summary> The total throughput (MBps) that will be allowed across all VMs mounting the shared disk as ReadOnly. MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10. </summary>
        public long? DiskMBpsReadOnly { get; set; }
        /// <summary> The maximum number of VMs that can attach to the disk at the same time. Value greater than one indicates a disk that can be mounted on multiple VMs at the same time. </summary>
        public int? MaxShares { get; set; }
        /// <summary> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </summary>
        public DiskEncryption Encryption { get; set; }
        /// <summary> Policy for accessing the disk via network. </summary>
        public NetworkAccessPolicy? NetworkAccessPolicy { get; set; }
        /// <summary> ARM id of the DiskAccess resource for using private endpoints on disks. </summary>
        public ResourceIdentifier DiskAccessId { get; set; }
        /// <summary> Performance tier of the disk (e.g, P4, S10) as described here: https://azure.microsoft.com/en-us/pricing/details/managed-disks/. Does not apply to Ultra disks. </summary>
        public string Tier { get; set; }
        /// <summary> Set to true to enable bursting beyond the provisioned performance target of the disk. Bursting is disabled by default. Does not apply to Ultra disks. </summary>
        public bool? BurstingEnabled { get; set; }
        /// <summary> Purchase plan information to be added on the OS disk. </summary>
        public DiskPurchasePlan PurchasePlan { get; set; }
        /// <summary> List of supported capabilities to be added on the OS disk. </summary>
        public SupportedCapabilities SupportedCapabilities { get; set; }
        /// <summary> Properties of the disk for which update is pending. </summary>
        internal PropertyUpdatesInProgress PropertyUpdatesInProgress { get; }
        /// <summary> The target performance tier of the disk if a tier change operation is in progress. </summary>
        public string PropertyUpdatesInProgressTargetTier
        {
            get => PropertyUpdatesInProgress?.TargetTier;
        }

        /// <summary> Indicates the OS on a disk supports hibernation. </summary>
        public bool? SupportsHibernation { get; set; }
        /// <summary> Policy for controlling export on the disk. </summary>
        public DiskPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Additional authentication requirements when exporting or uploading to a disk or snapshot. </summary>
        public DataAccessAuthMode? DataAccessAuthMode { get; set; }
    }
}
