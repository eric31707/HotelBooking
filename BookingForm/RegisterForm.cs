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
using static BookingForm.Models.DTOs.UsersDTO;

namespace BookingForm
{
	public partial class RegisterForm : Form
	{		
		public RegisterForm()
		{
			InitializeComponent();
		}
		BookingEntities BookEntity = new BookingEntities();

		private void registerbtn_Click(object sender, EventArgs e)
		{
			string account = accounttxt.Text;
			string password = passwordtxt.Text;
			string name = nametxt.Text;
			UserVM model = new UserVM
			{				
				Account = account,
				Password = password,
				Name = name,
			};
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accounttxt},
				{"Password", passwordtxt},
				{"Name", nametxt},
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;
			UserDTO dto = model.ToDTO();
			try
			{
				new UserService().Create(dto);
				MessageBox.Show("註冊成功");
				UserLogin.Account = accounttxt.Text;
				this.DialogResult = DialogResult.OK;
				this.Hide();				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
						
		}
	}
}
