using Microsoft.EntityFrameworkCore;
using RapidApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidApi.ContextDb
{
	public class ContexotDb : DbContext
	{
		public ContexotDb(DbContextOptions options) : base (options)
		{

		}

		public DbSet<Personas> Personas { get; set; }
	}
}
