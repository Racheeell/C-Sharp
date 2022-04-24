using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastroPessoas
{
	static class Consistencia
	{
		static public void Finalizar(Form formFechar)
		{
			
			if (MessageBox.Show("Deseja realmente sair ?", "****Saída****", 
				MessageBoxButtons.YesNo, MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				formFechar.Close();
			}
		}

		static public void LimparCampos(Form formlimpar)
		{
			foreach(Control controle in formlimpar.Controls)
			{
				if(controle is TextBox)
				{
					(controle as TextBox).Clear();
				}
				else if(controle is DateTimePicker)
				{
					(controle as DateTimePicker).Value = DateTime.Now;
				}
			}
		}
	}
}
