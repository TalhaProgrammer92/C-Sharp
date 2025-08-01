using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MiscUtils
{
    class Symbol
    {
        // Attributes
        public string Unicode {  get; set; }
        public ConsoleColor Color { get; set; }

        // Constructor
        public Symbol(string unicode, ConsoleColor color)
        {
            Unicode = unicode;
            Color = color;
        }

        // Method - Display
        public void Display()
        {
            Console.ForegroundColor = Color;
            Console.Write(Unicode);
            Console.ResetColor();
        }
    }
}
