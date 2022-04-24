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
	public partial class frmTerceirizados : Form
	{
		public frmTerceirizados(string Usuario)
		{
			InitializeComponent();
			this.Text = "Cadastro Terceirizados" + Usuario;
		}

		private void frmTerceirizados_Load(object sender, EventArgs e)
		{

		}

		private void btnProcessar_Click(object sender, EventArgs e)
		{
			Terceirizados t = new Terceirizados();
			t.Nome = txtNomeTer.Text;
			t.Nasc = dtpNascTer.Value;
			t.Salario = Convert.ToDecimal(txtSalarioTer.Text);

			MessageBox.Show(t.DadosProcessados(), "***Dados Processados***",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
