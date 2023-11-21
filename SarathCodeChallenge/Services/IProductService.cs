using SarathCodeChallenge.Entites;

namespace SarathCodeChallenge.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        void AddProduct(Product product);
        Product GetProductById(int productId);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }
}
