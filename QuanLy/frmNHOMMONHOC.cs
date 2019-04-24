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
	public partial class frmNHOMMONHOC : Form
	{
		public frmNHOMMONHOC()
		{
			InitializeComponent();
		}
		connect con = new connect();
		int flag;
		private void data()
		{
			con.data("select_NMH", dgvNMH);

		}
		private void ThemNMH()
		{
			int index = dgvNMH.CurrentRow.Index;
			txtMaNMH.Text = dgvNMH.Rows[index].Cells[0].Value.ToString();
			txtTenNMH.Text = dgvNMH.Rows[index].Cells[1].Value.ToString();
		}
		void dis_end(bool e)
		{
			txtMaNMH.Enabled = e;
			txtTenNMH.Enabled = e;
			btnLuu.Enabled = e;
			btnHuy.Enabled = e;
			btnThem.Enabled = !e;
			btnSua.Enabled = !e;
			btnXoa.Enabled = !e;
		}

		private void frmNHOMMONHOC_Load(object sender, EventArgs e)
		{
			data();
			ThemNMH();
			dis_end(false);

		}

		private void dgvNMH_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ThemNMH();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			flag = 0;
			dis_end(true);
			txtMaNMH.Clear();
			txtTenNMH.Clear();
			txtMaNMH.Focus();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			flag = 1;
			dis_end(true);
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
					cmd.CommandText = "insert_NMH";
					cmd.Parameters.AddWithValue("@ma", txtMaNMH.Text);
					cmd.Parameters.AddWithValue("@ten", txtTenNMH.Text);
					cmd.ExecuteNonQuery();
					frmNHOMMONHOC_Load(sender, e);
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
					cmd.CommandText = "update_NMH";
					cmd.Parameters.AddWithValue("@ma", txtMaNMH.Text);
					cmd.Parameters.AddWithValue("@ten", txtTenNMH.Text);
					cmd.ExecuteNonQuery();
					frmNHOMMONHOC_Load(sender, e);
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
			frmNHOMMONHOC_Load(sender, e);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				con.connection();
				SqlCommand cmd = con.cnn.CreateCommand();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "delete_NMH";
				cmd.Parameters.AddWithValue("@manmh", txtMaNMH.Text);
				DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					cmd.ExecuteNonQuery();
					frmNHOMMONHOC_Load(sender, e);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Xóa không thành công");
			}
		}
	}
}
