
namespace Calculo_IMC
{
	partial class btnIMC
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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl = new System.Windows.Forms.Label();
			this.txtIMC = new System.Windows.Forms.TextBox();
			this.txtPeso = new System.Windows.Forms.TextBox();
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(169, 282);
			this.btnCalcular.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(138, 42);
			this.btnCalcular.TabIndex = 0;
			this.btnCalcular.Text = "Calcular IMC";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(144, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Calculo de IMC";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(52, 103);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Peso";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(58, 193);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Altura";
			// 
			// lbl
			// 
			this.lbl.AutoSize = true;
			this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl.Location = new System.Drawing.Point(56, 380);
			this.lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(87, 24);
			this.lbl.TabIndex = 4;
			this.lbl.Text = "Seu IMC:";
			// 
			// txtIMC
			// 
			this.txtIMC.Location = new System.Drawing.Point(155, 380);
			this.txtIMC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.txtIMC.Name = "txtIMC";
			this.txtIMC.Size = new System.Drawing.Size(180, 29);
			this.txtIMC.TabIndex = 5;
			// 
			// txtPeso
			// 
			this.txtPeso.Location = new System.Drawing.Point(148, 103);
			this.txtPeso.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.txtPeso.Name = "txtPeso";
			this.txtPeso.Size = new System.Drawing.Size(180, 29);
			this.txtPeso.TabIndex = 6;
			// 
			// txtAltura
			// 
			this.txtAltura.Location = new System.Drawing.Point(137, 188);
			this.txtAltura.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(180, 29);
			this.txtAltura.TabIndex = 7;
			// 
			// btnIMC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 587);
			this.Controls.Add(this.txtAltura);
			this.Controls.Add(this.txtPeso);
			this.Controls.Add(this.txtIMC);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCalcular);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "btnIMC";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.TextBox txtIMC;
		private System.Windows.Forms.TextBox txtPeso;
		private System.Windows.Forms.TextBox txtAltura;
	}
}

