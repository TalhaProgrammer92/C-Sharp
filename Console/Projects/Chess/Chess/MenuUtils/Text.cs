using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MenuUtils
{
    class Text
    {
        // Attributes
        public string Data { get; set; }
        public ConsoleColor color { get; }

        // Constructor
        public Text(string text, ConsoleColor color)
        {
            this.Data = text;
            this.color = color;
        }

        // Display
        public void Display(bool line_break = false)
        {
            Console.ForegroundColor = color;

            if (line_break)
                Console.WriteLine(Data);
            else
                Console.Write(Data);

            Console.ResetColor();
        }
    }
}
