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

		

		private void btnFuncionario_Click(object sender, EventArgs e)
		{
			//criando o objeto
			frmFuncionario objFuncionario = new frmFuncionario(txtUsuario.Text);
			objFuncionario.Show();
		}

		private void btnTerceirizado_Click(object sender, EventArgs e)
		{
			frmTerceirizados objTerceirizado = new frmTerceirizados(txtUsuario.Text);
			objTerceirizado.Show();
		}

		private void btnVoluntario_Click(object sender, EventArgs e)
		{
			frmVoluntarios objVoluntario = new frmVoluntarios(txtUsuario.Text);
			objVoluntario.Show();
		}
	}
}
