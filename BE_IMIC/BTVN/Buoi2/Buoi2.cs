using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC_LuyenTap.BTVN.Buoi2
{
    internal class Buoi2
    {
        //Bái 4
        public void TinhGiaiThua(int n)
        {
            int result = n;
            for (int i = 2; i < n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Giai thừa của {n}: {result}");
        }

        //Bài 5
        public void LietKeSoNguyenTo(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if(KiemTraSNT(i)) Console.WriteLine(i);
            }
        }

        //Bài 6
        public void KiemTraSoChanLe(int n)
        {
            if(n%2==0)
            {
                Console.WriteLine("Số chẵn");
            }
            else
            {
                Console.WriteLine("Số lẻ");
            }
        }

        //Bài 7
        public bool KiemTraSNT(int n)
        {
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        //Bài 8
        public void InMangChanLe(int[] n)
        {
            for(int i = 2; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    Console.WriteLine($"Mảng chẵn: {n[i]}");
                }
                else
                {
                    Console.WriteLine($"Mảng lẻ: {n[i]}");
                }
            }
        }
        //Bài 9
        public void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void SapXepMang(int[] n)
        {
            for(int i = 0; i < n.Length - 1; i++)
            {
                for(int j = i + 1; j < n.Length; j++)
                {
                    Swap(n[i], n[j]);
                }
            }
        }
        //Bài 10

    }
}
