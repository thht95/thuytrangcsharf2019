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
	public partial class frmNHAPDIEM : Form
	{
		public frmNHAPDIEM()
		{
			InitializeComponent();
		}
		connect con = new connect();
		int flag;
		private void data()
		{
			con.data("select_ND", dgvNhapdiem);
			con.Load_cbo("cbo_HS", cboTenhocsinh);
			con.Load_cbo("cbo_MH", cboMonhoc);
			con.Load_cbo("cbo_LD", cboLoaidiem);

		}
		private void Themdiem()
		{
			int index = dgvNhapdiem.CurrentRow.Index;
			txtMadiem.Text = dgvNhapdiem.Rows[index].Cells[0].Value.ToString();
			cboTenhocsinh.Text = dgvNhapdiem.Rows[index].Cells[1].Value.ToString();
			cboMonhoc.Text = dgvNhapdiem.Rows[index].Cells[2].Value.ToString();
			cboLoaidiem.Text = dgvNhapdiem.Rows[index].Cells[3].Value.ToString();
			txtDiem.Text = dgvNhapdiem.Rows[index].Cells[4].Value.ToString();

		}

		void dis_end(bool e)
		{
	
			cboTenhocsinh.Enabled = e;
			cboMonhoc.Enabled = e;
			cboLoaidiem.Enabled = e;
			txtDiem.Enabled = e;
			btnLuu.Enabled = e;
			btnHuy.Enabled = e;
			btnThem.Enabled = !e;
			btnSua.Enabled = !e;
			btnXoa.Enabled = !e;
		}
		private void frmNHAPDIEM_Load(object sender, EventArgs e)
		{
			data();
			Themdiem();
			dis_end(false);
		}

		private void dgvNhapdiem_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Themdiem();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			flag = 0;
			dis_end(true);
			txtMadiem.Clear();
			txtDiem.Clear();
		
			cboTenhocsinh.Text = "";
			cboLoaidiem.Text = "";
			cboMonhoc.Text = "";
			cboTenhocsinh.Focus();
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
				cmd.CommandText = "delete_ND";
				cmd.Parameters.AddWithValue("@madiem", txtMadiem.Text);
				DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					cmd.ExecuteNonQuery();
					frmNHAPDIEM_Load(sender, e);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Xóa không thành công");
			}
		}

        private bool check()
        {
            if (string.IsNullOrEmpty(txtDiem.Text))
                return false;

            int parse;

            if (!int.TryParse(txtDiem.Text, out parse))
            {
                MessageBox.Show("Điểm phải là số");
                return false;
            }

            if (int.Parse(txtDiem.Text) < 0 || int.Parse(txtDiem.Text) > 10)
            {
                MessageBox.Show("Điểm phải từ 0 đến 10");
                return false;
            }

            return true;
        }

		private void btnLuu_Click(object sender, EventArgs e)
		{
            if (check())
            {
                if (flag == 0)
                {
                    if (String.IsNullOrEmpty(cboTenhocsinh.Text) || String.IsNullOrEmpty(cboMonhoc.Text) || String.IsNullOrEmpty(cboLoaidiem.Text))
                        MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        con.connection();
                        SqlCommand cmd = con.cnn.CreateCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Insert_ND";
                        cmd.Parameters.AddWithValue("@madiem", txtMadiem.Text);

                        cmd.Parameters.AddWithValue("@mahs", cboTenhocsinh.SelectedValue);
                        cmd.Parameters.AddWithValue("@mamon", cboMonhoc.SelectedValue);
                        cmd.Parameters.AddWithValue("@maloai", cboLoaidiem.SelectedValue);
                        cmd.Parameters.AddWithValue("@diem", txtDiem.Text);
                        cmd.ExecuteNonQuery();
                        frmNHAPDIEM_Load(sender, e);
                    }
                }
                else
                {
                    con.connection();
                    SqlCommand cmd = con.cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Update_ND";
                    cmd.Parameters.AddWithValue("@madiem", txtMadiem.Text);
                    cmd.Parameters.AddWithValue("@mahs", cboTenhocsinh.SelectedValue);
                    cmd.Parameters.AddWithValue("@mamon", cboMonhoc.SelectedValue);
                    cmd.Parameters.AddWithValue("@maloai", cboLoaidiem.SelectedValue);
                    cmd.Parameters.AddWithValue("@diem", txtDiem.Text);
                    cmd.ExecuteNonQuery();
                    frmNHAPDIEM_Load(sender, e);
                }
            }
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			frmNHAPDIEM_Load(sender, e);
		}
	}
}
