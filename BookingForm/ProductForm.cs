using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingForm
{
	public partial class ProductForm : Form
	{
		DataTable categories;
		public ProductForm()
		{
			InitializeComponent();
			DisplayProductCatetories();
			
		}
		private void DisplayProductCatetories()
		{
			string sql = @" SELECT * 
            FROM [Booking].[dbo].[Rooms] order by price";

			categories = new SqlDbHelper("default").Select(sql, null);

			BindData(categories);
		}

		private void BindData(DataTable model)
		{
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

		private void addbtn_Click(object sender, EventArgs e)
		{
			var frm = new ProductUpdate(null);
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayProductCatetories();
			}
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

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;
			if (rowIndx < 0) return;
			DataRow row = this.categories.Rows[rowIndx];
			int id = row.Field<int>("Id");
			var frm = new ProductUpdate(id);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayProductCatetories();
			}
		}

		private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			
		}

		private void deletebtn_Click(object sender, EventArgs e)
		{					
			DataRow row = this.categories.Rows[dataGridView1.CurrentRow.Index];
			var dic = new Dictionary<string, object>();
			dic["Id"] = row.Field<int>("Id").ToString();
			string sql = @"DELETE  FROM [dbo].[Booking]  WHERE RoomId= @Id ";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", Convert.ToInt32(dic["Id"]))
				.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			string sql1 = @"DELETE FROM Booking WHERE Id=@Id";
			var parameters1 = new SqlParameterBuilder()
				.AddInt("Id", Convert.ToInt32(dic["Id"]))
				.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql1, parameters1);
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}			
				
			this.DialogResult = DialogResult.OK;
			DisplayProductCatetories();
		}
	}
}
