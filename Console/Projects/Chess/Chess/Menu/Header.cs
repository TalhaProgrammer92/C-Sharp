
using System;
using Chess.Menu;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace Chess.Menu
{
    class Header : Text
    {
        // Attributes
        int padding_left, padding_right;
        Decorator decorator;

        // Constructor
        public Header(string text, int padding_left, int padding_right, Decorator decorator, ConsoleColor color = ConsoleColor.White) : base(text, color)
        {
            this.padding_left = padding_left;
            this.padding_right = padding_right;
            this.decorator = decorator;
        }

        // Display the header
        public void display()
        {
            // Decorator - Top
            Misc.PrintSeparator(decorator, padding_left + text.Length + padding_right + 2);

            // Decorator - Left
            decorator.display();

            // Padding - Left
            for (int i = 0; i < padding_left; i++)
                Console.Write(" ");

            // Text
            base.display();

            // Padding - Right
            for (int i = 0; i < padding_right; i++)
                Console.Write(" ");

            // Decorator - Right
            decorator.display();
            
            Console.WriteLine();

            // Decorator - Bottom
            Misc.PrintSeparator(decorator, padding_left + text.Length + padding_right + 2);
        }
    }
}
