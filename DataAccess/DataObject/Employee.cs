using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataObject
{
    public class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Salary: {Salary}";
        }
    }
}
