using InventoryManagement.Models.Entities;

namespace InventoryManagement.Services.Interfaces
{
    public interface ICustomer
    {
        public List<Customer> GetAll();
        public string Add(Customer customer);
        public string Update(Customer customer);
        public string Delete(Customer customer);
    }
}
