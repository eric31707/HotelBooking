using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingForm
{
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
			
		}

		private void 管理訂單ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new OderForm();
			frm.MdiParent = this;			
			this.WindowState = FormWindowState.Maximized;
			panel1.Controls.Clear();
			frm.TopLevel = false;
			frm.Parent = panel1;
			frm.Show();

		}

		private void 會員管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new UsersEditForm();
			frm.MdiParent = this;
			this.WindowState = FormWindowState.Maximized;
			panel1.Controls.Clear();
			frm.TopLevel = false;
			frm.Parent = panel1;
			frm.Show();
		}

		private void 產品管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new ProductForm();
			frm.MdiParent = this;
			this.WindowState = FormWindowState.Maximized;
			panel1.Controls.Clear();
			frm.TopLevel = false;
			frm.Parent = panel1;
			frm.Show();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
