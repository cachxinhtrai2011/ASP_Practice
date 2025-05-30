using DataAccess.DataObject.Buoi9;
using DataAccess.Interface.Buoi9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Manager.Buoi9
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new();

        public void Add(Product product) => _products.Add(product);
        public void Update(Product product)
        {
            var index = _products.FindIndex(p => p.Id == product.Id);
            if (index >= 0) _products[index] = product;
        }
        public void Delete(Guid id) => _products.RemoveAll(p => p.Id == id);
        public List<Product> GetAll() => _products;
        public Product GetById(Guid id) => _products.FirstOrDefault(p => p.Id == id);
    }

}
