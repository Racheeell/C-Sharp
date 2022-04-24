using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
	public partial class Form1 : Form
	{
		string[] produtos = new string[10];
		string[] codigo = new string[10];
		double[] valor = new double[10];
		double soma;

		/*Declaracao de 3 arrays para armazenar 10 produtos, 
		 * e seus respectivos codigos e valores*/

		public Form1()
		{
			InitializeComponent();
		}

		private void picImagem_Click(object sender, EventArgs e)
		{

		}

		private void txtCodigo_TextChanged(object sender, EventArgs e)
		{
			if (txtCodigo.Text.Length == 3)
			{
				/*lstCaixa.Items.Add(txtCodigo.Text);
				txtCodigo.Text = "";
				txtCodigo.Focus();
				Inicia com uma condicao, se o usuario digitar um codigo com 5 caracteres (length), esse
				 codigo é adicionado ao listBox.
					A propriedade leghth retorna a quantidade de caracteres.
					Apos o conteudo ser enviado para o ListBox, o textbox sera limpo e o Focus 
				posiciona o cursor para o TextBox para uma nova digitacao*/
				{
					int indice = 0;
					for(int prod = 1; prod < codigo.Length; prod++)
					/*Faça enquanto o prod for menor ou igual a qtde de itens do array*/
					{
						if (txtCodigo.Text == codigo[prod]) 
						{
							indice = prod;
						}
					}
					if(indice == 0)
					{
						MessageBox.Show("Produto não encontrado");

						/*Condicao, se foi encontrado o produto ele retorna
						 as informaçoes de acordo com o indice
						Caso nao encontre aparecera a mensagem, Produto nao encontrado*/

					}
					else
					{
						lstCaixa.Items.Add(txtCodigo.Text + " -- " + produtos[indice] + "-- R$ " + 
							valor[indice]);
						/*Conteudo adicionado no ListBox, concatena (+) as informaçoes (codigo/nome/valor)*/

						soma = soma + valor[indice];
						label3.Text = ("Valor Total R$ " + soma);
						picImagem.ImageLocation = "c:/imagens/" + codigo[indice] + "jpg";
						txtCodigo.Text = "";
						txtCodigo.Focus();
						/*localizaçao da imagem que deve ser colocada em uma pasta em c:
						 em uma pasta imagens
						* o TextBox sera limpo e o focus posiciona o cursor para 
						o TextBox para uma nova digitacao*/
					}
				}

			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			carregarArray();
			soma = 0;
			/*Ao entrar no Form Load sera chamado o método*/
		}
		private void carregarArray()

		/*Criacao do metodo para ser chamado quando necessario, isso evita repetir
		 varias vezes o mesmo codigo*/
		{
			codigo[1] = "001";
			codigo[2] = "002";
			codigo[3] = "003";
			codigo[4] = "004";
			codigo[5] = "005";

			produtos[1] = "Pastel";
			produtos[2] = "Coxinha";
			produtos[3] = "Hot_Dog";
			produtos[4] = "Chocolate";
			produtos[5] = "Suco";

			valor[1] = 6.00;
			valor[2] = 5.00;
			valor[3] = 12.00;
			valor[4] = 3.50;
			valor[5] = 8.00;

			/*Codigos, produtos e valores ref. os arrays que foram declarados*/

		
			
		}
	}
}
