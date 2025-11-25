using Cards.Enums;
using Cards.Utils.Text;

namespace Cards.Settings
{
    public class TextColor
    {
        // Attributes
        public static readonly ColorObject Info = new ColorObject(ConsoleColor.Cyan);
        public static readonly ColorObject Warning = new ColorObject(ConsoleColor.Magenta);
        public static readonly ColorObject Error = new ColorObject(ConsoleColor.Red);
        public static readonly ColorObject Success = new ColorObject(ConsoleColor.Green);
        public static readonly ColorObject Default = new ColorObject(ConsoleColor.White);
        public static readonly ColorObject Prompt = new ColorObject(ConsoleColor.Yellow);

        public static readonly Dictionary<CardType, ColorObject> CardTypeColors = new()
        {
            { CardType.Hearts, new ColorObject(ConsoleColor.Red) },
            { CardType.Diamonds, new ColorObject(ConsoleColor.Magenta) },
            { CardType.Clubs, new ColorObject(ConsoleColor.Blue) },
            { CardType.Spades, new ColorObject(ConsoleColor.Green) }
        };
    }
}
