using System;

namespace Herramientas
{
	public static class Divisas
	{
		public static decimal Cambio(decimal cantidad, decimal divisa)
		{
			decimal temp = cantidad / divisa;

			temp = Math.Round(temp, 2);

			return temp;
		}
	}
}
