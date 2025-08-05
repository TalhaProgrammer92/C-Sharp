using CodeFirstApproach.Models.Entities;

namespace CodeFirstApproach.Services.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        string AddCustomer(Customer customer);
        string DeleteCustomer(int id);
        string UpdateCustomer(Customer customer);
    }
}
