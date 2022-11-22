namespace BookingForm
{
	partial class RegisterForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.registerbtn = new System.Windows.Forms.Button();
			this.passwordtxt = new System.Windows.Forms.TextBox();
			this.nametxt = new System.Windows.Forms.TextBox();
			this.accounttxt = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(31, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 31);
			this.label2.TabIndex = 19;
			this.label2.Text = "密碼:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(31, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 31);
			this.label3.TabIndex = 20;
			this.label3.Text = "姓名:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(31, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 31);
			this.label1.TabIndex = 21;
			this.label1.Text = "帳號:";
			// 
			// registerbtn
			// 
			this.registerbtn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.registerbtn.Location = new System.Drawing.Point(341, 198);
			this.registerbtn.Name = "registerbtn";
			this.registerbtn.Size = new System.Drawing.Size(142, 48);
			this.registerbtn.TabIndex = 3;
			this.registerbtn.Text = "註冊";
			this.registerbtn.UseVisualStyleBackColor = true;
			this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
			// 
			// passwordtxt
			// 
			this.passwordtxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.passwordtxt.Location = new System.Drawing.Point(119, 71);
			this.passwordtxt.Name = "passwordtxt";
			this.passwordtxt.Size = new System.Drawing.Size(364, 39);
			this.passwordtxt.TabIndex = 1;
			// 
			// nametxt
			// 
			this.nametxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.nametxt.Location = new System.Drawing.Point(119, 121);
			this.nametxt.Name = "nametxt";
			this.nametxt.Size = new System.Drawing.Size(364, 39);
			this.nametxt.TabIndex = 2;
			// 
			// accounttxt
			// 
			this.accounttxt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.accounttxt.Location = new System.Drawing.Point(119, 21);
			this.accounttxt.Name = "accounttxt";
			this.accounttxt.Size = new System.Drawing.Size(364, 39);
			this.accounttxt.TabIndex = 0;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(512, 275);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.registerbtn);
			this.Controls.Add(this.passwordtxt);
			this.Controls.Add(this.nametxt);
			this.Controls.Add(this.accounttxt);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "RegisterForm";
			this.Text = "註冊頁面";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button registerbtn;
		private System.Windows.Forms.TextBox passwordtxt;
		private System.Windows.Forms.TextBox nametxt;
		private System.Windows.Forms.TextBox accounttxt;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}