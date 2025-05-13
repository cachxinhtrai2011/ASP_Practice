using DataAccess.DataObject;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace DataAccess.DataAccessLayer
{
    public class Bai4
    {
        List<Student> students = new List<Student>();
        public void AddStudentFromConsole(string name, string dobStr, string gpaStr)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                !DateTime.TryParseExact(dobStr, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime dob) ||
                !double.TryParse(gpaStr, out double gpa))
            {
                Console.WriteLine("Dữ liệu không hợp lệ!");
                return;
            }

            students.Add(new Student { Name = name, DateOfBirth = dob, GPA = gpa });
        }

        public void AddStudentFromExcel(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File không tồn tại.");
                return;
            }

            using (var package = new ExcelPackage(new FileInfo(path)))
            {
                var sheet = package.Workbook.Worksheets.First();
                int row = 2;
                while (sheet.Cells[row, 1].Value != null)
                {
                    string name = sheet.Cells[row, 1].Text.Trim();
                    string dobStr = sheet.Cells[row, 2].Text.Trim();
                    string gpaStr = sheet.Cells[row, 3].Text.Trim();

                    if (string.IsNullOrWhiteSpace(name) ||
                        !DateTime.TryParseExact(dobStr, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime dob) ||
                        !double.TryParse(gpaStr, out double gpa))
                    {
                        Console.WriteLine($"-> Lỗi ở dòng {row}: dữ liệu thiếu hoặc sai định dạng.");
                    }
                    else
                    {
                        students.Add(new Student { Name = name, DateOfBirth = dob, GPA = gpa });
                    }

                    row++;
                }
            }
        }

        public void DisplayStudents()
        {
            Console.WriteLine("\nDanh sách học sinh:");
            foreach (var s in students)
            {
                Console.WriteLine(s);
            }
        }

        public void SearchByAcademicRank(string rank)
        {
            var filtered = students.Where(s => s.GetAcademicRank().Equals(rank, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!filtered.Any())
            {
                Console.WriteLine("Không tìm thấy học sinh nào.");
                return;
            }

            Console.WriteLine($"\nDanh sách học sinh học lực {rank}:");
            foreach (var s in filtered)
                Console.WriteLine(s);

            Console.Write("Xuất ra file Excel? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                using (var package = new ExcelPackage())
                {
                    var sheet = package.Workbook.Worksheets.Add("Kết quả");
                    sheet.Cells[1, 1].Value = "Tên";
                    sheet.Cells[1, 2].Value = "Ngày sinh";
                    sheet.Cells[1, 3].Value = "Điểm";

                    for (int i = 0; i < filtered.Count; i++)
                    {
                        sheet.Cells[i + 2, 1].Value = filtered[i].Name;
                        sheet.Cells[i + 2, 2].Value = filtered[i].DateOfBirth.ToString("dd/MM/yyyy");
                        sheet.Cells[i + 2, 3].Value = filtered[i].GPA;
                    }

                    string outputPath = $"HocSinh_{rank}.xlsx";
                    File.WriteAllBytes(outputPath, package.GetAsByteArray());
                    Console.WriteLine($"Đã lưu file: {outputPath}");
                }
            }
        }
        public void SortStudentsAZ()
        {
            students.Sort((a, b) => a.Name.CompareTo(b.Name));
            Console.WriteLine("\nĐã sắp xếp tên từ A-Z.");
        }

        public void SortStudentsZA()
        {
            students.Sort((a, b) => b.Name.CompareTo(a.Name));
            Console.WriteLine("\nĐã sắp xếp tên từ Z-A.");
        }
    }
}
