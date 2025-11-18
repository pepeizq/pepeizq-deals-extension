using System.IO.Compression;
using System.Text;

namespace Herramientas
{
	public static class Decompiladores
	{
		public static async Task<string> Estandar(string enlace)
		{
			HttpRequestMessage mensaje = new HttpRequestMessage();
			mensaje.Headers.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue() { NoCache = true, NoStore = true };
			mensaje.Headers.Pragma.ParseAdd("no-cache");
			mensaje.RequestUri = new Uri(enlace);
			mensaje.Headers.Accept.ParseAdd("text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8");
			mensaje.Headers.AcceptEncoding.ParseAdd("gzip, deflate, br");
			mensaje.Headers.AcceptLanguage.ParseAdd("es,en-US;q=0.7,en;q=0.3");
			mensaje.Headers.Connection.ParseAdd("keep-alive");
			mensaje.Headers.UserAgent.ParseAdd("Mozilla/5.0 (Linux; Android 10; Generic Android-x86_64 Build/QD1A.190821.014.C2; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/79.0.3945.36 Safari/537.36");

			using (var handler = new HttpClientHandler() { })
			{
				using (HttpClient cliente = new HttpClient(handler) { BaseAddress = new Uri(enlace) })
				{
					HttpResponseMessage respuesta = await cliente.SendAsync(mensaje);

					Stream stream = await respuesta.Content.ReadAsStreamAsync();
					respuesta.Dispose();

					using (GZipStream descompresion = new GZipStream(stream, CompressionMode.Decompress, false))
					{
						using (StreamReader lector = new StreamReader(stream, Encoding.UTF8))
						{
							return await lector.ReadToEndAsync();
						}
					}
				}
			}
		}
	}
}
