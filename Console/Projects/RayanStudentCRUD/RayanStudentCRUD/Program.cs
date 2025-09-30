using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RayanStudentCRUD
{
    internal class Program
    {
        static int ShowMenu()
        {
            Console.Clear();

            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Update Student");
            Console.WriteLine("3. Retrieve a Student");
            Console.WriteLine("4. Retrieve all Students");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");

            Console.Write("\nEnter your choice: ");
            int choice = 0;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input!");
            }

            return (choice < 1 || choice > 6) ? ShowMenu() : choice;
        }

        static void Main(string[] args)
        {
            Manager manager = new Manager();

            while (true)
            {
                int choice = ShowMenu();

                switch (choice)
                {
                    case 1: manager.Create(); break;        // Create and add student object
                    case 2: manager.Update(); break;        // Update a specific student data
                    case 3: manager.Retrieve(); break;      // Display a specific student
                    case 4: manager.RetrieveAll(); break;   // Display all students
                    case 5: manager.Delete(); break;        // Delete a specific student
                    case 6: return;                         // Exit the program
                }
            }
        }
    }
}
