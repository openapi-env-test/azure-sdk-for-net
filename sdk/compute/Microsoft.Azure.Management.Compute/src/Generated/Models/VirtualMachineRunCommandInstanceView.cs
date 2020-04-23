// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The instance view of a virtual machine run command.
    /// </summary>
    public partial class VirtualMachineRunCommandInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineRunCommandInstanceView class.
        /// </summary>
        public VirtualMachineRunCommandInstanceView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineRunCommandInstanceView class.
        /// </summary>
        /// <param name="executionState">Script execution status. Possible
        /// values include: 'Unknown', 'Pending', 'Running', 'Failed',
        /// 'Succeeded', 'TimedOut', 'Canceled'</param>
        /// <param name="output">Script output stream.</param>
        /// <param name="error">Script error stream.</param>
        /// <param name="startTime">Script start time.</param>
        /// <param name="endTime">Script end time.</param>
        /// <param name="statuses">The resource status information.</param>
        public VirtualMachineRunCommandInstanceView(string executionState = default(string), string output = default(string), string error = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), IList<InstanceViewStatus> statuses = default(IList<InstanceViewStatus>))
        {
            ExecutionState = executionState;
            Output = output;
            Error = error;
            StartTime = startTime;
            EndTime = endTime;
            Statuses = statuses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets script execution status. Possible values include:
        /// 'Unknown', 'Pending', 'Running', 'Failed', 'Succeeded', 'TimedOut',
        /// 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "executionState")]
        public string ExecutionState { get; set; }

        /// <summary>
        /// Gets or sets script output stream.
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public string Output { get; set; }

        /// <summary>
        /// Gets or sets script error stream.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets script start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets script end time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the resource status information.
        /// </summary>
        [JsonProperty(PropertyName = "statuses")]
        public IList<InstanceViewStatus> Statuses { get; set; }

    }
}
