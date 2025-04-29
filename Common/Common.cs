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
    }
}
