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
	public partial class frmHOCSINH : Form
	{
		public frmHOCSINH()
		{
			InitializeComponent();
		}
		connect con = new connect();
		int flag;
		private void data()
		{
			con.data("select_HS", dgvHocsinh);
			con.Load_cbo("cbo_LH", cboLophoc);
			/*cboLophoc.Items.Add("6A1");
			cboLophoc.Items.Add("6A2");
			cboLophoc.Items.Add("6A3");
			cboLophoc.Items.Add("7A1");
			cboLophoc.Items.Add("7A2");
			cboLophoc.Items.Add("8A1");
			cboLophoc.Items.Add("8A2");
			cboLophoc.Items.Add("9A1");
			cboLophoc.Items.Add("9A2");*/
		}
		private void Themhocsinh()
		{
			int index = dgvHocsinh.CurrentRow.Index;
			//txtMahocsinh.Text = dgvHocsinh.Rows[index].Cells[0].Value.ToString();
			txtTenhocsinh.Text = dgvHocsinh.Rows[index].Cells[1].Value.ToString();
			if (dgvHocsinh.Rows[index].Cells[2].Value.ToString().Trim().Equals("Nam"))
			{
				rdbNam.Checked = true;
			}
			else
			{
				rdbNu.Checked = true;
			}
			dtNgaysinh.Text = dgvHocsinh.Rows[index].Cells[3].Value.ToString();
			txtDiachi.Text = dgvHocsinh.Rows[index].Cells[4].Value.ToString();
			txtDantoc.Text = dgvHocsinh.Rows[index].Cells[5].Value.ToString();
			cboLophoc.Text = dgvHocsinh.Rows[index].Cells[6].Value.ToString();

		}

		void dis_end(bool e)
		{
			txtTenhocsinh.Enabled = e;
			dtNgaysinh.Enabled = e;
			cboLophoc.Enabled = e;
			txtDiachi.Enabled = e;
			txtDantoc.Enabled = e;

			btnLuu.Enabled = e;
			btnHuy.Enabled = e;
			btnThem.Enabled = !e;
			btnSua.Enabled = !e;
			btnXoa.Enabled = !e;
		}
		private void frmHOCSINH_Load(object sender, EventArgs e)
		{
			data();
			Themhocsinh();
			dis_end(false);
		}

		private void dgvHocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Themhocsinh();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			flag = 0;
			dis_end(true);
		//	txtMahocsinh.Clear();
			txtTenhocsinh.Clear();
			txtDiachi.Clear();
			cboLophoc.Text = "";
			txtDantoc.Clear();
			rdbNam.Checked = true;

			txtTenhocsinh.Focus();
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
				cmd.CommandText = "delete_HS";
				cmd.Parameters.AddWithValue("@tenhs", txtTenhocsinh.Text);
				DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					cmd.ExecuteNonQuery();
					frmHOCSINH_Load(sender, e);
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
				if (String.IsNullOrEmpty(cboLophoc.Text))
					MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					con.connection();
					SqlCommand cmd = con.cnn.CreateCommand();
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "insert_HS";
					//cmd.Parameters.AddWithValue("@mahs", txtMahocsinh.Text);
					cmd.Parameters.AddWithValue("@ten", txtTenhocsinh.Text);
					if (rdbNam.Checked == true)
						cmd.Parameters.AddWithValue("@gt", 1);
					else if (rdbNu.Checked == true)
						cmd.Parameters.AddWithValue("@gt", 0);
					cmd.Parameters.AddWithValue("@ns", Convert.ToDateTime(dtNgaysinh.Value.ToString()));
					cmd.Parameters.AddWithValue("@dc", txtDiachi.Text);
					cmd.Parameters.AddWithValue("@dt", txtDantoc.Text);
					cmd.Parameters.AddWithValue("@malop", cboLophoc.SelectedValue);
					cmd.ExecuteNonQuery();
					frmHOCSINH_Load(sender, e);
				}
			
			}
			else
			{
				try
				{
					con.connection();
					SqlCommand cmd = con.cnn.CreateCommand();
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandText = "update_HS";
					//cmd.Parameters.AddWithValue("@mahs", txtMahocsinh.Text);
					cmd.Parameters.AddWithValue("@ten", txtTenhocsinh.Text);
					if (rdbNam.Checked == true)
						cmd.Parameters.AddWithValue("@gt", 1);
					else if (rdbNu.Checked == true)
						cmd.Parameters.AddWithValue("@gt", 0);
					cmd.Parameters.AddWithValue("@ns", Convert.ToDateTime(dtNgaysinh.Value.ToString()));
					cmd.Parameters.AddWithValue("@dc", txtDiachi.Text);
					cmd.Parameters.AddWithValue("@dt", txtDantoc.Text);
					cmd.Parameters.AddWithValue("@malop", cboLophoc.SelectedValue);
					cmd.ExecuteNonQuery();
					frmHOCSINH_Load(sender, e);
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
			frmHOCSINH_Load(sender, e);
		}
	}
}
