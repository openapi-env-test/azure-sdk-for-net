namespace Azure.Contoso.Widgetmanager
{
    public partial class WidgetmanagerClient
    {
        protected WidgetmanagerClient() { }
        public WidgetmanagerClient(string endpoint, Azure.Core.TokenCredential credential, Azure.Contoso.Widgetmanager.WidgetmanagerClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class WidgetmanagerClientOptions : Azure.Core.ClientOptions
    {
        public WidgetmanagerClientOptions(Azure.Contoso.Widgetmanager.Generated.WidgetmanagerClientOptions.ServiceVersion version = Azure.Contoso.Widgetmanager.Generated.WidgetmanagerClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}