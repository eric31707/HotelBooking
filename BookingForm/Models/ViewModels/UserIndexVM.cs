using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingForm.Models.ViewModels
{
	public class UserIndexVM
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }

		public string Name { get; set; }
	}
	public class UserVM
	{
		public int Id { get; set; }

		[EmailAddress(ErrorMessage = "Email格式有誤")]
		[Required(ErrorMessage = "帳號必填")]
		public string Account { get; set; }


		[Required(ErrorMessage = "密碼必填")]
		public string Password { get; set; }


		[Required(ErrorMessage = "姓名必填")]
		public string Name { get; set; }
	}
}
