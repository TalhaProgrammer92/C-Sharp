using CodeFirstApproach.Models;
using CodeFirstApproach.Models.Entities;
using CodeFirstApproach.Services.Interfaces;

namespace CodeFirstApproach.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomerContext context;

        // Constructor to initialize the context
        public CustomerService(CustomerContext context)
        {
            this.context = context;
        }

        // Methods to handle customer operations
        // Get: api/customer/GetCustomers
        public List<Customer> GetCustomers() => context.Customers.ToList();

        // Post: api/customer/AddCustomer
        public string AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return "Customer added successfully!";
        }

        // Delete: api/customer/DeleteCustomer
        public string DeleteCustomer(int id)
        {
            var existing = context.Customers.Find(id);
            // Check if the customer exists
            if (existing == null) return "Customer not found!";

            // Remove the customer from the database
            context.Customers.Remove(existing);
            context.SaveChanges();
            return "Customer deleted!";
        }

        // Put: api/customer/UpdateCustomer
        public string UpdateCustomer(Customer customer)
        {
            var existing = context.Customers.Find(customer.Id);
            // Check if the customer exists
            if (existing == null) return "Customer not found!";

            // Update the customer details
            existing.Name = customer.Name;
            existing.Email = customer.Email;
            existing.Phone = customer.Phone;
            context.SaveChanges();
            return "Customer updated!";
        }
    }
}
