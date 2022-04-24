using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastroPessoas
{
	class Terceirizados : Pessoas
	{
		#region Corpo da classe
		private decimal salario;

		public decimal Salario { get => salario; set => salario = value; }

		public override string DadosProcessados()
		{
			CalculoIdade();
			string msg = "Nome Terceirizado = " + Nome + Environment.NewLine;
			msg += "Data Nasc. = " + Nasc + Environment.NewLine;
			msg += "Idade = " + idade + Environment.NewLine;
			msg += "Salario = " + Salario.ToString("C") + Environment.NewLine;

			return msg;
		}
		#endregion
	}
}
