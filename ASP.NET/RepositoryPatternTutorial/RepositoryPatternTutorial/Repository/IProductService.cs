using RepositoryPatternTutorial.Models;

namespace RepositoryPatternTutorial.Repository
{
    public interface IProductService
    {
        public IEnumerable<Product> GetProducts();
        public Product PostProduct(Product product);
    }
}
