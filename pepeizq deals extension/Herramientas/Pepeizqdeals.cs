using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Herramientas
{
	public class Pepeizqdeals
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("minimosHistoricos")]
		public List<PepeizqdealsPrecio> Historicos { get; set; }

		[JsonPropertyName("precioActuales")]
		public List<PepeizqdealsPrecio> Actuales { get; set; }
	}

	public class PepeizqdealsPrecio
	{
		[JsonPropertyName("descuento")]
		public int Descuento { get; set; }

		[JsonPropertyName("precio")]
		public decimal Precio { get; set; }

		[JsonPropertyName("drm")]
		public int DRM { get; set; }

		[JsonPropertyName("tienda")]
		public string Tienda { get; set; }

		[JsonPropertyName("enlace")]
		public string Enlace { get; set; }

		[JsonPropertyName("fechaDetectado")]
		public DateTime FechaDetectado { get; set; }

		[JsonPropertyName("fechaActualizacion")]
		public DateTime FechaActualizacion { get; set; }
	}
}
