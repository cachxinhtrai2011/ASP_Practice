using DataAccess.DataObject.Buoi9;
using DataAccess.Interface.Buoi9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.Buoi9
{
    public class Order : IEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } = new();
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
