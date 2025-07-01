using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface.Buoi13
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        void DisplayInfo();
    }
}
