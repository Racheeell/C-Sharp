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
		public frmCadastro()
		{
			InitializeComponent();
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
	}
}
