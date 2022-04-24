using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banco_Dados
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnConectar_Click(object sender, EventArgs e)
		{
			//Criar uma conexão 
		
			SqlConnection con = new SqlConnection("Data Source= SQLEXPRESS;Initial Catalog=Loja;Integrated Security=True");

		

			con.ConnectionString = Properties.Settings.Default.CST;

			//Criando conexao com nome con,
			//Recuperando junto as propriedades, apos  digitar o Default
			//observe que aparecera´uma lista de opções e nesta lista deve aparecer
			//o nome que escolhemos nas propriedades/ setings do projeto anterioremente.
			//no caso CS 

			try
			{
				con.Open();

				//Criando Sql Command, Selecionando todos os dados na tb_clientes;
				SqlCommand Cmm = new SqlCommand();
				Cmm.CommandText = "SELECT * FROM tb_Clientes";
				Cmm.CommandType = CommandType.Text;
				Cmm.Connection = con;
				SqlDataReader DR;
				DR = Cmm.ExecuteReader();

				//Carregar dados Do DataGrid
				DataTable dt = new DataTable();
				dt.Load(DR);
				dataGridView1.DataSource = dt;
				dataGridView1.Refresh();


				con.Close();

				MessageBox.Show("A  conexão foi realizada com sucesso!");

			}
			catch(Exception ex)
			{
				MessageBox.Show(String.Format("Falha na Conexão:{0}", ex.Message));

				//Abriu e fechou a conexão
				//Exibe  a mensagem se a conexão foi realizada  com sucesso,
				//Caso  dê algum erro ele irá  direto  para o catch e exibirá
				//a msg de falha
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
