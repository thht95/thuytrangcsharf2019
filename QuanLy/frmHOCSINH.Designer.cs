namespace QuanLy
{
	partial class frmHOCSINH
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
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
			this.cboLophoc = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvHocsinh = new System.Windows.Forms.DataGridView();
			this.Mahocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dantoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tenlophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtDantoc = new System.Windows.Forms.TextBox();
			this.txtDiachi = new System.Windows.Forms.TextBox();
			this.txtTenhocsinh = new System.Windows.Forms.TextBox();
			this.lblDantoc = new System.Windows.Forms.Label();
			this.lblDiachi = new System.Windows.Forms.Label();
			this.lblGioitinh = new System.Windows.Forms.Label();
			this.lblNgaysinh = new System.Windows.Forms.Label();
			this.lblTenhocsinh = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbNu = new System.Windows.Forms.RadioButton();
			this.rdbNam = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvHocsinh)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnHuy
			// 
			this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.Location = new System.Drawing.Point(595, 409);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(88, 23);
			this.btnHuy.TabIndex = 75;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Location = new System.Drawing.Point(486, 409);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(88, 23);
			this.btnLuu.TabIndex = 74;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(701, 358);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 73;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// dtNgaysinh
			// 
			this.dtNgaysinh.CustomFormat = "dd/MM/yyyy";
			this.dtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtNgaysinh.Location = new System.Drawing.Point(92, 132);
			this.dtNgaysinh.Name = "dtNgaysinh";
			this.dtNgaysinh.Size = new System.Drawing.Size(143, 20);
			this.dtNgaysinh.TabIndex = 71;
			// 
			// cboLophoc
			// 
			this.cboLophoc.FormattingEnabled = true;
			this.cboLophoc.Location = new System.Drawing.Point(92, 274);
			this.cboLophoc.Name = "cboLophoc";
			this.cboLophoc.Size = new System.Drawing.Size(135, 21);
			this.cboLophoc.TabIndex = 70;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 283);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 68;
			this.label2.Text = "Lớp học:";
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(614, 358);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 66;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(524, 358);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 65;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(432, 358);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 64;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(488, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 22);
			this.label1.TabIndex = 63;
			this.label1.Text = "Danh sách học sinh";
			// 
			// dgvHocsinh
			// 
			this.dgvHocsinh.AllowUserToAddRows = false;
			this.dgvHocsinh.AllowUserToDeleteRows = false;
			this.dgvHocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHocsinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahocsinh,
            this.Tenhocsinh,
            this.Gioitinh,
            this.Ngaysinh,
            this.Diachi,
            this.Dantoc,
            this.Tenlophoc});
			this.dgvHocsinh.Location = new System.Drawing.Point(281, 91);
			this.dgvHocsinh.Name = "dgvHocsinh";
			this.dgvHocsinh.ReadOnly = true;
			this.dgvHocsinh.Size = new System.Drawing.Size(507, 233);
			this.dgvHocsinh.TabIndex = 62;
			this.dgvHocsinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocsinh_CellClick);
			// 
			// Mahocsinh
			// 
			this.Mahocsinh.DataPropertyName = "Mahocsinh";
			this.Mahocsinh.HeaderText = "Mã học sinh";
			this.Mahocsinh.Name = "Mahocsinh";
			this.Mahocsinh.ReadOnly = true;
			// 
			// Tenhocsinh
			// 
			this.Tenhocsinh.DataPropertyName = "Tenhocsinh";
			this.Tenhocsinh.HeaderText = "Tên học sinh";
			this.Tenhocsinh.Name = "Tenhocsinh";
			this.Tenhocsinh.ReadOnly = true;
			// 
			// Gioitinh
			// 
			this.Gioitinh.DataPropertyName = "Gioitinh";
			this.Gioitinh.HeaderText = "Giới tính";
			this.Gioitinh.Name = "Gioitinh";
			this.Gioitinh.ReadOnly = true;
			// 
			// Ngaysinh
			// 
			this.Ngaysinh.DataPropertyName = "Ngaysinh";
			this.Ngaysinh.HeaderText = "Ngày sinh";
			this.Ngaysinh.Name = "Ngaysinh";
			this.Ngaysinh.ReadOnly = true;
			// 
			// Diachi
			// 
			this.Diachi.DataPropertyName = "Diachi";
			this.Diachi.HeaderText = "Đại chỉ";
			this.Diachi.Name = "Diachi";
			this.Diachi.ReadOnly = true;
			// 
			// Dantoc
			// 
			this.Dantoc.DataPropertyName = "Dantoc";
			this.Dantoc.HeaderText = "Dân tộc";
			this.Dantoc.Name = "Dantoc";
			this.Dantoc.ReadOnly = true;
			// 
			// Tenlophoc
			// 
			this.Tenlophoc.DataPropertyName = "Tenlophoc";
			this.Tenlophoc.HeaderText = "Tên lớp học";
			this.Tenlophoc.Name = "Tenlophoc";
			this.Tenlophoc.ReadOnly = true;
			// 
			// txtDantoc
			// 
			this.txtDantoc.Location = new System.Drawing.Point(92, 224);
			this.txtDantoc.Name = "txtDantoc";
			this.txtDantoc.Size = new System.Drawing.Size(135, 20);
			this.txtDantoc.TabIndex = 61;
			// 
			// txtDiachi
			// 
			this.txtDiachi.Location = new System.Drawing.Point(92, 177);
			this.txtDiachi.Name = "txtDiachi";
			this.txtDiachi.Size = new System.Drawing.Size(135, 20);
			this.txtDiachi.TabIndex = 60;
			// 
			// txtTenhocsinh
			// 
			this.txtTenhocsinh.Location = new System.Drawing.Point(92, 45);
			this.txtTenhocsinh.Name = "txtTenhocsinh";
			this.txtTenhocsinh.Size = new System.Drawing.Size(135, 20);
			this.txtTenhocsinh.TabIndex = 59;
			// 
			// lblDantoc
			// 
			this.lblDantoc.AutoSize = true;
			this.lblDantoc.Location = new System.Drawing.Point(18, 231);
			this.lblDantoc.Name = "lblDantoc";
			this.lblDantoc.Size = new System.Drawing.Size(48, 13);
			this.lblDantoc.TabIndex = 57;
			this.lblDantoc.Text = "Dân tộc:";
			// 
			// lblDiachi
			// 
			this.lblDiachi.AutoSize = true;
			this.lblDiachi.Location = new System.Drawing.Point(18, 184);
			this.lblDiachi.Name = "lblDiachi";
			this.lblDiachi.Size = new System.Drawing.Size(43, 13);
			this.lblDiachi.TabIndex = 56;
			this.lblDiachi.Text = "Địa chỉ:";
			// 
			// lblGioitinh
			// 
			this.lblGioitinh.AutoSize = true;
			this.lblGioitinh.Location = new System.Drawing.Point(18, 98);
			this.lblGioitinh.Name = "lblGioitinh";
			this.lblGioitinh.Size = new System.Drawing.Size(50, 13);
			this.lblGioitinh.TabIndex = 55;
			this.lblGioitinh.Text = "Giới tính:";
			// 
			// lblNgaysinh
			// 
			this.lblNgaysinh.AutoSize = true;
			this.lblNgaysinh.Location = new System.Drawing.Point(18, 140);
			this.lblNgaysinh.Name = "lblNgaysinh";
			this.lblNgaysinh.Size = new System.Drawing.Size(57, 13);
			this.lblNgaysinh.TabIndex = 54;
			this.lblNgaysinh.Text = "Ngày sinh:";
			// 
			// lblTenhocsinh
			// 
			this.lblTenhocsinh.AutoSize = true;
			this.lblTenhocsinh.Location = new System.Drawing.Point(18, 51);
			this.lblTenhocsinh.Name = "lblTenhocsinh";
			this.lblTenhocsinh.Size = new System.Drawing.Size(72, 13);
			this.lblTenhocsinh.TabIndex = 53;
			this.lblTenhocsinh.Text = "Tên học sinh:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbNu);
			this.groupBox1.Controls.Add(this.rdbNam);
			this.groupBox1.Controls.Add(this.dtNgaysinh);
			this.groupBox1.Controls.Add(this.cboLophoc);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtDantoc);
			this.groupBox1.Controls.Add(this.txtDiachi);
			this.groupBox1.Controls.Add(this.txtTenhocsinh);
			this.groupBox1.Controls.Add(this.lblDantoc);
			this.groupBox1.Controls.Add(this.lblDiachi);
			this.groupBox1.Controls.Add(this.lblGioitinh);
			this.groupBox1.Controls.Add(this.lblNgaysinh);
			this.groupBox1.Controls.Add(this.lblTenhocsinh);
			this.groupBox1.Location = new System.Drawing.Point(11, 47);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(254, 334);
			this.groupBox1.TabIndex = 76;
			this.groupBox1.TabStop = false;
			// 
			// rdbNu
			// 
			this.rdbNu.AutoSize = true;
			this.rdbNu.Location = new System.Drawing.Point(163, 96);
			this.rdbNu.Name = "rdbNu";
			this.rdbNu.Size = new System.Drawing.Size(39, 17);
			this.rdbNu.TabIndex = 73;
			this.rdbNu.Text = "Nữ";
			this.rdbNu.UseVisualStyleBackColor = true;
			// 
			// rdbNam
			// 
			this.rdbNam.AutoSize = true;
			this.rdbNam.Checked = true;
			this.rdbNam.Location = new System.Drawing.Point(92, 96);
			this.rdbNam.Name = "rdbNam";
			this.rdbNam.Size = new System.Drawing.Size(47, 17);
			this.rdbNam.TabIndex = 72;
			this.rdbNam.TabStop = true;
			this.rdbNam.Text = "Nam";
			this.rdbNam.UseVisualStyleBackColor = true;
			// 
			// frmHOCSINH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dgvHocsinh);
			this.Name = "frmHOCSINH";
			this.Text = "frmHOCSINH";
			this.Load += new System.EventHandler(this.frmHOCSINH_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvHocsinh)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.DateTimePicker dtNgaysinh;
		private System.Windows.Forms.ComboBox cboLophoc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvHocsinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mahocsinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tenhocsinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
		private System.Windows.Forms.DataGridViewTextBoxColumn Dantoc;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tenlophoc;
		private System.Windows.Forms.TextBox txtDantoc;
		private System.Windows.Forms.TextBox txtDiachi;
		private System.Windows.Forms.TextBox txtTenhocsinh;
		private System.Windows.Forms.Label lblDantoc;
		private System.Windows.Forms.Label lblDiachi;
		private System.Windows.Forms.Label lblGioitinh;
		private System.Windows.Forms.Label lblNgaysinh;
		private System.Windows.Forms.Label lblTenhocsinh;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbNu;
		private System.Windows.Forms.RadioButton rdbNam;
	}
}