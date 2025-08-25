using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace RazaTodoList
{
    class Section
    {
        // Attributes
        List<Task> Tasks;
        public string? Name { get; set; } = null;
        public int Id { get; set; }

        // Constructor
        public Section(int id, string name)
        {
            Id = id;
            Name = name;
            Tasks = new List<Task>();
        }
        public Section() 
        {
            Tasks = new List<Task>();
        }

        // Method - Hold Screen
        void HoldScreen(string message = "")
        {
            Console.WriteLine(message + "\nPress any key to continue...");
            Console.ReadKey();
        }

        // Method - Add a task to the section
        public void AddTask()
        {
            Task newTask = new Task();

            Console.WriteLine("Enter task description: ");
            newTask.Description = Console.ReadLine() ?? "";
            newTask.Id = Tasks.Count + 1;

            HoldScreen("Task added successfully!");
        }

        // Method - Remove a task from the section by its ID
        public void RemoveTask(int taskId)
        {
            Tasks.RemoveAll(t => t.Id == taskId);   // Fastest way to remove a task rather then using loop!

            HoldScreen("Task removed successfully!");
        }

        // Method - Update a task's attributes by its ID
        public void UpdateTask(int taskId)
        {
            Task? taskToUpdate = Tasks.Find(t => t.Id == taskId);
            
            if (taskToUpdate != null)
            {
                taskToUpdate = new Task();

                Console.WriteLine("Enter new task description: ");
                taskToUpdate.Description = Console.ReadLine() ?? taskToUpdate.Description;

                Console.WriteLine("Completion Status (0, 1): ");
                taskToUpdate.IsCompleted = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

                HoldScreen("Task updated successfully!");
            }
            else
            {
                HoldScreen($"Task with ID {taskId} not found.");
            }
        }

        // Method - Mark all as completed
        public void MarkAllAsCompleted()
        {
            foreach (var task in Tasks)
            {
                task.IsCompleted = true;
            }

            HoldScreen("All tasks marked as completed!");
        }

        // Method - Mark all as pending
        public void MarkAllAsPending()
        {
            foreach (var task in Tasks)
            {
                task.IsCompleted = false;
            }

            HoldScreen("All tasks marked as pending!");
        }

        // Method - Display section information
        public override string ToString()
        {
            return $"Id:\t{Id}\nSection:\t{Name}\nTotal Tasks:\t{Tasks.Count}";
        }

        // Method - Display all tasks
        public void DisplayAllTasks()
        {
            Console.WriteLine($"Section: {Name} (ID: {Id})");
            
            foreach (var task in Tasks)
            {
                Console.WriteLine(task);
                Console.WriteLine("--------------------");
            }

            if (Tasks.Count == 0)
            {
                HoldScreen("No tasks available in this section.");
            }
            else
            {
                HoldScreen();
            }
        }

        // Method - Display a particular task by its ID
        public void DisplayTask(int taskId)
        {
            Task? taskToDisplay = Tasks.FirstOrDefault(t => t.Id == taskId);
            
            if (taskToDisplay != null)
            {
                Console.WriteLine(taskToDisplay);
                HoldScreen();
            }
            else
            {
                HoldScreen($"Task with ID {taskId} not found.");
            }
        }

        // Method - Display all pending tasks
        public void DisplayPendingTasks()
        {
            var pendingTasks = Tasks.Where(t => !t.IsCompleted).ToList();   // Returns a list of pending tasks
            Console.WriteLine($"Pending Tasks in Section: {Name} (ID: {Id})");
            
            foreach (var task in pendingTasks)
            {
                Console.WriteLine(task);
                Console.WriteLine("--------------------");
            }

            if (pendingTasks.Count == 0)
            {
                HoldScreen("No pending tasks available in this section.");
            }
            else
            {
                HoldScreen();
            }
        }

        // Method - Display all completed tasks
        public void DisplayCompletedTasks()
        {
            var completedTasks = Tasks.Where(t => t.IsCompleted).ToList();   // Returns a list of completed tasks
            Console.WriteLine($"Completed Tasks in Section: {Name} (ID: {Id})");

            foreach (var task in completedTasks)
            {
                Console.WriteLine(task);
                Console.WriteLine("--------------------");
            }

            if (completedTasks.Count == 0)
            {
                HoldScreen("No completed tasks available in this section.");
            }
            else
            {
                HoldScreen();
            }
        }
    }
}
