namespace BookingForm
{
	partial class AdminForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.管理訂單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.會員管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.產品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理訂單ToolStripMenuItem,
            this.會員管理ToolStripMenuItem,
            this.產品管理ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1476, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 管理訂單ToolStripMenuItem
			// 
			this.管理訂單ToolStripMenuItem.Name = "管理訂單ToolStripMenuItem";
			this.管理訂單ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.管理訂單ToolStripMenuItem.Text = "管理訂單";
			this.管理訂單ToolStripMenuItem.Click += new System.EventHandler(this.管理訂單ToolStripMenuItem_Click);
			// 
			// 會員管理ToolStripMenuItem
			// 
			this.會員管理ToolStripMenuItem.Name = "會員管理ToolStripMenuItem";
			this.會員管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.會員管理ToolStripMenuItem.Text = "會員管理";
			this.會員管理ToolStripMenuItem.Click += new System.EventHandler(this.會員管理ToolStripMenuItem_Click);
			// 
			// 產品管理ToolStripMenuItem
			// 
			this.產品管理ToolStripMenuItem.Name = "產品管理ToolStripMenuItem";
			this.產品管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.產品管理ToolStripMenuItem.Text = "產品管理";
			this.產品管理ToolStripMenuItem.Click += new System.EventHandler(this.產品管理ToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1476, 683);
			this.panel1.TabIndex = 3;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1476, 707);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.Name = "AdminForm";
			this.Text = "AdminForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 管理訂單ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 會員管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 產品管理ToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
	}
}