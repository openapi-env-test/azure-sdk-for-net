namespace Azure.Template.SDKReleasePlannerTest
{
    public partial class SDKReleasePlannerTestClient
    {
        protected SDKReleasePlannerTestClient() { }
        public SDKReleasePlannerTestClient(string endpoint, Azure.Core.TokenCredential credential, Azure.Template.SDKReleasePlannerTest.SDKReleasePlannerTestClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class SDKReleasePlannerTestClientOptions : Azure.Core.ClientOptions
    {
        public SDKReleasePlannerTestClientOptions(Azure.Template.SDKReleasePlannerTest.Generated.SDKReleasePlannerTestClientOptions.ServiceVersion version = Azure.Template.SDKReleasePlannerTest.Generated.SDKReleasePlannerTestClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}