using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingForm.Models.ViewModels
{
	public class BookingFormVM
	{
		public int Id { get; set; }
		public string Room { get; set; }
		public int Price { get; set; }
		public string City { get; set; }
		public string Name { get; set; }
	
	}
	public class BookingIndexVM
	{
		public int Id { get; set; }
		public string Room { get; set; }
		public int Price { get; set; }
		public string City { get; set; }
		public string Name { get; set; }
		}
}
