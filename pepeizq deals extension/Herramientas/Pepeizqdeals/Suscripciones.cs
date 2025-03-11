using System.Collections.Generic;

namespace Herramientas.Pepeizqdeals
{
	public static class Suscripciones
	{
		public static List<Suscripcion> GenerarListado()
		{
			List<Suscripcion> suscripciones = [new Suscripcion
			{
				Id = 0,
				Nombre = "Humble Choice"
			},
			new Suscripcion
			{
				Id = 1,
				Nombre = "Prime Gaming"
			},
			new Suscripcion
			{
				Id = 2,
				Nombre = "Humble Monthly"
			},
			new Suscripcion
			{
				Id = 3,
				Nombre = "Twitch Prime"
			},
			new Suscripcion
			{
				Id = 4,
				Nombre = "EA Play"
			},
			new Suscripcion
			{
				Id = 5,
				Nombre = "EA Play Pro"
			},
			new Suscripcion
			{
				Id = 6,
				Nombre = "PC Game Pass"
			},
			new Suscripcion
			{
				Id = 7,
				Nombre = "Ubisoft+ Classics"
			},
			new Suscripcion
			{
				Id = 8,
				Nombre = "Ubisoft+ Premium"
			},
			new Suscripcion
			{
				Id = 9,
				Nombre = "Amazon Luna +"
			}];

			return suscripciones;
		}

		public static string DevolverNombre(int id)
		{
			foreach (var suscripcion in GenerarListado())
			{
				if (suscripcion.Id == id)
				{
					return suscripcion.Nombre;
				}
			}

			return null;
		}
	}

	public class Suscripcion
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
	}
}
