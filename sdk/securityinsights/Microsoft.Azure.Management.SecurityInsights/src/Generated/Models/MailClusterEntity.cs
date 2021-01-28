// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Contoso.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a mail cluster entity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("MailCluster")]
    [Rest.Serialization.JsonTransformation]
    public partial class MailClusterEntity : Entity
    {
        /// <summary>
        /// Initializes a new instance of the MailClusterEntity class.
        /// </summary>
        public MailClusterEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MailClusterEntity class.
        /// </summary>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="additionalData">A bag of custom fields that should be
        /// part of the entity and will be presented to the user.</param>
        /// <param name="friendlyName">The graph item display name which is a
        /// short humanly readable description of the graph item instance. This
        /// property is optional and might be system generated.</param>
        /// <param name="networkMessageIds">The mail message IDs that are part
        /// of the mail cluster</param>
        /// <param name="countByDeliveryStatus">Count of mail messages by
        /// DeliveryStatus string representation</param>
        /// <param name="countByThreatType">Count of mail messages by
        /// ThreatType string representation</param>
        /// <param name="countByProtectionStatus">Count of mail messages by
        /// ProtectionStatus string representation</param>
        /// <param name="threats">The threats of mail messages that are part of
        /// the mail cluster</param>
        /// <param name="query">The query that was used to identify the
        /// messages of the mail cluster</param>
        /// <param name="queryTime">The query time</param>
        /// <param name="mailCount">The number of mail messages that are part
        /// of the mail cluster</param>
        /// <param name="isVolumeAnomaly">Is this a volume anomaly mail
        /// cluster</param>
        /// <param name="source">The source of the mail cluster (default is
        /// 'O365 ATP')</param>
        /// <param name="clusterSourceIdentifier">The id of the cluster
        /// source</param>
        /// <param name="clusterSourceType">The type of the cluster
        /// source</param>
        /// <param name="clusterQueryStartTime">The cluster query start
        /// time</param>
        /// <param name="clusterQueryEndTime">The cluster query end
        /// time</param>
        /// <param name="clusterGroup">The cluster group</param>
        public MailClusterEntity(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, object> additionalData = default(IDictionary<string, object>), string friendlyName = default(string), IList<string> networkMessageIds = default(IList<string>), object countByDeliveryStatus = default(object), object countByThreatType = default(object), object countByProtectionStatus = default(object), IList<string> threats = default(IList<string>), string query = default(string), System.DateTime? queryTime = default(System.DateTime?), int? mailCount = default(int?), bool? isVolumeAnomaly = default(bool?), string source = default(string), string clusterSourceIdentifier = default(string), string clusterSourceType = default(string), System.DateTime? clusterQueryStartTime = default(System.DateTime?), System.DateTime? clusterQueryEndTime = default(System.DateTime?), string clusterGroup = default(string))
            : base(id, name, type)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            NetworkMessageIds = networkMessageIds;
            CountByDeliveryStatus = countByDeliveryStatus;
            CountByThreatType = countByThreatType;
            CountByProtectionStatus = countByProtectionStatus;
            Threats = threats;
            Query = query;
            QueryTime = queryTime;
            MailCount = mailCount;
            IsVolumeAnomaly = isVolumeAnomaly;
            Source = source;
            ClusterSourceIdentifier = clusterSourceIdentifier;
            ClusterSourceType = clusterSourceType;
            ClusterQueryStartTime = clusterQueryStartTime;
            ClusterQueryEndTime = clusterQueryEndTime;
            ClusterGroup = clusterGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a bag of custom fields that should be part of the entity and
        /// will be presented to the user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalData")]
        public IDictionary<string, object> AdditionalData { get; private set; }

        /// <summary>
        /// Gets the graph item display name which is a short humanly readable
        /// description of the graph item instance. This property is optional
        /// and might be system generated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; private set; }

        /// <summary>
        /// Gets the mail message IDs that are part of the mail cluster
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkMessageIds")]
        public IList<string> NetworkMessageIds { get; private set; }

        /// <summary>
        /// Gets count of mail messages by DeliveryStatus string representation
        /// </summary>
        [JsonProperty(PropertyName = "properties.countByDeliveryStatus")]
        public object CountByDeliveryStatus { get; private set; }

        /// <summary>
        /// Gets count of mail messages by ThreatType string representation
        /// </summary>
        [JsonProperty(PropertyName = "properties.countByThreatType")]
        public object CountByThreatType { get; private set; }

        /// <summary>
        /// Gets count of mail messages by ProtectionStatus string
        /// representation
        /// </summary>
        [JsonProperty(PropertyName = "properties.countByProtectionStatus")]
        public object CountByProtectionStatus { get; private set; }

        /// <summary>
        /// Gets the threats of mail messages that are part of the mail cluster
        /// </summary>
        [JsonProperty(PropertyName = "properties.threats")]
        public IList<string> Threats { get; private set; }

        /// <summary>
        /// Gets the query that was used to identify the messages of the mail
        /// cluster
        /// </summary>
        [JsonProperty(PropertyName = "properties.query")]
        public string Query { get; private set; }

        /// <summary>
        /// Gets the query time
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryTime")]
        public System.DateTime? QueryTime { get; private set; }

        /// <summary>
        /// Gets the number of mail messages that are part of the mail cluster
        /// </summary>
        [JsonProperty(PropertyName = "properties.mailCount")]
        public int? MailCount { get; private set; }

        /// <summary>
        /// Gets is this a volume anomaly mail cluster
        /// </summary>
        [JsonProperty(PropertyName = "properties.isVolumeAnomaly")]
        public bool? IsVolumeAnomaly { get; private set; }

        /// <summary>
        /// Gets the source of the mail cluster (default is 'O365 ATP')
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public string Source { get; private set; }

        /// <summary>
        /// Gets the id of the cluster source
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterSourceIdentifier")]
        public string ClusterSourceIdentifier { get; private set; }

        /// <summary>
        /// Gets the type of the cluster source
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterSourceType")]
        public string ClusterSourceType { get; private set; }

        /// <summary>
        /// Gets the cluster query start time
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterQueryStartTime")]
        public System.DateTime? ClusterQueryStartTime { get; private set; }

        /// <summary>
        /// Gets the cluster query end time
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterQueryEndTime")]
        public System.DateTime? ClusterQueryEndTime { get; private set; }

        /// <summary>
        /// Gets the cluster group
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterGroup")]
        public string ClusterGroup { get; private set; }

    }
}
