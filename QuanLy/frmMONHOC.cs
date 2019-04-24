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
	public partial class frmMONHOC : Form
	{
		public frmMONHOC()
		{
			InitializeComponent();
		}
		connect con = new connect();
		int flag;
		private void data()
		{
			con.data("select_MH", dgvMonhoc);
			con.Load_cbo("cbo_NMH", cboNMH);

		}
		private void Themmonhoc()
		{
			int index = dgvMonhoc.CurrentRow.Index;
			//txtMaMH.Text = dgvMonhoc.Rows[index].Cells[0].Value.ToString();
			txtTenMH.Text = dgvMonhoc.Rows[index].Cells[1].Value.ToString();

			cboNMH.Text = dgvMonhoc.Rows[index].Cells[2].Value.ToString();
			txtSotiet.Text = dgvMonhoc.Rows[index].Cells[3].Value.ToString();
		}

		void dis_end(bool e)
		{
			txtTenMH.Enabled = e;
			txtSotiet.Enabled = e;
			cboNMH.Enabled = e;
			btnLuu.Enabled = e;
			btnHuy.Enabled = e;
			btnThem.Enabled = !e;
			btnSua.Enabled = !e;
			btnXoa.Enabled = !e;
		}
		private void frmMONHOC_Load(object sender, EventArgs e)
		{
			data();
			Themmonhoc();
			dis_end(false);
		}

		private void dgvMonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Themmonhoc();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			flag = 0;
			dis_end(true);
			
			txtTenMH.Clear();
			txtSotiet.Clear();
			cboNMH.Text = "";
			txtTenMH.Focus();
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
				cmd.CommandText = "delete_MH";
				cmd.Parameters.AddWithValue("@tenmon", txtTenMH.Text);
				DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					cmd.ExecuteNonQuery();
					frmMONHOC_Load(sender, e);
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
				if (String.IsNullOrEmpty(cboNMH.Text))
					MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					con.connection();
					SqlCommand cmd = con.cnn.CreateCommand();
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "insert_MH";
					//cmd.Parameters.AddWithValue("@mamon", txtMaMH.Text);
					cmd.Parameters.AddWithValue("@tenmon", txtTenMH.Text);
					cmd.Parameters.AddWithValue("@sotiet", txtSotiet.Text);
					cmd.Parameters.AddWithValue("@manmh", cboNMH.SelectedValue);
					cmd.ExecuteNonQuery();
					frmMONHOC_Load(sender, e);
				}
			}
			else
			{
				try
				{
					con.connection();
					SqlCommand cmd = con.cnn.CreateCommand();
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "update_MH";
					//cmd.Parameters.AddWithValue("@mamon", txtMaMH.Text);
					cmd.Parameters.AddWithValue("@tenmon", txtTenMH.Text);
					cmd.Parameters.AddWithValue("@sotiet", txtSotiet.Text);
					cmd.Parameters.AddWithValue("@manmh", cboNMH.SelectedValue);
					cmd.ExecuteNonQuery();
					frmMONHOC_Load(sender, e);	
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
			frmMONHOC_Load(sender, e);
		}

	
	}
}
