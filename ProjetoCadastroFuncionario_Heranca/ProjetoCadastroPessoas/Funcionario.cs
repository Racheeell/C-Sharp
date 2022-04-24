using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastroPessoas
{
	class Funcionario : Pessoas
	{
		//essa classe vai herdar todos os atributos, propriedade e métodos na nossa base Pessoas

		#region Corpo da classe
		private string funcao;
		private decimal salario;

		public string Funcao { get => funcao; set => funcao = value; }
		public decimal Salario { get => salario; set => salario = value; }

		/*Crie o método com a palavra
			chave Override ,
			assim estaremos sobrescrevendo o método da classe Base.*/
		public override string DadosProcessados()
		{
			CalculoIdade();
			string msg = "Nome = " + Nome + Environment.NewLine;
			msg += "Data Nasc. = " + Nasc + Environment.NewLine;
			msg += "Idade = " + idade + Environment.NewLine;
			msg += "Função = " + funcao + Environment.NewLine;
			msg += "Salario = " + salario;

			return msg;

			#endregion
		}
	}
}
