namespace Azure.ResourceManager.ServiceLinker
{
    public static partial class ServiceLinkerExtensions
    {
        public static Azure.Response<Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult> GetConfigurationsLinker(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult>> GetConfigurationsLinkerAsync(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ServiceLinker.Models.LinkerResource> GetLinkers(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ServiceLinker.Models.LinkerResource> GetLinkersAsync(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult> ValidateLinker(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, Azure.WaitUntil waitUntil, string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult>> ValidateLinkerAsync(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, Azure.WaitUntil waitUntil, string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ServiceLinker.Mocking
{
    public partial class MockableServiceLinkerArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableServiceLinkerArmClient() { }
        public virtual Azure.Response<Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult> GetConfigurationsLinker(Azure.Core.ResourceIdentifier scope, string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult>> GetConfigurationsLinkerAsync(Azure.Core.ResourceIdentifier scope, string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceLinker.Models.LinkerResource> GetLinkers(Azure.Core.ResourceIdentifier scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceLinker.Models.LinkerResource> GetLinkersAsync(Azure.Core.ResourceIdentifier scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult> ValidateLinker(Azure.Core.ResourceIdentifier scope, Azure.WaitUntil waitUntil, string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult>> ValidateLinkerAsync(Azure.Core.ResourceIdentifier scope, Azure.WaitUntil waitUntil, string linkerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ServiceLinker.Models
{
    public static partial class ArmServiceLinkerModelFactory
    {
        public static Azure.ResourceManager.ServiceLinker.Models.AzureKeyVaultProperties AzureKeyVaultProperties(bool? doesConnectAsKubernetesCsiDriver = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.AzureResourceInfo AzureResourceInfo(Azure.Core.ResourceIdentifier id = null, Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties resourceProperties = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.ConfluentBootstrapServerInfo ConfluentBootstrapServerInfo(string endpoint = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.ConfluentSchemaRegistryInfo ConfluentSchemaRegistryInfo(string endpoint = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretReferenceSecretInfo KeyVaultSecretReferenceSecretInfo(string name = null, string version = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretUriSecretInfo KeyVaultSecretUriSecretInfo(string value = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerResource LinkerResource(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo targetService = null, Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo authInfo = null, Azure.ResourceManager.ServiceLinker.Models.LinkerClientType? clientType = default(Azure.ResourceManager.ServiceLinker.Models.LinkerClientType?), string provisioningState = null, Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType? solutionType = default(Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType?), Azure.Core.ResourceIdentifier secretStoreKeyVaultId = null, string scope = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult LinkerValidateOperationResult(Azure.Core.ResourceIdentifier resourceId = null, string status = null, string linkerName = null, bool? isConnectionAvailable = default(bool?), System.DateTimeOffset? reportStartOn = default(System.DateTimeOffset?), System.DateTimeOffset? reportEndOn = default(System.DateTimeOffset?), Azure.Core.ResourceIdentifier sourceId = null, Azure.Core.ResourceIdentifier targetId = null, Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType? authType = default(Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo> validationDetail = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo LinkerValidationResultItemInfo(string name = null, string description = null, Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus? result = default(Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus?), string errorMessage = null, string errorCode = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.RawValueSecretInfo RawValueSecretInfo(string value = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.SecretAuthInfo SecretAuthInfo(string name = null, Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo secretInfo = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalCertificateAuthInfo ServicePrincipalCertificateAuthInfo(string clientId = null, System.Guid principalId = default(System.Guid), string certificate = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalSecretAuthInfo ServicePrincipalSecretAuthInfo(string clientId = null, System.Guid principalId = default(System.Guid), string secret = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration SourceConfiguration(string name = null, string value = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult SourceConfigurationResult(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration> configurations = null) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.UserAssignedIdentityAuthInfo UserAssignedIdentityAuthInfo(string clientId = null, string subscriptionId = null) { throw null; }
    }
    public abstract partial class AuthBaseInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo>
    {
        protected AuthBaseInfo() { }
        Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AzureKeyVaultProperties : Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.AzureKeyVaultProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AzureKeyVaultProperties>
    {
        internal AzureKeyVaultProperties() { }
        public bool? DoesConnectAsKubernetesCsiDriver { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.AzureKeyVaultProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.AzureKeyVaultProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.AzureKeyVaultProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.AzureKeyVaultProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AzureKeyVaultProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AzureKeyVaultProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AzureKeyVaultProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class AzureResourceBaseProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties>
    {
        protected AzureResourceBaseProperties() { }
        Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AzureResourceInfo : Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceInfo>
    {
        internal AzureResourceInfo() { }
        public Azure.Core.ResourceIdentifier Id { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.AzureResourceBaseProperties ResourceProperties { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.AzureResourceInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.AzureResourceInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.AzureResourceInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConfluentBootstrapServerInfo : Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentBootstrapServerInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentBootstrapServerInfo>
    {
        internal ConfluentBootstrapServerInfo() { }
        public string Endpoint { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.ConfluentBootstrapServerInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentBootstrapServerInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentBootstrapServerInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.ConfluentBootstrapServerInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentBootstrapServerInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentBootstrapServerInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentBootstrapServerInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConfluentSchemaRegistryInfo : Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentSchemaRegistryInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentSchemaRegistryInfo>
    {
        internal ConfluentSchemaRegistryInfo() { }
        public string Endpoint { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.ConfluentSchemaRegistryInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentSchemaRegistryInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentSchemaRegistryInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.ConfluentSchemaRegistryInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentSchemaRegistryInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentSchemaRegistryInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ConfluentSchemaRegistryInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KeyVaultSecretReferenceSecretInfo : Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretReferenceSecretInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretReferenceSecretInfo>
    {
        internal KeyVaultSecretReferenceSecretInfo() { }
        public string Name { get { throw null; } }
        public string Version { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretReferenceSecretInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretReferenceSecretInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretReferenceSecretInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretReferenceSecretInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretReferenceSecretInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretReferenceSecretInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretReferenceSecretInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KeyVaultSecretUriSecretInfo : Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretUriSecretInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretUriSecretInfo>
    {
        internal KeyVaultSecretUriSecretInfo() { }
        public string Value { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretUriSecretInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretUriSecretInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretUriSecretInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretUriSecretInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretUriSecretInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretUriSecretInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.KeyVaultSecretUriSecretInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LinkerAuthType : System.IEquatable<Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LinkerAuthType(string value) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType Secret { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType ServicePrincipalCertificate { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType ServicePrincipalSecret { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType SystemAssignedIdentity { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType UserAssignedIdentity { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType left, Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType left, Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LinkerClientType : System.IEquatable<Azure.ResourceManager.ServiceLinker.Models.LinkerClientType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LinkerClientType(string value) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Django { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Dotnet { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Go { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Java { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType KafkaSpringBoot { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Nodejs { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType None { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Php { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Python { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType Ruby { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerClientType SpringBoot { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceLinker.Models.LinkerClientType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceLinker.Models.LinkerClientType left, Azure.ResourceManager.ServiceLinker.Models.LinkerClientType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceLinker.Models.LinkerClientType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceLinker.Models.LinkerClientType left, Azure.ResourceManager.ServiceLinker.Models.LinkerClientType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LinkerResource : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.LinkerResource>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.LinkerResource>
    {
        internal LinkerResource() { }
        public Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo AuthInfo { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.LinkerClientType? ClientType { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public string Scope { get { throw null; } }
        public Azure.Core.ResourceIdentifier SecretStoreKeyVaultId { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType? SolutionType { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo TargetService { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.LinkerResource System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.LinkerResource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.LinkerResource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.LinkerResource System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.LinkerResource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.LinkerResource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.LinkerResource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LinkerValidateOperationResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult>
    {
        internal LinkerValidateOperationResult() { }
        public Azure.ResourceManager.ServiceLinker.Models.LinkerAuthType? AuthType { get { throw null; } }
        public bool? IsConnectionAvailable { get { throw null; } }
        public string LinkerName { get { throw null; } }
        public System.DateTimeOffset? ReportEndOn { get { throw null; } }
        public System.DateTimeOffset? ReportStartOn { get { throw null; } }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } }
        public Azure.Core.ResourceIdentifier SourceId { get { throw null; } }
        public string Status { get { throw null; } }
        public Azure.Core.ResourceIdentifier TargetId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo> ValidationDetail { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidateOperationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LinkerValidationResultItemInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo>
    {
        internal LinkerValidationResultItemInfo() { }
        public string Description { get { throw null; } }
        public string ErrorCode { get { throw null; } }
        public string ErrorMessage { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus? Result { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultItemInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LinkerValidationResultStatus : System.IEquatable<Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LinkerValidationResultStatus(string value) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus Failure { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus Success { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus Warning { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus left, Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus left, Azure.ResourceManager.ServiceLinker.Models.LinkerValidationResultStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RawValueSecretInfo : Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.RawValueSecretInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.RawValueSecretInfo>
    {
        internal RawValueSecretInfo() { }
        public string Value { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.RawValueSecretInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.RawValueSecretInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.RawValueSecretInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.RawValueSecretInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.RawValueSecretInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.RawValueSecretInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.RawValueSecretInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SecretAuthInfo : Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SecretAuthInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SecretAuthInfo>
    {
        internal SecretAuthInfo() { }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo SecretInfo { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.SecretAuthInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SecretAuthInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SecretAuthInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.SecretAuthInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SecretAuthInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SecretAuthInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SecretAuthInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class SecretBaseInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo>
    {
        protected SecretBaseInfo() { }
        Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SecretBaseInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ServicePrincipalCertificateAuthInfo : Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalCertificateAuthInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalCertificateAuthInfo>
    {
        internal ServicePrincipalCertificateAuthInfo() { }
        public string Certificate { get { throw null; } }
        public string ClientId { get { throw null; } }
        public System.Guid PrincipalId { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalCertificateAuthInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalCertificateAuthInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalCertificateAuthInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalCertificateAuthInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalCertificateAuthInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalCertificateAuthInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalCertificateAuthInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ServicePrincipalSecretAuthInfo : Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalSecretAuthInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalSecretAuthInfo>
    {
        internal ServicePrincipalSecretAuthInfo() { }
        public string ClientId { get { throw null; } }
        public System.Guid PrincipalId { get { throw null; } }
        public string Secret { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalSecretAuthInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalSecretAuthInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalSecretAuthInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalSecretAuthInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalSecretAuthInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalSecretAuthInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.ServicePrincipalSecretAuthInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SourceConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration>
    {
        internal SourceConfiguration() { }
        public string Name { get { throw null; } }
        public string Value { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SourceConfigurationResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult>
    {
        internal SourceConfigurationResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ServiceLinker.Models.SourceConfiguration> Configurations { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SourceConfigurationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SystemAssignedIdentityAuthInfo : Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SystemAssignedIdentityAuthInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SystemAssignedIdentityAuthInfo>
    {
        internal SystemAssignedIdentityAuthInfo() { }
        Azure.ResourceManager.ServiceLinker.Models.SystemAssignedIdentityAuthInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SystemAssignedIdentityAuthInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.SystemAssignedIdentityAuthInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.SystemAssignedIdentityAuthInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SystemAssignedIdentityAuthInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SystemAssignedIdentityAuthInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.SystemAssignedIdentityAuthInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class TargetServiceBaseInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo>
    {
        protected TargetServiceBaseInfo() { }
        Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.TargetServiceBaseInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UserAssignedIdentityAuthInfo : Azure.ResourceManager.ServiceLinker.Models.AuthBaseInfo, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.UserAssignedIdentityAuthInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.UserAssignedIdentityAuthInfo>
    {
        internal UserAssignedIdentityAuthInfo() { }
        public string ClientId { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
        Azure.ResourceManager.ServiceLinker.Models.UserAssignedIdentityAuthInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.UserAssignedIdentityAuthInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ServiceLinker.Models.UserAssignedIdentityAuthInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ServiceLinker.Models.UserAssignedIdentityAuthInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.UserAssignedIdentityAuthInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.UserAssignedIdentityAuthInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ServiceLinker.Models.UserAssignedIdentityAuthInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VnetSolutionType : System.IEquatable<Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VnetSolutionType(string value) { throw null; }
        public static Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType PrivateLink { get { throw null; } }
        public static Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType ServiceEndpoint { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType left, Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType left, Azure.ResourceManager.ServiceLinker.Models.VnetSolutionType right) { throw null; }
        public override string ToString() { throw null; }
    }
}
