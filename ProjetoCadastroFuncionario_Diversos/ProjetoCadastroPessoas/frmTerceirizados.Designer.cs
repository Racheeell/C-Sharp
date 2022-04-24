
namespace ProjetoCadastroPessoas
{
	partial class frmTerceirizados
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
			this.lblNomeTer = new System.Windows.Forms.Label();
			this.lblNascTer = new System.Windows.Forms.Label();
			this.lblSalarioTer = new System.Windows.Forms.Label();
			this.txtNomeTer = new System.Windows.Forms.TextBox();
			this.dtpNascTer = new System.Windows.Forms.DateTimePicker();
			this.txtSalarioTer = new System.Windows.Forms.TextBox();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnProcessar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNomeTer
			// 
			this.lblNomeTer.AutoSize = true;
			this.lblNomeTer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeTer.Location = new System.Drawing.Point(39, 46);
			this.lblNomeTer.Name = "lblNomeTer";
			this.lblNomeTer.Size = new System.Drawing.Size(51, 20);
			this.lblNomeTer.TabIndex = 0;
			this.lblNomeTer.Text = "Nome";
			// 
			// lblNascTer
			// 
			this.lblNascTer.AutoSize = true;
			this.lblNascTer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNascTer.Location = new System.Drawing.Point(39, 85);
			this.lblNascTer.Name = "lblNascTer";
			this.lblNascTer.Size = new System.Drawing.Size(88, 20);
			this.lblNascTer.TabIndex = 1;
			this.lblNascTer.Text = "Data Nasc.";
			// 
			// lblSalarioTer
			// 
			this.lblSalarioTer.AutoSize = true;
			this.lblSalarioTer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSalarioTer.Location = new System.Drawing.Point(39, 125);
			this.lblSalarioTer.Name = "lblSalarioTer";
			this.lblSalarioTer.Size = new System.Drawing.Size(58, 20);
			this.lblSalarioTer.TabIndex = 2;
			this.lblSalarioTer.Text = "Salario";
			// 
			// txtNomeTer
			// 
			this.txtNomeTer.Location = new System.Drawing.Point(133, 46);
			this.txtNomeTer.Name = "txtNomeTer";
			this.txtNomeTer.Size = new System.Drawing.Size(196, 20);
			this.txtNomeTer.TabIndex = 3;
			// 
			// dtpNascTer
			// 
			this.dtpNascTer.Location = new System.Drawing.Point(133, 85);
			this.dtpNascTer.Name = "dtpNascTer";
			this.dtpNascTer.Size = new System.Drawing.Size(196, 20);
			this.dtpNascTer.TabIndex = 4;
			// 
			// txtSalarioTer
			// 
			this.txtSalarioTer.Location = new System.Drawing.Point(133, 125);
			this.txtSalarioTer.Name = "txtSalarioTer";
			this.txtSalarioTer.Size = new System.Drawing.Size(196, 20);
			this.txtSalarioTer.TabIndex = 5;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(332, 12);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(56, 23);
			this.btnLimpar.TabIndex = 6;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// btnProcessar
			// 
			this.btnProcessar.Location = new System.Drawing.Point(181, 164);
			this.btnProcessar.Name = "btnProcessar";
			this.btnProcessar.Size = new System.Drawing.Size(108, 42);
			this.btnProcessar.TabIndex = 7;
			this.btnProcessar.Text = "Processar";
			this.btnProcessar.UseVisualStyleBackColor = true;
			this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(327, 223);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(61, 23);
			this.btnSair.TabIndex = 8;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			// 
			// frmTerceirizados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 245);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnProcessar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.txtSalarioTer);
			this.Controls.Add(this.dtpNascTer);
			this.Controls.Add(this.txtNomeTer);
			this.Controls.Add(this.lblSalarioTer);
			this.Controls.Add(this.lblNascTer);
			this.Controls.Add(this.lblNomeTer);
			this.Name = "frmTerceirizados";
			this.Text = "Cadastro dos Terceirizados";
			this.Load += new System.EventHandler(this.frmTerceirizados_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNomeTer;
		private System.Windows.Forms.Label lblNascTer;
		private System.Windows.Forms.Label lblSalarioTer;
		private System.Windows.Forms.TextBox txtNomeTer;
		private System.Windows.Forms.DateTimePicker dtpNascTer;
		private System.Windows.Forms.TextBox txtSalarioTer;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnProcessar;
		private System.Windows.Forms.Button btnSair;
	}
}