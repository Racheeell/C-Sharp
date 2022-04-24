
namespace ProjetoCadastroPessoas
{
	partial class frmPrincipal
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
			this.btnPessoas = new System.Windows.Forms.Button();
			this.btnFuncionario = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnPessoas
			// 
			this.btnPessoas.Location = new System.Drawing.Point(52, 104);
			this.btnPessoas.Name = "btnPessoas";
			this.btnPessoas.Size = new System.Drawing.Size(172, 64);
			this.btnPessoas.TabIndex = 0;
			this.btnPessoas.Text = "Cadastro de Pessoas";
			this.btnPessoas.UseVisualStyleBackColor = true;
			this.btnPessoas.Click += new System.EventHandler(this.btnPessoas_Click);
			// 
			// btnFuncionario
			// 
			this.btnFuncionario.Location = new System.Drawing.Point(52, 184);
			this.btnFuncionario.Name = "btnFuncionario";
			this.btnFuncionario.Size = new System.Drawing.Size(172, 64);
			this.btnFuncionario.TabIndex = 1;
			this.btnFuncionario.Text = "Cadastro de Funcionarios";
			this.btnFuncionario.UseVisualStyleBackColor = true;
			this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(115, 44);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(166, 20);
			this.txtUsuario.TabIndex = 2;
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Location = new System.Drawing.Point(24, 44);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(85, 13);
			this.lblUsuario.TabIndex = 3;
			this.lblUsuario.Text = "Usuário Logado:";
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 272);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.btnFuncionario);
			this.Controls.Add(this.btnPessoas);
			this.Name = "frmPrincipal";
			this.Text = "Menu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPessoas;
		private System.Windows.Forms.Button btnFuncionario;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblUsuario;
	}
}