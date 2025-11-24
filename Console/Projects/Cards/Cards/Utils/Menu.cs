namespace Cards.Utils
{
    public class Menu
    {
        // Attributes
        protected readonly List<Text> _options;
        protected readonly Text _title;
        protected readonly ColorObject _optionColor;

        // Constructor
        public Menu(Text title, ConsoleColor optionColor)
        {
            _title = title;
            _options = new List<Text>();
            _optionColor = new ColorObject(optionColor);
        }

        // Method - Add option to the menu
        public void AddOption(string optionLabel)
        {
            _options.Add(new Text(optionLabel, _optionColor));
        }
    }
}
