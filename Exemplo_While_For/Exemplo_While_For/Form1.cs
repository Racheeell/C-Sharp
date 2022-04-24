using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_While_For
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int contador;
			for (contador = 2016 ; contador >= 1950; contador --)
				{
				cboAno.Items.Add(contador);

				/*Declaracao da variavel contador do tipo inteiro
				 Laço For - Atribuido o valor de 2016 (ano), ate que o ano seja maior ou igua a 1950,
				o contador vai fazendo um decremento.
				Ou seja começa com 2016 e vai ate 1950.
				Em seguida os itens sao adicionados no Contador*/
			}
		}

		private void btnProximo_Click(object sender, EventArgs e)
		{
			Form2 novo = new Form2();
			//Declara o objeto novo tipo form e chama em seguida atraves do metodo Show.
			novo.Show();
			//fecha o formulario atual
			this.Visible = false;
		}
	}
}
