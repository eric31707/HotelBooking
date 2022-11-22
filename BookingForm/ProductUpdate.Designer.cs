namespace BookingForm
{
	partial class ProductUpdate
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
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.citycbx = new System.Windows.Forms.ComboBox();
			this.roomcbx = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nametxt = new System.Windows.Forms.TextBox();
			this.pricetxt = new System.Windows.Forms.TextBox();
			this.updatebtn = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.addnewbtn = new System.Windows.Forms.Button();
			this.deletebtn = new System.Windows.Forms.Button();
			this.resoucebtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(43, 202);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 24);
			this.label4.TabIndex = 28;
			this.label4.Text = "城市:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(43, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 24);
			this.label2.TabIndex = 29;
			this.label2.Text = "房型:";
			// 
			// citycbx
			// 
			this.citycbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.citycbx.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.citycbx.FormattingEnabled = true;
			this.citycbx.Items.AddRange(new object[] {
            "基隆市",
            "台北市",
            "新北市",
            "桃園市",
            "新竹市",
            "苗栗縣",
            "台中市",
            "彰化縣",
            "雲林縣",
            "嘉義市",
            "台南市",
            "高雄市",
            "屏東縣",
            "台東縣",
            "花蓮縣",
            "宜蘭縣"});
			this.citycbx.Location = new System.Drawing.Point(158, 194);
			this.citycbx.Name = "citycbx";
			this.citycbx.Size = new System.Drawing.Size(158, 32);
			this.citycbx.TabIndex = 3;
			// 
			// roomcbx
			// 
			this.roomcbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.roomcbx.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.roomcbx.FormattingEnabled = true;
			this.roomcbx.Items.AddRange(new object[] {
            "雙人房",
            "三人房",
            "四人房",
            "六人房",
            "八人房",
            "十六人房"});
			this.roomcbx.Location = new System.Drawing.Point(158, 138);
			this.roomcbx.Name = "roomcbx";
			this.roomcbx.Size = new System.Drawing.Size(158, 32);
			this.roomcbx.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(43, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 24);
			this.label3.TabIndex = 24;
			this.label3.Text = "名稱:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(43, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 24);
			this.label1.TabIndex = 25;
			this.label1.Text = "價格:";
			// 
			// nametxt
			// 
			this.nametxt.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.nametxt.Location = new System.Drawing.Point(158, 18);
			this.nametxt.Name = "nametxt";
			this.nametxt.Size = new System.Drawing.Size(137, 36);
			this.nametxt.TabIndex = 0;
			// 
			// pricetxt
			// 
			this.pricetxt.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.pricetxt.Location = new System.Drawing.Point(158, 78);
			this.pricetxt.Name = "pricetxt";
			this.pricetxt.Size = new System.Drawing.Size(137, 36);
			this.pricetxt.TabIndex = 1;
			// 
			// updatebtn
			// 
			this.updatebtn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.updatebtn.Location = new System.Drawing.Point(102, 274);
			this.updatebtn.Name = "updatebtn";
			this.updatebtn.Size = new System.Drawing.Size(112, 54);
			this.updatebtn.TabIndex = 4;
			this.updatebtn.Text = "更新";
			this.updatebtn.UseVisualStyleBackColor = true;
			this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(390, 90);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(477, 383);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 30;
			this.pictureBox1.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// addnewbtn
			// 
			this.addnewbtn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.addnewbtn.Location = new System.Drawing.Point(254, 304);
			this.addnewbtn.Name = "addnewbtn";
			this.addnewbtn.Size = new System.Drawing.Size(112, 54);
			this.addnewbtn.TabIndex = 6;
			this.addnewbtn.Text = "新增";
			this.addnewbtn.UseVisualStyleBackColor = true;
			this.addnewbtn.Click += new System.EventHandler(this.addnewbtn_Click);
			// 
			// deletebtn
			// 
			this.deletebtn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.deletebtn.Location = new System.Drawing.Point(102, 343);
			this.deletebtn.Name = "deletebtn";
			this.deletebtn.Size = new System.Drawing.Size(112, 54);
			this.deletebtn.TabIndex = 5;
			this.deletebtn.Text = "刪除";
			this.deletebtn.UseVisualStyleBackColor = true;
			this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
			// 
			// resoucebtn
			// 
			this.resoucebtn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resoucebtn.Location = new System.Drawing.Point(738, 18);
			this.resoucebtn.Name = "resoucebtn";
			this.resoucebtn.Size = new System.Drawing.Size(129, 63);
			this.resoucebtn.TabIndex = 7;
			this.resoucebtn.Text = "上傳圖片";
			this.resoucebtn.UseVisualStyleBackColor = true;
			this.resoucebtn.Click += new System.EventHandler(this.resoucebtn_Click);
			// 
			// ProductUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(879, 479);
			this.Controls.Add(this.resoucebtn);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.citycbx);
			this.Controls.Add(this.roomcbx);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nametxt);
			this.Controls.Add(this.pricetxt);
			this.Controls.Add(this.addnewbtn);
			this.Controls.Add(this.deletebtn);
			this.Controls.Add(this.updatebtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "ProductUpdate";
			this.Text = "產品更新";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox citycbx;
		private System.Windows.Forms.ComboBox roomcbx;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nametxt;
		private System.Windows.Forms.TextBox pricetxt;
		private System.Windows.Forms.Button updatebtn;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button addnewbtn;
		private System.Windows.Forms.Button deletebtn;
		private System.Windows.Forms.Button resoucebtn;
	}
}