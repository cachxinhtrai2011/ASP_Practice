using DataAccess.Abstract.Buoi9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface.Buoi9
{
    public interface IOrderRepository
    {
        void Add(Order order);
        void Update(Order order);
        void Delete(Guid id);
        List<Order> GetAll();
        Order GetById(Guid id);
    }
}
