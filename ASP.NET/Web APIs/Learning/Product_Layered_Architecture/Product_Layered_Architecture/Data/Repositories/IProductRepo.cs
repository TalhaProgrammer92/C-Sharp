using Product_Layered_Architecture.Models.Entities;

namespace Product_Layered_Architecture.Data.Repositories
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAll();
        Product? GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        void Save();
    }
}
