namespace Azure.ResourceManager.Cognitivesearch
{
    public static partial class CognitivesearchExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Cognitivesearch.IndexResource> GetIndex(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cognitivesearch.IndexResource>> GetIndexAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Cognitivesearch.IndexResource GetIndexResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Cognitivesearch.IndexCollection GetIndices(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Cognitivesearch.IndexResource> GetIndices(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Cognitivesearch.IndexResource> GetIndicesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class IndexCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cognitivesearch.IndexResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cognitivesearch.IndexResource>, System.Collections.IEnumerable
    {
        protected IndexCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cognitivesearch.IndexResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.Cognitivesearch.IndexData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cognitivesearch.IndexResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.Cognitivesearch.IndexData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cognitivesearch.IndexResource> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Cognitivesearch.IndexResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Cognitivesearch.IndexResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cognitivesearch.IndexResource>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Cognitivesearch.IndexResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Cognitivesearch.IndexResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Cognitivesearch.IndexResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Cognitivesearch.IndexResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class IndexData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public IndexData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string Endpoint { get { throw null; } }
        public Azure.ResourceManager.Cognitivesearch.Models.Capacity IndexingCapacity { get { throw null; } set { } }
        public Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Cognitivesearch.Models.Capacity QueryCapacity { get { throw null; } set { } }
    }
    public partial class IndexResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected IndexResource() { }
        public virtual Azure.ResourceManager.Cognitivesearch.IndexData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Cognitivesearch.IndexResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cognitivesearch.IndexResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cognitivesearch.IndexResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cognitivesearch.IndexResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cognitivesearch.IndexResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cognitivesearch.IndexResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Cognitivesearch.IndexResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Cognitivesearch.IndexResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cognitivesearch.IndexResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cognitivesearch.Models.IndexPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Cognitivesearch.IndexResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Cognitivesearch.Models.IndexPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Cognitivesearch.Models
{
    public static partial class ArmCognitivesearchModelFactory
    {
        public static Azure.ResourceManager.Cognitivesearch.IndexData IndexData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState?), string endpoint = null, Azure.ResourceManager.Cognitivesearch.Models.Capacity queryCapacity = null, Azure.ResourceManager.Cognitivesearch.Models.Capacity indexingCapacity = null) { throw null; }
    }
    public partial class Capacity
    {
        public Capacity(float minVCores, float maxVCores, Azure.ResourceManager.Cognitivesearch.Models.Pause autoPause) { }
        public Azure.ResourceManager.Cognitivesearch.Models.Pause AutoPause { get { throw null; } set { } }
        public float MaxVCores { get { throw null; } set { } }
        public float MinVCores { get { throw null; } set { } }
    }
    public partial class CapacityUpdate
    {
        public CapacityUpdate() { }
        public Azure.ResourceManager.Cognitivesearch.Models.Pause AutoPause { get { throw null; } set { } }
        public float? MaxVCores { get { throw null; } set { } }
        public float? MinVCores { get { throw null; } set { } }
    }
    public partial class DelayPause : Azure.ResourceManager.Cognitivesearch.Models.Pause
    {
        public DelayPause(System.TimeSpan duration) { }
        public System.TimeSpan Duration { get { throw null; } set { } }
    }
    public partial class IndexPatch
    {
        public IndexPatch() { }
        public Azure.ResourceManager.Cognitivesearch.Models.CapacityUpdate IndexingCapacity { get { throw null; } set { } }
        public Azure.ResourceManager.Cognitivesearch.Models.CapacityUpdate QueryCapacity { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class NonePause : Azure.ResourceManager.Cognitivesearch.Models.Pause
    {
        public NonePause() { }
    }
    public abstract partial class Pause
    {
        protected Pause() { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState Provisioning { get { throw null; } }
        public static Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState left, Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState left, Azure.ResourceManager.Cognitivesearch.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
}
