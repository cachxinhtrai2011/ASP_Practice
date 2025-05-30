using DataAccess.DataObject.Buoi9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface.Buoi9
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Guid id);
        List<Employee> GetAll();
        Employee GetById(Guid id);
    }
}
