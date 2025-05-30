using DataAccess.DataObject.Buoi9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface.Buoi9
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Guid id);
        List<Product> GetAll();
        Product GetById(Guid id);
    }
}
