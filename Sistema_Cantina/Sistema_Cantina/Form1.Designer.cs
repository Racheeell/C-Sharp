
namespace Sistema_Cantina
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lstCaixa = new System.Windows.Forms.ListBox();
			this.picImagem = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(131, 65);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "SISTEMA CANTINA";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "CÓDIGO DO PRODUTO:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(39, 142);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(125, 20);
			this.txtCodigo.TabIndex = 2;
			this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
			// 
			// lstCaixa
			// 
			this.lstCaixa.FormattingEnabled = true;
			this.lstCaixa.Location = new System.Drawing.Point(190, 110);
			this.lstCaixa.Name = "lstCaixa";
			this.lstCaixa.Size = new System.Drawing.Size(150, 160);
			this.lstCaixa.TabIndex = 3;
			// 
			// picImagem
			// 
			this.picImagem.Location = new System.Drawing.Point(39, 168);
			this.picImagem.Name = "picImagem";
			this.picImagem.Size = new System.Drawing.Size(125, 102);
			this.picImagem.TabIndex = 4;
			this.picImagem.TabStop = false;
			this.picImagem.Click += new System.EventHandler(this.picImagem_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 295);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 13);
			this.label3.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 380);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.picImagem);
			this.Controls.Add(this.lstCaixa);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.ListBox lstCaixa;
		private System.Windows.Forms.PictureBox picImagem;
		private System.Windows.Forms.Label label3;
	}
}

