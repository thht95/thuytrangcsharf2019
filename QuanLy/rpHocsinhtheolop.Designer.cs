namespace QuanLy
{
	partial class rpHocsinhtheolop
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
			this.rptheolop = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			// 
			// rptheolop
			// 
			this.rptheolop.ActiveViewIndex = -1;
			this.rptheolop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rptheolop.Cursor = System.Windows.Forms.Cursors.Default;
			this.rptheolop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rptheolop.Location = new System.Drawing.Point(0, 0);
			this.rptheolop.Name = "rptheolop";
			this.rptheolop.Size = new System.Drawing.Size(800, 450);
			this.rptheolop.TabIndex = 0;
			this.rptheolop.Load += new System.EventHandler(this.rptheolop_Load);
			// 
			// rpHocsinhtheolop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rptheolop);
			this.Name = "rpHocsinhtheolop";
			this.Text = "rpHocsinhtheolop";
			this.ResumeLayout(false);

		}

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer rptheolop;
	}
}