using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Misc
{
    public class ColorProperty
    {
        // Attributes
        public ConsoleColor? Foreground { get; set; }
        public ConsoleColor? Background { get; set; }

        // Constructor
        public ColorProperty()
        {
            Foreground = null;
            Background = null;
        }
        public ColorProperty(ConsoleColor fg, ConsoleColor bg)
        {
            Foreground = fg;
            Background = bg;
        }

        // Set
        public void Set()
        {
            if (Foreground is not null)
                Console.ForegroundColor = (ConsoleColor)Foreground;
            if (Background is not null)
                Console.BackgroundColor = (ConsoleColor)Background;
        }

        // Reset
        public void Reset()
        {
            Console.ResetColor();
        }
    }
}
