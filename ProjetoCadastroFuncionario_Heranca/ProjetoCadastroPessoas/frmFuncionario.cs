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
	public partial class frmFuncionario : Form
	{
		Consistencia c = new Consistencia();

		public frmFuncionario(string Usuario)
		{
			InitializeComponent();
			this.Text = "Cadastro de Pessoas - " + Usuario;
		}

		private void frmFuncionario_Load(object sender, EventArgs e)
		{

		}

		private void btnProcessar_Click(object sender, EventArgs e)
		{
			//instanciando um objeto da classe funcionario
			Funcionario f = new Funcionario();

			f.Nome = txtNomeFun.Text;
			f.Nasc = dtpNascFun.Value;
			f.Funcao = txtFuncao.Text;
			f.Salario = Convert.ToDecimal(txtSalario.Text);


			MessageBox.Show(f.DadosProcessados(), "Resultado do Processamento",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			c.LimparCampos(this);
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			c.Finalizar(this);
		}
	}
}
