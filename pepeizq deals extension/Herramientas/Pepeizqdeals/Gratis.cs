using System.Collections.Generic;

namespace Herramientas.Pepeizqdeals
{
	public static class Gratis
	{
		public static List<Gratis2> GenerarListado()
		{
			List<Gratis2> gratis = [new Gratis2
			{
				Id = 1,
				Nombre = "Steam"
			},
			new Gratis2
			{
				Id = 2,
				Nombre = "GOG"
			},
			new Gratis2
			{
				Id = 3,
				Nombre = "Fanatical"
			},
			new Gratis2
			{
				Id = 4,
				Nombre = "Ubisoft"
			},
			new Gratis2
			{
				Id = 5,
				Nombre = "Epic Games Store"
			},
			new Gratis2
			{
				Id = 6,
				Nombre = "Amplifiers"
			},
			new Gratis2
			{
				Id = 7,
				Nombre = "SEGA"
			},
			new Gratis2
			{
				Id = 8,
				Nombre = "Humble Bundle"
			},
			new Gratis2
			{
				Id = 9,
				Nombre = "BundleStars"
			},
			new Gratis2
			{
				Id = 10,
				Nombre = "IndieGala"
			},
			new Gratis2
			{
				Id = 11,
				Nombre = "Behavior"
			}];

			return gratis;
		}

		public static string DevolverNombre(int id)
		{
			foreach (var gratis in GenerarListado())
			{
				if (gratis.Id == id)
				{
					return gratis.Nombre;
				}
			}

			return null;
		}
	}

	public class Gratis2
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
	}
}
