// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Ssl predefined policy
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewaySslPredefinedPolicy : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewaySslPredefinedPolicy class.
        /// </summary>
        public ApplicationGatewaySslPredefinedPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewaySslPredefinedPolicy class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Name of the Ssl predefined policy.</param>
        /// <param name="cipherSuites">Ssl cipher suites to be enabled in the
        /// specified order for application gateway.</param>
        /// <param name="minProtocolVersion">Minimum version of Ssl protocol to
        /// be supported on application gateway. Possible values include:
        /// 'TLSv1_0', 'TLSv1_1', 'TLSv1_2'</param>
        public ApplicationGatewaySslPredefinedPolicy(string id = default(string), string name = default(string), IList<string> cipherSuites = default(IList<string>), string minProtocolVersion = default(string))
            : base(id)
        {
            Name = name;
            CipherSuites = cipherSuites;
            MinProtocolVersion = minProtocolVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Ssl predefined policy.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ssl cipher suites to be enabled in the specified order
        /// for application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cipherSuites")]
        public IList<string> CipherSuites { get; set; }

        /// <summary>
        /// Gets or sets minimum version of Ssl protocol to be supported on
        /// application gateway. Possible values include: 'TLSv1_0', 'TLSv1_1',
        /// 'TLSv1_2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.minProtocolVersion")]
        public string MinProtocolVersion { get; set; }

    }
}
