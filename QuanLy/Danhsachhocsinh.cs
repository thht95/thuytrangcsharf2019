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
	public partial class Danhsachhocsinh : Form
	{
		public Danhsachhocsinh()
		{
			InitializeComponent();
		}
		connect con = new connect();
	


		private void rpDanhsach_Load(object sender, EventArgs e)
		{
			
				con.connection();
				SqlCommand cmd = con.cnn.CreateCommand();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "select_HS";
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				rpDanhsachhs rp = new rpDanhsachhs();
				rp.SetDataSource(dt);
				rpDanhsach.ReportSource = rp;
			
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			con.connection();
			SqlCommand cmd = con.cnn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			string sql;
			sql = "select [Mahocsinh],[Tenhocsinh],case when [Gioitinh] = 1 then N'Nam' else N'Nữ' end as 'Gioitinh',[Ngaysinh],[Diachi],[Dantoc]from [dbo].[HOCSINH] where Mahocsinh='" + txtmahs.Text +"'";
			cmd.CommandText = sql;
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			rpDanhsachhs rp = new rpDanhsachhs();
			rp.SetDataSource(dt);
			rpDanhsach.ReportSource = rp;
		}

		private void Danhsachhocsinh_Load(object sender, EventArgs e)
		{

		}
	}
}
