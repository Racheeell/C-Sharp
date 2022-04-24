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
		public int idade;

		public  DateTime Nasc { get => nasc; set => nasc = value; }
	
		public string Nome { get => nome; set => nome = value; }

		protected void CalculoIdade()
		{
			idade = DateTime.Now.Year - Nasc.Year;
		}

		/*
		 Quando queremos alterar os comportamentos que uma
		classe herdou, podemos sobrescrever os métodos.

		Vamos fazer isso com o método DadosProcessados (), ele
		não atende nossa necessidade, pois não tem os campos
		função e salario.
		Para isso precisamos fazer o seguinte:

		Adicionar no método DadosProcessados da classe
		Base Pessoa a palavra chave “virtual”. Uma subclasse
		só pode sobrescrever um método marcado com essa
		palavra chave.

		Adicionar um método com o mesmo nome e a
		mesma assinatura (mesmo valor de retorno e
		mesmos argumentos) na classe derivada (subclasse)
		Funcionario*/
		public virtual string DadosProcessados()
		{ 
			CalculoIdade();
			string msg = "Nome = " + nome + Environment.NewLine;
			msg += "Data nasc = " + Nasc.ToShortDateString() + Environment.NewLine;
			msg += "idade = " + idade;

			return msg;
		}
	}
}
