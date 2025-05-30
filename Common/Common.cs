using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC_LuyenTap.Common
{
    public class Common
    {
        public bool CheckNullOrEmptyOrXSS(string value)
        {
            if(string.IsNullOrEmpty(value)) return false;
            if (value.Contains("<html>")) return false;
            return true;
        }
        public bool GetSafeInput(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Không được để trống!");
                return false;
            }

            if (value.Contains("<") || value.Contains(">") || value.Contains("\""))
            {
                Console.WriteLine("Dữ liệu không hợp lệ!");
                return false;
            }

            return true;
        }
    }
}
