using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.UI
{
    class Color
    {
        // Attributes
        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }

        // Constructor
        public Color(ConsoleColor foregroundColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroundColor;
        }

        // Method - Set
        public void Set()
        {
            Console.ForegroundColor = ForegroundColor;
            Console.BackgroundColor = BackgroundColor;
        }

        // Method - Reset
        public void Reset()
        {
            Console.ResetColor();
        }
    }
}
