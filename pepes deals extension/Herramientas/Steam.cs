namespace Herramientas
{
	public static class Steam
	{
		public static string LimpiarId(string enlace)
		{
			enlace = enlace.Replace("http://store.steampowered.com/app/", null);
			enlace = enlace.Replace("http://store.steampowered.com/dlc/", null);
			enlace = enlace.Replace("https://store.steampowered.com/app/", null);
			enlace = enlace.Replace("https://store.steampowered.com/dlc/", null);

			if (enlace.Contains("/") == true)
			{
				int int1 = enlace.IndexOf("/");
				enlace = enlace.Remove(int1, enlace.Length - int1);
			}

			if (enlace.Contains("?") == true)
			{
				int int1 = enlace.IndexOf("?");
				enlace = enlace.Remove(int1, enlace.Length - int1);
			}

			string id = enlace.Trim();

			return id;
		}
	}
}
