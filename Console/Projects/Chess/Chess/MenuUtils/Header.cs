using System;
using Chess.MenuUtils;
using Chess.MiscUtils;
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

        // Get total length of the header
        public int GetTotalLength()
        {
            return padding_left + Data.Length + padding_right + 2; // +2 for the decorators on both sides
        }

        // Print separator line
        void PrintSeparator(Offset offset)
        {
            Misc.PrintSeparator(decorator, GetTotalLength() + offset.GetValue());
        }

        // Display the header
        public void display(Offset offset)
        {
            // Decorator - Top
            PrintSeparator(offset);

            Misc.PrintTextWithPadding(
                new Text(base.Data, base.color), 
                padding_left + offset.GetValue() / 2,
                padding_right + offset.GetValue() / 2 + offset.GetValue() % 2,
                decorator
                );

            // Decorator - Bottom
            PrintSeparator(offset);
        }
    }
}
