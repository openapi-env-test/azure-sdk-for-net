// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The workflow run action.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WorkflowRunAction : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowRunAction class.
        /// </summary>
        public WorkflowRunAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkflowRunAction class.
        /// </summary>
        /// <param name="id">The resource id.</param>
        /// <param name="startTime">Gets the start time.</param>
        /// <param name="endTime">Gets the end time.</param>
        /// <param name="status">Gets the status. Possible values include:
        /// 'NotSpecified', 'Paused', 'Running', 'Waiting', 'Succeeded',
        /// 'Skipped', 'Suspended', 'Cancelled', 'Failed', 'Faulted',
        /// 'TimedOut', 'Aborted', 'Ignored'</param>
        /// <param name="code">Gets the code.</param>
        /// <param name="error">Gets the error.</param>
        /// <param name="trackingId">Gets the tracking id.</param>
        /// <param name="correlation">The correlation properties.</param>
        /// <param name="inputsLink">Gets the link to inputs.</param>
        /// <param name="outputsLink">Gets the link to outputs.</param>
        /// <param name="trackedProperties">Gets the tracked
        /// properties.</param>
        /// <param name="retryHistory">Gets the retry histories.</param>
        /// <param name="name">Gets the workflow run action name.</param>
        /// <param name="type">Gets the workflow run action type.</param>
        public WorkflowRunAction(string id = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string status = default(string), string code = default(string), object error = default(object), string trackingId = default(string), RunActionCorrelation correlation = default(RunActionCorrelation), ContentLink inputsLink = default(ContentLink), ContentLink outputsLink = default(ContentLink), object trackedProperties = default(object), IList<RetryHistory> retryHistory = default(IList<RetryHistory>), string name = default(string), string type = default(string))
            : base(id)
        {
            StartTime = startTime;
            EndTime = endTime;
            Status = status;
            Code = code;
            Error = error;
            TrackingId = trackingId;
            Correlation = correlation;
            InputsLink = inputsLink;
            OutputsLink = outputsLink;
            TrackedProperties = trackedProperties;
            RetryHistory = retryHistory;
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the start time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the end time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets the status. Possible values include: 'NotSpecified', 'Paused',
        /// 'Running', 'Waiting', 'Succeeded', 'Skipped', 'Suspended',
        /// 'Cancelled', 'Failed', 'Faulted', 'TimedOut', 'Aborted', 'Ignored'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        [JsonProperty(PropertyName = "properties.code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the error.
        /// </summary>
        [JsonProperty(PropertyName = "properties.error")]
        public object Error { get; private set; }

        /// <summary>
        /// Gets the tracking id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trackingId")]
        public string TrackingId { get; private set; }

        /// <summary>
        /// Gets or sets the correlation properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.correlation")]
        public RunActionCorrelation Correlation { get; set; }

        /// <summary>
        /// Gets the link to inputs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inputsLink")]
        public ContentLink InputsLink { get; private set; }

        /// <summary>
        /// Gets the link to outputs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputsLink")]
        public ContentLink OutputsLink { get; private set; }

        /// <summary>
        /// Gets the tracked properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trackedProperties")]
        public object TrackedProperties { get; private set; }

        /// <summary>
        /// Gets the retry histories.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retryHistory")]
        public IList<RetryHistory> RetryHistory { get; set; }

        /// <summary>
        /// Gets the workflow run action name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the workflow run action type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
