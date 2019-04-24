namespace QuanLy
{
	partial class frmLOAIKIEMTRA
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
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.txtHeso = new System.Windows.Forms.TextBox();
			this.txtTenloai = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvLoaidiem = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.cboHocky = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Maloaidiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Heso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvLoaidiem)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnHuy
			// 
			this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.Location = new System.Drawing.Point(572, 337);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(88, 23);
			this.btnHuy.TabIndex = 99;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Location = new System.Drawing.Point(463, 337);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(88, 23);
			this.btnLuu.TabIndex = 98;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(597, 286);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 97;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(496, 286);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 96;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(406, 286);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 95;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(314, 286);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 94;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// txtHeso
			// 
			this.txtHeso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHeso.Location = new System.Drawing.Point(96, 95);
			this.txtHeso.Name = "txtHeso";
			this.txtHeso.Size = new System.Drawing.Size(100, 25);
			this.txtHeso.TabIndex = 93;
			// 
			// txtTenloai
			// 
			this.txtTenloai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenloai.Location = new System.Drawing.Point(96, 44);
			this.txtTenloai.Name = "txtTenloai";
			this.txtTenloai.Size = new System.Drawing.Size(100, 25);
			this.txtTenloai.TabIndex = 92;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 17);
			this.label3.TabIndex = 90;
			this.label3.Text = "Hệ số";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 17);
			this.label2.TabIndex = 89;
			this.label2.Text = "Tên loại";
			// 
			// dgvLoaidiem
			// 
			this.dgvLoaidiem.AllowUserToAddRows = false;
			this.dgvLoaidiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLoaidiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maloaidiem,
            this.Tenloai,
            this.Heso,
            this.Hocky});
			this.dgvLoaidiem.Location = new System.Drawing.Point(280, 49);
			this.dgvLoaidiem.Name = "dgvLoaidiem";
			this.dgvLoaidiem.ReadOnly = true;
			this.dgvLoaidiem.Size = new System.Drawing.Size(424, 184);
			this.dgvLoaidiem.TabIndex = 87;
			this.dgvLoaidiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaidiem_CellClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 17);
			this.label4.TabIndex = 100;
			this.label4.Text = "Học kỳ";
			// 
			// cboHocky
			// 
			this.cboHocky.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboHocky.FormattingEnabled = true;
			this.cboHocky.Location = new System.Drawing.Point(96, 142);
			this.cboHocky.Name = "cboHocky";
			this.cboHocky.Size = new System.Drawing.Size(100, 25);
			this.cboHocky.TabIndex = 101;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTenloai);
			this.groupBox1.Controls.Add(this.cboHocky);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtHeso);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(230, 218);
			this.groupBox1.TabIndex = 102;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin loại kiểm tra";
			// 
			// Maloaidiem
			// 
			this.Maloaidiem.DataPropertyName = "Maloaidiem";
			this.Maloaidiem.HeaderText = "Mã loại điểm";
			this.Maloaidiem.Name = "Maloaidiem";
			this.Maloaidiem.ReadOnly = true;
			// 
			// Tenloai
			// 
			this.Tenloai.DataPropertyName = "Tenloai";
			this.Tenloai.HeaderText = "Tên loại";
			this.Tenloai.Name = "Tenloai";
			this.Tenloai.ReadOnly = true;
			// 
			// Heso
			// 
			this.Heso.DataPropertyName = "Heso";
			this.Heso.HeaderText = "Hệ số";
			this.Heso.Name = "Heso";
			this.Heso.ReadOnly = true;
			// 
			// Hocky
			// 
			this.Hocky.DataPropertyName = "Hocky";
			this.Hocky.HeaderText = "Học kỳ";
			this.Hocky.Name = "Hocky";
			this.Hocky.ReadOnly = true;
			// 
			// frmLOAIKIEMTRA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 389);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dgvLoaidiem);
			this.Name = "frmLOAIKIEMTRA";
			this.Text = "frmLOAIKIEMTRA";
			this.Load += new System.EventHandler(this.frmLOAIKIEMTRA_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvLoaidiem)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.TextBox txtHeso;
		private System.Windows.Forms.TextBox txtTenloai;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvLoaidiem;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboHocky;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Maloaidiem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tenloai;
		private System.Windows.Forms.DataGridViewTextBoxColumn Heso;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hocky;
	}
}