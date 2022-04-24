
namespace ProjetoCadastroPessoas
{
	partial class frmFuncionario
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
			this.lblNomeFun = new System.Windows.Forms.Label();
			this.lblNascFun = new System.Windows.Forms.Label();
			this.lblFuncao = new System.Windows.Forms.Label();
			this.lblSalario = new System.Windows.Forms.Label();
			this.btnProcessar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.dtpNascFun = new System.Windows.Forms.DateTimePicker();
			this.txtSalario = new System.Windows.Forms.TextBox();
			this.txtFuncao = new System.Windows.Forms.TextBox();
			this.txtNomeFun = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblNomeFun
			// 
			this.lblNomeFun.AutoSize = true;
			this.lblNomeFun.Location = new System.Drawing.Point(50, 81);
			this.lblNomeFun.Name = "lblNomeFun";
			this.lblNomeFun.Size = new System.Drawing.Size(35, 13);
			this.lblNomeFun.TabIndex = 0;
			this.lblNomeFun.Text = "Nome";
			// 
			// lblNascFun
			// 
			this.lblNascFun.AutoSize = true;
			this.lblNascFun.Location = new System.Drawing.Point(50, 114);
			this.lblNascFun.Name = "lblNascFun";
			this.lblNascFun.Size = new System.Drawing.Size(61, 13);
			this.lblNascFun.TabIndex = 1;
			this.lblNascFun.Text = "Data Nasc.";
			// 
			// lblFuncao
			// 
			this.lblFuncao.AutoSize = true;
			this.lblFuncao.Location = new System.Drawing.Point(50, 157);
			this.lblFuncao.Name = "lblFuncao";
			this.lblFuncao.Size = new System.Drawing.Size(43, 13);
			this.lblFuncao.TabIndex = 2;
			this.lblFuncao.Text = "Função";
			// 
			// lblSalario
			// 
			this.lblSalario.AutoSize = true;
			this.lblSalario.Location = new System.Drawing.Point(54, 191);
			this.lblSalario.Name = "lblSalario";
			this.lblSalario.Size = new System.Drawing.Size(39, 13);
			this.lblSalario.TabIndex = 3;
			this.lblSalario.Text = "Salário";
			// 
			// btnProcessar
			// 
			this.btnProcessar.Location = new System.Drawing.Point(180, 235);
			this.btnProcessar.Name = "btnProcessar";
			this.btnProcessar.Size = new System.Drawing.Size(84, 27);
			this.btnProcessar.TabIndex = 4;
			this.btnProcessar.Text = "Processar";
			this.btnProcessar.UseVisualStyleBackColor = true;
			this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(2, 298);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(67, 22);
			this.btnLimpar.TabIndex = 5;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(416, 298);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(40, 22);
			this.btnSair.TabIndex = 6;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// dtpNascFun
			// 
			this.dtpNascFun.Location = new System.Drawing.Point(117, 108);
			this.dtpNascFun.Name = "dtpNascFun";
			this.dtpNascFun.Size = new System.Drawing.Size(200, 20);
			this.dtpNascFun.TabIndex = 7;
			// 
			// txtSalario
			// 
			this.txtSalario.Location = new System.Drawing.Point(117, 188);
			this.txtSalario.Name = "txtSalario";
			this.txtSalario.Size = new System.Drawing.Size(200, 20);
			this.txtSalario.TabIndex = 8;
			// 
			// txtFuncao
			// 
			this.txtFuncao.Location = new System.Drawing.Point(117, 150);
			this.txtFuncao.Name = "txtFuncao";
			this.txtFuncao.Size = new System.Drawing.Size(200, 20);
			this.txtFuncao.TabIndex = 9;
			// 
			// txtNomeFun
			// 
			this.txtNomeFun.Location = new System.Drawing.Point(117, 78);
			this.txtNomeFun.Name = "txtNomeFun";
			this.txtNomeFun.Size = new System.Drawing.Size(200, 20);
			this.txtNomeFun.TabIndex = 10;
			// 
			// frmFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 322);
			this.Controls.Add(this.txtNomeFun);
			this.Controls.Add(this.txtFuncao);
			this.Controls.Add(this.txtSalario);
			this.Controls.Add(this.dtpNascFun);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnProcessar);
			this.Controls.Add(this.lblSalario);
			this.Controls.Add(this.lblFuncao);
			this.Controls.Add(this.lblNascFun);
			this.Controls.Add(this.lblNomeFun);
			this.Name = "frmFuncionario";
			this.Text = "Cadastro de Funcionários";
			this.Load += new System.EventHandler(this.frmFuncionario_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNomeFun;
		private System.Windows.Forms.Label lblNascFun;
		private System.Windows.Forms.Label lblFuncao;
		private System.Windows.Forms.Label lblSalario;
		private System.Windows.Forms.Button btnProcessar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.DateTimePicker dtpNascFun;
		private System.Windows.Forms.TextBox txtSalario;
		private System.Windows.Forms.TextBox txtFuncao;
		private System.Windows.Forms.TextBox txtNomeFun;
	}
}