using Cards.ValueObjects.Utils;

namespace Cards.Settings
{
    public class TextColor
    {
        // Attributes
        public static readonly ColorObject Info = new ColorObject(ConsoleColor.Cyan);
        public static readonly ColorObject Warning = new ColorObject(ConsoleColor.Yellow);
        public static readonly ColorObject Error = new ColorObject(ConsoleColor.Red);
        public static readonly ColorObject Success = new ColorObject(ConsoleColor.Green);
        public static readonly ColorObject Default = new ColorObject(ConsoleColor.White);
    }
}
