namespace Azure.ResourceManager.AppConfiguration
{
    public static partial class AppConfigurationExtensions
    {
        public static Azure.Response<Azure.ResourceManager.AppConfiguration.Models.NameAvailabilityStatus> CheckAppConfigurationNameAvailability(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.AppConfiguration.Models.CheckNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppConfiguration.Models.NameAvailabilityStatus>> CheckAppConfigurationNameAvailabilityAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.AppConfiguration.Models.CheckNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> GetConfigurationStore(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string configStoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource>> GetConfigurationStoreAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string configStoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource GetConfigurationStoreResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppConfiguration.ConfigurationStoreCollection GetConfigurationStores(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> GetConfigurationStores(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> GetConfigurationStoresAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ConfigurationStoreCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource>, System.Collections.IEnumerable
    {
        protected ConfigurationStoreCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string configStoreName, Azure.ResourceManager.AppConfiguration.ConfigurationStoreData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string configStoreName, Azure.ResourceManager.AppConfiguration.ConfigurationStoreData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string configStoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string configStoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> Get(string configStoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> GetAll(string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> GetAllAsync(string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource>> GetAsync(string configStoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ConfigurationStoreData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ConfigurationStoreData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public System.DateTimeOffset? CreationOn { get { throw null; } }
        public string Endpoint { get { throw null; } }
        public Azure.ResourceManager.AppConfiguration.Models.ProvisioningState? ProvisioningState { get { throw null; } }
    }
    public partial class ConfigurationStoreResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ConfigurationStoreResource() { }
        public virtual Azure.ResourceManager.AppConfiguration.ConfigurationStoreData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string configStoreName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppConfiguration.Models.ApiKey> GetKeys(string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppConfiguration.Models.ApiKey> GetKeysAsync(string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppConfiguration.Models.KeyValue> GetKeyValue(Azure.ResourceManager.AppConfiguration.Models.ListKeyValueContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppConfiguration.Models.KeyValue>> GetKeyValueAsync(Azure.ResourceManager.AppConfiguration.Models.ListKeyValueContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppConfiguration.Models.ApiKey> RegenerateKey(Azure.ResourceManager.AppConfiguration.Models.RegenerateKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppConfiguration.Models.ApiKey>> RegenerateKeyAsync(Azure.ResourceManager.AppConfiguration.Models.RegenerateKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppConfiguration.Models.ConfigurationStorePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppConfiguration.ConfigurationStoreResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppConfiguration.Models.ConfigurationStorePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.AppConfiguration.Models
{
    public partial class ApiKey
    {
        internal ApiKey() { }
        public string ConnectionString { get { throw null; } }
        public string Id { get { throw null; } }
        public System.DateTimeOffset? LastModified { get { throw null; } }
        public string Name { get { throw null; } }
        public bool? ReadOnly { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class CheckNameAvailabilityContent
    {
        public CheckNameAvailabilityContent(string name, Azure.ResourceManager.AppConfiguration.Models.ConfigurationResourceType resourceType) { }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.AppConfiguration.Models.ConfigurationResourceType ResourceType { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConfigurationResourceType : System.IEquatable<Azure.ResourceManager.AppConfiguration.Models.ConfigurationResourceType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConfigurationResourceType(string value) { throw null; }
        public static Azure.ResourceManager.AppConfiguration.Models.ConfigurationResourceType MicrosoftAppConfigurationConfigurationStores { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppConfiguration.Models.ConfigurationResourceType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppConfiguration.Models.ConfigurationResourceType left, Azure.ResourceManager.AppConfiguration.Models.ConfigurationResourceType right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppConfiguration.Models.ConfigurationResourceType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppConfiguration.Models.ConfigurationResourceType left, Azure.ResourceManager.AppConfiguration.Models.ConfigurationResourceType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ConfigurationStorePatch
    {
        public ConfigurationStorePatch() { }
        public System.BinaryData Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class KeyValue
    {
        internal KeyValue() { }
        public string ContentType { get { throw null; } }
        public string ETag { get { throw null; } }
        public string Key { get { throw null; } }
        public string Label { get { throw null; } }
        public System.DateTimeOffset? LastModified { get { throw null; } }
        public bool? Locked { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Tags { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class ListKeyValueContent
    {
        public ListKeyValueContent(string key) { }
        public string Key { get { throw null; } }
        public string Label { get { throw null; } set { } }
    }
    public partial class NameAvailabilityStatus
    {
        internal NameAvailabilityStatus() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public string Reason { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.AppConfiguration.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.AppConfiguration.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.AppConfiguration.Models.ProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.AppConfiguration.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.AppConfiguration.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.AppConfiguration.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.AppConfiguration.Models.ProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppConfiguration.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppConfiguration.Models.ProvisioningState left, Azure.ResourceManager.AppConfiguration.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppConfiguration.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppConfiguration.Models.ProvisioningState left, Azure.ResourceManager.AppConfiguration.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RegenerateKeyContent
    {
        public RegenerateKeyContent() { }
        public string Id { get { throw null; } set { } }
    }
}
