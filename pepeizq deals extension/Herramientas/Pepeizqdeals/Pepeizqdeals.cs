using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Herramientas.Pepeizqdeals
{
	public class Json
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("nombre")]
		public string Nombre { get; set; }

		[JsonPropertyName("minimosHistoricos")]
		public List<JsonPrecio> Historicos { get; set; }

		[JsonPropertyName("preciosActuales")]
		public List<JsonPrecio> Actuales { get; set; }

		[JsonPropertyName("bundles")]
		public List<JsonBundle> Bundles { get; set; }

		[JsonPropertyName("gratis")]
		public List<JsonGratis> Gratis { get; set; }

		[JsonPropertyName("suscripciones")]
		public List<JsonSuscripcion> Suscripciones { get; set; }

		[JsonPropertyName("dolar")]
		public decimal Dolar { get; set; }

		[JsonPropertyName("libra")]
		public decimal Libra { get; set; }
	}

	public class JsonPrecio
	{
		[JsonPropertyName("descuento")]
		public int Descuento { get; set; }

		[JsonPropertyName("precio")]
		public decimal Precio { get; set; }

		[JsonPropertyName("drm")]
		public int DRM { get; set; }

		[JsonPropertyName("moneda")]
		public int Moneda { get; set; }

		[JsonPropertyName("tienda")]
		public string Tienda { get; set; }

		[JsonPropertyName("enlace")]
		public string Enlace { get; set; }

		[JsonPropertyName("fechaDetectado")]
		public DateTime FechaDetectado { get; set; }

		[JsonPropertyName("fechaActualizacion")]
		public DateTime FechaActualizacion { get; set; }

		[JsonPropertyName("codigoDescuento")]
		public int CodigoDescuento { get; set; }

		[JsonPropertyName("codigoTexto")]
		public string CodigoTexto { get; set; }
	}

	public class JsonBundle
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("drm")]
		public int DRM { get; set; }

		[JsonPropertyName("fechaEmpieza")]
		public DateTime FechaEmpieza { get; set; }

		[JsonPropertyName("fechaTermina")]
		public DateTime FechaTermina { get; set; }
	}

	public class JsonGratis
	{
		[JsonPropertyName("tipo")]
		public int Tipo { get; set; }

		[JsonPropertyName("drm")]
		public int DRM { get; set; }

		[JsonPropertyName("fechaEmpieza")]
		public DateTime FechaEmpieza { get; set; }

		[JsonPropertyName("fechaTermina")]
		public DateTime FechaTermina { get; set; }
	}

	public class JsonSuscripcion
	{
		[JsonPropertyName("tipo")]
		public int Tipo { get; set; }

		[JsonPropertyName("drm")]
		public int DRM { get; set; }

		[JsonPropertyName("fechaEmpieza")]
		public DateTime FechaEmpieza { get; set; }

		[JsonPropertyName("fechaTermina")]
		public DateTime FechaTermina { get; set; }
	}
}
