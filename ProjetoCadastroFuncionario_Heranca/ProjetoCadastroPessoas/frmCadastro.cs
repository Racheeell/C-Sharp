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
	public partial class frmCadastro : Form
	{
		/*Instancie o objeto da classe
		Consistência no inicio da classe. Assim
		vamos conseguir usar o
		objeto em toda a classe*/
		Consistencia c = new Consistencia();

		//Estamos definindo que esse método recebe um argumento(Usuario) para funcionar
		public frmCadastro(string Usuario)
		{
			InitializeComponent();
			
			this.Text = "Cadastro de Pessoas - " + Usuario;

		}

		private void btnProcessar_Click(object sender, EventArgs e)
		{
			//Instanciando  o objeto
			Pessoas objpessoa = new Pessoas();

			objpessoa.Nome = txtNome.Text;
			objpessoa.Nasc = dtpDataNasc.Value;

			//string mensagem = objpessoa.DadosProcessados();

			MessageBox.Show(objpessoa.DadosProcessados(), "Resultado do processamento",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void frmCadastro_Load(object sender, EventArgs e)
		{

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
