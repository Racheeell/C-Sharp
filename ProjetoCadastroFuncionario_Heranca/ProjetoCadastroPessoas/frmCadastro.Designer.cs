
namespace ProjetoCadastroPessoas
{
	partial class frmCadastro
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnProcessar = new System.Windows.Forms.Button();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblData = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// btnProcessar
			// 
			this.btnProcessar.Location = new System.Drawing.Point(56, 185);
			this.btnProcessar.Name = "btnProcessar";
			this.btnProcessar.Size = new System.Drawing.Size(75, 38);
			this.btnProcessar.TabIndex = 0;
			this.btnProcessar.Text = "Processar";
			this.btnProcessar.UseVisualStyleBackColor = true;
			this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(53, 81);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(35, 13);
			this.lblNome.TabIndex = 1;
			this.lblNome.Text = "Nome";
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.Location = new System.Drawing.Point(56, 128);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(104, 13);
			this.lblData.TabIndex = 2;
			this.lblData.Text = "Data de Nascimento";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(157, 81);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(219, 20);
			this.txtNome.TabIndex = 3;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(166, 185);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 38);
			this.btnLimpar.TabIndex = 4;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(275, 185);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 38);
			this.btnSair.TabIndex = 5;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// dtpDataNasc
			// 
			this.dtpDataNasc.Location = new System.Drawing.Point(166, 121);
			this.dtpDataNasc.Name = "dtpDataNasc";
			this.dtpDataNasc.Size = new System.Drawing.Size(210, 20);
			this.dtpDataNasc.TabIndex = 6;
			// 
			// frmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 248);
			this.Controls.Add(this.dtpDataNasc);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.btnProcessar);
			this.Name = "frmCadastro";
			this.Text = "Cadastro de Pessoas";
			this.Load += new System.EventHandler(this.frmCadastro_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnProcessar;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.DateTimePicker dtpDataNasc;
	}
}

