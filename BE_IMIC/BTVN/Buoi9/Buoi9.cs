using DataAccess.Interface.Buoi9;
using DataAccess.Manager.Buoi9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC_LuyenTap.BTVN.Buoi9
{
    public class Buoi9
    {
        private readonly IEmployeeRepository _employeeRepo = new EmployeeRepository();
        private readonly IProductRepository _productRepo = new ProductRepository();
        private readonly ICustomerRepository _customerRepo = new CustomerRepository();
        private readonly IOrderRepository _orderRepo = new OrderRepository();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Quản lý nhân viên");
                Console.WriteLine("2. Quản lý sản phẩm");
                Console.WriteLine("3. Khách mua hàng");
                Console.WriteLine("4. Xem đơn hàng");
                Console.WriteLine("5. Xuất danh sách sản phẩm, khách hàng");
                Console.WriteLine("0. Thoát");

                string choice = "0";
                switch (choice)
                {
                    case "1": ManageEmployees(); break;
                    case "2": ManageProducts(); break;
                    case "3": HandleCustomerOrder(); break;
                    case "4": ShowOrders(); break;
                    case "5": ExportData(); break;
                    case "0": return;
                    default: Console.WriteLine("Chọn sai!"); break;
                }
            }
        }

        private void ManageEmployees()
        {
            Console.WriteLine("== Quản lý Nhân viên ==");
            // Implement thêm/sửa/xóa/danh sách
        }

        private void ManageProducts()
        {
            Console.WriteLine("== Quản lý Sản phẩm ==");
            // Implement thêm/sửa/xóa/danh sách
        }

        private void HandleCustomerOrder()
        {
            Console.WriteLine("== Khách mua hàng ==");
            // Nhập đơn hàng nhiều sản phẩm
        }

        private void ShowOrders()
        {
            Console.WriteLine("== Danh sách đơn hàng ==");
            // In ra danh sách và chi tiết đơn hàng
        }

        private void ExportData()
        {
            Console.WriteLine("== Danh sách sản phẩm ==");
            foreach (var p in _productRepo.GetAll())
            {
                Console.WriteLine($"- {p.Name} | Giá: {p.Price} | SL: {p.Quantity}");
            }

            Console.WriteLine("\n== Danh sách khách hàng ==");
            foreach (var c in _customerRepo.GetAll())
            {
                Console.WriteLine($"- {c.Name} | SĐT: {c.Phone}");
            }
        }
    }
}
