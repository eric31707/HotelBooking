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

namespace BookingForm
{
	public partial class OderForm : Form
	{
		DataTable orders;
		public OderForm()
		{

			InitializeComponent();

			DisplayOrders();
			
		}

		

		private void DisplayOrders()
		{
			string sql = @"SELECT  *,
					DATEDIFF(day, startDate, endDate) AS '入住天數' ,startDate,endDate
					FROM [Booking].[dbo].[Booking] b
					join Rooms r on r.Id = b.RoomId order by price";			
			orders = new SqlDbHelper("default").Select(sql, null);

			BindData(orders);
		}
		private void BindData(DataTable model)
		{
			DataTable dt = new DataTable();
			var md = model.AsEnumerable();
			dataGridView1.DataSource = (from row in md
										select new
										{
											房號 = row.Field<int>("RoomId").ToString(),
											房型 = row.Field<string>("Room"),
											城市 = row.Field<string>("City"),
											民宿名稱 = row.Field<string>("Name"),
											價格 = row.Field<int>("Price").ToString(),
											入住天數 = row.Field<int>("入住天數").ToString(),
											入住時間 = row.Field<DateTime>("startDate").ToString(),
											退房時間 = row.Field<DateTime>("endDate").ToString(),											
										}).ToList();
									
		}

		private void deletebtn_Click(object sender, EventArgs e)
		{

			DataRow row = this.orders.Rows[dataGridView1.CurrentRow.Index];
			var dic = new Dictionary<string, object>();
			dic["Id"] = row.Field<int>("Id").ToString();
			string sql = @"DELETE FROM Booking WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", Convert.ToInt32(dic["Id"]))
				.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}
			this.DialogResult = DialogResult.OK;
			DisplayOrders();
		}

		private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			this.dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridView1.Sort(this.dataGridView1.Columns["房號"], ListSortDirection.Ascending);
		}

		private void OderForm_Load(object sender, EventArgs e)
		{

		}
	}
}
