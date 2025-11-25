using Cards.Utils.Text;

namespace Cards.Utils.Menu
{
    public class GameMenu
    {
        // Attributes
        protected readonly List<Text.Text> _options;
        protected readonly MenuTitle _title;
        protected Padding Padding => Misc.GetMenuTitlePadding(
            GetLongestOptionLength(), _options.Count
        );

        // Constructor
        public GameMenu(string title)
        {
            _title = new MenuTitle(title);
            _options = new List<Text.Text>();
        }

        // Method - Add option to the menu
        protected void AddOption(string optionLabel)
        {
            _options.Add(new Text.Text(optionLabel, Settings.MenuSettings.MenuOptionColor));
        }

        // Method - Display the menu
        protected void Display(char? decorator = null)
        {
            _title.GetTitle(Padding, decorator ?? Settings.MenuSettings.SimpleMenuDecorator).Display(true);

            Misc.LineBreak();

            var labels = Misc.GetOptionsRangeList(_options.Count, new Text.ColorObject(ConsoleColor.DarkYellow));
            for (int i = 0; i <  _options.Count; i++)
            {
                labels[i].Display();
                Console.Write(" ");
                _options[i].Display(true);
            }

            Misc.LineBreak(2);
        }

        // Method - Select an options
        protected int SelectOption()
        {
            int selection = 0;
            Text.Text prompt = new Text.Text(
                "Select an option...",
                Settings.TextColor.Prompt
            );

            prompt.Display(true);   // Display the prompt
            do
            {
                // Take input
                var key = Console.ReadKey(true);

                // Clear the screen
                if (key.Key == Settings.KeyMapping.Actions[Enums.Action.ClearConsole])
                {
                    // Clear the console
                    Console.Clear();
                    
                    // Display menu and prompt
                    Display();
                    prompt.Display(true);
                    continue;
                }

                selection = key.KeyChar - '0';

                // Check if input selection is valid or not
                if (selection > 0 && selection <= _options.Count)
                    break;
                else
                    Message.Error($"Invalid selection! It must be in between 1 and {_options.Count}. Press '{Settings.KeyMapping.Actions[Enums.Action.ClearConsole]}' key to clear this message");
            }
            while (true);

            return --selection;
        }

        // Method - Get longest options' length
        protected int GetLongestOptionLength()
        {
            if (_options.Count == 0) return 0;

            int length = _title.Length;

            for (int i = 0; i < _options.Count; i++)
            {
                if (_options[i].Value.Length > length)
                    length = _options[i].Value.Length;
            }

            return length;
        }

        // Method - Display and input
        public virtual int DisplayAndTakeInput()
        {
            Display();
            return SelectOption();
        }
    }
}
