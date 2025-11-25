namespace Cards.Utils.Menu
{
    public class LoadGameMenu : GameMenu
    {
        // Constructor
        public LoadGameMenu() : base(new MenuTitle("Load Game", Settings.MenuSettings.SubMenuDecorator))
        {
            AddOption("Go Back", Enums.Action.OpenMainMenu);
        }
    }
}
