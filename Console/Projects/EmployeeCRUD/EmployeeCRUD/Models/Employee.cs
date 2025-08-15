using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.Models
{
    class Employee
    {
        // Attributes
        public int Id { get; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public int Salary { get; set; }

        // Constructor
        public Employee(int id, string name, int departmentId, int salary)
        {
            Id = id;
            Name = name;
            DepartmentId = departmentId;
            Salary = salary;
        }
    }
}
