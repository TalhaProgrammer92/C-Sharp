namespace Cards.Utils.Menu
{
    public class LoadGameMenu : GameMenu
    {
        // Constructor
        public LoadGameMenu() : base("Load Game")
        {
            AddOption("Go Back");
        }

        // Display method
        public override int DisplayAndTakeInput()
        {
            Display(Settings.MenuSettings.SubMenuDecorator);
            return SelectOption();
        }
    }
}
