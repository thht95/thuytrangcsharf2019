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
	public partial class rpHocsinhtheolop : Form
	{
		public rpHocsinhtheolop()
		{
			InitializeComponent();
		}
		connect con = new connect();
		private void rptheolop_Load(object sender, EventArgs e)
		{
			con.connection();
			SqlCommand cmd = con.cnn.CreateCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "pc_theolop";
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			DShocsinhtheolop rp = new DShocsinhtheolop();
			rp.SetDataSource(dt);
			rptheolop.ReportSource = rp;
		}
	}
}
