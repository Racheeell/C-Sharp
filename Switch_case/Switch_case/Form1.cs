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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cboSemana.Text)
			/*O conteudo da combox (cboSemana) sera analisado e de acordo com a opcao escolhida, 
			 aparecera uma determinada mensagem, caso o usuario escolha Domingo, sera uma msg, caso*/
			{
				case "Domingo":
					MessageBox.Show("Voce escolheu Domingo que é o 1º dia da Semana", "Mensagem", 
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;

				case "Segunda":
					MessageBox.Show("Voce escolheu Segunda que é o 2º dia da Semana", "Mensagem",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;

				case "Terça":
					MessageBox.Show("Voce escolheu Terça que é o 3º dia da Semana", "Mensagem",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;

				case "Quarta":
					MessageBox.Show("Voce escolheu Quarta que é o 4º dia da Semana", "Mensagem",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;

				case "Quinta: ":
					MessageBox.Show("Voce escolheu Quinta que é o 5º dia da Semana", "Mensagem",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;

				case "Sexta":
					MessageBox.Show("Voce escolheu Sexta que é o 6º dia da Semana", "Mensagem",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;

				case "Sabado":
					MessageBox.Show("Voce escolheu Sabado que é o 7º dia da Semana", "Mensagem",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;







			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 novo = new Form2();
			//Declara o objeto novo tipo form e chama em seguida atraves do metodo Show.
			novo.Show();
			//fecha o formulario atual
			this.Visible = false;
		}
	}
}
