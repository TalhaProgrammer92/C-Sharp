using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.Models
{
    class Department
    {
        // Attributes
        public int Id { get; }
        public string Name { get; set; }

        // Constructor
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
