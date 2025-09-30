using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazaTodoList
{
    class Menu
    {
        // Method - Display Main Menu
        public static void MainMenu()
        {
            Console.WriteLine("=== Main Menu ===");
            Console.WriteLine("1. View Section");
            Console.WriteLine("2. View All Sections");
            Console.WriteLine("3. Add Section");
            Console.WriteLine("4. Remove Section");
            Console.WriteLine("5. Select Section");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
        }

        // Method - Display Section Menu
        public static void SectionMenu(string sectionName)
        {
            Console.WriteLine($"=== Section: {sectionName} ===");
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Update Task");
            Console.WriteLine("5. Mark All as Completed");
            Console.WriteLine("6. Mark All as Pending");
            Console.WriteLine("7. Back to Main Menu");
            Console.Write("Choose an option: ");
        }

        // Method - Take input for menus
        public static int TakeInput(int min, int max)
        {
            int choice;

            while (true)
            {
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    // when user enters a number outside the range
                    if (choice < min || choice > max)
                    {
                        Console.WriteLine($"Please enter a number between {min} and {max}.");
                        continue;
                    }
                    break;
                }
                // when user enters a non-integer value
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                // when user enters a very large number
                catch (OverflowException)
                {
                    Console.WriteLine("Number too large. Please enter a smaller number.");
                }
            }
            return choice;
        }
    }
}
