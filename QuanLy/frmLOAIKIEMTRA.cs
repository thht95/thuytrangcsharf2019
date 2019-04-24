using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLy
{
	public partial class frmLOAIKIEMTRA : Form
	{
		public frmLOAIKIEMTRA()
		{
			InitializeComponent();
		}
		connect con = new connect();
		int flag;
		private void data()
		{
			con.data("select_LD", dgvLoaidiem);
			cboHocky.Items.Add("1");
			cboHocky.Items.Add("2");

		}
		private void Themloaikt()
		{
			int index = dgvLoaidiem.CurrentRow.Index;
			//txtMaloaidiem.Text = dgvLoaidiem.Rows[index].Cells[0].Value.ToString();
			txtTenloai.Text = dgvLoaidiem.Rows[index].Cells[1].Value.ToString();
			
			cboHocky.Text = dgvLoaidiem.Rows[index].Cells[2].Value.ToString();
			txtHeso.Text = dgvLoaidiem.Rows[index].Cells[3].Value.ToString();
		}

		void dis_end(bool e)
		{
			txtTenloai.Enabled = e;
			txtHeso.Enabled = e;
			cboHocky.Enabled = e;
			btnLuu.Enabled = e;
			btnHuy.Enabled = e;
			btnThem.Enabled = !e;
			btnSua.Enabled = !e;
			btnXoa.Enabled = !e;
		}
		private void frmLOAIKIEMTRA_Load(object sender, EventArgs e)
		{
			data();
			Themloaikt();
			dis_end(false);
		}

		private void dgvLoaidiem_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Themloaikt();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			flag = 0;
			dis_end(true);
			//txtMaloaidiem.Clear();
			txtTenloai.Clear();
			txtHeso.Clear();
			cboHocky.Text = "";
			txtTenloai.Focus();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			flag = 1;
			dis_end(true);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				con.connection();
				SqlCommand cmd = con.cnn.CreateCommand();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "delete_LD";
				cmd.Parameters.AddWithValue("@tenloai", txtTenloai.Text);
				DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					cmd.ExecuteNonQuery();
					frmLOAIKIEMTRA_Load(sender, e);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Xóa không thành công");
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if (flag == 0)
			{
				try
				{
					con.connection();
					SqlCommand cmd = con.cnn.CreateCommand();
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "insert_LD";
					//cmd.Parameters.AddWithValue("@maloai", txtMaloaidiem.Text);
					cmd.Parameters.AddWithValue("@tenloai", txtTenloai.Text);
					cmd.Parameters.AddWithValue("@hocky", cboHocky.Text);
					cmd.Parameters.AddWithValue("@heso", txtHeso.Text);
					cmd.ExecuteNonQuery();
					frmLOAIKIEMTRA_Load(sender, e);
				}
				catch (Exception)
				{
					MessageBox.Show("Thêm không thành công");
				}
			}
			else
			{
				try
				{
					con.connection();
					SqlCommand cmd = con.cnn.CreateCommand();
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "update_LD";
					//cmd.Parameters.AddWithValue("@maloai", txtMaloaidiem.Text);
					cmd.Parameters.AddWithValue("@tenloai", txtTenloai.Text);
					cmd.Parameters.AddWithValue("@hocky", cboHocky.Text);
					cmd.Parameters.AddWithValue("@heso", txtHeso.Text);
					cmd.ExecuteNonQuery();
					frmLOAIKIEMTRA_Load(sender, e);
				}
				catch (Exception)
				{
					MessageBox.Show("Sửa không thành công");
				}
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			frmLOAIKIEMTRA_Load(sender, e);
		}
	}
}
