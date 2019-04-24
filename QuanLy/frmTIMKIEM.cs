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
	public partial class frmTIMKIEM : Form
	{
		public frmTIMKIEM()
		{
			InitializeComponent();
		}
		connect con = new connect();
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void frmTIMKIEM_Load(object sender, EventArgs e)
		{
			clear();
			dgvTimkiem.DataSource = null;
		}
		private void clear()
		{
			txtHocsinh.Clear();
			txtLophoc.Clear();

		}
	
		private void txtTim_Click(object sender, EventArgs e)
		{
			string sql;
			if (String.IsNullOrEmpty(txtHocsinh.Text) && String.IsNullOrEmpty(txtLophoc.Text) )
			{
				MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "YÊU CẦU", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			sql = "select*from TK_HS where 1=1";
			if (!String.IsNullOrEmpty(txtHocsinh.Text))
				sql = sql + "and Tenhocsinh like '%" + txtHocsinh.Text + "%'";
			if (!String.IsNullOrEmpty(txtLophoc.Text))
				sql = sql + "and Tenlophoc like N'%" + txtLophoc.Text + "%'";
			con.connection();
			SqlCommand cmd = con.cnn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = sql;
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu thỏa mãn yêu cầu tìm kiếm", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				dgvTimkiem.DataSource = null;
			}
			else
				dgvTimkiem.DataSource = dt;
		}

		private void txtTimlai_Click(object sender, EventArgs e)
		{
			clear();
		}
	}
}
