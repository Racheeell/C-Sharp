
namespace Exemplo_While_For
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
			this.cboAno = new System.Windows.Forms.ComboBox();
			this.btnProximo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Selecione o Ano:";
			// 
			// cboAno
			// 
			this.cboAno.FormattingEnabled = true;
			this.cboAno.Location = new System.Drawing.Point(120, 61);
			this.cboAno.Name = "cboAno";
			this.cboAno.Size = new System.Drawing.Size(121, 21);
			this.cboAno.TabIndex = 1;
			// 
			// btnProximo
			// 
			this.btnProximo.Location = new System.Drawing.Point(231, 101);
			this.btnProximo.Name = "btnProximo";
			this.btnProximo.Size = new System.Drawing.Size(40, 23);
			this.btnProximo.TabIndex = 2;
			this.btnProximo.Text = ">";
			this.btnProximo.UseVisualStyleBackColor = true;
			this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 143);
			this.Controls.Add(this.btnProximo);
			this.Controls.Add(this.cboAno);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboAno;
		private System.Windows.Forms.Button btnProximo;
	}
}

