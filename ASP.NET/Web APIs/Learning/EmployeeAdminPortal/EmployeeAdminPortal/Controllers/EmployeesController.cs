using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        // Constructor for EmployeesController
        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/employees
        // Get all employees
        [HttpGet]
        public IActionResult GetEmployees()
        {
            // Retrieve all employees from the database
            var employees = dbContext.Employees.ToList();

            // If no employees are found, return an empty list
            return Ok(employees);
        }

        // GET: api/employees/{id}
        // Get employee by ID
        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            // Find the employee by ID
            var employee = dbContext.Employees.Find(id);

            // If employee is not found, return NotFound
            return (employee != null) ? Ok(employee) : NotFound();
        }

        // POST: api/employees
        // Add a new employee
        [HttpPost]
        public IActionResult AddEmployee(EmployeeDto employeeDto)
        {
            // Employe (DTO -> Entity)
            var employee = new Models.Entities.Employee
            {
                //Id = Guid.NewGuid(),
                Name = employeeDto.Name,
                Email = employeeDto.Email,
                Phone = employeeDto.Phone,
                Salary = employeeDto.Salary
            };

            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();

            return Ok(employee);
        }

        // PUT: api/employees/{id}
        // Update an existing employee
        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, EmployeeDto employeeDto)
        {
            // Find the employee by ID
            var employee = dbContext.Employees.Find(id);
            
            // If employee is not found, return NotFound
            if (employee == null)
            {
                return NotFound();
            }

            // Update employee properties
            employee.Name = employeeDto.Name;
            employee.Email = employeeDto.Email;
            employee.Phone = employeeDto.Phone;
            employee.Salary = employeeDto.Salary;
            
            dbContext.SaveChanges();

            return Ok(employee);
        }

        // DELETE: api/employees/{id}
        // Delete an employee by ID
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            // Find the employee by ID
            var employee = dbContext.Employees.Find(id);
            
            // If employee is not found, return NotFound
            if (employee == null)
            {
                return NotFound();
            }

            // Remove the employee from the database
            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();

            return Ok(employee);
        }
    }
}
