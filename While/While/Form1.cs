using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnVerificar_Click(object sender, EventArgs e)
		{
			int numero = 1;
			while (numero <= 10)
			{
				listBox1.Items.Add(numero);
				numero = numero + 1;
				/*Declaracao da variavel numero do tipo inteiro, 
				 a variavel  foi inicializada com o numero 1.
				"Enquanto" o numero for menor ou igual 5 o listBox sera preenchido
				expressao = numero + numero 1 é o incremento*/
			}
		}
	}
}
