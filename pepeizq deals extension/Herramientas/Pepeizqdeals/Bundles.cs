using System.Collections.Generic;

namespace Herramientas.Pepeizqdeals
{
	public static class Bundles
	{
		public static List<Bundle> GenerarListado()
		{
			List<Bundle> bundles = [new Bundle
			{
				Id = 1,
				Nombre = "Humble Bundle"
			},
			new Bundle
			{
				Id = 2,
				Nombre = "Fanatical"
			},
			new Bundle
			{
				Id = 3,
				Nombre = "Jingle Jam"
			},
			new Bundle
			{
				Id = 4,
				Nombre = "IndieGala"
			},
			new Bundle
			{
				Id = 5,
				Nombre = "itch.io"
			}];

			return bundles;
		}

		public static string DevolverNombre(int id)
		{
			foreach (var bundle in GenerarListado())
			{
				if (bundle.Id == id)
				{
					return bundle.Nombre;
				}
			}

			return null;
		}
	}

	public class Bundle
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
	}
}
