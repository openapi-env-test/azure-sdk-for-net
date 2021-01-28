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
    /// Represents a cloud application entity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("CloudApplication")]
    [Rest.Serialization.JsonTransformation]
    public partial class CloudApplicationEntity : Entity
    {
        /// <summary>
        /// Initializes a new instance of the CloudApplicationEntity class.
        /// </summary>
        public CloudApplicationEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloudApplicationEntity class.
        /// </summary>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="additionalData">A bag of custom fields that should be
        /// part of the entity and will be presented to the user.</param>
        /// <param name="friendlyName">The graph item display name which is a
        /// short humanly readable description of the graph item instance. This
        /// property is optional and might be system generated.</param>
        /// <param name="appId">The technical identifier of the
        /// application.</param>
        /// <param name="appName">The name of the related cloud
        /// application.</param>
        /// <param name="instanceName">The user defined instance name of the
        /// cloud application. It is often used to distinguish between several
        /// applications of the same type that a customer has.</param>
        public CloudApplicationEntity(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, object> additionalData = default(IDictionary<string, object>), string friendlyName = default(string), int? appId = default(int?), string appName = default(string), string instanceName = default(string))
            : base(id, name, type)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            AppId = appId;
            AppName = appName;
            InstanceName = instanceName;
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
        /// Gets the technical identifier of the application.
        /// </summary>
        [JsonProperty(PropertyName = "properties.appId")]
        public int? AppId { get; private set; }

        /// <summary>
        /// Gets the name of the related cloud application.
        /// </summary>
        [JsonProperty(PropertyName = "properties.appName")]
        public string AppName { get; private set; }

        /// <summary>
        /// Gets the user defined instance name of the cloud application. It is
        /// often used to distinguish between several applications of the same
        /// type that a customer has.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceName")]
        public string InstanceName { get; private set; }

    }
}
