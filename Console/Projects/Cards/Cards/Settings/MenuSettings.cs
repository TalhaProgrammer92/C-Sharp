using Cards.Utils.Text;

namespace Cards.Settings
{
    public class MenuSettings
    {
        // Attributes
        public static readonly ColorObject MenuTitleColor = new ColorObject(ConsoleColor.DarkBlue, ConsoleColor.White);
        public static readonly ColorObject MenuOptionColor = new ColorObject(ConsoleColor.DarkCyan);
        public static readonly ColorObject MenuLabelColor = new ColorObject(ConsoleColor.DarkYellow);
        
        public static readonly char MainMenuDecorator = '=';
        public static readonly char SubMenuDecorator = '-';
        public static readonly char SimpleMenuDecorator = '+';
        public static readonly char DefaultMenuDecorator = ' ';
    }
}
