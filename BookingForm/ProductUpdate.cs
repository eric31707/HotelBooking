using BookingForm.Infra;
using BookingForm.Infra.Exensions;
using BookingForm.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace BookingForm
{
	public partial class ProductUpdate : Form
	{
		private int id;
		public ProductUpdate(int? id)
		{			
			InitializeComponent();
			if (id.HasValue)
			{
				BindData(id.Value);
				this.id = id.Value;
				addnewbtn.Visible = false;
			}
			else
			{
				updatebtn.Visible = false;
				deletebtn.Visible = false;
				citycbx.Text = "桃園市";
				roomcbx.Text = "雙人房";
			}
		}
		private void EditProductForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}
		private void BindData(int id)
		{
			string sql = "SELECT * FROM Rooms WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉, 找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;
				return;
			}
			DataRow row = data.Rows[0];
			roomcbx.Text = row.Field<string>("Room");
			citycbx.Text = row.Field<string>("City");
			nametxt.Text = row.Field<string>("Name");
			pricetxt.Text = row.Field<int>("Price").ToString();
			byte[] photo = row.Field<byte[]>("photo");
			if (photo != null)
			{
				MemoryStream ms = new MemoryStream(photo);
				pictureBox1.Image = Image.FromStream(ms);
			}

		}
		private void updatebtn_Click(object sender, EventArgs e)
		{
			string sql = @"UPDATE Rooms
				SET name=@name, price=@price,city=@city,room=@room , photo=@photo
				WHERE Id=@Id";

			MemoryStream ms = new MemoryStream();
			byte[] image;

			pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
			image = ms.GetBuffer();

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("name", 50, nametxt.Text)
				.AddNVarchar("room", 50, roomcbx.Text)
				.AddNVarchar("city", 50, citycbx.Text)
				.AddInt("price", pricetxt.Text.ToInt(-1))
				.AddByteArray("photo", image)
				.AddInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			this.DialogResult = DialogResult.OK;
			MessageBox.Show("更新成功!!!");
		}

		private void addnewbtn_Click(object sender, EventArgs e)
		{
			string room = roomcbx.Text;
			string city = citycbx.Text;
			bool isExists = AccountExists(room, city);
			if (isExists)
			{
				MessageBox.Show("房間已存在");
				return;
			}
			try
			{
				string sql = @"INSERT INTO Rooms
				(name, price,city,room,photo)
				VALUES
				(@name, @price,@city,@room,@photo)";

				MemoryStream ms = new MemoryStream();
				byte[] image;
				if (pictureBox1.Image == null)
				{
					MessageBox.Show("請選擇要上傳的圖片");
					return ;
				}
				if (roomcbx.Text == string.Empty)
				{
					MessageBox.Show("請選擇房型");
					return;
				}
				if (citycbx.Text == string.Empty)
				{
					MessageBox.Show("請選擇城市");
					return;
				}
				if (nametxt.Text == string.Empty || pricetxt.Text == string.Empty)
				{
					MessageBox.Show("姓名或價格沒填");
				}
				
				pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
				image = ms.GetBuffer();

				var parameters = new SqlParameterBuilder()
					.AddNVarchar("name", 50, nametxt.Text)
					.AddNVarchar("room", 50, roomcbx.Text)
					.AddNVarchar("city", 50, citycbx.Text)
					.AddInt("price", pricetxt.Text.ToInt(-1))
					.AddByteArray("photo", image)
					.Build();

				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
				this.DialogResult = DialogResult.OK;
				MessageBox.Show("上傳成功!!!");
				nametxt.Text = string.Empty;
				roomcbx.Text = string.Empty;
				citycbx.Text = string.Empty;
				pricetxt.Text = string.Empty;
				pictureBox1.Image = null;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void resoucebtn_Click(object sender, EventArgs e)
		{
			if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				Bitmap p = (Bitmap)Image.FromFile(this.openFileDialog1.FileName);
				pictureBox1.Image = p;
			}
		}

		private void deletebtn_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			string sql1 = @"DELETE  FROM [dbo].[Booking]  WHERE RoomId= @RoomId";

			var parameters = new SqlParameterBuilder()
				.AddInt("RoomId", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql1, parameters);

			this.DialogResult = DialogResult.OK;


			string sql = @"DELETE FROM Rooms  WHERE Id=@Id";

			var parameters1 = new SqlParameterBuilder()
				.AddInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters1);

			this.DialogResult = DialogResult.OK;
		}

		private bool AccountExists(string room, string city)
		{
			string sql = @" SELECT Count(*) as count FROM [Rooms] WHERE Room =@Room and City=@City";


			var parameters = new SqlParameterBuilder()
				.AddNVarchar("room", 50, room)
				.AddNVarchar("city", 50, city)
				//.AddInt ("RoomId",roomId)
				.Build();
			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}


	}

}
