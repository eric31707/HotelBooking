using BookingForm.Infra.DAOs;
using BookingForm.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookingForm.Models.DTOs.UsersDTO;

namespace BookingForm
{
	public partial class UsersEditForm : Form
	{

		private UserIndexVM[] users = null;
		public UsersEditForm()
		{
			InitializeComponent();
			DisplayUsers();
		}

		private void addnewbtn_Click(object sender, EventArgs e)
		{
			var frm = new RegisterForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayUsers();
			}
		}
		private void DisplayUsers()
		{
			users = new UserDAO().GetAll()
						.Select(dto => dto.ToIndexVM())
						.ToArray();
			BindData(users);
		}
		private void BindData(UserIndexVM[] data)
		{
			dataGridView1.DataSource = (from row in data
										select new
										{
											帳號Emal = row.Account,
											密碼 = row.Password,
											名稱 = row.Name,
										}).ToList();

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;
			if (rowIndx < 0) return;
			UserIndexVM row = this.users[rowIndx];
			int id = row.Id;
			var frm = new UsersUpdateForm(row);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayUsers();
			}

		}
	}
	public static class UserDTOExts
	{
		public static UserIndexVM ToIndexVM(this UserDTO dto)
		{
			return new UserIndexVM
			{
				Id = dto.Id,
				Account = dto.Account,
				Password = dto.Password,
				Name = dto.Name,
			};
		}
	}
}
