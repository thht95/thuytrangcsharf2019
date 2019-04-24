namespace QuanLy
{
	partial class frmMONHOC
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
			this.dgvMonhoc = new System.Windows.Forms.DataGridView();
			this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cboNMH = new System.Windows.Forms.ComboBox();
			this.txtTenMH = new System.Windows.Forms.TextBox();
			this.txtSotiet = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnHuy
			// 
			this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.Location = new System.Drawing.Point(545, 348);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(88, 23);
			this.btnHuy.TabIndex = 74;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Location = new System.Drawing.Point(436, 348);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(88, 23);
			this.btnLuu.TabIndex = 73;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(570, 297);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 72;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(469, 297);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 71;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(379, 297);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 70;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(287, 297);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 69;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// dgvMonhoc
			// 
			this.dgvMonhoc.AllowUserToAddRows = false;
			this.dgvMonhoc.AllowUserToDeleteRows = false;
			this.dgvMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.TenNMH,
            this.SoTiet});
			this.dgvMonhoc.Location = new System.Drawing.Point(267, 33);
			this.dgvMonhoc.Name = "dgvMonhoc";
			this.dgvMonhoc.ReadOnly = true;
			this.dgvMonhoc.Size = new System.Drawing.Size(446, 209);
			this.dgvMonhoc.TabIndex = 68;
			this.dgvMonhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonhoc_CellClick);
			// 
			// MaMH
			// 
			this.MaMH.DataPropertyName = "MaMH";
			this.MaMH.HeaderText = "Mã môn học";
			this.MaMH.Name = "MaMH";
			this.MaMH.ReadOnly = true;
			// 
			// TenMH
			// 
			this.TenMH.DataPropertyName = "TenMH";
			this.TenMH.HeaderText = "Môn học";
			this.TenMH.Name = "TenMH";
			this.TenMH.ReadOnly = true;
			// 
			// TenNMH
			// 
			this.TenNMH.DataPropertyName = "TenNMH";
			this.TenNMH.HeaderText = "Nhóm môn học";
			this.TenNMH.Name = "TenNMH";
			this.TenNMH.ReadOnly = true;
			// 
			// SoTiet
			// 
			this.SoTiet.DataPropertyName = "SoTiet";
			this.SoTiet.HeaderText = "Số tiết";
			this.SoTiet.Name = "SoTiet";
			this.SoTiet.ReadOnly = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 17);
			this.label3.TabIndex = 62;
			this.label3.Text = "Tên môn học";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 17);
			this.label2.TabIndex = 61;
			this.label2.Text = "Nhóm môn học";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 60;
			// 
			// cboNMH
			// 
			this.cboNMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboNMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboNMH.FormattingEnabled = true;
			this.cboNMH.Location = new System.Drawing.Point(121, 97);
			this.cboNMH.Name = "cboNMH";
			this.cboNMH.Size = new System.Drawing.Size(100, 25);
			this.cboNMH.TabIndex = 67;
			// 
			// txtTenMH
			// 
			this.txtTenMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenMH.Location = new System.Drawing.Point(121, 51);
			this.txtTenMH.Name = "txtTenMH";
			this.txtTenMH.Size = new System.Drawing.Size(100, 25);
			this.txtTenMH.TabIndex = 75;
			// 
			// txtSotiet
			// 
			this.txtSotiet.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSotiet.Location = new System.Drawing.Point(121, 150);
			this.txtSotiet.Name = "txtSotiet";
			this.txtSotiet.Size = new System.Drawing.Size(100, 25);
			this.txtSotiet.TabIndex = 79;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 17);
			this.label4.TabIndex = 78;
			this.label4.Text = "Số tiết";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTenMH);
			this.groupBox1.Controls.Add(this.txtSotiet);
			this.groupBox1.Controls.Add(this.cboNMH);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 42);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(249, 215);
			this.groupBox1.TabIndex = 80;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin môn học";
			// 
			// frmMONHOC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 386);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dgvMonhoc);
			this.Controls.Add(this.label1);
			this.Name = "frmMONHOC";
			this.Text = "frmMONHOC";
			this.Load += new System.EventHandler(this.frmMONHOC_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.DataGridView dgvMonhoc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboNMH;
		private System.Windows.Forms.TextBox txtTenMH;
		private System.Windows.Forms.TextBox txtSotiet;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}