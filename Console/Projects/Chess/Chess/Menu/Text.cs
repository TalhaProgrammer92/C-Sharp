using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Menu
{
    class Text
    {
        // Attributes
        protected string text;
        protected ConsoleColor color;

        // Constructor
        public Text(string text, ConsoleColor color)
        {
            this.text = text;
            this.color = color;
        }

        // Display
        public void display(bool line_break = false)
        {
            Console.ForegroundColor = color;

            if (line_break)
                Console.WriteLine(text);
            else
                Console.Write(text);

            Console.ResetColor();
        }
    }
}
