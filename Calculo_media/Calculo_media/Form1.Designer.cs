
namespace Calculo_media
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblMedia = new System.Windows.Forms.Label();
			this.txtMedia = new System.Windows.Forms.TextBox();
			this.txtNota2 = new System.Windows.Forms.TextBox();
			this.txtNota1 = new System.Windows.Forms.TextBox();
			this.txtNota3 = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(48, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calculo de Media do Aluno";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(67, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Digite a 1º Nota:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(67, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Digite a 2ºNota";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(64, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Digite a 3ºNota:";
			// 
			// lblMedia
			// 
			this.lblMedia.AutoSize = true;
			this.lblMedia.Location = new System.Drawing.Point(83, 323);
			this.lblMedia.Name = "lblMedia";
			this.lblMedia.Size = new System.Drawing.Size(36, 13);
			this.lblMedia.TabIndex = 4;
			this.lblMedia.Text = "Média";
			// 
			// txtMedia
			// 
			this.txtMedia.Location = new System.Drawing.Point(137, 323);
			this.txtMedia.Name = "txtMedia";
			this.txtMedia.Size = new System.Drawing.Size(100, 20);
			this.txtMedia.TabIndex = 5;
			// 
			// txtNota2
			// 
			this.txtNota2.Location = new System.Drawing.Point(146, 167);
			this.txtNota2.Name = "txtNota2";
			this.txtNota2.Size = new System.Drawing.Size(100, 20);
			this.txtNota2.TabIndex = 6;
			// 
			// txtNota1
			// 
			this.txtNota1.Location = new System.Drawing.Point(146, 127);
			this.txtNota1.Name = "txtNota1";
			this.txtNota1.Size = new System.Drawing.Size(100, 20);
			this.txtNota1.TabIndex = 7;
			// 
			// txtNota3
			// 
			this.txtNota3.Location = new System.Drawing.Point(146, 202);
			this.txtNota3.Name = "txtNota3";
			this.txtNota3.Size = new System.Drawing.Size(100, 20);
			this.txtNota3.TabIndex = 8;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(35, 247);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(84, 46);
			this.btnCalcular.TabIndex = 9;
			this.btnCalcular.Text = "Calcular Média";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(137, 247);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 46);
			this.btnLimpar.TabIndex = 10;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(229, 247);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 46);
			this.btnSair.TabIndex = 11;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 450);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtNota3);
			this.Controls.Add(this.txtNota1);
			this.Controls.Add(this.txtNota2);
			this.Controls.Add(this.txtMedia);
			this.Controls.Add(this.lblMedia);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblMedia;
		private System.Windows.Forms.TextBox txtMedia;
		private System.Windows.Forms.TextBox txtNota2;
		private System.Windows.Forms.TextBox txtNota1;
		private System.Windows.Forms.TextBox txtNota3;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
	}
}

