using DataAccess.Interface.Buoi13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.Buoi13
{
    public abstract class VariantBase : IVariant
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public abstract void DisplayInfo();
    }
}
