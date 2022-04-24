using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastroPessoas
{
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void btnPessoas_Click(object sender, EventArgs e)
		{
			//Agora vamos chamar o formulário Cadastro de Pessoas
			frmCadastro objCadastroPessoas = new frmCadastro(txtUsuario.Text);
			//Usando o método Show(Mostrar) para visualizar o objeto instanciado
			objCadastroPessoas.Show();
		}

		private void btnFuncionario_Click(object sender, EventArgs e)
		{
			//criando o objeto
			frmFuncionario objFuncionario = new frmFuncionario(txtUsuario.Text);
			objFuncionario.Show();
		}
	}
}
