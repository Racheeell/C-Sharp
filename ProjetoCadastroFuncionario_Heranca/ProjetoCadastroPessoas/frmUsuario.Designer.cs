
namespace View
{
	partial class frmUsuario
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
			this.components = new System.ComponentModel.Container();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.lblCodUsu = new System.Windows.Forms.Label();
			this.lblNomeUsu = new System.Windows.Forms.Label();
			this.lblEmailUsu = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.txtSenhaConf = new System.Windows.Forms.Label();
			this.txtCod = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(6, 53);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(65, 30);
			this.btnCadastrar.TabIndex = 0;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(87, 53);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(63, 30);
			this.btnAlterar.TabIndex = 1;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(172, 53);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 30);
			this.btnExcluir.TabIndex = 2;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(266, 57);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(61, 23);
			this.btnConsultar.TabIndex = 3;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = false;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(333, 60);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 4;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(412, 53);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 5;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			// 
			// lblCodUsu
			// 
			this.lblCodUsu.AutoSize = true;
			this.lblCodUsu.Location = new System.Drawing.Point(24, 53);
			this.lblCodUsu.Name = "lblCodUsu";
			this.lblCodUsu.Size = new System.Drawing.Size(40, 13);
			this.lblCodUsu.TabIndex = 6;
			this.lblCodUsu.Text = "Código";
			// 
			// lblNomeUsu
			// 
			this.lblNomeUsu.AutoSize = true;
			this.lblNomeUsu.Location = new System.Drawing.Point(27, 90);
			this.lblNomeUsu.Name = "lblNomeUsu";
			this.lblNomeUsu.Size = new System.Drawing.Size(35, 13);
			this.lblNomeUsu.TabIndex = 7;
			this.lblNomeUsu.Text = "Nome";
			// 
			// lblEmailUsu
			// 
			this.lblEmailUsu.AutoSize = true;
			this.lblEmailUsu.Location = new System.Drawing.Point(23, 134);
			this.lblEmailUsu.Name = "lblEmailUsu";
			this.lblEmailUsu.Size = new System.Drawing.Size(35, 13);
			this.lblEmailUsu.TabIndex = 8;
			this.lblEmailUsu.Text = "E-mail";
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(23, 181);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(38, 13);
			this.lblSenha.TabIndex = 9;
			this.lblSenha.Text = "Senha";
			// 
			// txtSenhaConf
			// 
			this.txtSenhaConf.AutoSize = true;
			this.txtSenhaConf.Location = new System.Drawing.Point(195, 181);
			this.txtSenhaConf.Name = "txtSenhaConf";
			this.txtSenhaConf.Size = new System.Drawing.Size(92, 13);
			this.txtSenhaConf.TabIndex = 10;
			this.txtSenhaConf.Text = "Confirmar a senha";
			// 
			// txtCod
			// 
			this.txtCod.Enabled = false;
			this.txtCod.Location = new System.Drawing.Point(75, 50);
			this.txtCod.Name = "txtCod";
			this.txtCod.Size = new System.Drawing.Size(67, 20);
			this.txtCod.TabIndex = 11;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(75, 90);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(319, 20);
			this.txtNome.TabIndex = 12;
			this.txtNome.Text = "Digite seu Nome";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(75, 131);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(319, 20);
			this.textBox3.TabIndex = 13;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(75, 174);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(117, 20);
			this.txtSenha.TabIndex = 14;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(293, 174);
			this.textBox5.Name = "textBox5";
			this.textBox5.PasswordChar = '*';
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 15;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAlterar);
			this.groupBox1.Controls.Add(this.btnCadastrar);
			this.groupBox1.Controls.Add(this.btnExcluir);
			this.groupBox1.Controls.Add(this.btnConsultar);
			this.groupBox1.Controls.Add(this.btnLimpar);
			this.groupBox1.Controls.Add(this.btnSair);
			this.groupBox1.Location = new System.Drawing.Point(26, 256);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(493, 120);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Controles";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// toolTip1
			// 
			this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
			// 
			// frmUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(558, 393);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtCod);
			this.Controls.Add(this.txtSenhaConf);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblEmailUsu);
			this.Controls.Add(this.lblNomeUsu);
			this.Controls.Add(this.lblCodUsu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmUsuario";
			this.Text = "Cadastro de Usuário";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Label lblCodUsu;
		private System.Windows.Forms.Label lblNomeUsu;
		private System.Windows.Forms.Label lblEmailUsu;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label txtSenhaConf;
		private System.Windows.Forms.TextBox txtCod;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}