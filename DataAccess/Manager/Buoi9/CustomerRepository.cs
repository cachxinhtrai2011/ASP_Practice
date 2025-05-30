using DataAccess.DataObject.Buoi9;
using DataAccess.Interface.Buoi9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Manager.Buoi9
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = new();

        public void Add(Customer customer) => _customers.Add(customer);
        public void Update(Customer customer)
        {
            var index = _customers.FindIndex(c => c.Id == customer.Id);
            if (index >= 0) _customers[index] = customer;
        }
        public void Delete(Guid id) => _customers.RemoveAll(c => c.Id == id);
        public List<Customer> GetAll() => _customers;
        public Customer GetById(Guid id) => _customers.FirstOrDefault(c => c.Id == id);
    }
}
