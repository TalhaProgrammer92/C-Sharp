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

        // Methods - Comparision
        public static bool operator ==(Symbol symbol1, Symbol symbol2)
        {
            return symbol1.Unicode == symbol2.Unicode;
        }

        public static bool operator !=(Symbol symbol1, Symbol symbol2)
        {
            return !(symbol1 == symbol2);
        }
    }
}
