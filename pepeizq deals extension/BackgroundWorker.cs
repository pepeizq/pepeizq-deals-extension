using System.Threading.Tasks;
using Blazor.BrowserExtension;

namespace pepeizq_deals_extension
{
    public partial class BackgroundWorker : BackgroundWorkerBase
    {
        [BackgroundWorkerMain]
        public override void Main()
        {
            WebExtensions.Runtime.OnInstalled.AddListener(OnInstalled);
        }

        async Task OnInstalled()
        {
			string indexPageUrl = WebExtensions.Runtime.GetURL("index");

            await WebExtensions.Tabs.Create(new()
            {
                Url = indexPageUrl
            });
        }
    }
}
