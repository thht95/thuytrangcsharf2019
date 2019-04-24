namespace QuanLy
{
	partial class frmNHAPDIEM
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
			this.cboMonhoc = new System.Windows.Forms.ComboBox();
			this.cboTenhocsinh = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cboLoaidiem = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvNhapdiem = new System.Windows.Forms.DataGridView();
			this.MaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.txtDiem = new System.Windows.Forms.TextBox();
			this.lblTenhocsinh = new System.Windows.Forms.Label();
			this.txtMadiem = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhapdiem)).BeginInit();
			this.SuspendLayout();
			// 
			// cboMonhoc
			// 
			this.cboMonhoc.FormattingEnabled = true;
			this.cboMonhoc.Location = new System.Drawing.Point(104, 95);
			this.cboMonhoc.Name = "cboMonhoc";
			this.cboMonhoc.Size = new System.Drawing.Size(121, 21);
			this.cboMonhoc.TabIndex = 73;
			// 
			// cboTenhocsinh
			// 
			this.cboTenhocsinh.FormattingEnabled = true;
			this.cboTenhocsinh.Location = new System.Drawing.Point(104, 49);
			this.cboTenhocsinh.Name = "cboTenhocsinh";
			this.cboTenhocsinh.Size = new System.Drawing.Size(121, 21);
			this.cboTenhocsinh.TabIndex = 72;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 70;
			this.label3.Text = "Môn học";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 69;
			this.label2.Text = "Tên học sinh";
			// 
			// cboLoaidiem
			// 
			this.cboLoaidiem.FormattingEnabled = true;
			this.cboLoaidiem.Location = new System.Drawing.Point(366, 31);
			this.cboLoaidiem.Name = "cboLoaidiem";
			this.cboLoaidiem.Size = new System.Drawing.Size(121, 21);
			this.cboLoaidiem.TabIndex = 105;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(286, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 104;
			this.label5.Text = "Loại điểm";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(286, 95);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 106;
			this.label6.Text = "Điểm";
			// 
			// dgvNhapdiem
			// 
			this.dgvNhapdiem.AllowUserToAddRows = false;
			this.dgvNhapdiem.AllowUserToDeleteRows = false;
			this.dgvNhapdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNhapdiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDiem,
            this.Tenhocsinh,
            this.TenMH,
            this.Tenloai,
            this.Diem});
			this.dgvNhapdiem.Location = new System.Drawing.Point(36, 161);
			this.dgvNhapdiem.Name = "dgvNhapdiem";
			this.dgvNhapdiem.ReadOnly = true;
			this.dgvNhapdiem.Size = new System.Drawing.Size(538, 186);
			this.dgvNhapdiem.TabIndex = 108;
			this.dgvNhapdiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapdiem_CellClick);
			// 
			// MaDiem
			// 
			this.MaDiem.DataPropertyName = "MaDiem";
			this.MaDiem.HeaderText = "Mã điểm";
			this.MaDiem.Name = "MaDiem";
			this.MaDiem.ReadOnly = true;
			// 
			// Tenhocsinh
			// 
			this.Tenhocsinh.DataPropertyName = "Tenhocsinh";
			this.Tenhocsinh.HeaderText = "Học sinh";
			this.Tenhocsinh.Name = "Tenhocsinh";
			this.Tenhocsinh.ReadOnly = true;
			// 
			// TenMH
			// 
			this.TenMH.DataPropertyName = "TenMH";
			this.TenMH.HeaderText = "Môn học";
			this.TenMH.Name = "TenMH";
			this.TenMH.ReadOnly = true;
			// 
			// Tenloai
			// 
			this.Tenloai.DataPropertyName = "Tenloai";
			this.Tenloai.HeaderText = "Loại điểm";
			this.Tenloai.Name = "Tenloai";
			this.Tenloai.ReadOnly = true;
			// 
			// Diem
			// 
			this.Diem.DataPropertyName = "Diem";
			this.Diem.HeaderText = "Điểm";
			this.Diem.Name = "Diem";
			this.Diem.ReadOnly = true;
			// 
			// btnHuy
			// 
			this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.Location = new System.Drawing.Point(475, 422);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(88, 23);
			this.btnHuy.TabIndex = 116;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Location = new System.Drawing.Point(366, 422);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(88, 23);
			this.btnLuu.TabIndex = 115;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(499, 371);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 114;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(399, 371);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 112;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(309, 371);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 111;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(217, 371);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 110;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// txtDiem
			// 
			this.txtDiem.Location = new System.Drawing.Point(366, 87);
			this.txtDiem.Name = "txtDiem";
			this.txtDiem.Size = new System.Drawing.Size(100, 20);
			this.txtDiem.TabIndex = 117;
			// 
			// lblTenhocsinh
			// 
			this.lblTenhocsinh.AutoSize = true;
			this.lblTenhocsinh.Location = new System.Drawing.Point(30, 19);
			this.lblTenhocsinh.Name = "lblTenhocsinh";
			this.lblTenhocsinh.Size = new System.Drawing.Size(28, 13);
			this.lblTenhocsinh.TabIndex = 118;
			this.lblTenhocsinh.Text = "STT";
			// 
			// txtMadiem
			// 
			this.txtMadiem.Location = new System.Drawing.Point(104, 12);
			this.txtMadiem.Name = "txtMadiem";
			this.txtMadiem.Size = new System.Drawing.Size(121, 20);
			this.txtMadiem.TabIndex = 119;
			// 
			// frmNHAPDIEM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 462);
			this.Controls.Add(this.txtMadiem);
			this.Controls.Add(this.lblTenhocsinh);
			this.Controls.Add(this.txtDiem);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dgvNhapdiem);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cboLoaidiem);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboMonhoc);
			this.Controls.Add(this.cboTenhocsinh);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "frmNHAPDIEM";
			this.Text = "frmNHAPDIEM";
			this.Load += new System.EventHandler(this.frmNHAPDIEM_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvNhapdiem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboMonhoc;
		private System.Windows.Forms.ComboBox cboTenhocsinh;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboLoaidiem;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dgvNhapdiem;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaDiem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tenhocsinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tenloai;
		private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.TextBox txtDiem;
		private System.Windows.Forms.Label lblTenhocsinh;
		private System.Windows.Forms.TextBox txtMadiem;
	}
}