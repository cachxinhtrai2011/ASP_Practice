using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface.Buoi13
{
    public interface IVariant
    {
        int Id { get; set; }
        string Color { get; set; }
        string Size { get; set; }
        void DisplayInfo();
    }
}
