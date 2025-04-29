using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataObject
{
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }
        public PhanSo(int tuSo, int mauSo)
        {
            if (mauSo == 0)
                throw new ArgumentException("Mẫu số không được bằng 0.");
            TuSo = tuSo;
            MauSo = mauSo;
        }
    }
}
