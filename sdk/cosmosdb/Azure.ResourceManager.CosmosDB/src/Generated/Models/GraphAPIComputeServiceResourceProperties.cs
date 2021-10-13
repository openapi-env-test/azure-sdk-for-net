// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Properties for GraphAPIComputeServiceResource. </summary>
    public partial class GraphAPIComputeServiceResourceProperties : ServiceResourceProperties
    {
        /// <summary> Initializes a new instance of GraphAPIComputeServiceResourceProperties. </summary>
        public GraphAPIComputeServiceResourceProperties()
        {
            Locations = new ChangeTrackingList<GraphAPIComputeRegionalServiceResource>();
            ServiceType = ServiceType.GraphAPICompute;
        }

        /// <summary> Initializes a new instance of GraphAPIComputeServiceResourceProperties. </summary>
        /// <param name="creationTime"> Time of the last state change (ISO-8601 format). </param>
        /// <param name="instanceSize"> Instance type for the service. </param>
        /// <param name="instanceCount"> Instance count for the service. </param>
        /// <param name="serviceType"> ServiceType for the service. </param>
        /// <param name="status"> Describes the status of a service. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="graphApiComputeEndpoint"> GraphAPICompute endpoint for the service. </param>
        /// <param name="locations"> An array that contains all of the locations for the service. </param>
        internal GraphAPIComputeServiceResourceProperties(DateTimeOffset? creationTime, ServiceSize? instanceSize, int? instanceCount, ServiceType serviceType, ServiceStatus? status, IDictionary<string, object> additionalProperties, string graphApiComputeEndpoint, IReadOnlyList<GraphAPIComputeRegionalServiceResource> locations) : base(creationTime, instanceSize, instanceCount, serviceType, status, additionalProperties)
        {
            GraphApiComputeEndpoint = graphApiComputeEndpoint;
            Locations = locations;
            ServiceType = serviceType;
        }

        /// <summary> GraphAPICompute endpoint for the service. </summary>
        public string GraphApiComputeEndpoint { get; set; }
        /// <summary> An array that contains all of the locations for the service. </summary>
        public IReadOnlyList<GraphAPIComputeRegionalServiceResource> Locations { get; }
    }
}
