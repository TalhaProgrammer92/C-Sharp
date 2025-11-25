using Cards.Utils.Text;

namespace Cards.Utils.Menu
{
    public class MenuTitle
    {
        // Attribute
        private string title;
        private readonly char _decorator;
        public int Length => title.Length;

        // Constructor
        public MenuTitle(string title, char? decorator = null)
        {
            this.title = title;
            _decorator = decorator ?? Settings.MenuSettings.DefaultMenuDecorator;
        }

        // Method - Get title
        private Text.Text GetTitle(Padding padding)
        {
            string titleString = 
                new string(_decorator, Math.Max(0, padding.Left - 1))
                + $" {title} " +
                new string(_decorator, Math.Max(0, padding.Right - 1));

            return new Text.Text(titleString, Settings.MenuSettings.MenuTitleColor);
        }

        // Method - Display
        public void Display(Padding padding)
        {
            GetTitle(padding).Display(true);
        }
    }
}
