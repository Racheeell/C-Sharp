
namespace Calculos_basico
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
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.btnSomar = new System.Windows.Forms.Button();
			this.btnSubtrair = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(133, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calculos Basicos";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(88, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Digite o 1º número:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(88, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Digite o 2º número:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(130, 317);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Resultado";
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(191, 148);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(100, 20);
			this.txtNum1.TabIndex = 4;
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(191, 213);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(100, 20);
			this.txtNum2.TabIndex = 5;
			// 
			// txtResultado
			// 
			this.txtResultado.Location = new System.Drawing.Point(191, 310);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(100, 20);
			this.txtResultado.TabIndex = 6;
			// 
			// btnSomar
			// 
			this.btnSomar.Location = new System.Drawing.Point(119, 256);
			this.btnSomar.Name = "btnSomar";
			this.btnSomar.Size = new System.Drawing.Size(29, 23);
			this.btnSomar.TabIndex = 7;
			this.btnSomar.Text = "+";
			this.btnSomar.UseVisualStyleBackColor = true;
			this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
			// 
			// btnSubtrair
			// 
			this.btnSubtrair.Location = new System.Drawing.Point(159, 256);
			this.btnSubtrair.Name = "btnSubtrair";
			this.btnSubtrair.Size = new System.Drawing.Size(26, 23);
			this.btnSubtrair.TabIndex = 8;
			this.btnSubtrair.Text = "-";
			this.btnSubtrair.UseVisualStyleBackColor = true;
			this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
			// 
			// btnDividir
			// 
			this.btnDividir.Location = new System.Drawing.Point(191, 256);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(29, 23);
			this.btnDividir.TabIndex = 9;
			this.btnDividir.Text = "/";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Location = new System.Drawing.Point(227, 256);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(31, 23);
			this.btnMultiplicar.TabIndex = 10;
			this.btnMultiplicar.Text = "x";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 450);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnSubtrair);
			this.Controls.Add(this.btnSomar);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
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
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.Button btnSomar;
		private System.Windows.Forms.Button btnSubtrair;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnMultiplicar;
	}
}

