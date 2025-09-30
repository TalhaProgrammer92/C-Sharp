using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToe.Misc;
using System.Threading.Tasks;

namespace TicTacToe.Menu
{
    public class Menu
    {
        // Attributes
        Text header; Text? decorator;
        List<Option> options;
        int maxLengthInOptions;

        // Constructors
        public Menu()
        {
            maxLengthInOptions = 0;
            header = new Text();
            decorator = new Text();
            options = new List<Option>();
        }
        public Menu(Text header, Text decorator)
        {
            maxLengthInOptions = 0;
            this.header = header;
            this.decorator = (decorator.Data.Length == 1) ? decorator : null;
            options = new List<Option>();
        }

        // Method - Add option
        public void AddOption(Text option)
        {
            options.Add(new Option(option));
            
            if (maxLengthInOptions < option.Data.Length)
                maxLengthInOptions = option.Data.Length;
        }

        // Method - Remove Option
        public void RemoveOption(Text option)
        {
            if (options.Count >= 0)
            {
                maxLengthInOptions = options[0].option.Data.Length;
                bool removed = false;

                for (int i = 0; i < options.Count; i++)
                {
                    // Remove the option
                    if (options[i].option == option && !removed)
                    {
                        options.RemoveAt(i);
                        removed = true;
                    }

                    // Reset the max length in options
                    if (maxLengthInOptions < options[i].option.Data.Length)
                        maxLengthInOptions = options[i].option.Data.Length;
                }
            }
        }

        // Method - Clear options
        public void ClearOptions()
        {
            options.Clear();
        }

        // Method - Get separator
        Text? GetSeparator(int size)
        {
            string sep = "";

            for (int i = 0; i < size; i++)
                sep += (decorator is null) ? "" : decorator.Data;

            return (decorator is null) ? null : new Text(sep, decorator.ColorProperty);
        }

        string GetGap(int size)
        {
            string gap = "";

            for (int i = 0; i < size; i++)
                gap += " ";

            return gap;
        }

        // Method - Display
        public void Display()
        {
            // Display Header
            Text? separator = GetSeparator(maxLengthInOptions + 4);
            if (separator is not null) separator.Display(true);

            if (decorator is not null) decorator.Display();

            Console.Write(GetGap((int) Math.Abs(header.Data.Length - (maxLengthInOptions - 2)) / 2));

            header.Display();

            Console.Write(GetGap((int)Math.Abs(header.Data.Length - (maxLengthInOptions - 2)) / 2 + maxLengthInOptions % 2));

            if (decorator is not null) decorator.Display();

            if (separator is not null) separator.Display(true);

            // Display Options
            foreach (Option option in options)
            {
                Console.Write("  ");
                option.Display();
            }
        }
    }
}
