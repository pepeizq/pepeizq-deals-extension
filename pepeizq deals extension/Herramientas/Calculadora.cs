using System;

namespace Herramientas
{
	public static class Calculadora
	{
		public static string DiferenciaHaceTiempo(this DateTime? fecha2, string idioma = null)
		{
			if (string.IsNullOrEmpty(idioma) == true)
			{
				idioma = "en";
			}

			DateTime fecha = new DateTime();

			if (fecha2 == null)
			{
				fecha = DateTime.Now;
			}
			else
			{
				fecha = (DateTime)fecha2;
			}

			string mensaje = string.Empty;
			TimeSpan diferenciaTiempo = DateTime.Now.Subtract(fecha);

			if (diferenciaTiempo <= TimeSpan.FromSeconds(60))
			{
				if (diferenciaTiempo.Seconds == 1)
				{
					mensaje = string.Format(Idiomas.BuscarTexto(idioma, "Calculator.String0"), diferenciaTiempo.Seconds);
				}
				else
				{
					mensaje = string.Format(Idiomas.BuscarTexto(idioma, "Calculator.String1"), diferenciaTiempo.Seconds);
				}
			}
			else if (diferenciaTiempo <= TimeSpan.FromMinutes(60))
			{
				if (diferenciaTiempo.Minutes == 1)
				{
					mensaje = Idiomas.BuscarTexto(idioma, "Calculator.String3");
				}
				else if (diferenciaTiempo.Minutes > 1)
				{
					mensaje = string.Format(Idiomas.BuscarTexto(idioma, "Calculator.String2"), diferenciaTiempo.Minutes);
				}
			}
			else if (diferenciaTiempo <= TimeSpan.FromHours(24))
			{
				if (diferenciaTiempo.Hours == 1)
				{
					mensaje = Idiomas.BuscarTexto(idioma, "Calculator.String5");
				}
				else if (diferenciaTiempo.Hours > 1)
				{
					mensaje = string.Format(Idiomas.BuscarTexto(idioma, "Calculator.String4"), diferenciaTiempo.Hours);
				}
			}
			else if (diferenciaTiempo < TimeSpan.FromDays(31))
			{
				if (diferenciaTiempo.Days == 1)
				{
					if (diferenciaTiempo.Hours == 0)
					{
						mensaje = Idiomas.BuscarTexto(idioma, "Calculator.String17");
					}
					else if (diferenciaTiempo.Hours == 1)
					{
						mensaje = Idiomas.BuscarTexto(idioma, "Calculator.String16");
					}
					else if (diferenciaTiempo.Hours > 1)
					{
						mensaje = string.Format(Idiomas.BuscarTexto(idioma, "Calculator.String7"), diferenciaTiempo.Hours);
					}
				}
				else if (diferenciaTiempo.Days > 1)
				{
					mensaje = string.Format(Idiomas.BuscarTexto(idioma, "Calculator.String6"), diferenciaTiempo.Days);
				}
			}
			else if (diferenciaTiempo <= TimeSpan.FromDays(365))
			{
				if (diferenciaTiempo.Days > 30 && diferenciaTiempo.Days < 60)
				{
					int dias = diferenciaTiempo.Days - 30;

					if (dias > 1)
					{
						mensaje = string.Format(Idiomas.BuscarTexto(idioma, "Calculator.String9"), dias);
					}
					else if (dias == 1)
					{
						mensaje = Idiomas.BuscarTexto(idioma, "Calculator.String14");
					}
					else
					{
						mensaje = Idiomas.BuscarTexto(idioma, "Calculator.String15");
					}
				}
				else if (diferenciaTiempo.Days >= 60)
				{
					mensaje = string.Format(Idiomas.BuscarTexto(idioma, "Calculator.String8"), diferenciaTiempo.Days / 30);
				}
			}
			else
			{
				if (diferenciaTiempo.Days > 365 && diferenciaTiempo.Days < 730)
				{
					int meses = (diferenciaTiempo.Days - 365) / 30;

					if (meses > 1)
					{
						mensaje = string.Format(Idiomas.BuscarTexto(idioma, "Calculator.String11"), meses);
					}
					else if (meses == 1)
					{
						mensaje = Idiomas.BuscarTexto(idioma, "Calculator.String12");
					}
					else
					{
						mensaje = Idiomas.BuscarTexto(idioma, "Calculator.String13");
					}
				}
				else if (diferenciaTiempo.Days >= 730)
				{
					mensaje = string.Format(Idiomas.BuscarTexto(idioma, "Calculator.String10"), diferenciaTiempo.Days / 365);
				}
			}

			return mensaje;
		}
	}
}
