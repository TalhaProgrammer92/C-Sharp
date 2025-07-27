using System;
using Chess.Menu;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Menu
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
    }
}
