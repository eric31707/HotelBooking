using BookingForm.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingForm.Models.DTOs
{
	public class UsersDTO
	{
		public class UserDTO
		{
			public int Id { get; set; }

			public string Account { get; set; }

			public string Password { get; set; }


			public string Name { get; set; }
		}
				
	}
}
