using DataAccess.Abstract.Buoi13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataObject.Buoi13
{
	public class Product : ProductBase
    {
		public List<Variant> Variants { get; set; } = new List<Variant>();

		public override void DisplayInfo()
		{
			Console.WriteLine($"Product: {Name} (ID: {Id})");
			foreach (var variant in Variants)
			{
				variant.DisplayInfo();
			}
		}
	}
}
