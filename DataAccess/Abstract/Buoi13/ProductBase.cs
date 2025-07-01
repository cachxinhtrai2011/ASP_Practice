using DataAccess.Interface.Buoi13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.Buoi13
{
    public abstract class ProductBase : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void DisplayInfo();
    }
}
