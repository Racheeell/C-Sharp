﻿
namespace Tabuada
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.lstTabuada = new System.Windows.Forms.ListBox();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(92, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "TABUADA";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Digite um número:";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(147, 124);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(84, 44);
			this.btnCalcular.TabIndex = 2;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(147, 193);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(84, 36);
			this.btnLimpar.TabIndex = 3;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(147, 253);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(84, 41);
			this.btnSair.TabIndex = 4;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			// 
			// lstTabuada
			// 
			this.lstTabuada.FormattingEnabled = true;
			this.lstTabuada.Location = new System.Drawing.Point(12, 108);
			this.lstTabuada.Name = "lstTabuada";
			this.lstTabuada.Size = new System.Drawing.Size(120, 186);
			this.lstTabuada.TabIndex = 5;
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(110, 73);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(130, 20);
			this.txtNumero.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 320);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lstTabuada);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnCalcular);
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
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.ListBox lstTabuada;
		private System.Windows.Forms.TextBox txtNumero;
	}
}

