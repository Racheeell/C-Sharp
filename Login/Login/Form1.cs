using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			string usuario, senha;
			usuario = txtUsuario.Text;
			senha = txtSenha.Text;

			if(usuario == "Admin" && senha =="Admin")
			{
				Form2 novo = new Form2();
				novo.Show();
				this.Visible = false;
				/*Declaracao de variaveis e atribuiçao
				 Condicao - Se o usuario e (&&) Senha forem iguais e Admin,
				Sera chamado o Form2.
				Ou seja ele terá acesso ao sistema, somente se o usuario e senha estiver correto*/
			}
		}
	}
}
