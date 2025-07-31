using RepositoryPatternTutorial.Data;
using RepositoryPatternTutorial.Models;

namespace RepositoryPatternTutorial.Repository
{
    public class ProductService : IProductService
    {
        ProductContext context;

        public ProductService(ProductContext context) 
        {
            this.context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public Product PostProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChangesAsync();

            return product;
        }
    }
}
