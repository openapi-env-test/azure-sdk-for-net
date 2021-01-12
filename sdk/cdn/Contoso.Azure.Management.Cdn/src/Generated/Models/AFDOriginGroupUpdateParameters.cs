// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Contoso.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// AFDOrigin group properties needed for origin group creation or update.
    /// </summary>
    [JsonTransformation]
    public partial class AFDOriginGroupUpdateParameters : IResource
    {
        /// <summary>
        /// Initializes a new instance of the AFDOriginGroupUpdateParameters
        /// class.
        /// </summary>
        public AFDOriginGroupUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AFDOriginGroupUpdateParameters
        /// class.
        /// </summary>
        /// <param name="loadBalancingSettings">Load balancing settings for a
        /// backend pool</param>
        /// <param name="healthProbeSettings">Health probe settings to the
        /// origin that is used to determine the health of the origin.</param>
        /// <param
        /// name="trafficRestorationTimeToHealedOrNewEndpointsInMinutes">Time
        /// in minutes to shift the traffic to the endpoint gradually when an
        /// unhealthy endpoint comes healthy or a new endpoint is added.
        /// Default is 10 mins. This property is currently not
        /// supported.</param>
        /// <param name="responseBasedAfdOriginErrorDetectionSettings">The JSON
        /// object that contains the properties to determine origin health
        /// using real requests/responses. This property is currently not
        /// supported.</param>
        /// <param name="sessionAffinityState">Whether to allow session
        /// affinity on this host. Valid options are 'Enabled' or 'Disabled'.
        /// Possible values include: 'Enabled', 'Disabled'</param>
        public AFDOriginGroupUpdateParameters(LoadBalancingSettingsParameters loadBalancingSettings = default(LoadBalancingSettingsParameters), HealthProbeParameters healthProbeSettings = default(HealthProbeParameters), int? trafficRestorationTimeToHealedOrNewEndpointsInMinutes = default(int?), ResponseBasedOriginErrorDetectionParameters responseBasedAfdOriginErrorDetectionSettings = default(ResponseBasedOriginErrorDetectionParameters), string sessionAffinityState = default(string))
        {
            LoadBalancingSettings = loadBalancingSettings;
            HealthProbeSettings = healthProbeSettings;
            TrafficRestorationTimeToHealedOrNewEndpointsInMinutes = trafficRestorationTimeToHealedOrNewEndpointsInMinutes;
            ResponseBasedAfdOriginErrorDetectionSettings = responseBasedAfdOriginErrorDetectionSettings;
            SessionAffinityState = sessionAffinityState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets load balancing settings for a backend pool
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancingSettings")]
        public LoadBalancingSettingsParameters LoadBalancingSettings { get; set; }

        /// <summary>
        /// Gets or sets health probe settings to the origin that is used to
        /// determine the health of the origin.
        /// </summary>
        [JsonProperty(PropertyName = "properties.healthProbeSettings")]
        public HealthProbeParameters HealthProbeSettings { get; set; }

        /// <summary>
        /// Gets or sets time in minutes to shift the traffic to the endpoint
        /// gradually when an unhealthy endpoint comes healthy or a new
        /// endpoint is added. Default is 10 mins. This property is currently
        /// not supported.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trafficRestorationTimeToHealedOrNewEndpointsInMinutes")]
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the JSON object that contains the properties to
        /// determine origin health using real requests/responses. This
        /// property is currently not supported.
        /// </summary>
        [JsonProperty(PropertyName = "properties.responseBasedAfdOriginErrorDetectionSettings")]
        public ResponseBasedOriginErrorDetectionParameters ResponseBasedAfdOriginErrorDetectionSettings { get; set; }

        /// <summary>
        /// Gets or sets whether to allow session affinity on this host. Valid
        /// options are 'Enabled' or 'Disabled'. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.sessionAffinityState")]
        public string SessionAffinityState { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HealthProbeSettings != null)
            {
                HealthProbeSettings.Validate();
            }
            if (TrafficRestorationTimeToHealedOrNewEndpointsInMinutes > 50)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "TrafficRestorationTimeToHealedOrNewEndpointsInMinutes", 50);
            }
            if (TrafficRestorationTimeToHealedOrNewEndpointsInMinutes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TrafficRestorationTimeToHealedOrNewEndpointsInMinutes", 0);
            }
            if (ResponseBasedAfdOriginErrorDetectionSettings != null)
            {
                ResponseBasedAfdOriginErrorDetectionSettings.Validate();
            }
        }
    }
}
