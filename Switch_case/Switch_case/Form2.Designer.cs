
namespace Switch_case
{
	partial class Form2
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
			this.lblRes = new System.Windows.Forms.Label();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.cboOpcao = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(73, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Rodizio de veiculos";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Selecione o ultimo numero da placa";
			// 
			// lblRes
			// 
			this.lblRes.AutoSize = true;
			this.lblRes.Location = new System.Drawing.Point(57, 185);
			this.lblRes.Name = "lblRes";
			this.lblRes.Size = new System.Drawing.Size(0, 13);
			this.lblRes.TabIndex = 2;
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(37, 201);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 3;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(143, 201);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(75, 23);
			this.btnVoltar.TabIndex = 4;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// cboOpcao
			// 
			this.cboOpcao.FormattingEnabled = true;
			this.cboOpcao.Items.AddRange(new object[] {
            "1 ou 2",
            "3 ou 4",
            "5 ou 6",
            "7 ou 8",
            "9 ou 0"});
			this.cboOpcao.Location = new System.Drawing.Point(60, 137);
			this.cboOpcao.Name = "cboOpcao";
			this.cboOpcao.Size = new System.Drawing.Size(121, 21);
			this.cboOpcao.TabIndex = 5;
			this.cboOpcao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 269);
			this.Controls.Add(this.cboOpcao);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.lblRes);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblRes;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.ComboBox cboOpcao;
	}
}