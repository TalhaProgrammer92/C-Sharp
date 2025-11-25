namespace Cards.Utils.Menu.Menu
{
    public class MainMenu : GameMenu
    {
        // Constructor
        public MainMenu() : base("Main Menu")
        {
            AddOption("Start Game");
            AddOption("Load Game");
            AddOption("Settings");
            AddOption("Exit");
        }

        public override int DisplayAndTakeInput()
        {
            Display(Settings.MenuSettings.MainMenuDecorator);
            return SelectOption();
        }
    }
}
