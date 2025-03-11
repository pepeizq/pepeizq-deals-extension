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
	}
}
