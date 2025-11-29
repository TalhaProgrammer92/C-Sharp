using Cards.Utils.Text;

namespace Cards.Utils.Menu
{
    public class InGameSelection
    {
        // Attributes
        private readonly Dictionary<int, MenuOption> _options;
        public Enums.Action TrigerredAction { get; private set; }

        // Constructor
        public InGameSelection()
        {
            _options = new Dictionary<int, MenuOption>();
        }

        // Method - Add an option
        public void AddOption(string optionLabel, ColorObject colorObject)
        {
            _options.Add(
                _options.Count,
                new MenuOption(
                    optionLabel,
                    Enums.Action.OptionSelection,
                    colorObject
                )
            );
        }

        // Method - Display options
        private void DisplayOptions()
        {
            for (int i = 0; i < _options.Count; i++)
            {
                Misc.PrintColoredMessage($"{i + 1}. ", new ColorObject(ConsoleColor.White), false);
                var option = _options[i];
                Misc.PrintColoredMessage(option.Label, option.ColorObject!);
            }
        }

        // Method - Check if option is valid or not
        private bool IsValid(int option)
        {
            return _options.ContainsKey(option); 
        }

        // Method - Display and take input
        public int? ReadOption()
        {
            int option = 0;

            if (_options.Count == 0)
                return null;

            DisplayOptions();

            // Bug: It only supports single digit input. Cards > 9 could not be read.
            var key = Console.ReadKey();

            // Clear the console
            if (key.Key == Settings.KeyMapping.Actions[Enums.Action.ClearConsole])
            {
                TrigerredAction = Enums.Action.ClearConsole;
                return null;
            }

            option = key.KeyChar - '0';

            if (!IsValid(option))
            {
                TrigerredAction = Enums.Action.InvalidOptionSelection;
                return null;
            }

            TrigerredAction = Enums.Action.OptionSelection;
            return option;
        }
    }
}
