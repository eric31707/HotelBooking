using BookingForm.Infra;
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

namespace BookingForm
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();			
		}

		private void registerbtn_Click(object sender, EventArgs e)
		{
			var frm = new RegisterForm();
			frm.ShowDialog();
			if (frm.DialogResult == DialogResult.OK)
			{
				accounttxt.Text = UserLogin.Account;
			}

		}

		private void loginbtn_Click(object sender, EventArgs e)
		{
			LoginVM model = new LoginVM
			{
				Account = accounttxt.Text,
				Password = passwordtxt.Text
			};
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accounttxt},
				{"Password", passwordtxt},
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			bool result = new UserService().Authenticate(model,	out var user);
			if (result == false)
			{
				MessageBox.Show("帳號或密碼錯誤");
				return;
			}
			
			UserLogin.Name=user.Name;
			UserLogin.Password=user.Password;
			UserLogin.Account = user.Account;
			UserLogin.Id = user.Id;

			if (user.Account == "eric31707@gmail.com")
			{
				var frm1 = new AdminForm();
				frm1.Owner = this;
				frm1.Show();
				this.Hide();
			}
			else
			{
				var frm = new BookingForm();
				frm.Owner = this;
				frm.Show();
				this.Hide();
			}
			accounttxt.Text=string.Empty; passwordtxt.Text=string.Empty;
		}

		private void demobtn_Click(object sender, EventArgs e)
		{
			accounttxt.Text = "eric@.com";
			passwordtxt.Text = "eric";
		}

		private void Adminbtn_Click(object sender, EventArgs e)
		{
			accounttxt.Text = "eric31707@gmail.com";
			passwordtxt.Text = "123";
		}
	}
}
