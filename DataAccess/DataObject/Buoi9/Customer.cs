using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract.Buoi9;

namespace DataAccess.DataObject.Buoi9
{
    public class Customer : Person
    {
        public List<Order> Orders { get; set; } = new();
    }
}
