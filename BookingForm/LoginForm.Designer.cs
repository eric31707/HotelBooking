namespace BookingForm
{
	partial class LoginForm
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
			this.components = new System.ComponentModel.Container();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.registerbtn = new System.Windows.Forms.Button();
			this.loginbtn = new System.Windows.Forms.Button();
			this.passwordtxt = new System.Windows.Forms.TextBox();
			this.accounttxt = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.demobtn = new System.Windows.Forms.Button();
			this.Adminbtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(12, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 50);
			this.label3.TabIndex = 12;
			this.label3.Text = "                帳號:\r\n(請輸入Email)\r\n";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(75, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 21);
			this.label1.TabIndex = 13;
			this.label1.Text = "密碼:";
			// 
			// registerbtn
			// 
			this.registerbtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.registerbtn.Location = new System.Drawing.Point(68, 141);
			this.registerbtn.Name = "registerbtn";
			this.registerbtn.Size = new System.Drawing.Size(125, 46);
			this.registerbtn.TabIndex = 3;
			this.registerbtn.Text = "註冊帳號";
			this.registerbtn.UseVisualStyleBackColor = true;
			this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
			// 
			// loginbtn
			// 
			this.loginbtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.loginbtn.Location = new System.Drawing.Point(234, 141);
			this.loginbtn.Name = "loginbtn";
			this.loginbtn.Size = new System.Drawing.Size(125, 46);
			this.loginbtn.TabIndex = 4;
			this.loginbtn.Text = "登入";
			this.loginbtn.UseVisualStyleBackColor = true;
			this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
			// 
			// passwordtxt
			// 
			this.passwordtxt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.passwordtxt.Location = new System.Drawing.Point(136, 77);
			this.passwordtxt.Name = "passwordtxt";
			this.passwordtxt.PasswordChar = '*';
			this.passwordtxt.Size = new System.Drawing.Size(268, 29);
			this.passwordtxt.TabIndex = 2;
			// 
			// accounttxt
			// 
			this.accounttxt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.accounttxt.Location = new System.Drawing.Point(136, 27);
			this.accounttxt.Name = "accounttxt";
			this.accounttxt.Size = new System.Drawing.Size(268, 29);
			this.accounttxt.TabIndex = 1;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// demobtn
			// 
			this.demobtn.Location = new System.Drawing.Point(407, 141);
			this.demobtn.Name = "demobtn";
			this.demobtn.Size = new System.Drawing.Size(75, 23);
			this.demobtn.TabIndex = 14;
			this.demobtn.Text = "DEMO";
			this.demobtn.UseVisualStyleBackColor = true;
			this.demobtn.Click += new System.EventHandler(this.demobtn_Click);
			// 
			// Adminbtn
			// 
			this.Adminbtn.Location = new System.Drawing.Point(407, 170);
			this.Adminbtn.Name = "Adminbtn";
			this.Adminbtn.Size = new System.Drawing.Size(75, 23);
			this.Adminbtn.TabIndex = 14;
			this.Adminbtn.Text = "ADMIN";
			this.Adminbtn.UseVisualStyleBackColor = true;
			this.Adminbtn.Click += new System.EventHandler(this.Adminbtn_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(508, 216);
			this.Controls.Add(this.Adminbtn);
			this.Controls.Add(this.demobtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.registerbtn);
			this.Controls.Add(this.loginbtn);
			this.Controls.Add(this.passwordtxt);
			this.Controls.Add(this.accounttxt);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.Text = "登入頁面";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button registerbtn;
		private System.Windows.Forms.Button loginbtn;
		private System.Windows.Forms.TextBox passwordtxt;
		private System.Windows.Forms.TextBox accounttxt;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button demobtn;
		private System.Windows.Forms.Button Adminbtn;
	}
}