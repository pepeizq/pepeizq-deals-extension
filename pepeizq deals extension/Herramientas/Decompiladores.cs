using System.Net.Http;
using System.Threading.Tasks;

namespace Herramientas
{
	public static class Decompiladores
	{
		public static async Task<string> Estandar(string enlace)
		{
			HttpClient cliente = new HttpClient();

			string contenido = string.Empty;

			using (cliente)
			{
				cliente.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:109.0) Gecko/20100101 Firefox/114.0");

				using (HttpResponseMessage respuesta = await cliente.GetAsync(enlace, HttpCompletionOption.ResponseContentRead))
				{
					contenido = await respuesta.Content.ReadAsStringAsync();
				}
			}

			cliente.Dispose();

			return contenido;
		}
	}
}
