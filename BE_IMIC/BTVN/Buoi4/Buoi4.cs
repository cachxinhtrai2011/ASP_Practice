using DataAccess.DataObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC_LuyenTap.BTVN.Buoi4
{
    public class Buoi4
    {
        static List<Student> students = new List<Student>();
        DataAccess.DataAccessLayer.Bai4 _bai4 = new DataAccess.DataAccessLayer.Bai4();
        public void BaiTapBuoi4()
        {

            while (true)
            {
                Console.WriteLine("\n1. Thêm học sinh từ bàn phím");
                Console.WriteLine("2. Thêm học sinh từ file Excel");
                Console.WriteLine("3. Hiển thị danh sách học sinh");
                Console.WriteLine("4. Sắp xếp theo tên A-Z");
                Console.WriteLine("5. Sắp xếp theo tên Z-A");
                Console.WriteLine("6. Tìm kiếm theo học lực và xuất Excel");
                Console.WriteLine("7. Thoát");
                Console.Write("Chọn chức năng: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddStudentFromConsole(); break;
                    case "2": AddStudentFromExcel(); break;
                    case "3": DisplayStudents(); break;
                    case "4": SortStudentsAZ(); break;
                    case "5": SortStudentsZA(); break;
                    case "6": SearchByAcademicRank(); break;
                    case "7": return;
                    default: Console.WriteLine("Chọn sai. Nhập lại."); break;
                }
            }
        }
        public void AddStudentFromConsole()
        {
            Console.Write("Nhập tên: ");
            string name = Console.ReadLine();
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            string dobStr = Console.ReadLine();
            Console.Write("Nhập điểm: ");
            string gpaStr = Console.ReadLine();

            _bai4.AddStudentFromConsole(name, dobStr, gpaStr);
        }

        public void AddStudentFromExcel()
        {
            Console.Write("Nhập đường dẫn file Excel: ");
            string path = Console.ReadLine();
            _bai4.AddStudentFromExcel(path);
            
        }

        public void DisplayStudents()
        {
            _bai4.DisplayStudents();
        }

        public void SearchByAcademicRank()
        {
            Console.Write("Nhập học lực cần tìm (Giỏi/Khá/Trung bình/Yếu): ");
            string rank = Console.ReadLine().Trim();
            _bai4.SearchByAcademicRank(rank);
        }
        public void SortStudentsAZ()
        {
            _bai4.SortStudentsAZ();
        }

        public void SortStudentsZA()
        {
            _bai4.SortStudentsZA();
        }
    }
}
