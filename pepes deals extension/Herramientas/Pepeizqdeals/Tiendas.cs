using System.Collections.Generic;

namespace Herramientas.Pepeizqdeals
{
	public static class Tiendas
	{
		public static List<Tienda> GenerarListado()
		{
			List<Tienda> tiendas = [new Tienda
			{
				Id = "steam",
				Nombre = "Steam",
				Icono = "imagenes/tiendas/steam_icono.ico"
			},
			new Tienda
			{
				Id = "gamersgate",
				Nombre = "GamersGate",
				Icono = "imagenes/tiendas/gamersgate_icono.ico"
			},
			new Tienda
			{
				Id = "humblestore",
				Nombre = "Humble Store",
				Icono = "imagenes/tiendas/humblestore_icono.ico"
			},
			new Tienda
			{
				Id = "humblechoice",
				Nombre = "Humble Choice",
				Icono = "imagenes/tiendas/humblestore_icono.ico"
			},
			new Tienda
			{
				Id = "fanatical",
				Nombre = "Fanatical",
				Icono = "imagenes/tiendas/fanatical_icono.ico"
			},
			new Tienda
			{
				Id = "gamesplanetuk",
				Nombre = "Gamesplanet (UK)",
				Icono = "imagenes/tiendas/gamesplanet_icono.webp"
			},
			new Tienda
			{
				Id = "gamesplanetfr",
				Nombre = "Gamesplanet (FR)",
				Icono = "imagenes/tiendas/gamesplanet_icono.webp"
			},
			new Tienda
			{
				Id = "gamesplanetde",
				Nombre = "Gamesplanet (DE)",
				Icono = "imagenes/tiendas/gamesplanet_icono.webp"
			},
			new Tienda
			{
				Id = "gamesplanetus",
				Nombre = "Gamesplanet (US)",
				Icono = "imagenes/tiendas/gamesplanet_icono.webp"
			},
			new Tienda
			{
				Id = "wingamestore",
				Nombre = "WinGameStore",
				Icono = "imagenes/tiendas/wingamestore_icono.webp"
			},
			new Tienda
			{
				Id = "greenmangaming",
				Nombre = "Green Man Gaming",
				Icono = "imagenes/tiendas/greenmangaming_icono.ico"
			},
			new Tienda
			{
				Id = "greenmangaminggold",
				Nombre = "Green Man Gaming (Gold)",
				Icono = "imagenes/tiendas/greenmangaming_icono.ico"
			},
			new Tienda
			{
				Id = "indiegala",
				Nombre = "IndieGala",
				Icono = "imagenes/tiendas/indiegala_icono.ico"
			},
			new Tienda
			{
				Id = "gamebillet",
				Nombre = "Gamebillet",
				Icono = "imagenes/tiendas/gamebillet_icono.ico"
			},
			new Tienda
			{
				Id = "playsum",
				Nombre = "Playsum",
				Icono = "imagenes/tiendas/playsum_icono.ico"
			},
			new Tienda
			{
				Id = "2game",
				Nombre = "2Game",
				Icono = "imagenes/tiendas/2game_icono.webp"
			},
			new Tienda
			{
				Id = "dlgamer",
				Nombre = "DLGamer",
				Icono = "imagenes/tiendas/dlgamer_icono.webp"
			},
			new Tienda
			{
				Id = "joybuggy",
				Nombre = "JoyBuggy",
				Icono = "imagenes/tiendas/joybuggy_icono.ico"
			},
			new Tienda
			{
				Id = "voidu",
				Nombre = "Voidu",
				Icono = "imagenes/tiendas/voidu_icono.ico"
			},
			new Tienda
			{
				Id = "gog",
				Nombre = "GOG",
				Icono = "imagenes/tiendas/gog_icono.ico"
			},
			new Tienda
			{
				Id = "epicgamesstore",
				Nombre = "Epic Games Store",
				Icono = "imagenes/tiendas/epic_icono.ico"
			},
			new Tienda
			{
				Id = "planetplay",
				Nombre = "PlanetPlay",
				Icono = "imagenes/tiendas/planetplay_icono.webp"
			},
			new Tienda
			{
				Id = "muvegames",
				Nombre = "Muve.games",
				Icono = "imagenes/tiendas/muvegames_icono.ico"
			}
			];

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

		public static string GenerarReferido(string id, string enlace)
		{
			if (id == "dlgamer")
			{
				return enlace + "?affil=pepeizqdeals";
			}
			else if (id == "fanatical")
			{
				return enlace + "?ref=pepeizq";
			}
			else if (id == "gamebillet")
			{
				return enlace + "?affiliate=64e186aa-fb0e-436f-a000-069090c06fe9";
			}
			else if (id == "gamersgate")
			{
				return enlace + "?aff=6704538";
			}
			else if (id == "gamesplanetuk" || id == "gamesplanetfr" || id == "gamesplanetde" || id == "gamesplanetus")
			{
				return enlace + "?ref=pepeizq";
			}
			else if (id == "greenmangaming" || id == "greenmangamingold")
			{
				enlace = enlace.Replace(":", "%3A");
				enlace = enlace.Replace("/", "%2F");
				enlace = enlace.Replace("/", "%2F");
				enlace = enlace.Replace("?", "%3F");
				enlace = enlace.Replace("=", "%3D");

				return "https://greenmangaming.sjv.io/c/1382810/1219987/15105?u=" + enlace;
			}
			else if (id == "humblestore" || id == "humblechoice")
			{
				enlace = enlace.Replace(":", "%3A");
				enlace = enlace.Replace("/", "%2F");
				enlace = enlace.Replace("/", "%2F");
				enlace = enlace.Replace("?", "%3F");
				enlace = enlace.Replace("=", "%3D");

				return "https://humblebundleinc.sjv.io/c/1382810/2059850/25796?u=" + enlace;
			}
			else if (id == "indiegala")
			{
				return enlace + "?ref=pepeizq";
			}
			else if (id == "joybuggy")
			{
				return enlace + "?ref=253";
			}
			else if (id == "playsum")
			{
				return enlace + "?plysm_ref_id=YiEguGaNJjlnglvi5JTNrVZi1z5OUoli";
			}
			else if (id == "steam")
			{
				return enlace + "?curator_clanid=33500256";
			}
			else if (id == "wingamestore")
			{
				return enlace + "?ars=pepeizqdeals";
			}

			return enlace;
		}
	}

	public class Tienda
	{
		public string Id { get; set; }
		public string Nombre { get; set; }
		public string Icono { get; set; }
	}
}
