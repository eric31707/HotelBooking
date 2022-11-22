using BookingForm.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using SortOrder = System.Windows.Forms.SortOrder;

namespace BookingForm
{

	public partial class BookingForm : Form
	{

		DataTable categories;
		List<Dictionary<string, object>> cartlist = new List<Dictionary<string, object>>();
		public BookingForm()
		{
			InitializeComponent();
			welcome.Text += UserLogin.Name;
			DisplayProducts();
			roomcbx.Text = "全部";


		}

		private void BindData(DataTable model)
		{
			roomcbx.DropDownStyle = ComboBoxStyle.DropDownList;
			DataTable dt = new DataTable();
			var md = model.AsEnumerable();
			dataGridView1.DataSource = (from row in md
										select new
										{
											房型 = row.Field<string>("Room"),
											城市 = row.Field<string>("City"),
											民宿名稱 = row.Field<string>("Name"),
											價格 = row.Field<int>("Price").ToString()
										}).ToList();

		}
		private void DisplayProducts()
		{
			string sql = @"SELECT* 
            FROM [Booking].[dbo].[Rooms] order by price";
			categories = new SqlDbHelper("default").Select(sql, null);
			BindData(categories);

		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;
			if (rowIndx < 0) return;
			DataRow row = this.categories.Rows[rowIndx];
			byte[] photo = row.Field<byte[]>("photo");
			if (photo != null)
			{
				MemoryStream ms = new MemoryStream(photo);
				pictureBox1.Image = Image.FromStream(ms);
			}

		}

		private void logoutbtn_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎?",
				"登出",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void BookingForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();

		}

		private void searchbtn_Click(object sender, EventArgs e)
		{
			if (dateTimePicker1.Value < DateTime.Now || dateTimePicker2.Value < dateTimePicker1.Value)
			{
				MessageBox.Show("請正確的選擇入住時間");
				return;
			}

			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@room", roomcbx.Text));
			string sql = @"SELECT * 
            FROM [Booking].[dbo].[Rooms] ";
			if (roomcbx.Text == "全部")
			{
				string sql2 = @"SELECT * FROM [Booking].[dbo].[Rooms] order by price ";
				categories = new SqlDbHelper("default").Select(sql2, parameters.ToArray());
				BindData(categories);
			}
			else
			{
				sql += "where room=@room  order by price";
				categories = new SqlDbHelper("default").Select(sql, parameters.ToArray());
				BindData(categories);
			}
			


		}

		private void addnewbtn_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow == null)
			{
				MessageBox.Show("請選擇房間");
				return;
			}
			DataRow row = this.categories.Rows[dataGridView1.CurrentRow.Index];
			var dic = new Dictionary<string, object>();
			dic["Id"] = row.Field<int>("Id").ToString();
			dic["City"] = row.Field<string>("City");
			dic["Name"] = row.Field<string>("Name");
			dic["Room"] = row.Field<string>("Room");
			dic["Price"] = row.Field<int>("Price").ToString();

			DateTime startdate = dateTimePicker1.Value;
			DateTime enddate = dateTimePicker2.Value;
			bool isExists = AccountExists(startdate, enddate, Convert.ToInt32(dic["Id"]));
			if (isExists)
			{
				MessageBox.Show("房間已被預訂");
				return;
			}
			if (cartlist.FirstOrDefault(a =>
			Convert.ToInt32(a["Id"]) == Convert.ToInt32(dic["Id"])) != null)

			{
				MessageBox.Show("已加入購物車");
				return;
			}
			cartlist.Add(dic);
			dataGridView2.DataSource = (from item in cartlist
										select new
										{
											房型 = item["Room"],
											城市 = item["City"],
											民宿名稱 = item["Name"],
											價格 = item["Price"]
										}).ToList();


		}

		private void sendbtn_Click(object sender, EventArgs e)
		{
			if (dateTimePicker1.Value < DateTime.Now || dateTimePicker2.Value < dateTimePicker1.Value)
			{
				MessageBox.Show("請選擇入住時間");
				return ;
			}			
			else
			{
				int total = 0;
				foreach (var item in cartlist)
				{
					total += Convert.ToInt32(item["Price"]);
					int roomId = Convert.ToInt32(item["Id"]);
					string sql = @" INSERT INTO [Booking]
				(RoomId, [Startdate],[Enddate],[CustomersId])
				VALUES
				(@RoomId, @Startdate,@Enddate,@CustomersId)";
					var parameters = new SqlParameterBuilder()
					.AddInt("RoomId", roomId)
					.AddDateTime("Startdate", dateTimePicker1.Value)
					.AddDateTime("Enddate", dateTimePicker2.Value)
					.AddInt("CustomersId", UserLogin.Id)
					.Build();
					new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
				}
				if (total == 0) 
				{
					MessageBox.Show("請選擇房型");
					return;
				}
				cartlist.Clear();
				dataGridView2.DataSource = null;
				TimeSpan Bookingdays = (DateTime)dateTimePicker2.Value - (DateTime)dateTimePicker1.Value;
				int Totalday = Bookingdays.Days;
				int Final = Totalday * total;
				MessageBox.Show($"總共入住{Totalday}天\r\n總金額是\r\n {Final.ToString()}");

			}

		}

		private void deletebtn_Click(object sender, EventArgs e)
		{
			cartlist.RemoveAt(dataGridView2.CurrentRow.Index);
			dataGridView2.DataSource = (from item in cartlist
										select new
										{
											房型 = item["Room"],
											城市 = item["City"],
											民宿名稱 = item["Name"],
											價格 = item["Price"]
										}).ToList();

		}


		private bool AccountExists(DateTime startdate, DateTime enddate, int id)
		{
			string sql = @" SELECT  count(*)  as count
						    FROM [Booking].[dbo].[Booking] b
							join [dbo].[Rooms] r on b.RoomId =　r.Id
							WHERE  RoomId　= @RoomId   and
							Startdate BETWEEN @Startdate AND @enddate ";


			var parameters = new SqlParameterBuilder()
				.AddInt("RoomId", id)
				.AddDateTime("startdate", startdate)
				.AddDateTime("enddate", enddate)
				.Build();
			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
	}


}

