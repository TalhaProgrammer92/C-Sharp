using Cards.ValueObjects.Utils;

namespace Cards.Utils
{
    public class Text
    {
        // Attributes
        public readonly ColorObject ColorObject;
        public string Value { get; set; }

        // Constructor
        public Text(string value, ColorObject colorObject)
        {
            Value = value;
            ColorObject = colorObject;
        }

        // Method - Display text with color
        public void Display(bool lineBreak = false)
        {
            Misc.PrintColoredMessage(Value, ColorObject, lineBreak);
        }
    }
}
