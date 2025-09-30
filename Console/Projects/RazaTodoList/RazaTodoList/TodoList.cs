using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazaTodoList
{
    class TodoList
    {
        // Attributes
        public List<Section> Sections; // A todo list contains multiple sections (multiple tasks)
        public int ActiveSectionId { get; set; } = -1; // -1 means no active section

        // Constructor
        public TodoList()
        {
            Sections = new List<Section>();
        }

        // Method - Hold Screen
        void HoldScreen(string message = "")
        {
            Console.WriteLine(message + "\nPress any key to continue...");
            Console.ReadKey();
        }

        // Method - Check active section
        public void ChangeActiveSection(int sectionId)
        {
            if (Sections.Any(s => s.Id == sectionId))
            {
                ActiveSectionId = sectionId;
                HoldScreen($"Active section changed to {sectionId}");
            }

            else
            {
                HoldScreen("Section not found!");
            }
        }

        // Method - Add a section to the todo list
        public void AddSection(Section section)
        {
            Sections.Add(section);
            ActiveSectionId = section.Id; // Set the newly added section as the active section
        }

        // Method - Remove a section from the todo list by its ID
        public void RemoveSection(int sectionId)
        {
            Sections.RemoveAll(s => s.Id == sectionId); // Fastest way to remove a section rather then using loop!
            if (ActiveSectionId == sectionId)
            {
                ActiveSectionId = Sections.Count > 0 ? Sections[0].Id : -1; // Set to first section or -1 if no sections left
            }

            HoldScreen($"Section removed! Active Section is now {ActiveSectionId}");
        }
    }
}
