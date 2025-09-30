using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazaTodoList
{
    class Task
    {
        // Attributes
        public int Id { get; set; }
        public string? Description { get; set; } = null;
        public bool IsCompleted { get; set; }

        // Constructor
        public Task(int id, string description)
        {
            Id = id;
            Description = description;
            IsCompleted = false;
        }
        public Task(Task task)
        {
            Id = task.Id;
            Description = task.Description;
            IsCompleted = task.IsCompleted;
        }
        public Task() { }

        // Method - Display task information
        public override string ToString()
        {
            return $"Id:\t{Id}\nTask:\t{Description}\nStatus:\t{(IsCompleted ? "Completed" : "Pending")}";
        }
    }
}
