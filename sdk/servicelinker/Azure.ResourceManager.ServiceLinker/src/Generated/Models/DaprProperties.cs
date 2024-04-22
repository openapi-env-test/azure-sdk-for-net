// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> Indicates some additional properties for dapr client type. </summary>
    public partial class DaprProperties
    {
        /// <summary> Initializes a new instance of <see cref="DaprProperties"/>. </summary>
        public DaprProperties()
        {
            Metadata = new ChangeTrackingList<DaprMetadata>();
            Scopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DaprProperties"/>. </summary>
        /// <param name="version"> The dapr component version. </param>
        /// <param name="componentType"> The dapr component type. </param>
        /// <param name="secretStoreComponent"> The name of a secret store dapr to retrieve secret. </param>
        /// <param name="metadata"> Additional dapr metadata. </param>
        /// <param name="scopes"> The dapr component scopes. </param>
        /// <param name="runtimeVersion"> The runtime version supported by the properties. </param>
        /// <param name="bindingComponentDirection"> The direction supported by the dapr binding component. </param>
        internal DaprProperties(string version, string componentType, string secretStoreComponent, IList<DaprMetadata> metadata, IList<string> scopes, string runtimeVersion, DaprBindingComponentDirection? bindingComponentDirection)
        {
            Version = version;
            ComponentType = componentType;
            SecretStoreComponent = secretStoreComponent;
            Metadata = metadata;
            Scopes = scopes;
            RuntimeVersion = runtimeVersion;
            BindingComponentDirection = bindingComponentDirection;
        }

        /// <summary> The dapr component version. </summary>
        public string Version { get; set; }
        /// <summary> The dapr component type. </summary>
        public string ComponentType { get; set; }
        /// <summary> The name of a secret store dapr to retrieve secret. </summary>
        public string SecretStoreComponent { get; set; }
        /// <summary> Additional dapr metadata. </summary>
        public IList<DaprMetadata> Metadata { get; }
        /// <summary> The dapr component scopes. </summary>
        public IList<string> Scopes { get; }
        /// <summary> The runtime version supported by the properties. </summary>
        public string RuntimeVersion { get; }
        /// <summary> The direction supported by the dapr binding component. </summary>
        public DaprBindingComponentDirection? BindingComponentDirection { get; }
    }
}
