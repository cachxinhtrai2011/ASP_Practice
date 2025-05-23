using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface IEmployeeManager
    {
        void DisplayEmployees(bool ascending = true);
        void AddEmployeeFromKeyboard();
        void AddEmployeeFromExcel(string filePath);
        void DeleteEmployeeById(string id);
        void DeleteEmployeeList(List<string> idList);
    }
}
