using System.Collections.Generic;
using System.Text.Json;

namespace Herramientas
{
	public static class Idiomas
	{
		public class IdiomaClase
		{
			public string Id { get; set; }
			public List<string> Codigos { get; set; }
		}

		public static List<IdiomaClase> ListadoIdiomasGenerar()
		{
			List<IdiomaClase> idiomas = [
				new IdiomaClase
				{
					Id = "en",
					Codigos = new List<string>() { "en", "en-US", "en-GB" }
				},
				new IdiomaClase
				{
					Id = "es",
					Codigos = new List<string>() { "es", "es-ES", "ca", "ca-ES-valencia", "eu", "gl" }
				},
				new IdiomaClase
				{
					Id = "de",
					Codigos = new List<string>() { "de", "de-DE" }
				},
				new IdiomaClase
				{
					Id = "fr",
					Codigos = new List<string>() { "fr", "fr-FR", "fr-CA" }
				},
				new IdiomaClase
				{
					Id = "it",
					Codigos = new List<string>() { "it", "it-IT" }
				},
				new IdiomaClase
				{
					Id = "pt",
					Codigos = new List<string>() { "pt", "pt-PT" }
				}
			];

			return idiomas;
		}

		public static string SacarIdiomaUsuarioWeb(string idiomaUsuario)
		{
			if (string.IsNullOrEmpty(idiomaUsuario) == true)
			{
				return "en";
			}
			else
			{
				foreach (var idioma in ListadoIdiomasGenerar())
				{
					if (idioma.Id == idiomaUsuario)
					{
						return idioma.Id;
					}

					foreach (var codigo in idioma.Codigos)
					{
						if (codigo.ToLower() == idiomaUsuario.ToLower())
						{
							return idioma.Id;
						}
					}
				}

				return "en";
			}
		}

		public static string BuscarTexto(string json, string cadena)
		{
			if (string.IsNullOrEmpty(json) == false)
			{
				JsonElement elementos = JsonSerializer.Deserialize<JsonElement>(json);

				if (elementos.TryGetProperty(cadena, out var resultado))
				{
					return resultado.GetString();
				}
			}

			return "empty";
		}
	}
}
