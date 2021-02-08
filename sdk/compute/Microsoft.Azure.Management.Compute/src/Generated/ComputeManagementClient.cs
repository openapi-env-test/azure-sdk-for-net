// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// Compute Client
    /// </summary>
    public partial class ComputeManagementClient : ServiceClient<ComputeManagementClient>, IComputeManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every service
        /// call.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Client Api Version.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IAvailabilitySetsOperations.
        /// </summary>
        public virtual IAvailabilitySetsOperations AvailabilitySets { get; private set; }

        /// <summary>
        /// Gets the IProximityPlacementGroupsOperations.
        /// </summary>
        public virtual IProximityPlacementGroupsOperations ProximityPlacementGroups { get; private set; }

        /// <summary>
        /// Gets the IDedicatedHostGroupsOperations.
        /// </summary>
        public virtual IDedicatedHostGroupsOperations DedicatedHostGroups { get; private set; }

        /// <summary>
        /// Gets the IDedicatedHostsOperations.
        /// </summary>
        public virtual IDedicatedHostsOperations DedicatedHosts { get; private set; }

        /// <summary>
        /// Gets the IVirtualMachineExtensionImagesOperations.
        /// </summary>
        public virtual IVirtualMachineExtensionImagesOperations VirtualMachineExtensionImages { get; private set; }

        /// <summary>
        /// Gets the IVirtualMachineExtensionsOperations.
        /// </summary>
        public virtual IVirtualMachineExtensionsOperations VirtualMachineExtensions { get; private set; }

        /// <summary>
        /// Gets the IVirtualMachineImagesOperations.
        /// </summary>
        public virtual IVirtualMachineImagesOperations VirtualMachineImages { get; private set; }

        /// <summary>
        /// Gets the IUsageOperations.
        /// </summary>
        public virtual IUsageOperations Usage { get; private set; }

        /// <summary>
        /// Gets the IVirtualMachinesOperations.
        /// </summary>
        public virtual IVirtualMachinesOperations VirtualMachines { get; private set; }

        /// <summary>
        /// Gets the IVirtualMachineSizesOperations.
        /// </summary>
        public virtual IVirtualMachineSizesOperations VirtualMachineSizes { get; private set; }

        /// <summary>
        /// Gets the IImagesOperations.
        /// </summary>
        public virtual IImagesOperations Images { get; private set; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetsOperations.
        /// </summary>
        public virtual IVirtualMachineScaleSetsOperations VirtualMachineScaleSets { get; private set; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetExtensionsOperations.
        /// </summary>
        public virtual IVirtualMachineScaleSetExtensionsOperations VirtualMachineScaleSetExtensions { get; private set; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetRollingUpgradesOperations.
        /// </summary>
        public virtual IVirtualMachineScaleSetRollingUpgradesOperations VirtualMachineScaleSetRollingUpgrades { get; private set; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetVMExtensionsOperations.
        /// </summary>
        public virtual IVirtualMachineScaleSetVMExtensionsOperations VirtualMachineScaleSetVMExtensions { get; private set; }

        /// <summary>
        /// Gets the IVirtualMachineScaleSetVMsOperations.
        /// </summary>
        public virtual IVirtualMachineScaleSetVMsOperations VirtualMachineScaleSetVMs { get; private set; }

        /// <summary>
        /// Gets the ILogAnalyticsOperations.
        /// </summary>
        public virtual ILogAnalyticsOperations LogAnalytics { get; private set; }

        /// <summary>
        /// Gets the IDisksOperations.
        /// </summary>
        public virtual IDisksOperations Disks { get; private set; }

        /// <summary>
        /// Gets the ISnapshotsOperations.
        /// </summary>
        public virtual ISnapshotsOperations Snapshots { get; private set; }

        /// <summary>
        /// Gets the IDiskEncryptionSetsOperations.
        /// </summary>
        public virtual IDiskEncryptionSetsOperations DiskEncryptionSets { get; private set; }

        /// <summary>
        /// Gets the IGalleriesOperations.
        /// </summary>
        public virtual IGalleriesOperations Galleries { get; private set; }

        /// <summary>
        /// Gets the IGalleryImagesOperations.
        /// </summary>
        public virtual IGalleryImagesOperations GalleryImages { get; private set; }

        /// <summary>
        /// Gets the IGalleryImageVersionsOperations.
        /// </summary>
        public virtual IGalleryImageVersionsOperations GalleryImageVersions { get; private set; }

        /// <summary>
        /// Gets the IGalleryApplicationsOperations.
        /// </summary>
        public virtual IGalleryApplicationsOperations GalleryApplications { get; private set; }

        /// <summary>
        /// Gets the IGalleryApplicationVersionsOperations.
        /// </summary>
        public virtual IGalleryApplicationVersionsOperations GalleryApplicationVersions { get; private set; }

        /// <summary>
        /// Gets the IVirtualMachineRunCommandsOperations.
        /// </summary>
        public virtual IVirtualMachineRunCommandsOperations VirtualMachineRunCommands { get; private set; }

        /// <summary>
        /// Initializes a new instance of the ComputeManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling ComputeManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        protected ComputeManagementClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ComputeManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected ComputeManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ComputeManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected ComputeManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ComputeManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected ComputeManagementClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the ComputeManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected ComputeManagementClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the ComputeManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ComputeManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ComputeManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling ComputeManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ComputeManagementClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ComputeManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ComputeManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ComputeManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ComputeManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ComputeManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ComputeManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Operations = new Operations(this);
            AvailabilitySets = new AvailabilitySetsOperations(this);
            ProximityPlacementGroups = new ProximityPlacementGroupsOperations(this);
            DedicatedHostGroups = new DedicatedHostGroupsOperations(this);
            DedicatedHosts = new DedicatedHostsOperations(this);
            VirtualMachineExtensionImages = new VirtualMachineExtensionImagesOperations(this);
            VirtualMachineExtensions = new VirtualMachineExtensionsOperations(this);
            VirtualMachineImages = new VirtualMachineImagesOperations(this);
            Usage = new UsageOperations(this);
            VirtualMachines = new VirtualMachinesOperations(this);
            VirtualMachineSizes = new VirtualMachineSizesOperations(this);
            Images = new ImagesOperations(this);
            VirtualMachineScaleSets = new VirtualMachineScaleSetsOperations(this);
            VirtualMachineScaleSetExtensions = new VirtualMachineScaleSetExtensionsOperations(this);
            VirtualMachineScaleSetRollingUpgrades = new VirtualMachineScaleSetRollingUpgradesOperations(this);
            VirtualMachineScaleSetVMExtensions = new VirtualMachineScaleSetVMExtensionsOperations(this);
            VirtualMachineScaleSetVMs = new VirtualMachineScaleSetVMsOperations(this);
            LogAnalytics = new LogAnalyticsOperations(this);
            Disks = new DisksOperations(this);
            Snapshots = new SnapshotsOperations(this);
            DiskEncryptionSets = new DiskEncryptionSetsOperations(this);
            Galleries = new GalleriesOperations(this);
            GalleryImages = new GalleryImagesOperations(this);
            GalleryImageVersions = new GalleryImageVersionsOperations(this);
            GalleryApplications = new GalleryApplicationsOperations(this);
            GalleryApplicationVersions = new GalleryApplicationVersionsOperations(this);
            VirtualMachineRunCommands = new VirtualMachineRunCommandsOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2019-07-01";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
