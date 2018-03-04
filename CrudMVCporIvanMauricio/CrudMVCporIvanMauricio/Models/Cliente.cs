using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMVCporIvanMauricio.Models
{
	[Table("Clientes")]
	public class Cliente
	{
		public int Id { get; set; }

		[Required]
		public String Nome { get; set; }

		[Required]
		[Display(Name = "Endereço")]
		public String Endereco { get; set; }

		[Required]
		public String Telefone { get; set; }

		[Display(Name = "E-mail")]
		public String Email { get; set; }

		[Display(Name = "Data de Nascimento")]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime DataNascimento { get; set; }

		[Required]
		public bool Ativo { get; set; }
	}
}