namespace Azure.Template.Widgetmanager
{
    public partial class WidgetManagerClient
    {
        public WidgetManagerClient() { }
        public WidgetManagerClient(Azure.Template.Widgetmanager.WidgetManagerClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Operation<System.BinaryData> CreateOrUpdateWidget(Azure.WaitUntil waitUntil, string widgetName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> CreateOrUpdateWidgetAsync(Azure.WaitUntil waitUntil, string widgetName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<System.BinaryData> DeleteWidget(Azure.WaitUntil waitUntil, string widgetName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> DeleteWidgetAsync(Azure.WaitUntil waitUntil, string widgetName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetWidget(string widgetName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetWidgetAsync(string widgetName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetWidgets(int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetWidgetsAsync(int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), Azure.RequestContext context = null) { throw null; }
    }
    public partial class WidgetManagerClientOptions : Azure.Core.ClientOptions
    {
        public WidgetManagerClientOptions(Azure.Template.Widgetmanager.WidgetManagerClientOptions.ServiceVersion version = Azure.Template.Widgetmanager.WidgetManagerClientOptions.ServiceVersion.V2022_11_01_Preview) { }
        public enum ServiceVersion
        {
            V2022_11_01_Preview = 1,
        }
    }
}
