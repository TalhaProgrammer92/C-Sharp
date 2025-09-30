using Product_Layered_Architecture.Models.Entities;

namespace Product_Layered_Architecture.Data.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _context;

        public ProductRepo(AppDbContext context)
        {
            _context = context;
        }

        // Get all products list
        public IEnumerable<Product> GetAll() => _context.Products.ToList();

        // Get a product by id
        public Product? GetById(int id) => _context.Products.Find(id);

        // Add a new product
        public void Add(Product product)
        {
            _context.Products.Add(product);
        }

        // Update a product
        public void Update(Product product)
        {
            _context.Products.Update(product);
        }

        // Delete a product
        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
                _context.Products.Remove(product);
        }

        // Save changes to db-context
        public void Save() => _context.SaveChanges();
    }
}
