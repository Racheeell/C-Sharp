using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			int numero, resultado, i;
			i = 1;
			numero = int.Parse(txtNumero.Text);
			while (i <=10)
			{
				resultado = i * numero;
				lstTabuada.Items.Add(String.Concat(numero, " * ", i, " = ", resultado));
				i = i + 1;

				/*Declaracao das variaveis do tipo inteiro
				 COnversao para int
				Condicao, enquanto o i for menor ou igual a 10
				variavel resultado realiza o calculo de i multiplicacao pelo numero digitado
				ListBox adiciona o item e concatena (numero * i = resultado)
				incremento*/
			}
		}
	}
}
