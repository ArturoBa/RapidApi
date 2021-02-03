using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidApi.Models
{
	public class Personas
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Email { get; set; }
		public string ZIP { get; set; }
		public DateTime Fecha { get; set; }
		public string Incidencias { get; set; }
		public string Riesgo { get; set; }
	}
}
