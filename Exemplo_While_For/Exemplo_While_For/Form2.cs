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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			
			Form1 novo = new Form1();
			//Apresenta o formulario e chama em seguida
			novo.Show();
			//fecha o formulario atual
			this.Visible = false;
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			int Contador;
			Contador = 2016;

			while (Contador>= 1950)
			{
				cboAno.Items.Add(Contador);
				Contador--;
			}
			/*Declaracao da variavel contador do tipo inteiro, onde foi atribuido o valor de 2016(ano)
			 Enquanto o contador for maior oi igual a 1950, o contador faz o decremento.
			Ou seja começa com 2016 e vai ate 1950.
			Itens sao adicionados no Contador*/
		}
	}
}
