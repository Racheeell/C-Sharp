
namespace Loja.UI
{
	partial class Cadastro_usuario
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cboPerfil = new System.Windows.Forms.ComboBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtCadastro = new System.Windows.Forms.TextBox();
			this.cboSituacao = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnConfirmar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(68, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cadastro de Usuários";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(26, 156);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(26, 190);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Login:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(26, 228);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "E-mail: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(26, 258);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Senha:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(26, 292);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Cadastro:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(26, 326);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 17);
			this.label7.TabIndex = 6;
			this.label7.Text = "Situação:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(26, 358);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 17);
			this.label8.TabIndex = 7;
			this.label8.Text = "Perfil:";
			// 
			// cboPerfil
			// 
			this.cboPerfil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboPerfil.FormattingEnabled = true;
			this.cboPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Operador",
            "Gerencial"});
			this.cboPerfil.Location = new System.Drawing.Point(96, 358);
			this.cboPerfil.Name = "cboPerfil";
			this.cboPerfil.Size = new System.Drawing.Size(178, 25);
			this.cboPerfil.TabIndex = 8;
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtNome.Location = new System.Drawing.Point(96, 156);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(323, 25);
			this.txtNome.TabIndex = 9;
			// 
			// txtLogin
			// 
			this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtLogin.Location = new System.Drawing.Point(96, 190);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(178, 25);
			this.txtLogin.TabIndex = 10;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtEmail.Location = new System.Drawing.Point(96, 222);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(323, 25);
			this.txtEmail.TabIndex = 11;
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtSenha.Location = new System.Drawing.Point(96, 255);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(178, 25);
			this.txtSenha.TabIndex = 12;
			this.txtSenha.UseSystemPasswordChar = true;
			// 
			// txtCadastro
			// 
			this.txtCadastro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtCadastro.Location = new System.Drawing.Point(96, 288);
			this.txtCadastro.Name = "txtCadastro";
			this.txtCadastro.Size = new System.Drawing.Size(178, 25);
			this.txtCadastro.TabIndex = 13;
			// 
			// cboSituacao
			// 
			this.cboSituacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cboSituacao.FormattingEnabled = true;
			this.cboSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
			this.cboSituacao.Location = new System.Drawing.Point(96, 326);
			this.cboSituacao.Name = "cboSituacao";
			this.cboSituacao.Size = new System.Drawing.Size(178, 25);
			this.cboSituacao.TabIndex = 14;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(26, 388);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(393, 112);
			this.dataGridView1.TabIndex = 15;
			// 
			// btnNovo
			// 
			this.btnNovo.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNovo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnNovo.Location = new System.Drawing.Point(15, 87);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(62, 41);
			this.btnNovo.TabIndex = 16;
			this.btnNovo.Text = "NOVO";
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnEditar.Location = new System.Drawing.Point(83, 87);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(63, 41);
			this.btnEditar.TabIndex = 17;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = false;
			// 
			// btnDeletar
			// 
			this.btnDeletar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeletar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnDeletar.Location = new System.Drawing.Point(152, 89);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(68, 40);
			this.btnDeletar.TabIndex = 18;
			this.btnDeletar.Text = "DELETAR";
			this.btnDeletar.UseVisualStyleBackColor = false;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCancelar.Location = new System.Drawing.Point(226, 90);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(87, 41);
			this.btnCancelar.TabIndex = 19;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = false;
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirmar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnConfirmar.Location = new System.Drawing.Point(319, 91);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(104, 40);
			this.btnConfirmar.TabIndex = 20;
			this.btnConfirmar.Text = "CONFIRMAR";
			this.btnConfirmar.UseVisualStyleBackColor = false;
			// 
			// Cadastro_usuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 505);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.cboSituacao);
			this.Controls.Add(this.txtCadastro);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.cboPerfil);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "Cadastro_usuario";
			this.Text = "Cadastro_usuario";
			this.Load += new System.EventHandler(this.Cadastro_usuario_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cboPerfil;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtCadastro;
		private System.Windows.Forms.ComboBox cboSituacao;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnDeletar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnConfirmar;
	}
}