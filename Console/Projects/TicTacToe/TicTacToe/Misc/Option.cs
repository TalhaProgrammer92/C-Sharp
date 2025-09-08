using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Misc
{
    public class Option
    {
        // Attributes
        public Text option { get; }
        public bool Highlighted { get; set; }

        // Constructor
        public Option()
        {
            option = new Text();
            Highlighted = false;
        }
        public Option(Text option)
        {
            this.option = option;
            Highlighted = false;
        }

        // Method - Display
        public void Display()
        {
            if (Highlighted)
                Console.BackgroundColor = ConsoleColor.White;
            option.Display(true);
        }
    }
}
