using Cards.Utils.Text;

namespace Cards.Utils.Menu
{
    public class MenuOption
    {
        // Attributes
        public string Label { get; }
        public readonly ColorObject? ColorObject;
        public Enums.Action Action { get; }
        public Text.Text Text => new Text.Text(Label, Settings.MenuSettings.MenuOptionColor);

        // Constructor
        public MenuOption(string label, Enums.Action action, ColorObject? colorObject = null)
        {
            Label = label;
            Action = action;
            ColorObject = colorObject;
        }
    }
}
