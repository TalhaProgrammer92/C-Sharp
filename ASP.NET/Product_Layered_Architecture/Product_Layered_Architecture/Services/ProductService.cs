using Product_Layered_Architecture.Data.Repositories;
using Product_Layered_Architecture.Models.Entities;

namespace Product_Layered_Architecture.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _repository;

        public ProductService(IProductRepo repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll().Where(p => p.IsActive); // Get only active products - Business Rule
        }

        public Product? GetById(int id) => _repository.GetById(id);

        public void Create(Product product)
        {
            _repository.Add(product);
            _repository.Save();
        }

        public void Update(Product product)
        {
            _repository.Update(product);
            _repository.Save();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }
    }
}
