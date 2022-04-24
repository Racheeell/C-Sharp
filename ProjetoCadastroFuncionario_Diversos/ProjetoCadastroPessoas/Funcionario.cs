using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastroPessoas
{

	/* 1-Uma classe só pode herdar de uma única classe, mas pode herdar
		de várias Interface.
	
	 2- Como a classe funcionário já herda da classe Pessoas
		precisamos separar por vírgula.
	
	 3-A classe Funcionario irá herdar os métodos da Interface IReajuste

	 4-	Enquanto o método Reajuste , que pertence a Interface IReajuste 
		não for implementado essa informação de erra permanecerá (sublinhado
		vermelho)*/
	class Funcionario : Pessoas, IReajuste
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

		public decimal Reajuste(double salario)
		{
			decimal salReajustado = Convert.ToDecimal(salario * 1.5);

			return salReajustado;
		}

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
