using ProductServiceDeployment.Data;
using ProductServiceDeployment.Models;
using ProductServiceDeployment.Operations;

namespace ProductServiceDeployment.Service
{
    public class ProductServices : IProductOperation
    {
        private readonly ProductDbContext productDbContext;

        public ProductServices(ProductDbContext productDbContext)
        {
            this.productDbContext = productDbContext;
        }

        public List<Product> GetAllProducts()
        {
            return productDbContext.Products.ToList();
        }

        public int CreateProduct(Product product)
        {
            productDbContext.Products.Add(product);
            return productDbContext.SaveChanges();
        }
    }
}