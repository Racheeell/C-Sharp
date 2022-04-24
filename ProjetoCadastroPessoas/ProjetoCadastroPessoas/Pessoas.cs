using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastroPessoas
{
	class Pessoas
	{
		private string nome;
		private DateTime nasc;
		private int idade;

		public  DateTime Nasc { get => nasc; set => nasc = value; }
	
		public string Nome { get => nome; set => nome = value; }

		private void CalculoIdade()
		{
			idade = DateTime.Now.Year - Nasc.Year;
		}

		public string DadosProcessados()
		{ 
			CalculoIdade();
			string msg = "Nome = " + nome + Environment.NewLine;
			msg += "Data nasc = " + Nasc.ToShortDateString() + Environment.NewLine;
			msg += "idade = " + idade;

			return msg;
		}
	}
}
