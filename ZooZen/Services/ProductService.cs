using Microsoft.EntityFrameworkCore;
using ZooZen.Data;
using ZooZen.Models;
using ZooZen.Models.Enums;
using ZooZen.Services.Interfaces;

namespace ZooZen.Services
{
    /// <summary>
    /// Service for product management in ZooZen
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly ZooZenDbContext _context;

        public ProductService(ZooZenDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public List<Product> GetProductsByCategory(ProductCategory category)
        {
            return _context.Products
                .Where(p => p.Category == category)
                .ToList();
        }

        public Product? GetProductById(Guid id)
        {
            return _context.Products.Find(id);
        }

        public void AddProduct(Product product)
        {
            if (product.Id == Guid.Empty)
                product.Id = Guid.NewGuid();

            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            var existing = _context.Products.Find(product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Description = product.Description;
                existing.Price = product.Price;
                existing.StockQuantity = product.StockQuantity;
                existing.ImageUrl = product.ImageUrl;
                existing.Category = product.Category;
                _context.SaveChanges();
            }
        }

        public void DeleteProduct(Guid id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public List<Product> SearchProducts(string searchTerm)
        {
            return _context.Products
                .Where(p => p.Name.Contains(searchTerm) ||
                            (p.Description != null && p.Description.Contains(searchTerm)))
                .ToList();
        }
    }
}
