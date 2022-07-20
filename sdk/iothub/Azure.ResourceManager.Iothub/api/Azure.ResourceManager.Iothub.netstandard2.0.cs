namespace Azure.ResourceManager.Iothub
{
    public partial class CertificateDescriptionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Iothub.CertificateDescriptionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Iothub.CertificateDescriptionResource>, System.Collections.IEnumerable
    {
        protected CertificateDescriptionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.CertificateDescriptionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string certificateName, Azure.ResourceManager.Iothub.CertificateDescriptionData data, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.CertificateDescriptionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string certificateName, Azure.ResourceManager.Iothub.CertificateDescriptionData data, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string certificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string certificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.CertificateDescriptionResource> Get(string certificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Iothub.CertificateDescriptionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Iothub.CertificateDescriptionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.CertificateDescriptionResource>> GetAsync(string certificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Iothub.CertificateDescriptionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Iothub.CertificateDescriptionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Iothub.CertificateDescriptionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Iothub.CertificateDescriptionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class CertificateDescriptionData : Azure.ResourceManager.Models.ResourceData
    {
        public CertificateDescriptionData() { }
        public Azure.ETag? Etag { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.CertificateProperties Properties { get { throw null; } set { } }
    }
    public partial class CertificateDescriptionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected CertificateDescriptionResource() { }
        public virtual Azure.ResourceManager.Iothub.CertificateDescriptionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string certificateName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, string ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, string ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.Models.CertificateWithNonceDescription> GenerateVerificationCode(string ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.Models.CertificateWithNonceDescription>> GenerateVerificationCodeAsync(string ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.CertificateDescriptionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.CertificateDescriptionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.CertificateDescriptionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Iothub.CertificateDescriptionData data, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.CertificateDescriptionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Iothub.CertificateDescriptionData data, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.CertificateDescriptionResource> Verify(string ifMatch, Azure.ResourceManager.Iothub.Models.CertificateVerificationDescription certificateVerificationBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.CertificateDescriptionResource>> VerifyAsync(string ifMatch, Azure.ResourceManager.Iothub.Models.CertificateVerificationDescription certificateVerificationBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventHubConsumerGroupInfoCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource>, System.Collections.IEnumerable
    {
        protected EventHubConsumerGroupInfoCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.Iothub.Models.EventHubConsumerGroupInfoCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.Iothub.Models.EventHubConsumerGroupInfoCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EventHubConsumerGroupInfoData : Azure.ResourceManager.Models.ResourceData
    {
        internal EventHubConsumerGroupInfoData() { }
        public Azure.ETag? Etag { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, System.BinaryData> Properties { get { throw null; } }
    }
    public partial class EventHubConsumerGroupInfoResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EventHubConsumerGroupInfoResource() { }
        public virtual Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string eventHubEndpointName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Iothub.Models.EventHubConsumerGroupInfoCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Iothub.Models.EventHubConsumerGroupInfoCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class GroupIdInformationCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Iothub.GroupIdInformationResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Iothub.GroupIdInformationResource>, System.Collections.IEnumerable
    {
        protected GroupIdInformationCollection() { }
        public virtual Azure.Response<bool> Exists(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.GroupIdInformationResource> Get(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Iothub.GroupIdInformationResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Iothub.GroupIdInformationResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.GroupIdInformationResource>> GetAsync(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Iothub.GroupIdInformationResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Iothub.GroupIdInformationResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Iothub.GroupIdInformationResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Iothub.GroupIdInformationResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class GroupIdInformationData : Azure.ResourceManager.Models.ResourceData
    {
        internal GroupIdInformationData() { }
        public Azure.ResourceManager.Iothub.Models.GroupIdInformationProperties Properties { get { throw null; } }
    }
    public partial class GroupIdInformationResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected GroupIdInformationResource() { }
        public virtual Azure.ResourceManager.Iothub.GroupIdInformationData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string groupId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.GroupIdInformationResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.GroupIdInformationResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class IotHubDescriptionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Iothub.IotHubDescriptionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Iothub.IotHubDescriptionResource>, System.Collections.IEnumerable
    {
        protected IotHubDescriptionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.IotHubDescriptionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string resourceName, Azure.ResourceManager.Iothub.IotHubDescriptionData data, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.IotHubDescriptionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string resourceName, Azure.ResourceManager.Iothub.IotHubDescriptionData data, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.IotHubDescriptionResource> Get(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Iothub.IotHubDescriptionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Iothub.IotHubDescriptionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.IotHubDescriptionResource>> GetAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Iothub.IotHubDescriptionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Iothub.IotHubDescriptionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Iothub.IotHubDescriptionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Iothub.IotHubDescriptionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class IotHubDescriptionData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public IotHubDescriptionData(Azure.Core.AzureLocation location, Azure.ResourceManager.Iothub.Models.IotHubSkuInfo sku) : base (default(Azure.Core.AzureLocation)) { }
        public Azure.ETag? Etag { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.IotHubProperties Properties { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.IotHubSkuInfo Sku { get { throw null; } set { } }
    }
    public partial class IotHubDescriptionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected IotHubDescriptionResource() { }
        public virtual Azure.ResourceManager.Iothub.IotHubDescriptionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.IotHubDescriptionResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.IotHubDescriptionResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.IotHubDescriptionResource> Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.IotHubDescriptionResource>> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.Models.JobResponse> ExportDevices(Azure.ResourceManager.Iothub.Models.ExportDevicesContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.Models.JobResponse>> ExportDevicesAsync(Azure.ResourceManager.Iothub.Models.ExportDevicesContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.IotHubDescriptionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Iothub.GroupIdInformationCollection GetAllGroupIdInformation() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.IotHubDescriptionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.CertificateDescriptionResource> GetCertificateDescription(string certificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.CertificateDescriptionResource>> GetCertificateDescriptionAsync(string certificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Iothub.CertificateDescriptionCollection GetCertificateDescriptions() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Iothub.Models.EndpointHealthData> GetEndpointHealth(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Iothub.Models.EndpointHealthData> GetEndpointHealthAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource> GetEventHubConsumerGroupInfo(string eventHubEndpointName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource>> GetEventHubConsumerGroupInfoAsync(string eventHubEndpointName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoCollection GetEventHubConsumerGroupInfos(string eventHubEndpointName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.GroupIdInformationResource> GetGroupIdInformation(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.GroupIdInformationResource>> GetGroupIdInformationAsync(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource> GetIothubPrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource>> GetIothubPrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionCollection GetIothubPrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.Models.JobResponse> GetJob(string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.Models.JobResponse>> GetJobAsync(string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Iothub.Models.JobResponse> GetJobs(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Iothub.Models.JobResponse> GetJobsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Iothub.Models.SharedAccessSignatureAuthorizationRule> GetKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Iothub.Models.SharedAccessSignatureAuthorizationRule> GetKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.Models.SharedAccessSignatureAuthorizationRule> GetKeysForKeyName(string keyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.Models.SharedAccessSignatureAuthorizationRule>> GetKeysForKeyNameAsync(string keyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Iothub.Models.IotHubQuotaMetricInfo> GetQuotaMetrics(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Iothub.Models.IotHubQuotaMetricInfo> GetQuotaMetricsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.Models.RegistryStatistics> GetStats(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.Models.RegistryStatistics>> GetStatsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Iothub.Models.IotHubSkuDescription> GetValidSkus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Iothub.Models.IotHubSkuDescription> GetValidSkusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.Models.JobResponse> ImportDevices(Azure.ResourceManager.Iothub.Models.ImportDevicesContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.Models.JobResponse>> ImportDevicesAsync(Azure.ResourceManager.Iothub.Models.ImportDevicesContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation ManualFailoverIotHub(Azure.WaitUntil waitUntil, Azure.ResourceManager.Iothub.Models.FailoverContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> ManualFailoverIotHubAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Iothub.Models.FailoverContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.IotHubDescriptionResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.IotHubDescriptionResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.IotHubDescriptionResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.IotHubDescriptionResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.Models.TestAllRoutesResult> TestAllRoutes(Azure.ResourceManager.Iothub.Models.TestAllRoutesContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.Models.TestAllRoutesResult>> TestAllRoutesAsync(Azure.ResourceManager.Iothub.Models.TestAllRoutesContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.Models.TestRouteResult> TestRoute(Azure.ResourceManager.Iothub.Models.TestRouteContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.Models.TestRouteResult>> TestRouteAsync(Azure.ResourceManager.Iothub.Models.TestRouteContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.IotHubDescriptionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Iothub.Models.IotHubDescriptionPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.IotHubDescriptionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Iothub.Models.IotHubDescriptionPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class IothubExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Iothub.Models.IotHubNameAvailabilityInfo> CheckNameAvailabilityIotHubResource(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Iothub.Models.OperationInputs operationInputs, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.Models.IotHubNameAvailabilityInfo>> CheckNameAvailabilityIotHubResourceAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Iothub.Models.OperationInputs operationInputs, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Iothub.CertificateDescriptionResource GetCertificateDescriptionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Iothub.EventHubConsumerGroupInfoResource GetEventHubConsumerGroupInfoResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Iothub.GroupIdInformationResource GetGroupIdInformationResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Iothub.IotHubDescriptionResource> GetIotHubDescription(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.IotHubDescriptionResource>> GetIotHubDescriptionAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Iothub.IotHubDescriptionResource GetIotHubDescriptionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Iothub.IotHubDescriptionCollection GetIotHubDescriptions(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Iothub.IotHubDescriptionResource> GetIotHubDescriptions(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Iothub.IotHubDescriptionResource> GetIotHubDescriptionsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource GetIothubPrivateEndpointConnectionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Iothub.Models.UserSubscriptionQuota> GetSubscriptionQuotaResourceProviderCommons(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Iothub.Models.UserSubscriptionQuota> GetSubscriptionQuotaResourceProviderCommonsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class IothubPrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource>, System.Collections.IEnumerable
    {
        protected IothubPrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class IothubPrivateEndpointConnectionData : Azure.ResourceManager.Models.ResourceData
    {
        public IothubPrivateEndpointConnectionData(Azure.ResourceManager.Iothub.Models.PrivateEndpointConnectionProperties properties) { }
        public Azure.ResourceManager.Iothub.Models.PrivateEndpointConnectionProperties Properties { get { throw null; } set { } }
    }
    public partial class IothubPrivateEndpointConnectionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected IothubPrivateEndpointConnectionResource() { }
        public virtual Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource> Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource>> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Iothub.Models
{
    public enum AccessRight
    {
        RegistryRead = 0,
        RegistryWrite = 1,
        ServiceConnect = 2,
        DeviceConnect = 3,
        RegistryReadRegistryWrite = 4,
        RegistryReadServiceConnect = 5,
        RegistryReadDeviceConnect = 6,
        RegistryWriteServiceConnect = 7,
        RegistryWriteDeviceConnect = 8,
        ServiceConnectDeviceConnect = 9,
        RegistryReadRegistryWriteServiceConnect = 10,
        RegistryReadRegistryWriteDeviceConnect = 11,
        RegistryReadServiceConnectDeviceConnect = 12,
        RegistryWriteServiceConnectDeviceConnect = 13,
        RegistryReadRegistryWriteServiceConnectDeviceConnect = 14,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AuthenticationType : System.IEquatable<Azure.ResourceManager.Iothub.Models.AuthenticationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AuthenticationType(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.AuthenticationType IdentityBased { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.AuthenticationType KeyBased { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.AuthenticationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.AuthenticationType left, Azure.ResourceManager.Iothub.Models.AuthenticationType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.AuthenticationType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.AuthenticationType left, Azure.ResourceManager.Iothub.Models.AuthenticationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Capability : System.IEquatable<Azure.ResourceManager.Iothub.Models.Capability>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Capability(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.Capability DeviceManagement { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.Capability None { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.Capability other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.Capability left, Azure.ResourceManager.Iothub.Models.Capability right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.Capability (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.Capability left, Azure.ResourceManager.Iothub.Models.Capability right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CertificateProperties
    {
        public CertificateProperties() { }
        public string Certificate { get { throw null; } set { } }
        public System.DateTimeOffset? Created { get { throw null; } }
        public System.DateTimeOffset? Expiry { get { throw null; } }
        public bool? IsVerified { get { throw null; } set { } }
        public string Subject { get { throw null; } }
        public string Thumbprint { get { throw null; } }
        public System.DateTimeOffset? Updated { get { throw null; } }
    }
    public partial class CertificatePropertiesWithNonce
    {
        internal CertificatePropertiesWithNonce() { }
        public string Certificate { get { throw null; } }
        public System.DateTimeOffset? Created { get { throw null; } }
        public System.DateTimeOffset? Expiry { get { throw null; } }
        public bool? IsVerified { get { throw null; } }
        public string Subject { get { throw null; } }
        public string Thumbprint { get { throw null; } }
        public System.DateTimeOffset? Updated { get { throw null; } }
        public string VerificationCode { get { throw null; } }
    }
    public partial class CertificateVerificationDescription
    {
        public CertificateVerificationDescription() { }
        public string Certificate { get { throw null; } set { } }
    }
    public partial class CertificateWithNonceDescription : Azure.ResourceManager.Models.ResourceData
    {
        internal CertificateWithNonceDescription() { }
        public Azure.ETag? Etag { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.CertificatePropertiesWithNonce Properties { get { throw null; } }
    }
    public partial class CloudToDeviceProperties
    {
        public CloudToDeviceProperties() { }
        public System.TimeSpan? DefaultTtlAsIso8601 { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.FeedbackProperties Feedback { get { throw null; } set { } }
        public int? MaxDeliveryCount { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DefaultAction : System.IEquatable<Azure.ResourceManager.Iothub.Models.DefaultAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DefaultAction(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.DefaultAction Allow { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.DefaultAction Deny { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.DefaultAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.DefaultAction left, Azure.ResourceManager.Iothub.Models.DefaultAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.DefaultAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.DefaultAction left, Azure.ResourceManager.Iothub.Models.DefaultAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EncryptionPropertiesDescription
    {
        public EncryptionPropertiesDescription() { }
        public string KeySource { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Iothub.Models.KeyVaultKeyProperties> KeyVaultProperties { get { throw null; } }
    }
    public partial class EndpointHealthData
    {
        internal EndpointHealthData() { }
        public string EndpointId { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.EndpointHealthStatus? HealthStatus { get { throw null; } }
        public string LastKnownError { get { throw null; } }
        public System.DateTimeOffset? LastKnownErrorOn { get { throw null; } }
        public System.DateTimeOffset? LastSendAttemptOn { get { throw null; } }
        public System.DateTimeOffset? LastSuccessfulSendAttemptOn { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EndpointHealthStatus : System.IEquatable<Azure.ResourceManager.Iothub.Models.EndpointHealthStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EndpointHealthStatus(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.EndpointHealthStatus Dead { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.EndpointHealthStatus Degraded { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.EndpointHealthStatus Healthy { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.EndpointHealthStatus Unhealthy { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.EndpointHealthStatus Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.EndpointHealthStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.EndpointHealthStatus left, Azure.ResourceManager.Iothub.Models.EndpointHealthStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.EndpointHealthStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.EndpointHealthStatus left, Azure.ResourceManager.Iothub.Models.EndpointHealthStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EnrichmentProperties
    {
        public EnrichmentProperties(string key, string value, System.Collections.Generic.IEnumerable<string> endpointNames) { }
        public System.Collections.Generic.IList<string> EndpointNames { get { throw null; } }
        public string Key { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class EventHubConsumerGroupInfoCreateOrUpdateContent
    {
        public EventHubConsumerGroupInfoCreateOrUpdateContent(Azure.ResourceManager.Iothub.Models.EventHubConsumerGroupName properties) { }
        public string EventHubConsumerGroupName { get { throw null; } }
    }
    public partial class EventHubConsumerGroupName
    {
        public EventHubConsumerGroupName(string name) { }
        public string Name { get { throw null; } }
    }
    public partial class EventHubProperties
    {
        public EventHubProperties() { }
        public string Endpoint { get { throw null; } }
        public int? PartitionCount { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> PartitionIds { get { throw null; } }
        public string Path { get { throw null; } }
        public long? RetentionTimeInDays { get { throw null; } set { } }
    }
    public partial class ExportDevicesContent
    {
        public ExportDevicesContent(System.Uri exportBlobContainerUri, bool excludeKeys) { }
        public Azure.ResourceManager.Iothub.Models.AuthenticationType? AuthenticationType { get { throw null; } set { } }
        public string ConfigurationsBlobName { get { throw null; } set { } }
        public bool ExcludeKeys { get { throw null; } }
        public System.Uri ExportBlobContainerUri { get { throw null; } }
        public string ExportBlobName { get { throw null; } set { } }
        public bool? IncludeConfigurations { get { throw null; } set { } }
        public string UserAssignedIdentity { get { throw null; } set { } }
    }
    public partial class FailoverContent
    {
        public FailoverContent(string failoverRegion) { }
        public string FailoverRegion { get { throw null; } }
    }
    public partial class FallbackRouteProperties
    {
        public FallbackRouteProperties(Azure.ResourceManager.Iothub.Models.RoutingSource source, System.Collections.Generic.IEnumerable<string> endpointNames, bool isEnabled) { }
        public string Condition { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> EndpointNames { get { throw null; } }
        public bool IsEnabled { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.RoutingSource Source { get { throw null; } set { } }
    }
    public partial class FeedbackProperties
    {
        public FeedbackProperties() { }
        public System.TimeSpan? LockDurationAsIso8601 { get { throw null; } set { } }
        public int? MaxDeliveryCount { get { throw null; } set { } }
        public System.TimeSpan? TtlAsIso8601 { get { throw null; } set { } }
    }
    public partial class GroupIdInformationProperties
    {
        internal GroupIdInformationProperties() { }
        public string GroupId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredMembers { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredZoneNames { get { throw null; } }
    }
    public partial class ImportDevicesContent
    {
        public ImportDevicesContent(System.Uri inputBlobContainerUri, System.Uri outputBlobContainerUri) { }
        public Azure.ResourceManager.Iothub.Models.AuthenticationType? AuthenticationType { get { throw null; } set { } }
        public string ConfigurationsBlobName { get { throw null; } set { } }
        public bool? IncludeConfigurations { get { throw null; } set { } }
        public System.Uri InputBlobContainerUri { get { throw null; } }
        public string InputBlobName { get { throw null; } set { } }
        public System.Uri OutputBlobContainerUri { get { throw null; } }
        public string OutputBlobName { get { throw null; } set { } }
        public string UserAssignedIdentity { get { throw null; } set { } }
    }
    public partial class IotHubCapacity
    {
        internal IotHubCapacity() { }
        public long? Default { get { throw null; } }
        public long? Maximum { get { throw null; } }
        public long? Minimum { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.IotHubScaleType? ScaleType { get { throw null; } }
    }
    public partial class IotHubDescriptionPatch
    {
        public IotHubDescriptionPatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class IotHubLocationDescription
    {
        internal IotHubLocationDescription() { }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.IotHubReplicaRoleType? Role { get { throw null; } }
    }
    public partial class IotHubNameAvailabilityInfo
    {
        internal IotHubNameAvailabilityInfo() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.IotHubNameUnavailabilityReason? Reason { get { throw null; } }
    }
    public enum IotHubNameUnavailabilityReason
    {
        Invalid = 0,
        AlreadyExists = 1,
    }
    public partial class IothubPrivateLinkServiceConnectionState
    {
        public IothubPrivateLinkServiceConnectionState(Azure.ResourceManager.Iothub.Models.PrivateLinkServiceConnectionStatus status, string description) { }
        public string ActionsRequired { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.PrivateLinkServiceConnectionStatus Status { get { throw null; } set { } }
    }
    public partial class IotHubProperties
    {
        public IotHubProperties() { }
        public System.Collections.Generic.IList<string> AllowedFqdnList { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Iothub.Models.SharedAccessSignatureAuthorizationRule> AuthorizationPolicies { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.CloudToDeviceProperties CloudToDevice { get { throw null; } set { } }
        public string Comments { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> DeviceStreamsStreamingEndpoints { get { throw null; } }
        public bool? DisableDeviceSAS { get { throw null; } set { } }
        public bool? DisableLocalAuth { get { throw null; } set { } }
        public bool? DisableModuleSAS { get { throw null; } set { } }
        public bool? EnableDataResidency { get { throw null; } set { } }
        public bool? EnableFileUploadNotifications { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.EncryptionPropertiesDescription Encryption { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Iothub.Models.EventHubProperties> EventHubEndpoints { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.Capability? Features { get { throw null; } set { } }
        public string HostName { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Iothub.Models.IPFilterRule> IPFilterRules { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Iothub.Models.IotHubLocationDescription> Locations { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Iothub.Models.MessagingEndpointProperties> MessagingEndpoints { get { throw null; } }
        public string MinTlsVersion { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.NetworkRuleSetProperties NetworkRuleSets { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Iothub.IothubPrivateEndpointConnectionData> PrivateEndpointConnections { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.PublicNetworkAccess? PublicNetworkAccess { get { throw null; } set { } }
        public bool? RestrictOutboundNetworkAccess { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.RootCertificateProperties RootCertificate { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.RoutingProperties Routing { get { throw null; } set { } }
        public string State { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Iothub.Models.StorageEndpointProperties> StorageEndpoints { get { throw null; } }
    }
    public partial class IotHubQuotaMetricInfo
    {
        internal IotHubQuotaMetricInfo() { }
        public long? CurrentValue { get { throw null; } }
        public long? MaxValue { get { throw null; } }
        public string Name { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IotHubReplicaRoleType : System.IEquatable<Azure.ResourceManager.Iothub.Models.IotHubReplicaRoleType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IotHubReplicaRoleType(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.IotHubReplicaRoleType Primary { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.IotHubReplicaRoleType Secondary { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.IotHubReplicaRoleType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.IotHubReplicaRoleType left, Azure.ResourceManager.Iothub.Models.IotHubReplicaRoleType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.IotHubReplicaRoleType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.IotHubReplicaRoleType left, Azure.ResourceManager.Iothub.Models.IotHubReplicaRoleType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum IotHubScaleType
    {
        None = 0,
        Automatic = 1,
        Manual = 2,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IotHubSku : System.IEquatable<Azure.ResourceManager.Iothub.Models.IotHubSku>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IotHubSku(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.IotHubSku B1 { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.IotHubSku B2 { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.IotHubSku B3 { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.IotHubSku F1 { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.IotHubSku S1 { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.IotHubSku S2 { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.IotHubSku S3 { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.IotHubSku other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.IotHubSku left, Azure.ResourceManager.Iothub.Models.IotHubSku right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.IotHubSku (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.IotHubSku left, Azure.ResourceManager.Iothub.Models.IotHubSku right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class IotHubSkuDescription
    {
        internal IotHubSkuDescription() { }
        public Azure.ResourceManager.Iothub.Models.IotHubCapacity Capacity { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.IotHubSkuInfo Sku { get { throw null; } }
    }
    public partial class IotHubSkuInfo
    {
        public IotHubSkuInfo(Azure.ResourceManager.Iothub.Models.IotHubSku name) { }
        public long? Capacity { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.IotHubSku Name { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.IotHubSkuTier? Tier { get { throw null; } }
    }
    public enum IotHubSkuTier
    {
        Free = 0,
        Standard = 1,
        Basic = 2,
    }
    public enum IPFilterActionType
    {
        Accept = 0,
        Reject = 1,
    }
    public partial class IPFilterRule
    {
        public IPFilterRule(string filterName, Azure.ResourceManager.Iothub.Models.IPFilterActionType action, string ipMask) { }
        public Azure.ResourceManager.Iothub.Models.IPFilterActionType Action { get { throw null; } set { } }
        public string FilterName { get { throw null; } set { } }
        public string IPMask { get { throw null; } set { } }
    }
    public partial class JobResponse
    {
        internal JobResponse() { }
        public System.DateTimeOffset? EndTimeUtc { get { throw null; } }
        public string FailureReason { get { throw null; } }
        public string JobId { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.JobType? JobType { get { throw null; } }
        public string ParentJobId { get { throw null; } }
        public System.DateTimeOffset? StartTimeUtc { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.JobStatus? Status { get { throw null; } }
        public string StatusMessage { get { throw null; } }
    }
    public enum JobStatus
    {
        Unknown = 0,
        Enqueued = 1,
        Running = 2,
        Completed = 3,
        Failed = 4,
        Cancelled = 5,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct JobType : System.IEquatable<Azure.ResourceManager.Iothub.Models.JobType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public JobType(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.JobType Backup { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.JobType Export { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.JobType FactoryResetDevice { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.JobType FirmwareUpdate { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.JobType Import { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.JobType ReadDeviceProperties { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.JobType RebootDevice { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.JobType Unknown { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.JobType UpdateDeviceConfiguration { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.JobType WriteDeviceProperties { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.JobType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.JobType left, Azure.ResourceManager.Iothub.Models.JobType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.JobType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.JobType left, Azure.ResourceManager.Iothub.Models.JobType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class KeyVaultKeyProperties
    {
        public KeyVaultKeyProperties() { }
        public string KeyIdentifier { get { throw null; } set { } }
        public string UserAssignedIdentity { get { throw null; } set { } }
    }
    public partial class MatchedRoute
    {
        internal MatchedRoute() { }
        public Azure.ResourceManager.Iothub.Models.RouteProperties Properties { get { throw null; } }
    }
    public partial class MessagingEndpointProperties
    {
        public MessagingEndpointProperties() { }
        public System.TimeSpan? LockDurationAsIso8601 { get { throw null; } set { } }
        public int? MaxDeliveryCount { get { throw null; } set { } }
        public System.TimeSpan? TtlAsIso8601 { get { throw null; } set { } }
    }
    public partial class Name
    {
        internal Name() { }
        public string LocalizedValue { get { throw null; } }
        public string Value { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NetworkRuleIPAction : System.IEquatable<Azure.ResourceManager.Iothub.Models.NetworkRuleIPAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NetworkRuleIPAction(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.NetworkRuleIPAction Allow { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.NetworkRuleIPAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.NetworkRuleIPAction left, Azure.ResourceManager.Iothub.Models.NetworkRuleIPAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.NetworkRuleIPAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.NetworkRuleIPAction left, Azure.ResourceManager.Iothub.Models.NetworkRuleIPAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NetworkRuleSetIPRule
    {
        public NetworkRuleSetIPRule(string filterName, string ipMask) { }
        public Azure.ResourceManager.Iothub.Models.NetworkRuleIPAction? Action { get { throw null; } set { } }
        public string FilterName { get { throw null; } set { } }
        public string IPMask { get { throw null; } set { } }
    }
    public partial class NetworkRuleSetProperties
    {
        public NetworkRuleSetProperties(bool applyToBuiltInEventHubEndpoint, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Iothub.Models.NetworkRuleSetIPRule> ipRules) { }
        public bool ApplyToBuiltInEventHubEndpoint { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.DefaultAction? DefaultAction { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Iothub.Models.NetworkRuleSetIPRule> IPRules { get { throw null; } }
    }
    public partial class OperationInputs
    {
        public OperationInputs(string name) { }
        public string Name { get { throw null; } }
    }
    public partial class PrivateEndpointConnectionProperties
    {
        public PrivateEndpointConnectionProperties(Azure.ResourceManager.Iothub.Models.IothubPrivateLinkServiceConnectionState connectionState) { }
        public Azure.ResourceManager.Iothub.Models.IothubPrivateLinkServiceConnectionState ConnectionState { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PrivateLinkServiceConnectionStatus : System.IEquatable<Azure.ResourceManager.Iothub.Models.PrivateLinkServiceConnectionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PrivateLinkServiceConnectionStatus(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.PrivateLinkServiceConnectionStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.PrivateLinkServiceConnectionStatus Disconnected { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.PrivateLinkServiceConnectionStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.PrivateLinkServiceConnectionStatus Rejected { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.PrivateLinkServiceConnectionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.PrivateLinkServiceConnectionStatus left, Azure.ResourceManager.Iothub.Models.PrivateLinkServiceConnectionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.PrivateLinkServiceConnectionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.PrivateLinkServiceConnectionStatus left, Azure.ResourceManager.Iothub.Models.PrivateLinkServiceConnectionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PublicNetworkAccess : System.IEquatable<Azure.ResourceManager.Iothub.Models.PublicNetworkAccess>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PublicNetworkAccess(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.PublicNetworkAccess Disabled { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.PublicNetworkAccess Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.PublicNetworkAccess other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.PublicNetworkAccess left, Azure.ResourceManager.Iothub.Models.PublicNetworkAccess right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.PublicNetworkAccess (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.PublicNetworkAccess left, Azure.ResourceManager.Iothub.Models.PublicNetworkAccess right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RegistryStatistics
    {
        internal RegistryStatistics() { }
        public long? DisabledDeviceCount { get { throw null; } }
        public long? EnabledDeviceCount { get { throw null; } }
        public long? TotalDeviceCount { get { throw null; } }
    }
    public partial class RootCertificateProperties
    {
        public RootCertificateProperties() { }
        public bool? EnableRootCertificateV2 { get { throw null; } set { } }
        public System.DateTimeOffset? LastUpdatedTimeUtc { get { throw null; } }
    }
    public partial class RouteCompilationError
    {
        internal RouteCompilationError() { }
        public Azure.ResourceManager.Iothub.Models.RouteErrorRange Location { get { throw null; } }
        public string Message { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.RouteErrorSeverity? Severity { get { throw null; } }
    }
    public partial class RouteErrorPosition
    {
        internal RouteErrorPosition() { }
        public int? Column { get { throw null; } }
        public int? Line { get { throw null; } }
    }
    public partial class RouteErrorRange
    {
        internal RouteErrorRange() { }
        public Azure.ResourceManager.Iothub.Models.RouteErrorPosition End { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.RouteErrorPosition Start { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RouteErrorSeverity : System.IEquatable<Azure.ResourceManager.Iothub.Models.RouteErrorSeverity>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RouteErrorSeverity(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.RouteErrorSeverity Error { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.RouteErrorSeverity Warning { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.RouteErrorSeverity other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.RouteErrorSeverity left, Azure.ResourceManager.Iothub.Models.RouteErrorSeverity right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.RouteErrorSeverity (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.RouteErrorSeverity left, Azure.ResourceManager.Iothub.Models.RouteErrorSeverity right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RouteProperties
    {
        public RouteProperties(string name, Azure.ResourceManager.Iothub.Models.RoutingSource source, System.Collections.Generic.IEnumerable<string> endpointNames, bool isEnabled) { }
        public string Condition { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> EndpointNames { get { throw null; } }
        public bool IsEnabled { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.RoutingSource Source { get { throw null; } set { } }
    }
    public partial class RoutingCosmosDBSqlApiProperties
    {
        public RoutingCosmosDBSqlApiProperties(string name, System.Uri endpointUri, string databaseName, string collectionName) { }
        public Azure.ResourceManager.Iothub.Models.AuthenticationType? AuthenticationType { get { throw null; } set { } }
        public string CollectionName { get { throw null; } set { } }
        public string DatabaseName { get { throw null; } set { } }
        public System.Uri EndpointUri { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string PartitionKeyName { get { throw null; } set { } }
        public string PartitionKeyTemplate { get { throw null; } set { } }
        public string PrimaryKey { get { throw null; } set { } }
        public string ResourceGroup { get { throw null; } set { } }
        public string SecondaryKey { get { throw null; } set { } }
        public string SubscriptionId { get { throw null; } set { } }
        public string UserAssignedIdentity { get { throw null; } set { } }
    }
    public partial class RoutingEndpoints
    {
        public RoutingEndpoints() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Iothub.Models.RoutingCosmosDBSqlApiProperties> CosmosDBSqlCollections { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Iothub.Models.RoutingEventHubProperties> EventHubs { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Iothub.Models.RoutingServiceBusQueueEndpointProperties> ServiceBusQueues { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Iothub.Models.RoutingServiceBusTopicEndpointProperties> ServiceBusTopics { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Iothub.Models.RoutingStorageContainerProperties> StorageContainers { get { throw null; } }
    }
    public partial class RoutingEventHubProperties
    {
        public RoutingEventHubProperties(string name) { }
        public Azure.ResourceManager.Iothub.Models.AuthenticationType? AuthenticationType { get { throw null; } set { } }
        public string ConnectionString { get { throw null; } set { } }
        public System.Uri EndpointUri { get { throw null; } set { } }
        public string EntityPath { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string ResourceGroup { get { throw null; } set { } }
        public string SubscriptionId { get { throw null; } set { } }
        public string UserAssignedIdentity { get { throw null; } set { } }
    }
    public partial class RoutingMessage
    {
        public RoutingMessage() { }
        public System.Collections.Generic.IDictionary<string, string> AppProperties { get { throw null; } }
        public string Body { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> SystemProperties { get { throw null; } }
    }
    public partial class RoutingProperties
    {
        public RoutingProperties() { }
        public Azure.ResourceManager.Iothub.Models.RoutingEndpoints Endpoints { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Iothub.Models.EnrichmentProperties> Enrichments { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.FallbackRouteProperties FallbackRoute { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Iothub.Models.RouteProperties> Routes { get { throw null; } }
    }
    public partial class RoutingServiceBusQueueEndpointProperties
    {
        public RoutingServiceBusQueueEndpointProperties(string name) { }
        public Azure.ResourceManager.Iothub.Models.AuthenticationType? AuthenticationType { get { throw null; } set { } }
        public string ConnectionString { get { throw null; } set { } }
        public System.Uri EndpointUri { get { throw null; } set { } }
        public string EntityPath { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string ResourceGroup { get { throw null; } set { } }
        public string SubscriptionId { get { throw null; } set { } }
        public string UserAssignedIdentity { get { throw null; } set { } }
    }
    public partial class RoutingServiceBusTopicEndpointProperties
    {
        public RoutingServiceBusTopicEndpointProperties(string name) { }
        public Azure.ResourceManager.Iothub.Models.AuthenticationType? AuthenticationType { get { throw null; } set { } }
        public string ConnectionString { get { throw null; } set { } }
        public System.Uri EndpointUri { get { throw null; } set { } }
        public string EntityPath { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string ResourceGroup { get { throw null; } set { } }
        public string SubscriptionId { get { throw null; } set { } }
        public string UserAssignedIdentity { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RoutingSource : System.IEquatable<Azure.ResourceManager.Iothub.Models.RoutingSource>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RoutingSource(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.RoutingSource DeviceConnectionStateEvents { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.RoutingSource DeviceJobLifecycleEvents { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.RoutingSource DeviceLifecycleEvents { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.RoutingSource DeviceMessages { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.RoutingSource DigitalTwinChangeEvents { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.RoutingSource Invalid { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.RoutingSource MqttBrokerMessages { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.RoutingSource TwinChangeEvents { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.RoutingSource other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.RoutingSource left, Azure.ResourceManager.Iothub.Models.RoutingSource right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.RoutingSource (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.RoutingSource left, Azure.ResourceManager.Iothub.Models.RoutingSource right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RoutingStorageContainerProperties
    {
        public RoutingStorageContainerProperties(string name, string containerName) { }
        public Azure.ResourceManager.Iothub.Models.AuthenticationType? AuthenticationType { get { throw null; } set { } }
        public int? BatchFrequencyInSeconds { get { throw null; } set { } }
        public string ConnectionString { get { throw null; } set { } }
        public string ContainerName { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.RoutingStorageContainerPropertiesEncoding? Encoding { get { throw null; } set { } }
        public System.Uri EndpointUri { get { throw null; } set { } }
        public string FileNameFormat { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public int? MaxChunkSizeInBytes { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string ResourceGroup { get { throw null; } set { } }
        public string SubscriptionId { get { throw null; } set { } }
        public string UserAssignedIdentity { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RoutingStorageContainerPropertiesEncoding : System.IEquatable<Azure.ResourceManager.Iothub.Models.RoutingStorageContainerPropertiesEncoding>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RoutingStorageContainerPropertiesEncoding(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.RoutingStorageContainerPropertiesEncoding Avro { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.RoutingStorageContainerPropertiesEncoding AvroDeflate { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.RoutingStorageContainerPropertiesEncoding Json { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.RoutingStorageContainerPropertiesEncoding other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.RoutingStorageContainerPropertiesEncoding left, Azure.ResourceManager.Iothub.Models.RoutingStorageContainerPropertiesEncoding right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.RoutingStorageContainerPropertiesEncoding (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.RoutingStorageContainerPropertiesEncoding left, Azure.ResourceManager.Iothub.Models.RoutingStorageContainerPropertiesEncoding right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RoutingTwin
    {
        public RoutingTwin() { }
        public Azure.ResourceManager.Iothub.Models.RoutingTwinProperties Properties { get { throw null; } set { } }
        public System.BinaryData Tags { get { throw null; } set { } }
    }
    public partial class RoutingTwinProperties
    {
        public RoutingTwinProperties() { }
        public System.BinaryData Desired { get { throw null; } set { } }
        public System.BinaryData Reported { get { throw null; } set { } }
    }
    public partial class SharedAccessSignatureAuthorizationRule
    {
        public SharedAccessSignatureAuthorizationRule(string keyName, Azure.ResourceManager.Iothub.Models.AccessRight rights) { }
        public string KeyName { get { throw null; } set { } }
        public string PrimaryKey { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.AccessRight Rights { get { throw null; } set { } }
        public string SecondaryKey { get { throw null; } set { } }
    }
    public partial class StorageEndpointProperties
    {
        public StorageEndpointProperties(string connectionString, string containerName) { }
        public Azure.ResourceManager.Iothub.Models.AuthenticationType? AuthenticationType { get { throw null; } set { } }
        public string ConnectionString { get { throw null; } set { } }
        public string ContainerName { get { throw null; } set { } }
        public System.TimeSpan? SasTtlAsIso8601 { get { throw null; } set { } }
        public string UserAssignedIdentity { get { throw null; } set { } }
    }
    public partial class TestAllRoutesContent
    {
        public TestAllRoutesContent() { }
        public Azure.ResourceManager.Iothub.Models.RoutingMessage Message { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.RoutingSource? RoutingSource { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.RoutingTwin Twin { get { throw null; } set { } }
    }
    public partial class TestAllRoutesResult
    {
        internal TestAllRoutesResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Iothub.Models.MatchedRoute> Routes { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TestResultStatus : System.IEquatable<Azure.ResourceManager.Iothub.Models.TestResultStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TestResultStatus(string value) { throw null; }
        public static Azure.ResourceManager.Iothub.Models.TestResultStatus False { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.TestResultStatus True { get { throw null; } }
        public static Azure.ResourceManager.Iothub.Models.TestResultStatus Undefined { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Iothub.Models.TestResultStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Iothub.Models.TestResultStatus left, Azure.ResourceManager.Iothub.Models.TestResultStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Iothub.Models.TestResultStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Iothub.Models.TestResultStatus left, Azure.ResourceManager.Iothub.Models.TestResultStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TestRouteContent
    {
        public TestRouteContent(Azure.ResourceManager.Iothub.Models.RouteProperties route) { }
        public Azure.ResourceManager.Iothub.Models.RoutingMessage Message { get { throw null; } set { } }
        public Azure.ResourceManager.Iothub.Models.RouteProperties Route { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.RoutingTwin Twin { get { throw null; } set { } }
    }
    public partial class TestRouteResult
    {
        internal TestRouteResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Iothub.Models.RouteCompilationError> DetailsCompilationErrors { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.TestResultStatus? Result { get { throw null; } }
    }
    public partial class UserSubscriptionQuota
    {
        internal UserSubscriptionQuota() { }
        public int? CurrentValue { get { throw null; } }
        public string Id { get { throw null; } }
        public int? Limit { get { throw null; } }
        public Azure.ResourceManager.Iothub.Models.Name Name { get { throw null; } }
        public string Unit { get { throw null; } }
        public string UserSubscriptionQuotaType { get { throw null; } }
    }
}
