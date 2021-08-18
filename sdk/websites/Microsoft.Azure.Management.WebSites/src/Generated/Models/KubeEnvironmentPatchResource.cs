// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ARM resource for a KubeEnvironment when patching
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class KubeEnvironmentPatchResource : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the KubeEnvironmentPatchResource
        /// class.
        /// </summary>
        public KubeEnvironmentPatchResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KubeEnvironmentPatchResource
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="provisioningState">Provisioning state of the
        /// Kubernetes Environment. Possible values include: 'Succeeded',
        /// 'Failed', 'Canceled', 'Waiting', 'InitializationInProgress',
        /// 'InfrastructureSetupInProgress', 'InfrastructureSetupComplete',
        /// 'ScheduledForDelete', 'UpgradeRequested', 'UpgradeFailed'</param>
        /// <param name="deploymentErrors">Any errors that occurred during
        /// deployment or deployment validation</param>
        /// <param name="internalLoadBalancerEnabled">Only visible within
        /// Vnet/Subnet</param>
        /// <param name="defaultDomain">Default Domain Name for the
        /// cluster</param>
        /// <param name="staticIp">Static IP of the KubeEnvironment</param>
        /// <param name="arcConfiguration">Cluster configuration which
        /// determines the ARC cluster
        /// components types. Eg: Choosing between BuildService kind,
        /// FrontEnd Service ArtifactsStorageType etc.</param>
        /// <param name="appLogsConfiguration">Cluster configuration which
        /// enables the log daemon to export
        /// app logs to a destination. Currently only "log-analytics" is
        /// supported</param>
        public KubeEnvironmentPatchResource(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), KubeEnvironmentProvisioningState? provisioningState = default(KubeEnvironmentProvisioningState?), string deploymentErrors = default(string), bool? internalLoadBalancerEnabled = default(bool?), string defaultDomain = default(string), string staticIp = default(string), ArcConfiguration arcConfiguration = default(ArcConfiguration), AppLogsConfiguration appLogsConfiguration = default(AppLogsConfiguration), string aksResourceID = default(string))
            : base(id, name, kind, type)
        {
            ProvisioningState = provisioningState;
            DeploymentErrors = deploymentErrors;
            InternalLoadBalancerEnabled = internalLoadBalancerEnabled;
            DefaultDomain = defaultDomain;
            StaticIp = staticIp;
            ArcConfiguration = arcConfiguration;
            AppLogsConfiguration = appLogsConfiguration;
            AksResourceID = aksResourceID;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets provisioning state of the Kubernetes Environment. Possible
        /// values include: 'Succeeded', 'Failed', 'Canceled', 'Waiting',
        /// 'InitializationInProgress', 'InfrastructureSetupInProgress',
        /// 'InfrastructureSetupComplete', 'ScheduledForDelete',
        /// 'UpgradeRequested', 'UpgradeFailed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public KubeEnvironmentProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets any errors that occurred during deployment or deployment
        /// validation
        /// </summary>
        [JsonProperty(PropertyName = "properties.deploymentErrors")]
        public string DeploymentErrors { get; private set; }

        /// <summary>
        /// Gets or sets only visible within Vnet/Subnet
        /// </summary>
        [JsonProperty(PropertyName = "properties.internalLoadBalancerEnabled")]
        public bool? InternalLoadBalancerEnabled { get; set; }

        /// <summary>
        /// Gets default Domain Name for the cluster
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultDomain")]
        public string DefaultDomain { get; private set; }

        /// <summary>
        /// Gets or sets static IP of the KubeEnvironment
        /// </summary>
        [JsonProperty(PropertyName = "properties.staticIp")]
        public string StaticIp { get; set; }

        /// <summary>
        /// Gets or sets cluster configuration which determines the ARC cluster
        /// components types. Eg: Choosing between BuildService kind,
        /// FrontEnd Service ArtifactsStorageType etc.
        /// </summary>
        [JsonProperty(PropertyName = "properties.arcConfiguration")]
        public ArcConfiguration ArcConfiguration { get; set; }

        /// <summary>
        /// Gets or sets cluster configuration which enables the log daemon to
        /// export
        /// app logs to a destination. Currently only "log-analytics" is
        /// supported
        /// </summary>
        [JsonProperty(PropertyName = "properties.appLogsConfiguration")]
        public AppLogsConfiguration AppLogsConfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.aksResourceID")]
        public string AksResourceID { get; set; }

    }
}
