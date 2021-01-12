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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Friendly Routes name mapping to the any Routes or secret related
    /// information.
    /// </summary>
    [JsonTransformation]
    public partial class Route : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Route class.
        /// </summary>
        public Route()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Route class.
        /// </summary>
        /// <param name="originGroup">A reference to the origin group.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="customDomains">Domains referenced by this
        /// endpoint.</param>
        /// <param name="originPath">A directory path on the origin that
        /// AzureFrontDoor can use to retrieve content from, e.g.
        /// contoso.cloudapp.net/originpath.</param>
        /// <param name="ruleSets">rule sets referenced by this
        /// endpoint.</param>
        /// <param name="supportedProtocols">List of supported protocols for
        /// this route.</param>
        /// <param name="patternsToMatch">The route patterns of the
        /// rule.</param>
        /// <param name="compressionSettings">compression settings.</param>
        /// <param name="queryStringCachingBehavior">Defines how AzureFrontDoor
        /// caches requests that include query strings. You can ignore any
        /// query strings when caching, bypass caching to prevent requests that
        /// contain query strings from being cached, or cache every request
        /// with a unique URL. Possible values include: 'IgnoreQueryString',
        /// 'BypassCaching', 'UseQueryString', 'NotSet'</param>
        /// <param name="optimizationType">Specifies what scenario the customer
        /// wants this AzureFrontDoor endpoint to optimize for, e.g. Download,
        /// Media services. With this information, AzureFrontDoor can apply
        /// scenario driven optimization. Possible values include:
        /// 'GeneralWebDelivery', 'GeneralMediaStreaming',
        /// 'VideoOnDemandMediaStreaming', 'LargeFileDownload',
        /// 'DynamicSiteAcceleration'</param>
        /// <param name="forwardingProtocol">Protocol this rule will use when
        /// forwarding traffic to backends. Possible values include:
        /// 'HttpOnly', 'HttpsOnly', 'MatchRequest'</param>
        /// <param name="linkToDefaultDomain">whether this route will be linked
        /// to the default endpoint domain. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="httpsRedirect">Whether to automatically redirect HTTP
        /// traffic to HTTPS traffic. Note that this is a easy way to set up
        /// this rule and it will be the first rule that gets executed.
        /// Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="enabledState">Whether to enable use of this rule.
        /// Permitted values are 'Enabled' or 'Disabled'. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="provisioningState">Provisioning status. Possible
        /// values include: 'Succeeded', 'Failed', 'Updating', 'Deleting',
        /// 'Creating'</param>
        /// <param name="deploymentStatus">Possible values include:
        /// 'NotStarted', 'InProgress', 'Succeeded', 'Failed'</param>
        public Route(ResourceReference originGroup, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), IList<ResourceReference> customDomains = default(IList<ResourceReference>), string originPath = default(string), IList<ResourceReference> ruleSets = default(IList<ResourceReference>), IList<string> supportedProtocols = default(IList<string>), IList<string> patternsToMatch = default(IList<string>), object compressionSettings = default(object), QueryStringCachingBehavior? queryStringCachingBehavior = default(QueryStringCachingBehavior?), string optimizationType = default(string), string forwardingProtocol = default(string), string linkToDefaultDomain = default(string), string httpsRedirect = default(string), string enabledState = default(string), string provisioningState = default(string), string deploymentStatus = default(string))
            : base(id, name, type, systemData)
        {
            CustomDomains = customDomains;
            OriginGroup = originGroup;
            OriginPath = originPath;
            RuleSets = ruleSets;
            SupportedProtocols = supportedProtocols;
            PatternsToMatch = patternsToMatch;
            CompressionSettings = compressionSettings;
            QueryStringCachingBehavior = queryStringCachingBehavior;
            OptimizationType = optimizationType;
            ForwardingProtocol = forwardingProtocol;
            LinkToDefaultDomain = linkToDefaultDomain;
            HttpsRedirect = httpsRedirect;
            EnabledState = enabledState;
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets domains referenced by this endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomains")]
        public IList<ResourceReference> CustomDomains { get; set; }

        /// <summary>
        /// Gets or sets a reference to the origin group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.originGroup")]
        public ResourceReference OriginGroup { get; set; }

        /// <summary>
        /// Gets or sets a directory path on the origin that AzureFrontDoor can
        /// use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        /// </summary>
        [JsonProperty(PropertyName = "properties.originPath")]
        public string OriginPath { get; set; }

        /// <summary>
        /// Gets or sets rule sets referenced by this endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ruleSets")]
        public IList<ResourceReference> RuleSets { get; set; }

        /// <summary>
        /// Gets or sets list of supported protocols for this route.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportedProtocols")]
        public IList<string> SupportedProtocols { get; set; }

        /// <summary>
        /// Gets or sets the route patterns of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.patternsToMatch")]
        public IList<string> PatternsToMatch { get; set; }

        /// <summary>
        /// Gets or sets compression settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.compressionSettings")]
        public object CompressionSettings { get; set; }

        /// <summary>
        /// Gets or sets defines how AzureFrontDoor caches requests that
        /// include query strings. You can ignore any query strings when
        /// caching, bypass caching to prevent requests that contain query
        /// strings from being cached, or cache every request with a unique
        /// URL. Possible values include: 'IgnoreQueryString', 'BypassCaching',
        /// 'UseQueryString', 'NotSet'
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryStringCachingBehavior")]
        public QueryStringCachingBehavior? QueryStringCachingBehavior { get; set; }

        /// <summary>
        /// Gets or sets specifies what scenario the customer wants this
        /// AzureFrontDoor endpoint to optimize for, e.g. Download, Media
        /// services. With this information, AzureFrontDoor can apply scenario
        /// driven optimization. Possible values include: 'GeneralWebDelivery',
        /// 'GeneralMediaStreaming', 'VideoOnDemandMediaStreaming',
        /// 'LargeFileDownload', 'DynamicSiteAcceleration'
        /// </summary>
        [JsonProperty(PropertyName = "properties.optimizationType")]
        public string OptimizationType { get; set; }

        /// <summary>
        /// Gets or sets protocol this rule will use when forwarding traffic to
        /// backends. Possible values include: 'HttpOnly', 'HttpsOnly',
        /// 'MatchRequest'
        /// </summary>
        [JsonProperty(PropertyName = "properties.forwardingProtocol")]
        public string ForwardingProtocol { get; set; }

        /// <summary>
        /// Gets or sets whether this route will be linked to the default
        /// endpoint domain. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.linkToDefaultDomain")]
        public string LinkToDefaultDomain { get; set; }

        /// <summary>
        /// Gets or sets whether to automatically redirect HTTP traffic to
        /// HTTPS traffic. Note that this is a easy way to set up this rule and
        /// it will be the first rule that gets executed. Possible values
        /// include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpsRedirect")]
        public string HttpsRedirect { get; set; }

        /// <summary>
        /// Gets or sets whether to enable use of this rule. Permitted values
        /// are 'Enabled' or 'Disabled'. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabledState")]
        public string EnabledState { get; set; }

        /// <summary>
        /// Gets provisioning status. Possible values include: 'Succeeded',
        /// 'Failed', 'Updating', 'Deleting', 'Creating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets possible values include: 'NotStarted', 'InProgress',
        /// 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.deploymentStatus")]
        public string DeploymentStatus { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OriginGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OriginGroup");
            }
        }
    }
}
