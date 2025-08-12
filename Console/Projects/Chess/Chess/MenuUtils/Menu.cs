using Chess.MiscUtils;

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
            maxLength = header.Data.Length;
            FindMaxLength();
        }

        // Find max length
        protected void FindMaxLength()
        {
            foreach (Text option in options)
            {
                if (option.Data.Length > maxLength)
                    maxLength = option.Data.Length;
            }
        }

        // Add an option to the menu
        public void AddOption(Text option)
        {
            options.Add(option);

            // Update max length if the new option is longer
            if (option.Data.Length > maxLength)
                maxLength = option.Data.Length;
        }

        // Display the menu
        public void Display()
        {
            // Display the header
            Offset offset = new Offset(Math.Abs(header.Data.Length - maxLength) + Convert.ToString(options.Count).Length + 3);
            header.display(offset);

            // Display the options
            for (int i = 0; i < options.Count; i++)
            {
                string text = $"[{i + 1}] {options[i].Data}";
                //int totalLength = header.padding_left + header.padding_right + text.Length;
                offset = new Offset(Math.Abs(options[i].Data.Length - maxLength));

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
            offset = new Offset(Math.Abs(header.Data.Length - maxLength) + Convert.ToString(options.Count).Length + 3);
            Misc.PrintSeparator(header.decorator, header.GetTotalLength() + offset.GetValue());
        }

        // Take input
        public int TakeInput()
        {
            int choice;
            do
            {
                char key = Console.ReadKey(true).KeyChar;   // Read a key from the console
                choice = (int)char.GetNumericValue(key);    // Direct numeric conversion

                if (choice > 0 && choice <= options.Count)
                    break;  // Valid choice, exit the loop
            }
            while (!(choice > 0 && choice <= options.Count));

            Console.Clear();  // Clear the console after input - Debugging purpose

            return choice;
        }
    }
}
