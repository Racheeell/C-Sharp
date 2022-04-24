using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos_basico
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		
		private void btnSomar_Click(object sender, EventArgs e)
		{
			//Declaracao de variaveis do tipo double, num1, num2, resultado
			double num1, num2, resultado;
			/* num1 e num2 recebe conteudo do textbox
			(txtNum1.txt e txtNum2.txt) 
			Convert.ToDouble é necessario para que seja convertido 
			o conteudo do textbox para numero*/
			num1 = Convert.ToDouble(txtNum1.Text);
			num2 = Convert.ToDouble(txtNum2.Text);
			// Variavel resultado = recebe conteudo de num1 + num2
			// e realizar o calculo
			resultado = num1 + num2;
			//txtResultado.Text = recebe conteudo da variavel
			// resultado e converte para numero
			txtResultado.Text = resultado.ToString();
		}

		private void btnSubtrair_Click(object sender, EventArgs e)
		{
			double num1, num2, resultado;

			num1 = Convert.ToDouble(txtNum1.Text);
			num2 = Convert.ToDouble(txtNum2.Text);
			
			resultado = num1 - num2;
			
			txtResultado.Text = resultado.ToString();
		}

		private void btnDividir_Click(object sender, EventArgs e)
		{
			double num1, num2, resultado;

			num1 = Convert.ToDouble(txtNum1.Text);
			num2 = Convert.ToDouble(txtNum2.Text);

			resultado = num1 / num2;

			txtResultado.Text = resultado.ToString();
		}

		private void btnMultiplicar_Click(object sender, EventArgs e)
		{
			double num1, num2, resultado;

			num1 = Convert.ToDouble(txtNum1.Text);
			num2 = Convert.ToDouble(txtNum2.Text);

			resultado = num1 * num2;

			txtResultado.Text = resultado.ToString();
		}
	}
}
