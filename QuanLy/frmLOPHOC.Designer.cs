namespace QuanLy
{
	partial class frmLOPHOC
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
			this.lblSiso = new System.Windows.Forms.Label();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.txtTenlop = new System.Windows.Forms.TextBox();
			this.dgvlophoc = new System.Windows.Forms.DataGridView();
			this.Malophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tenlophoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Khoilop = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Siso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtSiso = new System.Windows.Forms.TextBox();
			this.lblTenlophoc = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbokhoilop = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvlophoc)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblSiso
			// 
			this.lblSiso.AutoSize = true;
			this.lblSiso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSiso.Location = new System.Drawing.Point(15, 90);
			this.lblSiso.Name = "lblSiso";
			this.lblSiso.Size = new System.Drawing.Size(36, 17);
			this.lblSiso.TabIndex = 81;
			this.lblSiso.Text = "Sĩ số";
			// 
			// btnHuy
			// 
			this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.Location = new System.Drawing.Point(546, 321);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(88, 23);
			this.btnHuy.TabIndex = 80;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Location = new System.Drawing.Point(437, 321);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(88, 23);
			this.btnLuu.TabIndex = 79;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(571, 270);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 78;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(470, 270);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 77;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(380, 270);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 76;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(288, 270);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 75;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// txtTenlop
			// 
			this.txtTenlop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenlop.Location = new System.Drawing.Point(100, 38);
			this.txtTenlop.Name = "txtTenlop";
			this.txtTenlop.Size = new System.Drawing.Size(100, 25);
			this.txtTenlop.TabIndex = 72;
			// 
			// dgvlophoc
			// 
			this.dgvlophoc.AllowUserToAddRows = false;
			this.dgvlophoc.AllowUserToDeleteRows = false;
			this.dgvlophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvlophoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Malophoc,
            this.Tenlophoc,
            this.Khoilop,
            this.Siso});
			this.dgvlophoc.Location = new System.Drawing.Point(299, 38);
			this.dgvlophoc.Name = "dgvlophoc";
			this.dgvlophoc.ReadOnly = true;
			this.dgvlophoc.Size = new System.Drawing.Size(347, 187);
			this.dgvlophoc.TabIndex = 70;
			this.dgvlophoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlophoc_CellClick);
			// 
			// Malophoc
			// 
			this.Malophoc.DataPropertyName = "Malophoc";
			this.Malophoc.HeaderText = "Mã lớp học";
			this.Malophoc.Name = "Malophoc";
			this.Malophoc.ReadOnly = true;
			// 
			// Tenlophoc
			// 
			this.Tenlophoc.DataPropertyName = "Tenlophoc";
			this.Tenlophoc.HeaderText = "Tên lớp học";
			this.Tenlophoc.Name = "Tenlophoc";
			this.Tenlophoc.ReadOnly = true;
			// 
			// Khoilop
			// 
			this.Khoilop.DataPropertyName = "Khoilop";
			this.Khoilop.HeaderText = "Khối lớp";
			this.Khoilop.Name = "Khoilop";
			this.Khoilop.ReadOnly = true;
			// 
			// Siso
			// 
			this.Siso.DataPropertyName = "Siso";
			this.Siso.HeaderText = "Sĩ số";
			this.Siso.Name = "Siso";
			this.Siso.ReadOnly = true;
			// 
			// txtSiso
			// 
			this.txtSiso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSiso.Location = new System.Drawing.Point(100, 83);
			this.txtSiso.Name = "txtSiso";
			this.txtSiso.Size = new System.Drawing.Size(100, 25);
			this.txtSiso.TabIndex = 69;
			// 
			// lblTenlophoc
			// 
			this.lblTenlophoc.AutoSize = true;
			this.lblTenlophoc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTenlophoc.Location = new System.Drawing.Point(12, 45);
			this.lblTenlophoc.Name = "lblTenlophoc";
			this.lblTenlophoc.Size = new System.Drawing.Size(78, 17);
			this.lblTenlophoc.TabIndex = 67;
			this.lblTenlophoc.Text = "Tên lớp học";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 139);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 17);
			this.label1.TabIndex = 83;
			this.label1.Text = "Khối lớp";
			// 
			// cbokhoilop
			// 
			this.cbokhoilop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbokhoilop.FormattingEnabled = true;
			this.cbokhoilop.Location = new System.Drawing.Point(100, 130);
			this.cbokhoilop.Name = "cbokhoilop";
			this.cbokhoilop.Size = new System.Drawing.Size(100, 25);
			this.cbokhoilop.TabIndex = 84;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTenlop);
			this.groupBox1.Controls.Add(this.cbokhoilop);
			this.groupBox1.Controls.Add(this.lblTenlophoc);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtSiso);
			this.groupBox1.Controls.Add(this.lblSiso);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(29, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(230, 208);
			this.groupBox1.TabIndex = 85;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin lớp học";
			// 
			// frmLOPHOC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 370);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dgvlophoc);
			this.Name = "frmLOPHOC";
			this.Text = "frmLOPHOC";
			this.Load += new System.EventHandler(this.frmLOPHOC_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvlophoc)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblSiso;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.TextBox txtTenlop;
		private System.Windows.Forms.DataGridView dgvlophoc;
		private System.Windows.Forms.TextBox txtSiso;
		private System.Windows.Forms.Label lblTenlophoc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Malophoc;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tenlophoc;
		private System.Windows.Forms.DataGridViewTextBoxColumn Khoilop;
		private System.Windows.Forms.DataGridViewTextBoxColumn Siso;
		private System.Windows.Forms.ComboBox cbokhoilop;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}