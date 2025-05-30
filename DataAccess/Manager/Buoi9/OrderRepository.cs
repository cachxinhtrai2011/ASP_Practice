using DataAccess.Abstract.Buoi9;
using DataAccess.Interface.Buoi9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Manager.Buoi9
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new();

        public void Add(Order order) => _orders.Add(order);
        public void Update(Order order)
        {
            var index = _orders.FindIndex(o => o.Id == order.Id);
            if (index >= 0) _orders[index] = order;
        }
        public void Delete(Guid id) => _orders.RemoveAll(o => o.Id == id);
        public List<Order> GetAll() => _orders;
        public Order GetById(Guid id) => _orders.FirstOrDefault(o => o.Id == id);
    }
}
