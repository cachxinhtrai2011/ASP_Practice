using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Common
{
    public class ValidatePhanSo
    {
        // Rút gọn phân số
        //public PhanSo RutGon(PhanSo _phanSo)
        //{
        //    int ucln = UCLN(Math.Abs(_phanSo.TuSo), Math.Abs(_phanSo.MauSo));
        //    _phanSo.TuSo /= ucln;
        //    _phanSo.MauSo /= ucln;

        //    // Đảm bảo mẫu số luôn dương
        //    if (_phanSo.MauSo < 0)
        //    {
        //        _phanSo.TuSo = -_phanSo.TuSo;
        //        _phanSo.MauSo = -_phanSo.MauSo;
        //    }
        //    return new PhanSo(_phanSo.TuSo, _phanSo.MauSo);
        //}

        // Tìm ước chung lớn nhất
        public int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
    }
}
