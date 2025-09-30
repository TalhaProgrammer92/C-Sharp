using CodeFirstApproach.Models.Entities;
using CodeFirstApproach.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApproach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;

        // Constructor to initialize the customer service
        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        // API Endpoints
        [HttpGet("GetCustomers")]
        public List<Customer> GetCustomers() => customerService.GetCustomers();

        // Post: api/customer/AddCustomer
        [HttpPost("AddCustomer")]
        public string AddCustomer(Customer customer) => customerService.AddCustomer(customer);

        // Delete: api/customer/DeleteCustomer/{id}
        [HttpDelete("DeleteCustomer/{id}")]
        public string DeleteCustomer(int id) => customerService.DeleteCustomer(id);

        // Put: api/customer/UpdateCustomer
        [HttpPut("UpdateCustomer")]
        public string UpdateCustomer(Customer customer) => customerService.UpdateCustomer(customer);
    }
}
