using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingForm.Models.ViewModels
{
	public class LoginVM
	{

		[Required(ErrorMessage = "帳號必填")]
		[EmailAddress(ErrorMessage = "Email格式不正確")]
		public string Account { get; set; }


		[Required(ErrorMessage = "密碼必填")]
		public string Password { get; set; }
	}
}
