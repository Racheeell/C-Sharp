using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastroPessoas
{
	interface IReajuste
	{
		/*Os métodos não são implementados na Interface.  
		 * São implementados nas classes que herdam a Interface.*/

		decimal Reajuste(double salario);
	}
}
