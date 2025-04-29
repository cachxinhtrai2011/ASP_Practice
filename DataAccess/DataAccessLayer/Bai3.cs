using DataAccess.DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccessLayer
{
    public class Bai3
    {
        // Phép cộng
        public PhanSo Cong(PhanSo _phanSoA, PhanSo _phanSoB)
        {
            int tu = 0;
            int mau = 0;
            try
            {
                tu = _phanSoA.TuSo * _phanSoB.MauSo + _phanSoB.TuSo * _phanSoA.MauSo;
                mau = _phanSoA.MauSo * _phanSoB.MauSo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi hàm Cộng phân số: {ex.Message}");
            }
            return new PhanSo(tu, mau);
        }

        // Phép trừ
        public PhanSo Tru(PhanSo _phanSoA, PhanSo _phanSoB)
        {
            int tu = 0;
            int mau = 0;
            try
            {
                tu = _phanSoA.TuSo * _phanSoB.MauSo - _phanSoB.TuSo * _phanSoA.MauSo;
                mau = _phanSoA.MauSo * _phanSoB.MauSo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi hàm Tru phân số: {ex.Message}");
            }
            return new PhanSo(tu, mau);
        }

        // Phép nhân
        public PhanSo Nhan(PhanSo _phanSoA, PhanSo _phanSoB)
        {
            int tu = 0;
            int mau = 0;
            try
            {
                tu = _phanSoA.TuSo * _phanSoB.TuSo;
                mau = _phanSoA.MauSo * _phanSoB.MauSo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi hàm Nhân phân số: {ex.Message}");
            }
            return new PhanSo(tu, mau);
        }

        // Phép chia
        public PhanSo Chia(PhanSo _phanSoA, PhanSo _phanSoB)
        {
            int tu = 0;
            int mau = 0;
            try
            {
                if (_phanSoB.TuSo == 0)
                    throw new DivideByZeroException("Không thể chia cho phân số có tử số bằng 0.");
                tu = _phanSoA.TuSo * _phanSoB.MauSo;
                mau = _phanSoA.MauSo * _phanSoB.TuSo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi hàm Nhân phân số: {ex.Message}");
            }
            return new PhanSo(tu, mau);
        }
    }
}
