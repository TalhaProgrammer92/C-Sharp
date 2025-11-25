using Cards.Utils.Text;

namespace Cards.Utils.Menu
{
    public class GameMenu
    {
        // Attributes
        protected readonly Dictionary<int, MenuOption> _options;
        protected readonly MenuTitle _title;
        protected Padding Padding => Misc.GetMenuTitlePadding(
            GetLongestOptionLength(), _options.Count
        );

        // Constructor
        public GameMenu(MenuTitle title)
        {
            _title = title;
            _options = new Dictionary<int, MenuOption>();
        }

        // Method - Get option by index
        public Enums.Action GetAction(int optionIndex)
        {
            return _options[optionIndex].Action;
        }

        // Method - Add option to the menu
        protected void AddOption(string optionLabel, Enums.Action action)
        {
            _options.Add(
                _options.Count,
                new MenuOption(
                    optionLabel,
                    action
                )
            );
        }

        // Method - Display the menu
        protected void Display()
        {
            _title.Display(Padding);

            Misc.LineBreak();

            // Print options with numbered labels
            var labels = Misc.GetOptionsRangeList(_options.Count, new ColorObject(ConsoleColor.DarkYellow));
            for (int i = 0; i <  _options.Count; i++)
            {
                labels[i].Display();    // Display option number
                Console.Write(" ");
                _options[i].Text.Display(true); // Display option label
            }
            
            Misc.LineBreak();
        }

        // Method - Select an options
        protected int SelectOption()
        {
            int selection = 0;

            do
            {
                // Take input
                var key = Console.ReadKey(true);

                // Clear the screen
                if (key.Key == Settings.KeyMapping.Actions[Enums.Action.ClearConsole])
                {
                    // Clear the console
                    Console.Clear();
                    
                    // Display menu
                    Display();
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
                if (_options[i].Label.Length > length)
                    length = _options[i].Label.Length;
            }

            return length;
        }

        // Method - Display and input
        public int DisplayAndTakeInput()
        {
            Display();
            return SelectOption();
        }
    }
}
