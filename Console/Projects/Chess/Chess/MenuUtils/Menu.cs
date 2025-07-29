using Chess.MiscUtils;
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
            FindMaxLength();
        }

        // Find max length
        protected void FindMaxLength()
        {
            foreach (Text option in options)
            {
                if (option.text.Length > maxLength)
                    maxLength = option.text.Length;
            }
        }

        // Add an option to the menu
        public void AddOption(Text option)
        {
            options.Add(option);
            
            // Update max length if the new option is longer
            if (option.text.Length > maxLength)
                maxLength = option.text.Length;
        }

        // Display the menu
        public void display()
        {
            // Display the header
            Offset offset = new Offset(Math.Abs(header.text.Length - maxLength) + Convert.ToString(options.Count).Length + 3);
            header.display(offset);

            // Display the options
            for (int i = 0; i < options.Count; i++)
            {
                string text = $"[{i}] {options[i].text}";
                //int totalLength = header.padding_left + header.padding_right + text.Length;
                offset = new Offset(Math.Abs(options[i].text.Length - maxLength));

                // Debugging purpose
                //Console.WriteLine($"Text: {text.Length} - Padding (Left): {header.padding_left} - Padding (Right): {header.padding_right} - Total: {totalLength} - Max (Text): {maxLength} - Max (Length): {GetMaxLength()} - Offset: {offset.GetValue()}");

                Misc.PrintTextWithPadding(
                    new Text(text, options[i].color),
                    header.padding_left,
                    header.padding_right + offset.GetValue(),
                    header.decorator
                    );
            }

            // Separator line
            offset = new Offset(Math.Abs(header.text.Length - maxLength) + Convert.ToString(options.Count).Length + 3);
            Misc.PrintSeparator(header.decorator, header.GetTotalLength() + offset.GetValue());
        }
    }
}
