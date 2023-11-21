using SarathCodeChallenge.Database;
using SarathCodeChallenge.Entites;

namespace SarathCodeChallenge.Services
{
    public class ProductService : IProductService
    {
        private readonly MyContext context;
        public ProductService(MyContext context)
        {
            context = context;
        }
        public void AddProduct(Product product)
        {
            try
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteProduct(int productId)
        {
            try
            {
                Product product = context.Products.SingleOrDefault(p => p.ProductId == productId);
                if(product != null)
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                return context.Products.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product GetProductById(int productId)
        {
           var res = context.Products.SingleOrDefault(p=>p.ProductId == productId);
            return res;
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                if(product != null)
                {
                    context.Products.Update(product);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
