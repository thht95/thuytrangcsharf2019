namespace QuanLy
{
	partial class frmTIMKIEM
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
			this.txtTim = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtHocsinh = new System.Windows.Forms.TextBox();
			this.txtLophoc = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvTimkiem = new System.Windows.Forms.DataGridView();
			this.txtTimlai = new System.Windows.Forms.Button();
			this.Tenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tenlophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvTimkiem)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTim
			// 
			this.txtTim.Location = new System.Drawing.Point(363, 40);
			this.txtTim.Name = "txtTim";
			this.txtTim.Size = new System.Drawing.Size(75, 23);
			this.txtTim.TabIndex = 0;
			this.txtTim.Text = "Tìm kiếm";
			this.txtTim.UseVisualStyleBackColor = true;
			this.txtTim.Click += new System.EventHandler(this.txtTim_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Học sinh";
			// 
			// txtHocsinh
			// 
			this.txtHocsinh.Location = new System.Drawing.Point(146, 32);
			this.txtHocsinh.Name = "txtHocsinh";
			this.txtHocsinh.Size = new System.Drawing.Size(100, 20);
			this.txtHocsinh.TabIndex = 2;
			// 
			// txtLophoc
			// 
			this.txtLophoc.Location = new System.Drawing.Point(146, 83);
			this.txtLophoc.Name = "txtLophoc";
			this.txtLophoc.Size = new System.Drawing.Size(100, 20);
			this.txtLophoc.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Lớp học";
			// 
			// dgvTimkiem
			// 
			this.dgvTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTimkiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tenhocsinh,
            this.Tenlophoc,
            this.TenMH,
            this.Tenloai,
            this.Diem});
			this.dgvTimkiem.Location = new System.Drawing.Point(59, 159);
			this.dgvTimkiem.Name = "dgvTimkiem";
			this.dgvTimkiem.Size = new System.Drawing.Size(544, 242);
			this.dgvTimkiem.TabIndex = 5;
			this.dgvTimkiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// txtTimlai
			// 
			this.txtTimlai.Location = new System.Drawing.Point(363, 79);
			this.txtTimlai.Name = "txtTimlai";
			this.txtTimlai.Size = new System.Drawing.Size(75, 23);
			this.txtTimlai.TabIndex = 6;
			this.txtTimlai.Text = "Tìm lại";
			this.txtTimlai.UseVisualStyleBackColor = true;
			this.txtTimlai.Click += new System.EventHandler(this.txtTimlai_Click);
			// 
			// Tenhocsinh
			// 
			this.Tenhocsinh.DataPropertyName = "Tenhocsinh";
			this.Tenhocsinh.HeaderText = "Học sinh";
			this.Tenhocsinh.Name = "Tenhocsinh";
			// 
			// Tenlophoc
			// 
			this.Tenlophoc.DataPropertyName = "Tenlophoc";
			this.Tenlophoc.HeaderText = "Lớp học";
			this.Tenlophoc.Name = "Tenlophoc";
			// 
			// TenMH
			// 
			this.TenMH.DataPropertyName = "TenMH";
			this.TenMH.HeaderText = "Môn học";
			this.TenMH.Name = "TenMH";
			// 
			// Tenloai
			// 
			this.Tenloai.DataPropertyName = "Tenloai";
			this.Tenloai.HeaderText = "Loại kiểm tra";
			this.Tenloai.Name = "Tenloai";
			// 
			// Diem
			// 
			this.Diem.DataPropertyName = "Diem";
			this.Diem.HeaderText = "Điểm";
			this.Diem.Name = "Diem";
			// 
			// frmTIMKIEM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 450);
			this.Controls.Add(this.txtTimlai);
			this.Controls.Add(this.dgvTimkiem);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtLophoc);
			this.Controls.Add(this.txtHocsinh);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTim);
			this.Name = "frmTIMKIEM";
			this.Text = "frmTIMKIEM";
			this.Load += new System.EventHandler(this.frmTIMKIEM_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTimkiem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button txtTim;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtHocsinh;
		private System.Windows.Forms.TextBox txtLophoc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvTimkiem;
		private System.Windows.Forms.Button txtTimlai;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tenhocsinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tenlophoc;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tenloai;
		private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
	}
}