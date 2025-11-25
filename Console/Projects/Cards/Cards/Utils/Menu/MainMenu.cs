namespace Cards.Utils.Menu.Menu
{
    public class MainMenu : GameMenu
    {
        // Constructor
        public MainMenu() : base(new MenuTitle("Main Menu", Settings.MenuSettings.MainMenuDecorator))
        {
            AddOption("Start Game", Enums.Action.StartGame);
            AddOption("Load Game", Enums.Action.LoadGame);
            AddOption("Settings", Enums.Action.OpenSettings);
            AddOption("Exit", Enums.Action.Exit);
        }
    }
}
