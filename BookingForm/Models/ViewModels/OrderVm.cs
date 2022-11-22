using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingForm.Models.ViewModels
{
	public class OrderVm
	{
		public int RoomId { get; set; }
		public string Room { get; set; }
		public string City { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public int Days { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime Enddate { get; set; }		
			
	}
}
