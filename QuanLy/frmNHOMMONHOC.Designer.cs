namespace QuanLy
{
	partial class frmNHOMMONHOC
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
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.txtTenNMH = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvNMH = new System.Windows.Forms.DataGridView();
			this.MaNMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnHuy = new System.Windows.Forms.Button();
			this.lblMaNMH = new System.Windows.Forms.Label();
			this.txtMaNMH = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvNMH)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Location = new System.Drawing.Point(174, 327);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(88, 23);
			this.btnLuu.TabIndex = 69;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(302, 276);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 68;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(207, 276);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 67;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(117, 276);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 66;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(20, 276);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 65;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// txtTenNMH
			// 
			this.txtTenNMH.Location = new System.Drawing.Point(182, 58);
			this.txtTenNMH.Name = "txtTenNMH";
			this.txtTenNMH.Size = new System.Drawing.Size(100, 20);
			this.txtTenNMH.TabIndex = 64;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(74, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 13);
			this.label2.TabIndex = 62;
			this.label2.Text = "Tên nhóm môn học";
			// 
			// dgvNMH
			// 
			this.dgvNMH.AllowUserToAddRows = false;
			this.dgvNMH.AllowUserToDeleteRows = false;
			this.dgvNMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNMH,
            this.TenNMH});
			this.dgvNMH.Location = new System.Drawing.Point(108, 101);
			this.dgvNMH.Name = "dgvNMH";
			this.dgvNMH.ReadOnly = true;
			this.dgvNMH.Size = new System.Drawing.Size(244, 151);
			this.dgvNMH.TabIndex = 60;
			this.dgvNMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNMH_CellClick);
			// 
			// MaNMH
			// 
			this.MaNMH.DataPropertyName = "MaNMH";
			this.MaNMH.HeaderText = "Mã nhóm môn học";
			this.MaNMH.Name = "MaNMH";
			this.MaNMH.ReadOnly = true;
			// 
			// TenNMH
			// 
			this.TenNMH.DataPropertyName = "TenNMH";
			this.TenNMH.HeaderText = "Tên nhóm";
			this.TenNMH.Name = "TenNMH";
			this.TenNMH.ReadOnly = true;
			// 
			// btnHuy
			// 
			this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.Location = new System.Drawing.Point(283, 327);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(88, 23);
			this.btnHuy.TabIndex = 70;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// lblMaNMH
			// 
			this.lblMaNMH.AutoSize = true;
			this.lblMaNMH.Location = new System.Drawing.Point(71, 19);
			this.lblMaNMH.Name = "lblMaNMH";
			this.lblMaNMH.Size = new System.Drawing.Size(95, 13);
			this.lblMaNMH.TabIndex = 61;
			this.lblMaNMH.Text = "Mã nhóm môn học";
			// 
			// txtMaNMH
			// 
			this.txtMaNMH.Location = new System.Drawing.Point(182, 12);
			this.txtMaNMH.Name = "txtMaNMH";
			this.txtMaNMH.Size = new System.Drawing.Size(100, 20);
			this.txtMaNMH.TabIndex = 63;
			// 
			// frmNHOMMONHOC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 360);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.txtTenNMH);
			this.Controls.Add(this.txtMaNMH);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblMaNMH);
			this.Controls.Add(this.dgvNMH);
			this.Name = "frmNHOMMONHOC";
			this.Text = "frmNHOMMONHOC";
			this.Load += new System.EventHandler(this.frmNHOMMONHOC_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvNMH)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.TextBox txtTenNMH;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvNMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNMH;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Label lblMaNMH;
		private System.Windows.Forms.TextBox txtMaNMH;
	}
}