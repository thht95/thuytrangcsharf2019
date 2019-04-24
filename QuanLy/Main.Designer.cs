namespace QuanLy
{
	partial class Main
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhómMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.họcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loạiKiểmTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhạpĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TimkiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dSHọcSinhTheoLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.quảnLýĐiểmToolStripMenuItem,
            this.TimkiemToolStripMenuItem,
            this.báoCáoToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(811, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// danhMụcToolStripMenuItem
			// 
			this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lớpHọcToolStripMenuItem,
            this.nhómMônHọcToolStripMenuItem,
            this.mônHọcToolStripMenuItem,
            this.họcSinhToolStripMenuItem});
			this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
			this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
			this.danhMụcToolStripMenuItem.Text = "Danh mục";
			// 
			// lớpHọcToolStripMenuItem
			// 
			this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
			this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.lớpHọcToolStripMenuItem.Text = "Lớp học";
			this.lớpHọcToolStripMenuItem.Click += new System.EventHandler(this.lớpHọcToolStripMenuItem_Click);
			// 
			// nhómMônHọcToolStripMenuItem
			// 
			this.nhómMônHọcToolStripMenuItem.Name = "nhómMônHọcToolStripMenuItem";
			this.nhómMônHọcToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.nhómMônHọcToolStripMenuItem.Text = "Nhóm môn học";
			this.nhómMônHọcToolStripMenuItem.Click += new System.EventHandler(this.nhómMônHọcToolStripMenuItem_Click);
			// 
			// mônHọcToolStripMenuItem
			// 
			this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
			this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.mônHọcToolStripMenuItem.Text = "Môn học";
			this.mônHọcToolStripMenuItem.Click += new System.EventHandler(this.mônHọcToolStripMenuItem_Click);
			// 
			// họcSinhToolStripMenuItem
			// 
			this.họcSinhToolStripMenuItem.Name = "họcSinhToolStripMenuItem";
			this.họcSinhToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.họcSinhToolStripMenuItem.Text = "Học sinh";
			this.họcSinhToolStripMenuItem.Click += new System.EventHandler(this.họcSinhToolStripMenuItem_Click);
			// 
			// quảnLýĐiểmToolStripMenuItem
			// 
			this.quảnLýĐiểmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiKiểmTraToolStripMenuItem,
            this.nhạpĐiểmToolStripMenuItem});
			this.quảnLýĐiểmToolStripMenuItem.Name = "quảnLýĐiểmToolStripMenuItem";
			this.quảnLýĐiểmToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.quảnLýĐiểmToolStripMenuItem.Text = "Quản lý điểm";
			// 
			// loạiKiểmTraToolStripMenuItem
			// 
			this.loạiKiểmTraToolStripMenuItem.Name = "loạiKiểmTraToolStripMenuItem";
			this.loạiKiểmTraToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.loạiKiểmTraToolStripMenuItem.Text = "Loại kiểm tra";
			this.loạiKiểmTraToolStripMenuItem.Click += new System.EventHandler(this.loạiKiểmTraToolStripMenuItem_Click);
			// 
			// nhạpĐiểmToolStripMenuItem
			// 
			this.nhạpĐiểmToolStripMenuItem.Name = "nhạpĐiểmToolStripMenuItem";
			this.nhạpĐiểmToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.nhạpĐiểmToolStripMenuItem.Text = "Nhập điểm";
			this.nhạpĐiểmToolStripMenuItem.Click += new System.EventHandler(this.nhạpĐiểmToolStripMenuItem_Click);
			// 
			// TimkiemToolStripMenuItem
			// 
			this.TimkiemToolStripMenuItem.Name = "TimkiemToolStripMenuItem";
			this.TimkiemToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.TimkiemToolStripMenuItem.Text = "Tìm kiếm";
			this.TimkiemToolStripMenuItem.Click += new System.EventHandler(this.TimkiemToolStripMenuItem_Click);
			// 
			// báoCáoToolStripMenuItem1
			// 
			this.báoCáoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchHọcSinhToolStripMenuItem,
            this.dSHọcSinhTheoLớpToolStripMenuItem});
			this.báoCáoToolStripMenuItem1.Name = "báoCáoToolStripMenuItem1";
			this.báoCáoToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
			this.báoCáoToolStripMenuItem1.Text = "Báo cáo";
			// 
			// danhSáchHọcSinhToolStripMenuItem
			// 
			this.danhSáchHọcSinhToolStripMenuItem.Name = "danhSáchHọcSinhToolStripMenuItem";
			this.danhSáchHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.danhSáchHọcSinhToolStripMenuItem.Text = "Danh sách học sinh";
			this.danhSáchHọcSinhToolStripMenuItem.Click += new System.EventHandler(this.danhSáchHọcSinhToolStripMenuItem_Click);
			// 
			// dSHọcSinhTheoLớpToolStripMenuItem
			// 
			this.dSHọcSinhTheoLớpToolStripMenuItem.Name = "dSHọcSinhTheoLớpToolStripMenuItem";
			this.dSHọcSinhTheoLớpToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.dSHọcSinhTheoLớpToolStripMenuItem.Text = "DS học sinh theo lớp";
			this.dSHọcSinhTheoLớpToolStripMenuItem.Click += new System.EventHandler(this.dSHọcSinhTheoLớpToolStripMenuItem_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 536);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "Main";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nhómMônHọcToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem họcSinhToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quảnLýĐiểmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loạiKiểmTraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nhạpĐiểmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem TimkiemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem danhSáchHọcSinhToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dSHọcSinhTheoLớpToolStripMenuItem;
	}
}

