using Cards.Utils.Text;

namespace Cards.Utils.Menu
{
    public class MenuTitle
    {
        // Attribute
        private string title;

        // Constructor
        public MenuTitle(string title)
        {
            this.title = title;
        }

        // Method - Get title
        public Text.Text GetTitle(Padding padding, char? decorator)
        {
            string titleString = 
                new string(decorator ?? Settings.MenuSettings.DefaultMenuDecorator, padding.Left - 1)
                + $" {title} " +
                new string(decorator ?? Settings.MenuSettings.DefaultMenuDecorator, padding.Right - 1);

            return new Text.Text(titleString, Settings.MenuSettings.MenuTitleColor);
        }
    }
}
