using Chess.MenuUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Chess.MenuUtils
{
    class Menu
    {
        // Attributes
        protected Header header;
        protected List<Text> options;
        protected int maxLength;

        // Constructor
        public Menu(Header header, List<Text> options)
        {
            this.header = header;
            this.options = options;
            maxLength = header.text.Length;
        }

        // Find max length
        protected void findMaxLength()
        {
            foreach (Text option in options)
            {
                if (option.text.Length > maxLength)
                    maxLength = option.text.Length;
            }
        }

        // Display the menu
        public void display()
        {
            // Display the header
            header.display();

            // Display the options
            for (int i = 0; i < options.Count; i++)
            {
                string text = $"[{i}] {options[i].text}";
                Misc.PrintTextWithPadding(
                    new Text(text, options[i].color),
                    header.padding_left,
                    Math.Abs(text.Length - maxLength) + header.padding_right,
                    header.decorator
                    );
            }

            // Separator line
            Misc.PrintSeparator(header.decorator, header.padding_left + maxLength + header.padding_right + 2);
        }
    }
}
