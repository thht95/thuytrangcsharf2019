namespace QuanLy
{
	partial class Danhsachhocsinh
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
			this.rpDanhsach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.label1 = new System.Windows.Forms.Label();
			this.txtmahs = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rpDanhsach
			// 
			this.rpDanhsach.ActiveViewIndex = -1;
			this.rpDanhsach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rpDanhsach.Cursor = System.Windows.Forms.Cursors.Default;
			this.rpDanhsach.Location = new System.Drawing.Point(0, 0);
			this.rpDanhsach.Name = "rpDanhsach";
			this.rpDanhsach.Size = new System.Drawing.Size(788, 378);
			this.rpDanhsach.TabIndex = 0;
			this.rpDanhsach.Load += new System.EventHandler(this.rpDanhsach_Load);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(218, 408);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã học sinh :";
			// 
			// txtmahs
			// 
			this.txtmahs.Location = new System.Drawing.Point(289, 401);
			this.txtmahs.Name = "txtmahs";
			this.txtmahs.Size = new System.Drawing.Size(100, 20);
			this.txtmahs.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(416, 399);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Xem";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Danhsachhocsinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtmahs);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rpDanhsach);
			this.Name = "Danhsachhocsinh";
			this.Text = "Danhsachhocsinh";
			this.Load += new System.EventHandler(this.Danhsachhocsinh_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer rpDanhsach;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtmahs;
		private System.Windows.Forms.Button button1;
	}
}