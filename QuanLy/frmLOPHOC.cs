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
	public partial class frmLOPHOC : Form
	{
		public frmLOPHOC()
		{
			InitializeComponent();
		}
		connect con = new connect();
		int flag;
		private void data()
		{
			con.data("select_LH", dgvlophoc);
			cbokhoilop.Items.Add("KHỐI 6");
			cbokhoilop.Items.Add("kHỐI 7");
			cbokhoilop.Items.Add("KHỐI 8");
			cbokhoilop.Items.Add("KHỐI 9");

		}
		private void Themlophoc()
		{
			int index = dgvlophoc.CurrentRow.Index;
			//txtMalop.Text = dgvlophoc.Rows[index].Cells[0].Value.ToString();
			txtTenlop.Text = dgvlophoc.Rows[index].Cells[1].Value.ToString();
			cbokhoilop.Text = dgvlophoc.Rows[index].Cells[2].Value.ToString();
			txtSiso.Text = dgvlophoc.Rows[index].Cells[3].Value.ToString();
		
		}

		void dis_end(bool e)
		{
			txtTenlop.Enabled = e;
			txtSiso.Enabled = e;
			cbokhoilop.Enabled = e;
			btnLuu.Enabled = e;
			btnHuy.Enabled = e;
			btnThem.Enabled = !e;
			btnSua.Enabled = !e;
			btnXoa.Enabled = !e;
		}
		private void frmLOPHOC_Load(object sender, EventArgs e)
		{
			data();
			Themlophoc();
			dis_end(false);
		}

		private void dgvlophoc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Themlophoc();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			flag = 0;
			dis_end(true);
		//	txtMalop.Clear();
			txtTenlop.Clear();
			txtSiso.Clear();
			cbokhoilop.Text = "";
			txtTenlop.Focus();
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
				cmd.CommandText = "delete_LH";
				cmd.Parameters.AddWithValue("@tenlop", txtTenlop.Text);
				DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					cmd.ExecuteNonQuery();
					frmLOPHOC_Load(sender, e);
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
					cmd.CommandText = "insert_LH";
					//cmd.Parameters.AddWithValue("@malop", txtMalop.Text);
					cmd.Parameters.AddWithValue("@tenlop", txtTenlop.Text);
					cmd.Parameters.AddWithValue("@khoilop", cbokhoilop.Text);
					cmd.Parameters.AddWithValue("@siso", txtSiso.Text);
					cmd.ExecuteNonQuery();
					frmLOPHOC_Load(sender, e);
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
					cmd.CommandText = "update_LH";
					//cmd.Parameters.AddWithValue("@malop", txtMalop.Text);
					cmd.Parameters.AddWithValue("@tenlop", txtTenlop.Text);
					cmd.Parameters.AddWithValue("@khoilop", cbokhoilop.Text);
					cmd.Parameters.AddWithValue("@siso", txtSiso.Text);
					cmd.ExecuteNonQuery();
					frmLOPHOC_Load(sender, e);
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
			frmLOPHOC_Load(sender, e);
		}
	}
}
