
namespace Exemplo_While_For
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
			this.btnVoltar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cboAno = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(12, 94);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(35, 23);
			this.btnVoltar.TabIndex = 0;
			this.btnVoltar.Text = "<";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Selecione o Ano:";
			// 
			// cboAno
			// 
			this.cboAno.FormattingEnabled = true;
			this.cboAno.Location = new System.Drawing.Point(112, 50);
			this.cboAno.Name = "cboAno";
			this.cboAno.Size = new System.Drawing.Size(121, 21);
			this.cboAno.TabIndex = 2;
			this.cboAno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 134);
			this.Controls.Add(this.cboAno);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnVoltar);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboAno;
	}
}