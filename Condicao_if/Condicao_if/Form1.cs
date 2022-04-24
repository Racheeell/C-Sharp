using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicao_if
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnVerificar_Click(object sender, EventArgs e)
		{
			int idade;
			idade = Convert.ToInt32(txtIdade.Text);
			if (idade < 18)
				MessageBox.Show("Você ainda é menor de idade", "Mensagem");
			else
				MessageBox.Show("Voce ja é maior de idade", " Mensagem");

			/*Declaracoa de variavel do tipo int
			 variavel idade recebe conteudo da textbox e valor é convertido para int
			Condição
			Se idade for menos que 18, sera exibida uma MessaBox com a mensagem:
			Voce ainda é menor de idade.
			*/
		}
	}
}
