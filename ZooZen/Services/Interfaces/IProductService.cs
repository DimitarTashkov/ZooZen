using ZooZen.Models;
using ZooZen.Models.Enums;

namespace ZooZen.Services.Interfaces
{
    /// <summary>
    /// ????????? ?? ?????????? ?? ???????? ? ZooZen
    /// </summary>
    public interface IProductService
    {
        List<Product> GetAllProducts();
        List<Product> GetProductsByCategory(ProductCategory category);
        Product? GetProductById(Guid id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Guid id);
        List<Product> SearchProducts(string searchTerm);
    }
}
