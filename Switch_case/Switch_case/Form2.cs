using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
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

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			switch (cboOpcao.Text)
			/* De acordo com o final da placa escolhida no combobox sera exibida uma mensagem
			 *informativa.
			 *Caso o final da placa seja 1 ou 2 o rodizio sera segunda, 
			 *caso 3 ou 4 na terça e assim por diante
			 */
			{
				case "1 ou 2":
					lblRes.Text = "O dia de seu rodizio é Segunda-feira";
					break;

				case "3 ou 4":
					lblRes.Text = "O dia de seu rodizio é Terça-feira";
					break;

				case "5 ou 6":
					lblRes.Text = "O dia de seu rodizio é Quarta-feira";
					break;

				case "7 ou 8":
					lblRes.Text = "O dia de seu rodizio é Quinta-feira";
					break;

				case "9 ou 0":
					lblRes.Text = "O dia de seu rodizio é Sexta-feira";
					break;
			


			}
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			Form1 novo = new Form1();
			//Apresenta o formulario e chama em seguida
			novo.Show();
			//fecha o formulario atual
			this.Visible = false;
		}
	}
}
