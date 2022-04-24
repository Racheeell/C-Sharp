
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
			this.btnFuncionario = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.btnVoluntario = new System.Windows.Forms.Button();
			this.btnTerceirizado = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnFuncionario
			// 
			this.btnFuncionario.Location = new System.Drawing.Point(52, 101);
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
			// btnVoluntario
			// 
			this.btnVoluntario.Location = new System.Drawing.Point(52, 278);
			this.btnVoluntario.Name = "btnVoluntario";
			this.btnVoluntario.Size = new System.Drawing.Size(172, 65);
			this.btnVoluntario.TabIndex = 4;
			this.btnVoluntario.Text = "Cadastro dos Voluntários";
			this.btnVoluntario.UseVisualStyleBackColor = true;
			this.btnVoluntario.Click += new System.EventHandler(this.btnVoluntario_Click);
			// 
			// btnTerceirizado
			// 
			this.btnTerceirizado.Location = new System.Drawing.Point(52, 186);
			this.btnTerceirizado.Name = "btnTerceirizado";
			this.btnTerceirizado.Size = new System.Drawing.Size(172, 72);
			this.btnTerceirizado.TabIndex = 5;
			this.btnTerceirizado.Text = "Cadastro dos Terceirizados";
			this.btnTerceirizado.UseVisualStyleBackColor = true;
			this.btnTerceirizado.Click += new System.EventHandler(this.btnTerceirizado_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 355);
			this.Controls.Add(this.btnTerceirizado);
			this.Controls.Add(this.btnVoluntario);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.btnFuncionario);
			this.Name = "frmPrincipal";
			this.Text = "Menu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnFuncionario;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Button btnVoluntario;
		private System.Windows.Forms.Button btnTerceirizado;
	}
}