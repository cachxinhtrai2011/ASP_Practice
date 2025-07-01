using DataAccess.Abstract.Buoi13;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataObject.Buoi13
{
    public class Variant : VariantBase
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"  Variant ID: {Id}, Color: {Color}, Size: {Size}");
        }
    }
}
