using Cards.Enums;
using Cards.Utils.Text;

namespace Cards.Settings
{
    public class TextSettings
    {
        // Attributes
        public static readonly ColorObject Info = new ColorObject(ConsoleColor.DarkCyan);
        public static readonly ColorObject Warning = new ColorObject(ConsoleColor.DarkYellow);
        public static readonly ColorObject Error = new ColorObject(ConsoleColor.DarkRed);
        public static readonly ColorObject Success = new ColorObject(ConsoleColor.DarkGreen);
        public static readonly ColorObject Default = new ColorObject(ConsoleColor.White);
        public static readonly ColorObject Prompt = new ColorObject(ConsoleColor.Cyan);
        public static readonly ColorObject Heading = new ColorObject(
            fgColor: ConsoleColor.Black,
            bgColor: ConsoleColor.White);

        public static readonly char HeadingDecorator = '*';

        public static readonly Dictionary<CardType, ColorObject> CardTypeColors = new()
        {
            { CardType.Hearts, new ColorObject(ConsoleColor.Red) },
            { CardType.Diamonds, new ColorObject(ConsoleColor.Magenta) },
            { CardType.Clubs, new ColorObject(ConsoleColor.Blue) },
            { CardType.Spades, new ColorObject(ConsoleColor.Green) }
        };
    }
}
