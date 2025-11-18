using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;

namespace Herramientas
{
	public static class Divisas
	{
		public static async Task<List<Divisa>> CargarDatos()
		{
			List<Divisa> divisas = new List<Divisa>();

			string html = await Decompiladores.Estandar("https://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");

			if (string.IsNullOrEmpty(html) == false)
			{
				using (TextReader lector = new StringReader(html))
				{
					XmlDocument documento = new XmlDocument();
					documento.Load(lector);

					foreach (XmlNode nodo in documento.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
					{
						if (nodo.Attributes["rate"].Value != null)
						{
							Divisa nuevaDivisa = new Divisa();
							nuevaDivisa.Id = nodo.Attributes["currency"].Value;
							nuevaDivisa.Cantidad = Convert.ToDecimal(nodo.Attributes["rate"].Value);

							divisas.Add(nuevaDivisa);
						}
					}
				}
			}

			if (divisas.Count > 0)
			{
				return divisas;
			}

			return null;
		}

		public class Divisa
		{
			public string Id;
			public decimal Cantidad;
		}

		public static decimal Cambio(decimal cantidad, decimal divisa)
		{
			decimal temp = cantidad / divisa;

			temp = Math.Round(temp, 2);

			return temp;
		}
	}
}
