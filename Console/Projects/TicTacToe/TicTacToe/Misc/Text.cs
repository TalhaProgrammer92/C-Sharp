namespace TicTacToe.Misc
{
    public class Text
    {
        // Attributes
        string? text;
        public ColorProperty ColorProperty { get; set; }

        // Constructor
        public Text()
        {
            text = null;
            ColorProperty = new ColorProperty();
        }
        public Text(string text, ColorProperty colorProperty)
        {
            this.text = text;
            this.ColorProperty = colorProperty;
        }

        // Getters and Setters
        public string Data
        {
            get { return text; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    text = value;
            }
        }

        // Comparision Operators - Overloaded
        public static bool operator==(Text A, Text B)
        {
            return A.Data == B.Data;
        }
        public static bool operator!=(Text A, Text B)
        {
            return A.Data != B.Data;
        }

        // Method - Display
        public void Display(bool lineBreak = false)
        {
            ColorProperty.Set();
            Console.Write(Data);
            if (lineBreak) Console.WriteLine();
            ColorProperty.Reset();
        }
    }
}
