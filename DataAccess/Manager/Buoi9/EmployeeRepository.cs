using DataAccess.DataObject.Buoi9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interface.Buoi9;

namespace DataAccess.Manager.Buoi9
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employees = new();

        public void Add(Employee employee) => _employees.Add(employee);
        public void Update(Employee employee)
        {
            var index = _employees.FindIndex(e => e.Id == employee.Id);
            if (index >= 0) _employees[index] = employee;
        }
        public void Delete(Guid id) => _employees.RemoveAll(e => e.Id == id);
        public List<Employee> GetAll() => _employees;
        public Employee GetById(Guid id) => _employees.FirstOrDefault(e => e.Id == id);
    }
}
