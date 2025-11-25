using Cards.Utils.Text;

namespace Cards.Utils.Menu
{
    public class MenuTitle
    {
        // Attribute
        private string title;
        public int Length => title.Length;

        // Constructor
        public MenuTitle(string title)
        {
            this.title = title;
        }

        // Method - Get title
        public Text.Text GetTitle(Padding padding, char? decorator)
        {
            string titleString = 
                new string(decorator ?? Settings.MenuSettings.DefaultMenuDecorator, Math.Max(0, padding.Left - 1))
                + $" {title} " +
                new string(decorator ?? Settings.MenuSettings.DefaultMenuDecorator, Math.Max(0, padding.Right - 1));

            return new Text.Text(titleString, Settings.MenuSettings.MenuTitleColor);
        }
    }
}
