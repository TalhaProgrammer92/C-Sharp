using Cards.ValueObjects.Utils;

namespace Cards.Utils
{
    public class Misc
    {
        // Method - Print a message with color
        public static void PrintColoredMessage(string message, ColorObject colorObject, bool lineBreak = true)
        {
            Console.ForegroundColor = colorObject.Color;
            
            if (lineBreak)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.Write(message);
            }
            
            Console.ResetColor();
        }
    }
}
