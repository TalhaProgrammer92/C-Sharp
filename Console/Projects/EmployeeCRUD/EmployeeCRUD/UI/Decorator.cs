using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.UI
{
    class Decorator
    {
        // Attributes
        public char Symbol { get; set; }
        public Color Color { get; set; }

        // Constructor
        public Decorator(char symbol, Color color)
        {
            Symbol = symbol;
            Color = color;
        }

        // Method - Display
        public void Display()
        {
            Color.Set();

            Console.Write(Symbol);
            
            Color.Reset();
        }
    }
}
