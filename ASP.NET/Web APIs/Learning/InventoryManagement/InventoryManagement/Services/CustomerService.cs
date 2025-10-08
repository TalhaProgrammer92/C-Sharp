using InventoryManagement.Models;
using InventoryManagement.Models.Entities;
using InventoryManagement.Services.Interfaces;

namespace InventoryManagement.Services
{
    public class CustomerService : ICustomer
    {
        readonly Models.Context.Customer context;

        public CustomerService(Models.Context.Customer context)
        {
            this.context = context;
        }

        public string Add(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return "Customer has been added successfully!";
        }

        public string Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        public string Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
