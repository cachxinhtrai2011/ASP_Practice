using DataAccess.DataObject.Buoi13;
using DataAccess.Interface.Buoi13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Manager.Buoi13
{
    public class ProductManager
    {
        private List<IProduct> products = new List<IProduct>();
        private int productIdCounter = 1;
        private int variantIdCounter = 1;

        public void DisplayProducts()
        {
            Console.Write("\nFilter by color (blank = skip): ");
            string colorFilter = Console.ReadLine()?.Trim();

            Console.Write("Filter by size (blank = skip): ");
            string sizeFilter = Console.ReadLine()?.Trim();

            Console.Write("Sort by (name/size/color): ");
            string sortBy = Console.ReadLine()?.Trim().ToLower();

            Console.Write("Sort order (asc/desc): ");
            string order = Console.ReadLine()?.Trim().ToLower();

            var query = products
                .Cast<Product>()
                .SelectMany(p => p.Variants.Select(v => new
                {
                    ProductId = p.Id,
                    ProductName = p.Name,
                    VariantId = v.Id,
                    v.Color,
                    v.Size
                }));

            if (!string.IsNullOrWhiteSpace(colorFilter))
                query = query.Where(v => v.Color.Equals(colorFilter, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(sizeFilter))
                query = query.Where(v => v.Size.Equals(sizeFilter, StringComparison.OrdinalIgnoreCase));

            query = sortBy switch
            {
                "name" => order == "desc" ? query.OrderByDescending(v => v.ProductName) : query.OrderBy(v => v.ProductName),
                "size" => order == "desc" ? query.OrderByDescending(v => v.Size) : query.OrderBy(v => v.Size),
                "color" => order == "desc" ? query.OrderByDescending(v => v.Color) : query.OrderBy(v => v.Color),
                _ => query
            };

            Console.WriteLine("\n-- Product List --");
            foreach (var item in query)
            {
                Console.WriteLine($"Product: {item.ProductName} (ID: {item.ProductId}) - Variant ID: {item.VariantId}, Color: {item.Color}, Size: {item.Size}");
            }
        }

        public void AddProduct()
        {
            Console.Write("\nEnter product name: ");
            string name = Console.ReadLine();

            var product = new Product
            {
                Id = productIdCounter++,
                Name = name
            };

            Console.Write("How many variants to add? ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Variant {i + 1}:");
                Console.Write("Color: ");
                string color = Console.ReadLine();
                Console.Write("Size: ");
                string size = Console.ReadLine();

                product.Variants.Add(new Variant
                {
                    Id = variantIdCounter++,
                    Color = color,
                    Size = size
                });
            }

            products.Add(product);
            Console.WriteLine("Product added successfully!");
        }

        public void UpdateVariant()
        {
            Console.Write("\nEnter Variant ID to update: ");
            int variantId = int.Parse(Console.ReadLine());

            foreach (var product in products.Cast<Product>())
            {
                var variant = product.Variants.FirstOrDefault(v => v.Id == variantId);
                if (variant != null)
                {
                    Console.Write($"New Color (current: {variant.Color}): ");
                    variant.Color = Console.ReadLine();

                    Console.Write($"New Size (current: {variant.Size}): ");
                    variant.Size = Console.ReadLine();

                    Console.WriteLine("Variant updated successfully.");
                    return;
                }
            }

            Console.WriteLine("Variant not found.");
        }

        public void DeleteVariant()
        {
            Console.Write("\nEnter Variant ID to delete: ");
            int variantId = int.Parse(Console.ReadLine());

            foreach (var product in products.Cast<Product>())
            {
                var variant = product.Variants.FirstOrDefault(v => v.Id == variantId);
                if (variant != null)
                {
                    product.Variants.Remove(variant);
                    Console.WriteLine("Variant deleted successfully.");
                    return;
                }
            }

            Console.WriteLine("Variant not found.");
        }
    }

}
