using Product_Layered_Architecture.Models.Entities;

namespace Product_Layered_Architecture.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        //public IEnumerable<Product> GetByPrice(int price);
        Product? GetById(int id);
        void Create(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
