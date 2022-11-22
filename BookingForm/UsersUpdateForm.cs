using BookingForm.Infra;
using BookingForm.Infra.DAOs;
using BookingForm.Models.DTOs;
using BookingForm.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookingForm.Models.DTOs.UsersDTO;

namespace BookingForm
{
	public partial class UsersUpdateForm : Form
	{		
		private UserIndexVM user = null;
		public UsersUpdateForm(UserIndexVM row)
		{
			InitializeComponent();
			this.Load += UsersUpdateForm_Load;
			this.user = row;
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			string account = accountTextBox.Text;
			string password = passwordTextBox.Text;
			string name = nameTextBox.Text;
			UserVM model = new UserVM
			{
				Id = user.Id,
				Account = account,
				Password = password,
				Name = name,
			};
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accountTextBox},
				{"Password", passwordTextBox},
				{"Name", nameTextBox},
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;
			UserDTO dto = model.ToDTO();
			try
			{
				new UserService().Update(dto);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			new UserService().Delete(user.Id);

			this.DialogResult = DialogResult.OK;
		}

		private void UsersUpdateForm_Load(object sender, EventArgs e)
		{
			BindData(user.Id);
		}
		private void BindData(int row)
		{

			accountTextBox.Text = user.Account;
			passwordTextBox.Text = user.Password;
			nameTextBox.Text = user.Name;
		}
	}
	public static class UserVMExts
	{
		public static UserDTO ToDTO(this UserVM vm)
		{
			return new UserDTO
			{
				Id = vm.Id,
				Account = vm.Account,
				Password = vm.Password,
				Name = vm.Name
			};
		}
	}
}
