using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternTutorial.Models;
using RepositoryPatternTutorial.Repository;

namespace RepositoryPatternTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // Attributes
        IProductService productService;

        // Constructor
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        // Get all products
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return productService.GetProducts();
        }

        // Post a new product
        [HttpPost]
        public Product PostProduct(Product product)
        {
            return productService.PostProduct(product);
        }
    }
}
