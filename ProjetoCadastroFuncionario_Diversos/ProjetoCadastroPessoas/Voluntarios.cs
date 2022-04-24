using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastroPessoas
{
	class Voluntarios : Pessoas
	{
		private string funcao;
		//Criacao  do campo  para armazenar  a quantidade  de voluntarios instanciados

		static private int qtdeVolunt = 0;


		public string Funcao { get => funcao; set => funcao = value; }
	
		public override string DadosProcessados()
		{
			CalculoIdade();
			string msg = "Nome voluntário = " + Nome + Environment.NewLine;
			msg += "Data Nasc. = " + Nasc + Environment.NewLine;
			msg += "Idade = " + idade + Environment.NewLine;
			msg += "Função = " + funcao;

			return msg;


		}

		//Metodo construtor da classe voluntario
		//toda vez que a classe for instanciada
		//sera armazenada 1 no campo qtdVolunt
		public Voluntarios()
		{
			qtdeVolunt += 1;
		}
		
		//Metodo  que retorna  a quantidade de volntarios 
		//quando instanciada
		static public int NumerosVoluntarios()
		{
			return qtdeVolunt;
		}

		/*Se
o campo não for
static toda vez que
instanciarmos um
objeto o campo será
inicializado O campo como Static ele mantém
o valor independente da qtde . de
objetos instanciados. O campo
passa a pertencer a classe. Se o método não for
Static, teremos que
instanciar um objeto
para utilizar o método*/
	}

}
