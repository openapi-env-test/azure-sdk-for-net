// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes an available virtual machine scale set sku. </summary>
    public partial class VirtualMachineScaleSetSku
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetSku"/>. </summary>
        internal VirtualMachineScaleSetSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetSku"/>. </summary>
        /// <param name="resourceType"> The type of resource the sku applies to. </param>
        /// <param name="sku"> The Sku. </param>
        /// <param name="capacity"> Specifies the number of virtual machines in the scale set. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetSku(ResourceType? resourceType, ComputeSku sku, VirtualMachineScaleSetSkuCapacity capacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceType = resourceType;
            Sku = sku;
            Capacity = capacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of resource the sku applies to. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> The Sku. </summary>
        public ComputeSku Sku { get; }
        /// <summary> Specifies the number of virtual machines in the scale set. </summary>
        public VirtualMachineScaleSetSkuCapacity Capacity { get; }
    }
}
