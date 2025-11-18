using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Herramientas
{
	public static class Gog
	{
		public static string LimpiarSlug(string enlace)
		{
			if (enlace.Contains("/game/") == true)
			{
				int int1 = enlace.IndexOf("/game/");
				enlace = enlace.Remove(0, int1 + 6);
			}

			if (enlace.Contains("?") == true)
			{
				int int1 = enlace.IndexOf("?");
				enlace = enlace.Remove(int1, enlace.Length - int1);
			}

			enlace = enlace.Trim();

			return enlace;
		}

		public static async Task<string> DevolverPrecioRegion(string region, string moneda, string id)
		{
			if (string.IsNullOrEmpty(region) == false && string.IsNullOrEmpty(id) == false)
			{
				string enlace = "https://api.gog.com/products/prices?ids=" + id + "&countryCode=" + region + "&currency=" + moneda;

				string html = await Decompiladores.Estandar(enlace);
			
				if (string.IsNullOrEmpty(html) == false)
				{
					GogPrecioRegion datos = JsonSerializer.Deserialize<GogPrecioRegion>(html);

					if (datos != null)
					{ 
						string precio = datos.Embebido.Items[0].Embebido.Precios[0].Precio;
						precio = precio.Replace(moneda, null);
						precio = precio.Trim();

						return precio;
					}
				}
			}

			return null;
		}
	}

	public class GogPrecioRegional
	{
		public string Id { get; set; }
		public string Precio { get; set; }
	}

	public class GogPrecioRegion
	{
		[JsonPropertyName("_embedded")]
		public GogPrecioRegionEmbebido Embebido { get; set; }
	}

	public class GogPrecioRegionEmbebido
	{
		[JsonPropertyName("items")]
		public List<GogPrecioRegionItem> Items { get; set; }
	}

	public class GogPrecioRegionItem
	{
		[JsonPropertyName("_embedded")]
		public GogPrecioRegionEmbebido2 Embebido { get; set; }
	}

	public class GogPrecioRegionEmbebido2
	{
		[JsonPropertyName("prices")]
		public List<GogPrecioRegionPrecio> Precios { get; set; }
	}

	public class GogPrecioRegionPrecio
	{
		[JsonPropertyName("finalPrice")]
		public string Precio { get; set; }
	}
}
