namespace Azure.Analytics.Purview.Shared
{
    public partial class SharedClient
    {
        protected SharedClient() { }
        public SharedClient(string endpoint, Azure.Core.TokenCredential credential, Azure.Analytics.Purview.Shared.SharedClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class SharedClientOptions : Azure.Core.ClientOptions
    {
        public SharedClientOptions(Azure.Analytics.Purview.Shared.Generated.SharedClientOptions.ServiceVersion version = Azure.Analytics.Purview.Shared.Generated.SharedClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}