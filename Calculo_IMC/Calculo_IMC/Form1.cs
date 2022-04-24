using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
{
	public partial class btnIMC : Form
	{
		public btnIMC()
		{
			InitializeComponent();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			double Peso, altura, resultado;

			Peso = Convert.ToDouble(txtPeso.Text);
			altura = Convert.ToDouble(txtAltura.Text);

			resultado = Peso / (altura * altura);

			

			if (resultado < 18.49)
			{
				MessageBox.Show("Você esta abaixo do peso", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (resultado < 24.99 )
			{
				MessageBox.Show("Voce esta com peso dentro da normalidade", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (resultado < 29.99)
			{
				MessageBox.Show("Voce esta acima do peso", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (resultado < 34.99)
			{
				MessageBox.Show("Atenção, você esta com Obesidade Grau I", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else if(resultado < 39.99)
				{
				MessageBox.Show("Atenção, voce esta com Obesidade Grau II(severa)", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else 
			{
				MessageBox.Show("Atenção, voce esta com Obesidade Grau III(mórbida)", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}

			txtIMC.Text = resultado.ToString("");
		}
	}
}
