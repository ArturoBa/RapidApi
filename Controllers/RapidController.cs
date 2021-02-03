using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RapidApi.ContextDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RapidController : ControllerBase
	{
		private ContexotDb _db;
		public RapidController(ContexotDb db)
		{
			_db = db;
		}

		[HttpGet]
		[Route("GetFilter/")]
		public JsonResult GetAllFiletered(string nombre, string incidencias, string riesgo)
		{
			var query = from data in _db.Personas
						where data.Nombre == nombre
						&& data.Incidencias == incidencias
						&& data.Riesgo == riesgo
						select data;

			var datos = query.ToList();

			return new JsonResult(new { datos });
		}
	}
}
