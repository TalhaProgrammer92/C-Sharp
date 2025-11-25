namespace Cards.Utils.Text
{
    public class ColorObject
    {
        // Attributes
        public ConsoleColor ForegroundColor { get; }
        public ConsoleColor? BackgroundColor { get; }

        // Constructor
        public ColorObject(ConsoleColor fgColor, ConsoleColor? bgColor = null)
        {
            ForegroundColor = fgColor;
            BackgroundColor = bgColor;
        }
    }
}
