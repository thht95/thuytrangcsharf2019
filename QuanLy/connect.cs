using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace QuanLy
{
	class connect
	{
		public SqlConnection cnn;
		public void connection()
		{
			try
			{
				string constr = ConfigurationManager.ConnectionStrings["quanly"].ConnectionString;
				cnn = new SqlConnection(constr);
				cnn.Open();
			}
			catch (Exception)
			{
				MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}

		public void data(string lenh, DataGridView dtg)
		{
			try
			{
				connection();
				SqlCommand cmd = cnn.CreateCommand();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = lenh;
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dtg.DataSource = dt;
			}
			catch (Exception)
			{
				MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		public void data1(string lenh, string text, DataGridView dtg)
		{
			try
			{
				connection();
				SqlCommand cmd = cnn.CreateCommand();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = lenh;
				cmd.Parameters.AddWithValue("@ma", text);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dtg.DataSource = dt;
			}
			catch (Exception)
			{
				MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		public void Load_cbo(string lenh, ComboBox cbo)
		{
			//connection();
			SqlCommand cmd = cnn.CreateCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = lenh;
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			cbo.DataSource = dt;
			cbo.DisplayMember = dt.Columns[1].ToString();
			cbo.ValueMember = dt.Columns[0].ToString();
			//cbo.SelectedValue = dt.Columns[0].ToString();
		}

		public bool kiemtra(string lenh, string text)
		{

			SqlCommand cmd = cnn.CreateCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = lenh;
			cmd.Parameters.AddWithValue("@ma", text);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			int i = dt.Rows.Count;
			return i > 0;
		}
	}
}
