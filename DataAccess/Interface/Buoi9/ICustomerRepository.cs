using DataAccess.DataObject.Buoi9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface.Buoi9
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Guid id);
        List<Customer> GetAll();
        Customer GetById(Guid id);
    }
}
