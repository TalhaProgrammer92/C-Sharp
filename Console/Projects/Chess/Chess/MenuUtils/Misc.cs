using System;
using Chess.MenuUtils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MenuUtils
{
    class Misc
    {
        // Print a seperator line of a given symbol and size
        public static void PrintSeparator(Decorator decorator, int size)
        {
            for (int i = 0; i < size; i++)
                decorator.display();

            Console.WriteLine();
        }

        // Print a text with paddings and a decorator
        public static void PrintTextWithPadding(Text text, int padding_left, int padding_right, Decorator decorator)
        {
            /// Decorator - Left
            decorator.display();

            // Padding - Left
            for (int i = 0; i < padding_left; i++)
                Console.Write(" ");

            // Text
            text.Display();

            // Padding - Right
            for (int i = 0; i < padding_right; i++)
                Console.Write(" ");

            // Decorator - Right
            decorator.display();

            Console.WriteLine();
        }
    }
}
