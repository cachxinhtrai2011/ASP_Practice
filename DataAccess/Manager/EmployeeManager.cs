using DataAccess.DataObject;
using DataAccess.Interface;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Manager
{
    public class EmployeeManager : IEmployeeManager
    {
        private List<Employee> employees = new List<Employee>();

        public void DisplayEmployees(bool ascending = true)
        {
            var sorted = ascending
                ? employees.OrderBy(e => e.Name).ToList()
                : employees.OrderByDescending(e => e.Name).ToList();

            Console.WriteLine("DANH SÁCH NHÂN VIÊN:");
            foreach (var emp in sorted)
            {
                Console.WriteLine(emp);
            }
        }

        public void AddEmployeeFromKeyboard()
        {
            Console.Write("Nhập ID: ");
            string id = Console.ReadLine();

            Console.Write("Nhập tên: ");
            string name = Console.ReadLine();

            Console.Write("Nhập lương: ");
            if (double.TryParse(Console.ReadLine(), out double salary))
            {
                employees.Add(new Employee { ID = id, Name = name, Salary = salary });
                Console.WriteLine("Thêm thành công!");
            }
            else
            {
                Console.WriteLine("Lương không hợp lệ.");
            }
        }

        public void AddEmployeeFromExcel(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File không tồn tại.");
                return;
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var sheet = package.Workbook.Worksheets[0];
                int row = 2;
                while (sheet.Cells[row, 1].Value != null)
                {
                    string id = sheet.Cells[row, 1].Text;
                    string name = sheet.Cells[row, 2].Text;
                    double.TryParse(sheet.Cells[row, 3].Text, out double salary);

                    employees.Add(new Employee { ID = id, Name = name, Salary = salary });
                    row++;
                }
            }

            Console.WriteLine("Đã thêm dữ liệu từ file Excel.");
        }

        public void DeleteEmployeeById(string id)
        {
            var emp = employees.FirstOrDefault(e => e.ID == id);
            if (emp != null)
            {
                employees.Remove(emp);
                Console.WriteLine("Xóa thành công.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy nhân viên.");
            }
        }

        public void DeleteEmployeeList(List<string> idList)
        {
            int count = 0;
            foreach (var id in idList)
            {
                var emp = employees.FirstOrDefault(e => e.ID == id);
                if (emp != null)
                {
                    employees.Remove(emp);
                    count++;
                }
            }
            Console.WriteLine($"Đã xóa {count} nhân viên.");
        }
    }
}
