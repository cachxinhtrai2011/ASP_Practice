﻿using DataAccess.DataObject;
using DataAccess.DataAccessLayer;
using System.Text;

namespace IMIC_LuyenTap
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DataAccess.DataAccessLayer.Bai3 _bai3 = new DataAccess.DataAccessLayer.Bai3();  
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số A: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhập số B: ");
            int b = int.Parse(Console.ReadLine()!); 
            TinhToan(a, b);

            //Buổi 3:
            Console.WriteLine("Nhập phân số thứ nhất:");
            PhanSo ps1 = NhapPhanSo();

            Console.WriteLine("Nhập phân số thứ hai:");
            PhanSo ps2 = NhapPhanSo();

            Console.WriteLine($"Tổng: {ps1} + {ps2} = {_bai3.Cong(ps1, ps2)}");
            Console.WriteLine($"Hiệu: {ps1} - {ps2} = {_bai3.Tru(ps1, ps2)}");
            Console.WriteLine($"Tích: {ps1} * {ps2} = {_bai3.Nhan(ps1, ps2)}");
            Console.WriteLine($"Thương: {ps1} / {ps2} = {_bai3.Chia(ps1, ps2)}");
        }
        static PhanSo NhapPhanSo()
        {
            Console.Write("Nhập tử số: ");
            int tu = int.Parse(Console.ReadLine());

            Console.Write("Nhập mẫu số: ");
            int mau = int.Parse(Console.ReadLine());

            return new PhanSo(tu, mau);
        }
        //Bài 1
        static void TinhToan(int a, int b)
        {
            Console.WriteLine($"Tích 2 số: {a*b}");
            Console.WriteLine($"Hiệu 2 số: {a-b}");
            Console.WriteLine($"Tổng 2 số: {a+b}");
        }

        //Bài 2 --> start
        // Hàm giải phương trình bậc 1: ax + b = 0
        public void GiaiPhuongTrinhBac1(double a, double b)
        {
            Console.WriteLine("Phương trình bậc 1: {0}x + {1} = 0", a, b);
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                else
                    Console.WriteLine("Phương trình vô nghiệm.");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Nghiệm của phương trình: x = {0}", x);
            }
        }
        // Hàm giải phương trình bậc 2: ax^2 + bx + c = 0
        public void GiaiPhuongTrinhBac2(double a, double b, double c)
        {
            Console.WriteLine("\nPhương trình bậc 2: {0}x^2 + {1}x + {2} = 0", a, b, c);
            if (a == 0)
            {
                // Nếu a == 0 thì chuyển thành phương trình bậc 1:
                GiaiPhuongTrinhBac1(b, c);
                return;
            }

            double delta = b * b - 4 * a * c;
            Console.WriteLine("Delta = {0}", delta);

            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm thực.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phương trình có nghiệm kép: x1 = x2 = {0}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt: ");
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
        }
        //Bài 2 <-- end

        //Bài 3
        public void ChuyenDoCThanhDoF(double doC)
        {
            Console.WriteLine($"Độ F: {doC * 1.8 + 32}");
        }

    }
}
