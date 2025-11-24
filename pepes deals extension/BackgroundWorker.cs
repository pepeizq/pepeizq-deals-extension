using Blazor.BrowserExtension;
using System.Text.Json;
using System.Threading.Tasks;
using WebExtensions.Net.Runtime;

namespace pepes_deals_extension
{
    public partial class BackgroundWorker : BackgroundWorkerBase
    {
        [BackgroundWorkerMain]
        public override async void Main()
        {
            WebExtensions.Runtime.OnMessage.AddListener(Escuchando);
		}

        async Task OnInstalled()
        {
            var indexPageUrl = WebExtensions.Runtime.GetURL("index.html");

            await WebExtensions.Tabs.Create(new()
            {
                Url = indexPageUrl
            });
		}

        public async Task<string> Escuchando()
        {
            var mensaje = WebExtensions.Runtime.OnMessage;

            if (mensaje.AdditionalData != null)
            {
                string accion = mensaje.AdditionalData["action"]?.ToString() ?? string.Empty;

                if (accion == "ObtenerHtml")
                {
					string enlace = mensaje.AdditionalData["enlace"]?.ToString() ?? string.Empty;

                    if (string.IsNullOrEmpty(enlace) == false)
                    {
						return await Herramientas.Decompiladores.Estandar(enlace);
					}
				}
			}

            return null;
		}
    }
}
