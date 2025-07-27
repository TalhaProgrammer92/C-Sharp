using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Menu
{
    class Decorator
    {
        // Attributes
        char decorator;
        ConsoleColor color;

        // Constructor
        public Decorator(char decorator, ConsoleColor color = ConsoleColor.White)
        {
            this.decorator = decorator;
            this.color = color;
        }

        // Display the decorator
        public void display()
        {
            Console.ForegroundColor = color;
            Console.Write(decorator);
            Console.ResetColor();
        }
    }
}
