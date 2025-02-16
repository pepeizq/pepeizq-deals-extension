using System.Collections.Generic;

namespace Herramientas
{
	public static class Tiendas
	{
		public static List<Tienda> GenerarListado()
		{
			List<Tienda> tiendas = new List<Tienda>();

			#region Steam

			Tienda steam = new Tienda
			{
				Id = "steam",
				Nombre = "Steam",
				Icono = "imagenes/tiendas/steam_icono.ico"
			};

			tiendas.Add(steam);

			#endregion

			#region Fanatical

			Tienda fanatical = new Tienda
			{
				Id = "fanatical",
				Nombre = "Fanatical",
				Icono = "imagenes/tiendas/fanatical_icono.ico"
			};

			tiendas.Add(fanatical);

			#endregion

			return tiendas;
		}

		public static Tienda Buscar(string id)
		{
			foreach (var tienda in GenerarListado())
			{
				if (tienda.Id == id)
				{
					return tienda;
				}
			}

			return null;
		}
	}

	public class Tienda
	{
		public string Id { get; set; }
		public string Nombre { get; set; }
		public string Icono { get; set; }
	}
}
