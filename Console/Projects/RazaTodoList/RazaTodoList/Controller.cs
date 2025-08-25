using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazaTodoList
{
    class Controller
    {
        // Attributes
        public TodoList todoList; // A controller contains a todo list
        Section? activeSection;

        // Constructor
        public Controller()
        {
            todoList = new TodoList();
            activeSection = null;
        }

        // Method - Hold the screen
        void HoldScreen(string message = "")
        {
            Console.WriteLine(message + "\nPress any key to continue...");
            Console.ReadKey();
        }

        // Method - Start the application
        public void StartApplication()
        {
            while (true)
            {
                HandleMainMenuChoice();
            }
        }

        // Method - Handle Main Menu choices
        void HandleMainMenuChoice()
        {
            Console.Clear();
            Menu.MainMenu();
            int choice = Menu.TakeInput(1, 5);

            switch (choice)
            {
                case 1:
                    ViewSection();
                    break;
                case 2:
                    ViewSections();
                    break;
                case 3:
                    AddSection();
                    break;
                case 4:
                    RemoveSection();
                    break;
                case 5:
                    SelectSection();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
        }

        private void ViewSection()
        {
            if (todoList.ActiveSectionId != -1)
            {
                HandleSectionChoice(todoList.ActiveSectionId);
            }
            else
            {
                HoldScreen("No active section. Please add and select a section first.");
            }
        }

        private void SelectSection()
        {
            Console.WriteLine("Enter section id: ");
            int sectionId = Convert.ToInt32(Console.ReadLine());

            todoList.ChangeActiveSection(sectionId);
        }

        private void RemoveSection()
        {
            Console.WriteLine("Enter section id: ");
            int sectionId = Convert.ToInt32(Console.ReadLine());

            todoList.RemoveSection(sectionId);
        }

        private void AddSection()
        {
            Section newSection = new Section();

            Console.WriteLine("Enter section name: ");
            newSection.Name = Console.ReadLine() ?? "";
            newSection.Id = todoList.Sections.Count + 1;

            todoList.AddSection(newSection);

            HoldScreen("Section added successfully!");
        }

        // Method - Handle Section choices
        void HandleSectionChoice(int sectionID)
        {
            activeSection = todoList.Sections.Find(s => s.Id == sectionID);
            
            if (activeSection == null)
            {
                Console.WriteLine($"Section with ID {sectionID} not found.");
                HoldScreen();
                return;
            }

            while (true)
            {
                Console.Clear();
                Menu.SectionMenu(activeSection.Name!);
                int choice = Menu.TakeInput(1, 5);
                switch (choice)
                {
                    case 1:
                        activeSection.DisplayAllTasks();
                        break;
                    case 2:
                        activeSection.AddTask();
                        break;
                    case 3:
                        RemoveTask();
                        break;
                    case 4:
                        UpdateTask();
                        break;
                    case 5:
                        activeSection.MarkAllAsCompleted();
                        break;
                    case 6:
                        activeSection.MarkAllAsPending();
                        break;
                    case 7:
                        return; // Back to Main Menu
                    default:
                        HoldScreen("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void UpdateTask()
        {
            Console.WriteLine("Enter task id: ");
            int taskId = Convert.ToInt32(Console.ReadLine());

            activeSection!.UpdateTask(taskId);
        }

        private void RemoveTask()
        {
            Console.WriteLine("Enter task id: ");
            int taskId = Convert.ToInt32(Console.ReadLine());

            activeSection!.RemoveTask(taskId);
        }

        private void ViewSections()
        {
            Console.Clear();
            
            foreach (var section in todoList.Sections)
            {
                Console.WriteLine(section);
            }

            HoldScreen();
        }
    }
}
