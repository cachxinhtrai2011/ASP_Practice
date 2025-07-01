using DataAccess.DataObject.Buoi13;
using DataAccess.DataObject.Buoi9;
using DataAccess.Interface.Buoi13;
using DataAccess.Manager.Buoi13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC_LuyenTap.BTVN.Buoi13
{
    public class Buoi13
    {
        ProductManager manager = new ProductManager();

        public void ProcessInput()
        {
            while (true)
            {
                Console.WriteLine("\n=== PRODUCT MANAGEMENT MENU ===");
                Console.WriteLine("1. Display products");
                Console.WriteLine("2. Add product with variants");
                Console.WriteLine("3. Update a variant");
                Console.WriteLine("4. Delete a variant");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": manager.DisplayProducts(); break;
                    case "2": manager.AddProduct(); break;
                    case "3": manager.UpdateVariant(); break;
                    case "4": manager.DeleteVariant(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid choice."); break;
                }
            }
        }
    }
}
