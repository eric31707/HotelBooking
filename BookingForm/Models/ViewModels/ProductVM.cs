using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingForm.Models.ViewModels
{
	public class ProductVM
	{
		public int Id { get; set; }
		public string Room { get; set; }
		public int Price { get; set; }
		public string City { get; set; }
		public string Name { get; set; }
		public byte[] Photo { get; set; }
	}
	public class ProductIndexVM
	{
		public int Id { get; set; }
		public string Room { get; set; }
		public int Price { get; set; }
		public string City { get; set; }
		public string Name { get; set; }
		public Image Photo { get; set; }
	}
}
