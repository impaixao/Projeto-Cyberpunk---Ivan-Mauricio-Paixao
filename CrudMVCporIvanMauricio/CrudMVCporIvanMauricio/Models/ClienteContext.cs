using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudMVCporIvanMauricio.Models
{
	public class ClienteContext:DbContext
	{
		public ClienteContext():base("Cadastro")
		{
			Database.CreateIfNotExists();
		}

		public DbSet<Cliente> Clientes { get; set; }
	}
}