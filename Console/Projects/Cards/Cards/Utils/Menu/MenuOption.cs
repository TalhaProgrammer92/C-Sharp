namespace Cards.Utils.Menu
{
    public class MenuOption
    {
        // Attributes
        public string Label { get; }
        public Enums.Action Action { get; }
        public Text.Text Text => new Text.Text(Label, Settings.MenuSettings.MenuOptionColor);

        // Constructor
        public MenuOption(string label, Enums.Action action)
        {
            Label = label;
            Action = action;
        }
    }
}
