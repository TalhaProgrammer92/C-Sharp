
using System;
using Chess.MenuUtils;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace Chess.MenuUtils
{
    class Header : Text
    {
        // Attributes
        public int padding_left { get; }
        public int padding_right { get; }
        public Decorator decorator { get; }

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

            // Text with padding
            Misc.PrintTextWithPadding(
                new Text(base.text, base.color), 
                padding_left, 
                padding_right, 
                decorator
                );

            // Decorator - Bottom
            Misc.PrintSeparator(decorator, padding_left + text.Length + padding_right + 2);
        }
    }
}
