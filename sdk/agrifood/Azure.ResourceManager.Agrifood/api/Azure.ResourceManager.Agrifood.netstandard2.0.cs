namespace Azure.ResourceManager.Agrifood
{
    public static partial class AgrifoodExtensions
    {
        public static Azure.Response<Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityResponse> CheckNameAvailabilityLocation(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityResponse>> CheckNameAvailabilityLocationAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Agrifood.ExtensionResource GetExtensionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource> GetFarmBeat(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string farmBeatsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource>> GetFarmBeatAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string farmBeatsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Agrifood.FarmBeatResource GetFarmBeatResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Agrifood.FarmBeatCollection GetFarmBeats(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Agrifood.FarmBeatResource> GetFarmBeats(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, int? maxPageSize = default(int?), string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Agrifood.FarmBeatResource> GetFarmBeatsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, int? maxPageSize = default(int?), string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource> GetFarmBeatsExtension(this Azure.ResourceManager.Resources.TenantResource tenantResource, string farmBeatsExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource>> GetFarmBeatsExtensionAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string farmBeatsExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource GetFarmBeatsExtensionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Agrifood.FarmBeatsExtensionCollection GetFarmBeatsExtensions(this Azure.ResourceManager.Resources.TenantResource tenantResource) { throw null; }
    }
    public partial class ExtensionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Agrifood.ExtensionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Agrifood.ExtensionResource>, System.Collections.IEnumerable
    {
        protected ExtensionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Agrifood.ExtensionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string extensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Agrifood.ExtensionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string extensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string extensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string extensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Agrifood.ExtensionResource> Get(string extensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Agrifood.ExtensionResource> GetAll(System.Collections.Generic.IEnumerable<string> extensionIds = null, System.Collections.Generic.IEnumerable<string> extensionCategories = null, int? maxPageSize = default(int?), string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Agrifood.ExtensionResource> GetAllAsync(System.Collections.Generic.IEnumerable<string> extensionIds = null, System.Collections.Generic.IEnumerable<string> extensionCategories = null, int? maxPageSize = default(int?), string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.ExtensionResource>> GetAsync(string extensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Agrifood.ExtensionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Agrifood.ExtensionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Agrifood.ExtensionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Agrifood.ExtensionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ExtensionData : Azure.ResourceManager.Models.ResourceData
    {
        public ExtensionData() { }
        public Azure.ETag? ETag { get { throw null; } }
        public string ExtensionApiDocsLink { get { throw null; } }
        public string ExtensionAuthLink { get { throw null; } }
        public string ExtensionCategory { get { throw null; } }
        public string ExtensionId { get { throw null; } }
        public string InstalledExtensionVersion { get { throw null; } }
    }
    public partial class ExtensionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ExtensionResource() { }
        public virtual Azure.ResourceManager.Agrifood.ExtensionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, string extensionId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Agrifood.ExtensionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.ExtensionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Agrifood.ExtensionResource> Update(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.ExtensionResource>> UpdateAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FarmBeatCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Agrifood.FarmBeatResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Agrifood.FarmBeatResource>, System.Collections.IEnumerable
    {
        protected FarmBeatCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Agrifood.FarmBeatResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string farmBeatsResourceName, Azure.ResourceManager.Agrifood.FarmBeatData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Agrifood.FarmBeatResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string farmBeatsResourceName, Azure.ResourceManager.Agrifood.FarmBeatData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string farmBeatsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string farmBeatsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource> Get(string farmBeatsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Agrifood.FarmBeatResource> GetAll(int? maxPageSize = default(int?), string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Agrifood.FarmBeatResource> GetAllAsync(int? maxPageSize = default(int?), string skipToken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource>> GetAsync(string farmBeatsResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Agrifood.FarmBeatResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Agrifood.FarmBeatResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Agrifood.FarmBeatResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Agrifood.FarmBeatResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FarmBeatData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public FarmBeatData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public System.Uri InstanceUri { get { throw null; } }
        public Azure.ResourceManager.Agrifood.Models.ProvisioningState? ProvisioningState { get { throw null; } }
    }
    public partial class FarmBeatResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FarmBeatResource() { }
        public virtual Azure.ResourceManager.Agrifood.FarmBeatData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string farmBeatsResourceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Agrifood.ExtensionResource> GetExtension(string extensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.ExtensionResource>> GetExtensionAsync(string extensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Agrifood.ExtensionCollection GetExtensions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource> Update(Azure.ResourceManager.Agrifood.Models.FarmBeatPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatResource>> UpdateAsync(Azure.ResourceManager.Agrifood.Models.FarmBeatPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FarmBeatsExtensionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource>, System.Collections.IEnumerable
    {
        protected FarmBeatsExtensionCollection() { }
        public virtual Azure.Response<bool> Exists(string farmBeatsExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string farmBeatsExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource> Get(string farmBeatsExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource> GetAll(System.Collections.Generic.IEnumerable<string> farmBeatsExtensionIds = null, System.Collections.Generic.IEnumerable<string> farmBeatsExtensionNames = null, System.Collections.Generic.IEnumerable<string> extensionCategories = null, System.Collections.Generic.IEnumerable<string> publisherIds = null, int? maxPageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource> GetAllAsync(System.Collections.Generic.IEnumerable<string> farmBeatsExtensionIds = null, System.Collections.Generic.IEnumerable<string> farmBeatsExtensionNames = null, System.Collections.Generic.IEnumerable<string> extensionCategories = null, System.Collections.Generic.IEnumerable<string> publisherIds = null, int? maxPageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource>> GetAsync(string farmBeatsExtensionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FarmBeatsExtensionData : Azure.ResourceManager.Models.ResourceData
    {
        public FarmBeatsExtensionData() { }
        public string Description { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Agrifood.Models.DetailedInformation> DetailedInformation { get { throw null; } }
        public string ExtensionApiDocsLink { get { throw null; } }
        public string ExtensionAuthLink { get { throw null; } }
        public string ExtensionCategory { get { throw null; } }
        public string FarmBeatsExtensionId { get { throw null; } }
        public string FarmBeatsExtensionName { get { throw null; } }
        public string FarmBeatsExtensionVersion { get { throw null; } }
        public string PublisherId { get { throw null; } }
        public string TargetResourceType { get { throw null; } }
    }
    public partial class FarmBeatsExtensionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FarmBeatsExtensionResource() { }
        public virtual Azure.ResourceManager.Agrifood.FarmBeatsExtensionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string farmBeatsExtensionId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Agrifood.FarmBeatsExtensionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Agrifood.Models
{
    public partial class CheckNameAvailabilityContent
    {
        public CheckNameAvailabilityContent() { }
        public string Name { get { throw null; } set { } }
        public string ResourceType { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CheckNameAvailabilityReason : System.IEquatable<Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityReason>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CheckNameAvailabilityReason(string value) { throw null; }
        public static Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityReason AlreadyExists { get { throw null; } }
        public static Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityReason Invalid { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityReason other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityReason left, Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityReason right) { throw null; }
        public static implicit operator Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityReason (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityReason left, Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityReason right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CheckNameAvailabilityResponse
    {
        internal CheckNameAvailabilityResponse() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public Azure.ResourceManager.Agrifood.Models.CheckNameAvailabilityReason? Reason { get { throw null; } }
    }
    public partial class DetailedInformation
    {
        internal DetailedInformation() { }
        public System.Collections.Generic.IReadOnlyList<string> ApiInputParameters { get { throw null; } }
        public string ApiName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> CustomParameters { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> PlatformParameters { get { throw null; } }
        public Azure.ResourceManager.Agrifood.Models.UnitSystemsInfo UnitsSupported { get { throw null; } }
    }
    public partial class FarmBeatPatch
    {
        public FarmBeatPatch() { }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.Agrifood.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Agrifood.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Agrifood.Models.ProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Agrifood.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Agrifood.Models.ProvisioningState left, Azure.ResourceManager.Agrifood.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Agrifood.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Agrifood.Models.ProvisioningState left, Azure.ResourceManager.Agrifood.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UnitSystemsInfo
    {
        internal UnitSystemsInfo() { }
        public string Key { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Values { get { throw null; } }
    }
}
