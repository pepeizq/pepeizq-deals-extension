namespace Herramientas
{
	public static class EpicGames
	{
		public static string LimpiarSlug(string enlace)
		{
			if (enlace.Contains("/p/") == true)
			{
				int int1 = enlace.IndexOf("/p/");
				enlace = enlace.Remove(0, int1 + 3);
			}

			if (enlace.Contains("?") == true)
			{
				int int1 = enlace.IndexOf("?");
				enlace = enlace.Remove(int1, enlace.Length - int1);
			}
			string slug = enlace.Trim();

			return slug;
		}
	}
}
