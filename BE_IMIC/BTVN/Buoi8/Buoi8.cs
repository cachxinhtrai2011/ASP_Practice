using DataAccess.Interface;
using DataAccess.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC_LuyenTap.BTVN.Buoi8
{
    public class Buoi8
    {
        public void EmployeeManager()
        {
            EmployeeManager manager = new EmployeeManager();
            while (true)
            {
                Console.WriteLine("\n----- MENU -----");
                Console.WriteLine("1. Hiển thị danh sách (A-Z)");
                Console.WriteLine("2. Hiển thị danh sách (Z-A)");
                Console.WriteLine("3. Thêm nhân viên (bàn phím)");
                Console.WriteLine("4. Thêm nhân viên (file Excel)");
                Console.WriteLine("5. Xóa nhân viên theo ID");
                Console.WriteLine("6. Xóa theo danh sách ID");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        manager.DisplayEmployees(true);
                        break;
                    case "2":
                        manager.DisplayEmployees(false);
                        break;
                    case "3":
                        manager.AddEmployeeFromKeyboard();
                        break;
                    case "4":
                        Console.Write("Nhập đường dẫn file Excel: ");
                        string path = Console.ReadLine();
                        manager.AddEmployeeFromExcel(path);
                        break;
                    case "5":
                        Console.Write("Nhập ID cần xóa: ");
                        string id = Console.ReadLine();
                        manager.DeleteEmployeeById(id);
                        break;
                    case "6":
                        Console.Write("Nhập các ID cần xóa (cách nhau bằng dấu phẩy): ");
                        var list = Console.ReadLine().Split(',').Select(s => s.Trim()).ToList();
                        manager.DeleteEmployeeList(list);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("❌ Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
    }
}
