
namespace ProjetoCadastroPessoas
{
	partial class frmVoluntarios
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnProcessar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.lblNomeVol = new System.Windows.Forms.Label();
			this.lblNascVol = new System.Windows.Forms.Label();
			this.lblFuncaoVol = new System.Windows.Forms.Label();
			this.lblQtdeVol = new System.Windows.Forms.Label();
			this.txtNomeVol = new System.Windows.Forms.TextBox();
			this.dtpNascVol = new System.Windows.Forms.DateTimePicker();
			this.txtFuncaoVol = new System.Windows.Forms.TextBox();
			this.txtQtdeVolunt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnProcessar
			// 
			this.btnProcessar.Location = new System.Drawing.Point(169, 233);
			this.btnProcessar.Name = "btnProcessar";
			this.btnProcessar.Size = new System.Drawing.Size(118, 52);
			this.btnProcessar.TabIndex = 0;
			this.btnProcessar.Text = "Processar";
			this.btnProcessar.UseVisualStyleBackColor = true;
			this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(367, 28);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(60, 23);
			this.btnLimpar.TabIndex = 1;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(382, 347);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(60, 23);
			this.btnSair.TabIndex = 2;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			// 
			// lblNomeVol
			// 
			this.lblNomeVol.AutoSize = true;
			this.lblNomeVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVol.Location = new System.Drawing.Point(40, 74);
			this.lblNomeVol.Name = "lblNomeVol";
			this.lblNomeVol.Size = new System.Drawing.Size(51, 20);
			this.lblNomeVol.TabIndex = 3;
			this.lblNomeVol.Text = "Nome";
			// 
			// lblNascVol
			// 
			this.lblNascVol.AutoSize = true;
			this.lblNascVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNascVol.Location = new System.Drawing.Point(40, 111);
			this.lblNascVol.Name = "lblNascVol";
			this.lblNascVol.Size = new System.Drawing.Size(88, 20);
			this.lblNascVol.TabIndex = 4;
			this.lblNascVol.Text = "Data Nasc.";
			// 
			// lblFuncaoVol
			// 
			this.lblFuncaoVol.AutoSize = true;
			this.lblFuncaoVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFuncaoVol.Location = new System.Drawing.Point(40, 152);
			this.lblFuncaoVol.Name = "lblFuncaoVol";
			this.lblFuncaoVol.Size = new System.Drawing.Size(63, 20);
			this.lblFuncaoVol.TabIndex = 5;
			this.lblFuncaoVol.Text = "Função";
			// 
			// lblQtdeVol
			// 
			this.lblQtdeVol.AutoSize = true;
			this.lblQtdeVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQtdeVol.Location = new System.Drawing.Point(45, 189);
			this.lblQtdeVol.Name = "lblQtdeVol";
			this.lblQtdeVol.Size = new System.Drawing.Size(115, 13);
			this.lblQtdeVol.TabIndex = 6;
			this.lblQtdeVol.Text = "Quantidade  Voluntario";
			this.lblQtdeVol.Click += new System.EventHandler(this.lblSalarioVol_Click);
			// 
			// txtNomeVol
			// 
			this.txtNomeVol.Location = new System.Drawing.Point(134, 76);
			this.txtNomeVol.Name = "txtNomeVol";
			this.txtNomeVol.Size = new System.Drawing.Size(200, 20);
			this.txtNomeVol.TabIndex = 7;
			// 
			// dtpNascVol
			// 
			this.dtpNascVol.Location = new System.Drawing.Point(134, 111);
			this.dtpNascVol.Name = "dtpNascVol";
			this.dtpNascVol.Size = new System.Drawing.Size(200, 20);
			this.dtpNascVol.TabIndex = 8;
			// 
			// txtFuncaoVol
			// 
			this.txtFuncaoVol.Location = new System.Drawing.Point(134, 152);
			this.txtFuncaoVol.Name = "txtFuncaoVol";
			this.txtFuncaoVol.Size = new System.Drawing.Size(200, 20);
			this.txtFuncaoVol.TabIndex = 9;
			// 
			// txtQtdeVolunt
			// 
			this.txtQtdeVolunt.Location = new System.Drawing.Point(166, 186);
			this.txtQtdeVolunt.Name = "txtQtdeVolunt";
			this.txtQtdeVolunt.Size = new System.Drawing.Size(168, 20);
			this.txtQtdeVolunt.TabIndex = 10;
			// 
			// frmVoluntarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 370);
			this.Controls.Add(this.txtQtdeVolunt);
			this.Controls.Add(this.txtFuncaoVol);
			this.Controls.Add(this.dtpNascVol);
			this.Controls.Add(this.txtNomeVol);
			this.Controls.Add(this.lblQtdeVol);
			this.Controls.Add(this.lblFuncaoVol);
			this.Controls.Add(this.lblNascVol);
			this.Controls.Add(this.lblNomeVol);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnProcessar);
			this.Name = "frmVoluntarios";
			this.Text = "frmVoluntarios";
			this.Load += new System.EventHandler(this.frmVoluntarios_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnProcessar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Label lblNomeVol;
		private System.Windows.Forms.Label lblNascVol;
		private System.Windows.Forms.Label lblFuncaoVol;
		private System.Windows.Forms.Label lblQtdeVol;
		private System.Windows.Forms.TextBox txtNomeVol;
		private System.Windows.Forms.DateTimePicker dtpNascVol;
		private System.Windows.Forms.TextBox txtFuncaoVol;
		private System.Windows.Forms.TextBox txtQtdeVolunt;
	}
}