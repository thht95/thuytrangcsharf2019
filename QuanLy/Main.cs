using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void nhómMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmNHOMMONHOC f1 = new frmNHOMMONHOC();
			f1.MdiParent = this;
			f1.Show();
		}

		private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmLOPHOC f1 = new frmLOPHOC();
			f1.MdiParent = this;
			f1.Show();
		}

		private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmMONHOC f1 = new frmMONHOC();
			f1.MdiParent = this;
			f1.Show();
		}

		private void loạiKiểmTraToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmLOAIKIEMTRA f1 = new frmLOAIKIEMTRA();
			f1.MdiParent = this;
			f1.Show();
		}

		private void nhạpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmNHAPDIEM f1 = new frmNHAPDIEM();
			f1.MdiParent = this;
			f1.Show();
		}

		private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmHOCSINH f1 = new frmHOCSINH();
			f1.MdiParent = this;
			f1.Show();
		}

		private void TimkiemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmTIMKIEM f1 = new frmTIMKIEM();
			f1.MdiParent = this;
			f1.Show();
		}

		private void danhSáchHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Danhsachhocsinh f1 = new Danhsachhocsinh();
			f1.MdiParent = this;
			f1.Show();
		}

		private void dSHọcSinhTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			rpHocsinhtheolop f1 = new rpHocsinhtheolop();
			f1.MdiParent = this;
			f1.Show();
		}
	}
}
