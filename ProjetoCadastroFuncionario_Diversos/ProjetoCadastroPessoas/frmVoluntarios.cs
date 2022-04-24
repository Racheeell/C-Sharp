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
	public partial class frmVoluntarios : Form
	{
		public frmVoluntarios(string Usuario)
		{
			InitializeComponent();
			this.Text = "Cadastro Terceirizados" + Usuario;
		}

		private void lblSalarioVol_Click(object sender, EventArgs e)
		{

		}

		private void frmVoluntarios_Load(object sender, EventArgs e)
		{

		}

		private void btnProcessar_Click(object sender, EventArgs e)
		{
			Voluntarios v = new Voluntarios();
			v.Nome = txtNomeVol.Text;
			v.Nasc = dtpNascVol.Value;
			v.Funcao = txtFuncaoVol.Text;

			MessageBox.Show(v.DadosProcessados(), "Dados Processados",
				MessageBoxButtons.OK, MessageBoxIcon.Information);

			txtQtdeVolunt.Text = Voluntarios.NumerosVoluntarios().ToString();

		}
	}
}
